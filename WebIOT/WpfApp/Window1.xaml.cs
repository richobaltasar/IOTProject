using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Diagnostics;
using MQTTnet.Exceptions;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly ConcurrentQueue<MqttNetLogMessage> _traceMessages = new ConcurrentQueue<MqttNetLogMessage>();
        string ClientId;
        private IMqttClient _mqttClient;
        private IManagedMqttClient _managedMqttClient;
        bool UseManagedClient = false;
        public Window1()
        {
            InitializeComponent();
            ClientId = Guid.NewGuid().ToString("D");
            txtHost.Text = "mqtt.eclipse.org";
            txtPort.Text = "1883";
            txtTopic.Text = "IOTAPP";
            MqttNetGlobalLogger.LogMessagePublished += OnTraceMessagePublished;
        }

        #region Event Handler Mqtt
        private async void OnTraceMessagePublished(object sender, MqttNetLogMessagePublishedEventArgs e)
        {
            if(e.LogMessage.Message.Contains("IOTAPP/") == true)
            {
                _traceMessages.Enqueue(e.LogMessage);
                //await UpdateLogAsync();
                //Dispatcher.Invoke(delegate {
                //    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                //    ListResult.Items.Add(e.LogMessage);
                //    UpdateScrollBar(ListResult);
                //});
            }
            else
            {
                _traceMessages.Enqueue(e.LogMessage);
            }
            
        }

        async Task UpdateLogAsync()
        {

            while (_traceMessages.Count > 100)
            {
                _ = await Task.Run(() => _traceMessages.TryDequeue(out _));
            }

            var logText = new StringBuilder();
            foreach (var traceMessage in _traceMessages)
            {
                logText.AppendFormat(
                    "[{0:yyyy-MM-dd HH:mm:ss.fff}] [{1}] [{2}] [{3}] [{4}]{5}",
                    traceMessage.Timestamp,
                    traceMessage.Level,
                    traceMessage.Source,
                    traceMessage.ThreadId,
                    traceMessage.Message,
                    Environment.NewLine);

                if (traceMessage.Exception != null)
                {
                    logText.AppendLine(traceMessage.Exception.ToString());
                }
            }
            Dispatcher.Invoke(delegate {
                // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                TxtLog.Text += logText.ToString();
                //ListResult.Items.Add(logText.ToString());
                //UpdateScrollBar(ListResult);
            });
            
        }

        public void HandleMqttMsgSubscribe (MqttMsgSubscribedEventArgs eventArgs)
        {

        }

        private async Task HandleReceivedApplicationMessageAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            string txt = "";
            Dispatcher.Invoke(delegate {
                txt = txtTopic.Text;
            });
            Dispatcher.Invoke(delegate {
                // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                ListResult.Items.Add(item);
                UpdateScrollBar(ListResult);
            });
            if (eventArgs.ApplicationMessage.Topic.Contains(txt) == true)
            {
                await ControlSesuaiTopic(eventArgs.ApplicationMessage.Topic, eventArgs.ApplicationMessage.ConvertPayloadToString());
            }
           
        }

        #endregion

        #region Funtion

        private async Task ControlSesuaiTopic(string Topic,string Payload)
        {
            if(("IOTAPP/POWER") == Topic)
            {
                await Publish("IOTAPP/LED", Payload);
            }
        }

        private async void UpdateScrollBar(ListBox listBox)
        {
            if (listBox != null)
            {
                var border = (Border)VisualTreeHelper.GetChild(listBox, 0);
                var scrollViewer = (ScrollViewer)VisualTreeHelper.GetChild(border, 0);
                await Task.Run(() => Dispatcher.Invoke(delegate {
                    scrollViewer.ScrollToBottom();
                }));
            }

        }
        private async void Disconnect()
        {
            try
            {
                if (_mqttClient != null)
                {
                    await _mqttClient.DisconnectAsync();
                    _mqttClient.Dispose();
                    _mqttClient = null;
                }

                if (_managedMqttClient != null)
                {
                    await _managedMqttClient.StopAsync();
                    _managedMqttClient.Dispose();
                    _managedMqttClient = null;
                }
            }
            catch (Exception exception)
            {
                Dispatcher.Invoke(delegate {
                    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(exception);
                    UpdateScrollBar(ListResult);
                });
            }
        }
        private async void OnDisconnected()
        {
            _traceMessages.Enqueue(new MqttNetLogMessage
            {
                Timestamp = DateTime.UtcNow,
                ThreadId = -1,
                Level = MqttNetLogLevel.Info,
                Message = "! DISCONNECTED EVENT FIRED",
            });

            await UpdateLogAsync();
        }
        private async Task Connect()
        {
            MqttFactory mqttFactory = new MqttFactory();
            var options = new MqttClientOptions
            {
                ClientId = ClientId,
                ProtocolVersion = MqttProtocolVersion.V500
            };

            options.ChannelOptions = new MqttClientTcpOptions
            {
                Server = txtHost.Text,
                Port = int.Parse(txtPort.Text),
                TlsOptions = null
            };


            if (options.ChannelOptions == null)
            {
                throw new InvalidOperationException();
            }


            options.CleanSession = true;
            options.KeepAlivePeriod = TimeSpan.FromSeconds(double.Parse("3000"));
            options.ProtocolVersion = MqttProtocolVersion.V311;
            //options.ProtocolVersion = MqttProtocolVersion.V310;
            //options.ProtocolVersion = MqttProtocolVersion.V500;
            try
            {
                if (_mqttClient != null)
                {
                    await _mqttClient.DisconnectAsync();
                    _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessageAsync);
                    _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected());
                    _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected());
                }

                if (UseManagedClient == true)
                {
                    _managedMqttClient = mqttFactory.CreateManagedMqttClient();
                    _managedMqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessageAsync);
                    _managedMqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected());
                    _managedMqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected());

                    await _managedMqttClient.StartAsync(new ManagedMqttClientOptions
                    {
                        ClientOptions = options
                    });
                }
                else
                {
                    _mqttClient = mqttFactory.CreateMqttClient();
                    _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessageAsync);
                    _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected());
                    _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected());

                    await _mqttClient.ConnectAsync(options);
                }

            }
            catch (Exception exception)
            {
                Dispatcher.Invoke(delegate {
                    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(exception);
                    UpdateScrollBar(ListResult);
                });
            }
        }
        private void OnConnected()
        {
            _traceMessages.Enqueue(new MqttNetLogMessage
            {
                Timestamp = DateTime.UtcNow,
                ThreadId = -1,
                Level = MqttNetLogLevel.Info,
                Message = "! CONNECTED EVENT FIRED",
            });

            Task.Run(UpdateLogAsync);
        }
        private async Task Publish(string Topic, string val)
        {
            Ulang:
            try
            {
                var qos = MqttQualityOfServiceLevel.AtMostOnce;
                qos = MqttQualityOfServiceLevel.ExactlyOnce;
                var payload = Array.Empty<byte>();
                payload = Encoding.UTF8.GetBytes(val);

                var message = new MqttApplicationMessageBuilder()
                    .WithContentType("text")
                    .WithResponseTopic("response")
                    .WithTopic(Topic)
                    .WithPayload(payload)
                    .WithQualityOfServiceLevel(qos)
                    .WithRetainFlag(true)
                    .Build();

                if (_mqttClient != null)
                {
                    await _mqttClient.PublishAsync(message);

                }

                if (_managedMqttClient != null)
                {
                    await _managedMqttClient.PublishAsync(message);
                }
            }
            catch (Exception exception)
            {
                Dispatcher.Invoke(delegate {
                    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(exception);
                    UpdateScrollBar(ListResult);
                });
                if(_mqttClient.IsConnected)
                {
                    goto Ulang;
                }
                else
                {
                    await Connect();
                }
            }
        }
        private async Task Subscribe(MqttTopicFilter SubTopic)
        {
            try
            {
                if (_mqttClient != null)
                {
                    await _mqttClient.SubscribeAsync(SubTopic);
                }

                if (_managedMqttClient != null)
                {
                    await _managedMqttClient.SubscribeAsync(SubTopic);
                }
            }
            catch (Exception exception)
            {
                Dispatcher.Invoke(delegate {
                    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(exception);
                    UpdateScrollBar(ListResult);
                });
                //Trace.Text += exception + Environment.NewLine;
            }
        }
        private async Task Unsubscribe(string SubTopic)
        {
            try
            {
                if (_mqttClient != null)
                {
                    await _mqttClient.UnsubscribeAsync(SubTopic);
                }

                if (_managedMqttClient != null)
                {
                    await _managedMqttClient.UnsubscribeAsync(SubTopic);
                }
            }
            catch (Exception exception)
            {
                Dispatcher.Invoke(delegate
                {
                    // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(exception);
                    UpdateScrollBar(ListResult);
                });
            }
        }
        #endregion


        private async void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            await Connect();
            if (_mqttClient != null)
            {
                var qos = MqttQualityOfServiceLevel.AtMostOnce;
                qos = MqttQualityOfServiceLevel.ExactlyOnce;

                //var KONVEYOR = new MqttTopicFilter { Topic = txtTopic.Text + "/KONVEYOR", QualityOfServiceLevel = qos };
                //var LED = new MqttTopicFilter { Topic = txtTopic.Text + "/LED", QualityOfServiceLevel = qos };
                //var TEGANGAN = new MqttTopicFilter { Topic = txtTopic.Text + "/TEGANGAN", QualityOfServiceLevel = qos };
                //var GETARAN = new MqttTopicFilter { Topic = txtTopic.Text + "/GETARAN", QualityOfServiceLevel = qos };
                var POWER = new MqttTopicFilter { Topic = txtTopic.Text + "/POWER", QualityOfServiceLevel = qos };

                var dt = new List<MqttTopicFilter>();
                //dt.Add(KONVEYOR);
                //dt.Add(LED);
                //dt.Add(TEGANGAN);
                //dt.Add(GETARAN);
                dt.Add(POWER);

                foreach (var sub in dt)
                {
                    await Subscribe(sub);
                }
            }
            else
            {
                await Connect();
            }
        }

        private async void btnSubcribe_Click(object sender, RoutedEventArgs e)
        {
            if (_managedMqttClient != null)
            {
                var qos = MqttQualityOfServiceLevel.AtMostOnce;
                qos = MqttQualityOfServiceLevel.ExactlyOnce;

                //var KONVEYOR = new MqttTopicFilter { Topic = txtTopic.Text + "/KONVEYOR", QualityOfServiceLevel = qos };
                //var LED = new MqttTopicFilter { Topic = txtTopic.Text + "/LED", QualityOfServiceLevel = qos };
                //var TEGANGAN = new MqttTopicFilter { Topic = txtTopic.Text + "/TEGANGAN", QualityOfServiceLevel = qos };
                //var GETARAN = new MqttTopicFilter { Topic = txtTopic.Text + "/GETARAN", QualityOfServiceLevel = qos };
                var POWER = new MqttTopicFilter { Topic = txtTopic.Text + "/POWER", QualityOfServiceLevel = qos };

                var dt = new List<MqttTopicFilter>();
                //dt.Add(KONVEYOR);
                //dt.Add(LED);
                //dt.Add(TEGANGAN);
                //dt.Add(GETARAN);
                dt.Add(POWER);

                foreach (var sub in dt)
                {
                    await Subscribe(sub);
                }
            }
        }

        private async void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            await Publish(txtTopicLED.Text, txtTopicMsgLED.Text);
            await Publish(txtTopicGETARAN.Text, txtTopicMsgGetaran.Text);
            await Publish(txtTopicPublishkonveyor.Text, txtMessageKonveyor.Text);
            await Publish(txtTopicTEGANGAN.Text, txtTopicMsgTegangan.Text);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            ListResult.Items.Clear();
        }

        private void TextBox_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
        {

        }
    }
}
