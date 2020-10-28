using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Diagnostics;
using MQTTnet.Exceptions;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Server.Status;
using System.Collections.ObjectModel;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private readonly ConcurrentQueue<MqttNetLogMessage> _traceMessages = new ConcurrentQueue<MqttNetLogMessage>();
        private readonly ObservableCollection<IMqttClientStatus> _sessions = new ObservableCollection<IMqttClientStatus>();

        string ClientId;
        private IMqttClient _mqttClient;

        public Form1()
        {
            InitializeComponent();
            ClientId = Guid.NewGuid().ToString("D");
            txtHost.Text = "mqtt.eclipse.org";
            txtPort.Text = "1883";
            txtSubTopic.Text = "IOTAPP";
            MqttNetGlobalLogger.LogMessagePublished += OnTraceMessagePublished;
            ListBox.CheckForIllegalCrossThreadCalls = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
            btnStatusProcess.Text = "?";
            btnStatusProcess.BackColor = Color.DeepPink;
            PanelPublish.Enabled = false;
            panelSubscribe.Enabled = false;
            panelMqttSetting.Hide();
            btnShowSetting.Text = "Show";
            this.panelControl.Location = new Point(
                this.panelMqttSetting.Location.X,
                this.panelMqttSetting.Location.Y
            );
            panelResult.Location = new Point(
                this.panelMqttSetting.Location.X,
                this.panelMqttSetting.Location.Y + panelControl.Height
            );

            this.Width = panelControl.Width + 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        #region Function
        #endregion

        #region Event Handler Mqtt
        private async void OnTraceMessagePublished(object sender, MqttNetLogMessagePublishedEventArgs e)
        {
            if (e.LogMessage.Message.Contains("IOTAPP/") == true)
            {
                _traceMessages.Enqueue(e.LogMessage);
                await UpdateLogAsync();
                
                listSubReceive.Items.Add(e.LogMessage);
                await UpdateScrollBar();
            }
            else
            {
                _traceMessages.Enqueue(e.LogMessage);
            }
            if(e.LogMessage.Message.Contains("Disconnecting") == true || e.LogMessage.Message == "Error while connecting with server.")
            {
                btnStatusProcess.Text = "Disconnecting";
                btnStatusProcess.BackColor = Color.DeepPink;
                //await Connect();
            }
            else
            {
                if(e.LogMessage.Message == "Connection with server established.")
                {
                    btnStatusProcess.Text = "Connected";
                    btnStatusProcess.BackColor = Color.ForestGreen;
                }
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
            //if(logText.ToString().Contains("error") == true)
            //{
            //    if(btnStatusProcess.Text == "Connected")
            //    {
            //        btnStatusProcess.Text = "Error";
            //    }
                
            //    btnStatusProcess.BackColor = Color.DeepPink;
            //}
            //else
            //{
            //    btnStatusProcess.Text = "Connected";
            //}
            txtResult.Text += logText.ToString();
            
        }

        private async Task HandleReceivedApplicationMessageAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            if(_mqttClient.IsConnected)
            {
                btnStatusProcess.Text = "Connected";
                btnStatusProcess.BackColor = Color.ForestGreen;
            }
            if (eventArgs.ApplicationMessage.Topic.Contains(txtSubTopic.Text) == true)
            {
                listSubReceive.Items.Add(item);
                await UpdateScrollBar();
                await ControlSesuaiTopic(eventArgs.ApplicationMessage.Topic, eventArgs.ApplicationMessage.ConvertPayloadToString());
            }

        }

        #endregion

        #region Funtion

        private async Task ControlSesuaiTopic(string Topic, string Payload)
        {
            if (("IOTAPP/POWER") == Topic)
            {
                if(Payload == "1")
                {
                    btnStatusPower.BackColor = Color.ForestGreen;
                    btnStatusPower.Text = "Started";
                }
                else
                {
                    btnStatusPower.BackColor = Color.DeepPink;
                    btnStatusPower.Text = "Stoped";
                }
                await Publish("IOTAPP/LED", Payload);
            }
        }

        private async Task UpdateScrollBar()
        {
            try
            {
                //if (listSubReceive.Items.Count > 10)
                //{
                //    listSubReceive.Items.Clear();
                //}
                //await Task.Run(() => listSubReceive.SelectedIndex = listSubReceive.Items.Count - 1);
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
        }
        private async Task Disconnect()
        {
            try
            {
                if (_mqttClient != null)
                {
                    await _mqttClient.DisconnectAsync();
                    _mqttClient.Dispose();
                    _mqttClient = null;
                    btnStatusProcess.Text = "?";
                    btnStatusProcess.BackColor = Color.DeepPink;
                }
            }
            catch (Exception exception)
            {
                listSubReceive.Items.Add(exception);
                await UpdateScrollBar();
                btnStatusProcess.Text = "Error";
                btnStatusProcess.BackColor = Color.DeepPink;
            }
        }
        private async Task OnDisconnected()
        {
            _traceMessages.Enqueue(new MqttNetLogMessage
            {
                Timestamp = DateTime.UtcNow,
                ThreadId = -1,
                Level = MqttNetLogLevel.Info,
                Message = "! DISCONNECTED EVENT FIRED",
            });
            await UpdateLogAsync();
            await Task.Delay(TimeSpan.FromSeconds(10));
            if(_mqttClient != null)
            {
                if (_mqttClient.IsConnected == false)
                {

                    await Connect();
                    await Unsubscribe("IOTAPP/#");
                    if (_mqttClient.IsConnected)
                    {
                        var qos = MqttQualityOfServiceLevel.AtMostOnce;
                        qos = MqttQualityOfServiceLevel.ExactlyOnce;

                        //var KONVEYOR = new MqttTopicFilter { Topic = txtTopic.Text + "/KONVEYOR", QualityOfServiceLevel = qos };
                        //var LED = new MqttTopicFilter { Topic = txtTopic.Text + "/LED", QualityOfServiceLevel = qos };
                        //var TEGANGAN = new MqttTopicFilter { Topic = txtTopic.Text + "/TEGANGAN", QualityOfServiceLevel = qos };
                        //var GETARAN = new MqttTopicFilter { Topic = txtTopic.Text + "/GETARAN", QualityOfServiceLevel = qos };
                        var POWER = new MqttTopicFilter { Topic = txtSubTopic.Text + "/POWER", QualityOfServiceLevel = qos };

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
            }
            
            
        }
        private async Task Connect()
        {
            //ulang:
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
                btnStatusProcess.Text = "Error";
                btnStatusProcess.BackColor = Color.DeepPink;
                throw new InvalidOperationException();
            }


            options.CleanSession = true;
            options.KeepAlivePeriod = TimeSpan.FromSeconds(double.Parse("10"));
            options.ProtocolVersion = MqttProtocolVersion.V311;
            //options.ProtocolVersion = MqttProtocolVersion.V310;
            //options.ProtocolVersion = MqttProtocolVersion.V500;
            try
            {
                if (_mqttClient != null && _mqttClient.IsConnected == true)
                {
                    await _mqttClient.DisconnectAsync();
                    _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessageAsync);
                    _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected());
                    _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected());
                }

                
                _mqttClient = mqttFactory.CreateMqttClient();
                _mqttClient.UseApplicationMessageReceivedHandler(HandleReceivedApplicationMessageAsync);
                _mqttClient.ConnectedHandler = new MqttClientConnectedHandlerDelegate(x => OnConnected());
                _mqttClient.DisconnectedHandler = new MqttClientDisconnectedHandlerDelegate(x => OnDisconnected());

                await _mqttClient.ConnectAsync(options);
                btnStatusProcess.Text = "Connected";
                btnStatusProcess.BackColor = Color.ForestGreen;

            }
            catch (Exception exception)
            {
                listSubReceive.Items.Add(exception);
                await UpdateScrollBar();
                btnStatusProcess.Text = "Error";
                btnStatusProcess.BackColor = Color.DeepPink;
                //if (exception.Message == "No such host is known.")
                //{
                //    goto ulang;
                //}
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
            btnStatusProcess.Text = "Connected";
            btnStatusProcess.BackColor = Color.ForestGreen;
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
            }
            catch (Exception exception)
            {
                listSubReceive.Items.Add(exception);
                await UpdateScrollBar();
                if (_mqttClient.IsConnected)
                {
                    btnStatusProcess.Text = "Connected";
                    btnStatusProcess.BackColor = Color.ForestGreen;
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

            }
            catch (Exception exception)
            {
                listSubReceive.Items.Add(exception);
                await UpdateScrollBar();
            }
        }
        private async Task Unsubscribe(string SubTopic)
        {
            try
            {
                if(_mqttClient !=null)
                {
                    if (_mqttClient.IsConnected)
                    {
                        await _mqttClient.UnsubscribeAsync(SubTopic);
                    }
                }
            }
            catch (Exception exception)
            {
                listSubReceive.Items.Add(exception);
                await UpdateScrollBar();   
            }
        }
        #endregion

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
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
                    var POWER = new MqttTopicFilter { Topic = txtSubTopic.Text + "/POWER", QualityOfServiceLevel = qos };

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
                    txtHost.Enabled = false;
                    txtPort.Enabled = false;
                }
                else
                {
                    await Connect();
                }
                btnConnect.Text = "Disconnect";
                PanelPublish.Enabled = true;
                panelSubscribe.Enabled = true;
            }
            else
            {
                await Disconnect();
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                btnConnect.Text = "Connect";
                PanelPublish.Enabled = false;
                panelSubscribe.Enabled = false;
            }
        }

        private async void btnPLed_Click(object sender, EventArgs e)
        {
            await Publish(txtPtLed.Text, txtPPLed.Text);
            
        }

        private async void btnPKonveyor_Click(object sender, EventArgs e)
        {
            await Publish(txtPtKonveyor.Text, txtPPKonveyor.Text);
            
            
        }

        private async void btnPGetaran_Click(object sender, EventArgs e)
        {
            await Publish(txtPtGetaran.Text, txtPPGetaran.Text);
            
        }

        private async void btnPTegangan_Click(object sender, EventArgs e)
        {
            await Publish(txtPtTegangan.Text, txtPPTegangan.Text);
        }

        private void listSubReceive_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (_mqttClient.IsConnected)
            {
                var qos = MqttQualityOfServiceLevel.AtMostOnce;
                qos = MqttQualityOfServiceLevel.ExactlyOnce;

                //var KONVEYOR = new MqttTopicFilter { Topic = txtTopic.Text + "/KONVEYOR", QualityOfServiceLevel = qos };
                //var LED = new MqttTopicFilter { Topic = txtTopic.Text + "/LED", QualityOfServiceLevel = qos };
                //var TEGANGAN = new MqttTopicFilter { Topic = txtTopic.Text + "/TEGANGAN", QualityOfServiceLevel = qos };
                //var GETARAN = new MqttTopicFilter { Topic = txtTopic.Text + "/GETARAN", QualityOfServiceLevel = qos };
                var POWER = new MqttTopicFilter { Topic = txtSubTopic.Text + "/POWER", QualityOfServiceLevel = qos };

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

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            int numberOfLine = txtResult.Lines.Count();
            if (numberOfLine >= 1000)
            {
                txtResult.Text="";
                numberOfLine = 0;
            }
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           if (btnConnect.Text == "Connect")
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
                    var POWER = new MqttTopicFilter { Topic = txtSubTopic.Text + "/POWER", QualityOfServiceLevel = qos };

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
                    txtHost.Enabled = false;
                    txtPort.Enabled = false;
                }
                else
                {
                    await Connect();
                }
                btnConnect.Text = "Disconnect";
                btnStartServices.Text = "Stop";
                btnStartServices.BackColor = Color.Red;
                PanelPublish.Enabled = true;
                panelSubscribe.Enabled = true;
                
            }
            else
            {
                await Disconnect();
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                btnConnect.Text = "Connect";
                btnStartServices.Text = "Start";
                btnStartServices.BackColor = Color.ForestGreen;
                PanelPublish.Enabled = false;
                panelSubscribe.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if(btnShowSetting.Text =="Show")
            {
                panelMqttSetting.Show();
                btnShowSetting.Text = "Hide";
                this.panelControl.Location = new Point(672, 147);
                panelResult.Location = new Point(672, 147+panelControl.Height);
                this.Width = panelControl.Width + 20 + panelMqttSetting.Width+10;
                
            }
            else
            {
                panelMqttSetting.Hide();
                btnShowSetting.Text = "Show";
                this.panelControl.Location = new Point(
                    this.panelMqttSetting.Location.X,
                    this.panelMqttSetting.Location.Y
                );
                panelResult.Location = new Point(
                    this.panelMqttSetting.Location.X,
                    this.panelMqttSetting.Location.Y + panelControl.Height
                );
                this.Width = panelControl.Width + 20;
            }
            this.CenterToScreen();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    Hide();
            //    notifyIcon1.Visible = true;
            //    notifyIcon1.ShowBalloonTip(1000);
            //}
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
