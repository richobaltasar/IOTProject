using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Disconnecting;
using MQTTnet.Client.Options;
using MQTTnet.Diagnostics;
using MQTTnet.Formatter;
using MQTTnet.Protocol;
using MQTTnet.Server.Status;

namespace IOTGatewayApp
{
    public partial class Form1 : Form
    {
        ModbusServer modbusServer = new ModbusServer();
        private readonly ConcurrentQueue<MqttNetLogMessage> _traceMessages = new ConcurrentQueue<MqttNetLogMessage>();
        private readonly ObservableCollection<IMqttClientStatus> _sessions = new ObservableCollection<IMqttClientStatus>();

        string ClientId;
        private IMqttClient _mqttClient;
        bool StatusConnectSerial = false;

        public Form1()
        {
            InitializeComponent();
            ClientId = Guid.NewGuid().ToString("D");
            this.Width = 1088;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //cmbPort.Items.Add("COM5");
            //cmbPort.Items.Add("COM4");
            var ports = SerialPort.GetPortNames();
            if (ports != null)
            {
                foreach (string po in ports)
                {
                    cmbPort.Items.Add(po);
                }
            }
            cmbBautrate.Items.Add("9600");
            cmbPort.SelectedIndex = cmbPort.FindStringExact("COM3");
            cmbBautrate.SelectedIndex = cmbBautrate.FindStringExact("9600");
            PanelMqtt.Visible = false;
            panelModbus.Visible = false;

            btnSetting.Text = "Show";
            PanelMqtt.Visible = false;
            panelModbus.Visible = false;
            panelControl.Location = new Point(10, 10);
            this.Width = 30 + panelControl.Width;
            this.Height = panelControl.Height + 60;
            ListBox.CheckForIllegalCrossThreadCalls = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            Button.CheckForIllegalCrossThreadCalls = false;
        }

        #region Modbus Lib
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(btnConnect.Text=="Connect")
            {
                modbusServer.SerialPort = cmbPort.Text;
                modbusServer.Baudrate = Convert.ToInt32(cmbBautrate.Text);
                modbusServer.UnitIdentifier = 1;
                modbusServer.Listen();
                modbusServer.HoldingRegistersChanged += new EasyModbus.ModbusServer.HoldingRegistersChangedHandler(holdingRegistersChanged);
                modbusServer.LogDataChanged += new EasyModbus.ModbusServer.LogDataChangedHandler(LogDataChanged);
                modbusServer.NumberOfConnectedClientsChanged += new ModbusServer.NumberOfConnectedClientsChangedHandler(ConnectedClientChanged);
                btnConnect.Text = "Disconnect";
            }
            else
            {
                btnConnect.Text = "Connect";
                modbusServer.StopListening();
            }
        }
        public void holdingRegistersChanged(int startingAddress, int quantity)
        {
            Console.WriteLine(startingAddress);
            Console.WriteLine(quantity);

        }

        public void ConnectedClientChanged()
        {

        }
        public void LogDataChanged()
        {
            int Address = 0;
            var rxRegister = modbusServer.ModbusLogData[0].receiveRegisterValues;
            var rxCoil = modbusServer.ModbusLogData[0].receiveCoilValues;
            var TxCoils = modbusServer.ModbusLogData[1].sendCoilValues;
            var TxRegister = modbusServer.ModbusLogData[1].sendRegisterValues;
            if (rxRegister != null)
            {
                Address = modbusServer.ModbusLogData[0].startingAdress + 1;
                foreach (ushort a in modbusServer.ModbusLogData[0].receiveRegisterValues)
                {
                    Console.WriteLine("Address : " + Address + " : " + a.ToString());
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        txtLogAction.AppendText("Address : " + Address + " : " + a.ToString()+ Environment.NewLine);
                        if (Address == Convert.ToInt32(txtHoldResAddr1.Text))
                        {
                            txtHoldResVal1.Text = a.ToString();
                            txtHoldResPayload1.Text = txtHoldResVal1.Text;
                            Task.Run(() => Publish(txtHoldResTopic1.Text, txtHoldResPayload1.Text));
                        }
                        else if(Address == Convert.ToInt32(txtHoldResAddr2.Text))
                        {
                            txtHoldResVal2.Text = a.ToString();
                            txtHoldResPayload2.Text = txtHoldResVal2.Text;
                            Task.Run(() => Publish(txtHoldResTopic2.Text, txtHoldResPayload2.Text));
                        }
                        else if (Address == Convert.ToInt32(txtHoldResAddr3.Text))
                        {
                            txtHoldResVal3.Text = a.ToString();
                            txtHoldResPayload3.Text = txtHoldResVal3.Text;
                            Task.Run(() => Publish(txtHoldResTopic3.Text, txtHoldResPayload3.Text));
                        }
                        else if (Address == Convert.ToInt32(txtHoldResAddr4.Text))
                        {
                            txtHoldResVal4.Text = a.ToString();
                            txtHoldResPayload4.Text = txtHoldResVal4.Text;
                            Task.Run(() => Publish(txtHoldResTopic4.Text, txtHoldResPayload4.Text));
                        }
                    });
                    Address++;
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogAction.AppendText(Environment.NewLine);
                });
            }
            else if(rxCoil !=null)
            {
                Address = modbusServer.ModbusLogData[0].startingAdress + 1;
                foreach (ushort a in rxCoil)
                {
                    Console.WriteLine("Address : " + Address + " : " + a.ToString());
                    txtLogAction.AppendText("Address : " + Address + " : " + a.ToString() + Environment.NewLine);
                    if (Address == Convert.ToInt32(txtCoilAddr1.Text))
                    {
                        if (a == 65280)
                        {
                            txtCoilVal1.SelectedIndex = txtCoilVal1.FindStringExact("TRUE"); ;
                            txtCoilPayload1.Text = "1";
                        }
                        else
                        {
                            txtCoilVal1.SelectedIndex = txtCoilVal1.FindStringExact("FALSE"); ;
                            txtCoilPayload1.Text = "0";
                        }
                        Task.Run(() => Publish(txtCoilTopic1.Text, txtCoilPayload1.Text));
                    }
                    else if (Address == Convert.ToInt32(txtCoilAddr2.Text))
                    {
                        if (a == 65280)
                        {
                            txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("TRUE"); ;
                            txtCoilPayload2.Text = "0";
                        }
                        else
                        {
                            txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("FALSE"); ;
                            txtCoilPayload2.Text = "0";
                        }
                        Task.Run(() => Publish(txtCoilTopic2.Text, txtCoilPayload2.Text));
                    }
                    Address++;
                    
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogAction.AppendText(Environment.NewLine);
                });

                
            }
            else if(TxCoils !=null)
            {
                Address = modbusServer.ModbusLogData[1].startingAdress + 1;
                foreach (bool a in TxCoils)
                {
                    Console.WriteLine("Address : " + Address + " : " + a.ToString());
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        txtLogAction.AppendText("Address : " + Address + " : " + a.ToString() + Environment.NewLine);
                    });
                    Address++;
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogAction.AppendText(Environment.NewLine);
                });
            }
            else if (TxRegister != null)
            {
                Address = modbusServer.ModbusLogData[1].startingAdress + 1;
                foreach (ushort a in TxRegister)
                {
                    Console.WriteLine("Address : " + Address + " : " + a.ToString());
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        txtLogAction.AppendText("Address : " + Address + " : " + a.ToString() + Environment.NewLine);
                    });
                    Address++;
                }
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogAction.AppendText(Environment.NewLine);
                });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int addr = Convert.ToInt32(txtAddrRegs.Text);
            modbusServer.holdingRegisters[addr] = (short)Convert.ToInt32(txtValRegs.Text);

        }
        private void cmbCoilsVal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int addr = Convert.ToInt32(txtCoilsAddr.Text);
            if (cmb_coilsval.Text == "FALSE")
            {
                modbusServer.coils[addr] = false;
            }
            else
            {
                modbusServer.coils[addr] = true;
            }
        }
        #endregion


        #region MQQT Lib
        private async void btnConMqtt_Click(object sender, EventArgs e)
        {
            
            if (btnConMqtt.Text == "Connect")
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
                btnConMqtt.Text = "Disconnect";
                PanelPublish.Enabled = true;
                panelSubscribe.Enabled = true;
            }
            else
            {
                await Disconnect();
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                btnConMqtt.Text = "Connect";
                PanelPublish.Enabled = false;
                panelSubscribe.Enabled = false;
            }
        }




        #region Funtion

        private async Task ControlSesuaiTopic(string Topic, string Payload)
        {
            if (("IOTAPP/POWER") == Topic)
            {
                if (Payload == "1")
                {
                    btnStatusPower.BackColor = Color.ForestGreen;
                    btnStatusPower.Text = "Started";
                    txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("TRUE");
                    int addr = Convert.ToInt32(txtCoilAddr2.Text);
                    modbusServer.coils[addr] = true;
                }
                else
                {
                    btnStatusPower.BackColor = Color.DeepPink;
                    btnStatusPower.Text = "Stoped";
                    txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("FALSE");
                    int addr = Convert.ToInt32(txtCoilAddr2.Text);
                    modbusServer.coils[addr] = false;
                }
                
                //await Publish("IOTAPP/LED", Payload);

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
            catch (NullReferenceException ex)
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
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        btnStatusProcess.Text = "?";
                        btnStatusProcess.BackColor = Color.DeepPink;
                    });
                }
            }
            catch (Exception exception)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(exception);
                    btnStatusProcess.Text = "Error";
                    btnStatusProcess.BackColor = Color.DeepPink;
                });
                await UpdateScrollBar();
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
            if (_mqttClient != null)
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
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(exception);
                });
                await UpdateScrollBar();
                this.Invoke((MethodInvoker)delegate ()
                {
                    btnStatusProcess.Text = "Error";
                    btnStatusProcess.BackColor = Color.DeepPink;
                });
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
            this.Invoke((MethodInvoker)delegate ()
            {
                btnStatusProcess.Text = "Connected";
                btnStatusProcess.BackColor = Color.ForestGreen;
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
            }
            catch (Exception exception)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(exception);
                });
                await UpdateScrollBar();
                if (_mqttClient.IsConnected)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        btnStatusProcess.Text = "Connected";
                        btnStatusProcess.BackColor = Color.ForestGreen;
                    });
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
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(exception);
                });
                await UpdateScrollBar();
            }
        }
        private async Task Unsubscribe(string SubTopic)
        {
            try
            {
                if (_mqttClient != null)
                {
                    if (_mqttClient.IsConnected)
                    {
                        await _mqttClient.UnsubscribeAsync(SubTopic);
                    }
                }
            }
            catch (Exception exception)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(exception);

                });
                await UpdateScrollBar();
            }
        }
        #endregion

        #region Event Handler Mqtt
        private async void OnTraceMessagePublished(object sender, MqttNetLogMessagePublishedEventArgs e)
        {
            if (e.LogMessage.Message.Contains("IOTAPP/") == true)
            {
                _traceMessages.Enqueue(e.LogMessage);
                await UpdateLogAsync();
                this.Invoke((MethodInvoker)delegate ()
                {
                    listResult.Items.Add(e.LogMessage);
                });
                await UpdateScrollBar();
            }
            else
            {
                _traceMessages.Enqueue(e.LogMessage);
            }
            if (e.LogMessage.Message.Contains("Disconnecting") == true || e.LogMessage.Message == "Error while connecting with server.")
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    btnStatusProcess.Text = "Disconnecting";
                    btnStatusProcess.BackColor = Color.DeepPink;
                });
                //await Connect();
            }
            else
            {
                if (e.LogMessage.Message == "Connection with server established.")
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        btnStatusProcess.Text = "Connected";
                        btnStatusProcess.BackColor = Color.ForestGreen;
                    });
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
                this.Invoke((MethodInvoker)delegate ()
                {
                    logText.AppendFormat(
                    "[{0:yyyy-MM-dd HH:mm:ss.fff}] [{1}] [{2}] [{3}] [{4}]{5}",
                    traceMessage.Timestamp,
                    traceMessage.Level,
                    traceMessage.Source,
                    traceMessage.ThreadId,
                    traceMessage.Message,
                    Environment.NewLine);
                });
                if (traceMessage.Exception != null)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        logText.AppendLine(traceMessage.Exception.ToString());
                    });
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
            this.Invoke((MethodInvoker)delegate ()
            {
                txtLogAction.Text += logText.ToString();
            });

        }

        private async Task HandleReceivedApplicationMessageAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            var item = $"Timestamp: {DateTime.Now:O} | Topic: {eventArgs.ApplicationMessage.Topic} | Payload: {eventArgs.ApplicationMessage.ConvertPayloadToString()} | QoS: {eventArgs.ApplicationMessage.QualityOfServiceLevel}";
            if (_mqttClient.IsConnected)
            {
                btnStatusProcess.Text = "Connected";
                btnStatusProcess.BackColor = Color.ForestGreen;
            }
            if (eventArgs.ApplicationMessage.Topic.Contains(txtSubTopic.Text) == true)
            {
                listResult.Items.Add(item);
                await UpdateScrollBar();
                await ControlSesuaiTopic(eventArgs.ApplicationMessage.Topic, eventArgs.ApplicationMessage.ConvertPayloadToString());
            }

        }

        #endregion

        #endregion

        private async void btnSubs_Click(object sender, EventArgs e)
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

        private async void btnPLED_Click(object sender, EventArgs e)
        {
            await Publish(txtPTLED.Text, txtPPLED.Text);
        }

        private async void btnPKONVEYOR_Click(object sender, EventArgs e)
        {
            await Publish(txtPTKONVEYOR.Text, txtPPKONVEYOR.Text);
        }

        private async void btnPGETARAN_Click(object sender, EventArgs e)
        {
            await Publish(txtPTGETARAN.Text, txtPPGETARAN.Text);
        }

        private async void btnPTEGANGAN_Click(object sender, EventArgs e)
        {
            await Publish(txtPTTEGANGAN.Text, txtPPTEGANGAN.Text);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if(btnSetting.Text =="Show")
            {
                btnSetting.Text = "Hide";
                PanelMqtt.Visible = true;
                panelModbus.Visible= true;
                panelControl.Location = new Point(PanelMqtt.Width+10+panelModbus.Width+20 , panelModbus.Location.X+1);
                this.Width = PanelMqtt.Width+panelModbus.Width+panelControl.Width+60;
                this.Height = panelControl.Height+70;
                this.CenterToScreen();
            }
            else
            {
                btnSetting.Text = "Show";
                PanelMqtt.Visible = false;
                panelModbus.Visible = false;
                panelControl.Location = new Point(10, 10);
                this.Width = 40 + panelControl.Width;
                this.Height = panelControl.Height + 70;
                this.CenterToScreen();
            }
        }

        private async void btnPTSUHU_Click(object sender, EventArgs e)
        {
            await Publish(txtPTSUHU.Text, txtPPSUHU.Text);
        }

        private async void btnServices_Click(object sender, EventArgs e)
        {
            if (btnServices.Text =="Start")
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    if(port == cmbPort.Text)
                    {
                        modbusServer.SerialPort = cmbPort.Text;
                        modbusServer.Baudrate = Convert.ToInt32(cmbBautrate.Text);
                        modbusServer.UnitIdentifier = 1;
                        modbusServer.Listen();
                        modbusServer.HoldingRegistersChanged += new EasyModbus.ModbusServer.HoldingRegistersChangedHandler(holdingRegistersChanged);
                        modbusServer.LogDataChanged += new EasyModbus.ModbusServer.LogDataChangedHandler(LogDataChanged);
                        btnConnect.Text = "Disconnect";
                        StatusConnectSerial = true;
                    }
                }
                if(StatusConnectSerial == true)
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

                        bool CoilAdd1 = modbusServer.coils[0];
                        bool CoilAdd2 = modbusServer.coils[1];
                        if (CoilAdd1)
                        {
                            txtCoilVal1.SelectedIndex = txtCoilVal1.FindStringExact("TRUE");
                            txtCoilPayload1.Text = "1";
                        }
                        else
                        {
                            txtCoilVal1.SelectedIndex = txtCoilVal1.FindStringExact("FALSE");
                            txtCoilPayload1.Text = "0";
                        }

                        await Publish(txtCoilTopic1.Text, txtCoilPayload1.Text);

                        if (CoilAdd2)
                        {
                            txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("TRUE");
                            txtCoilPayload2.Text = "1";
                        }
                        else
                        {
                            txtCoilVal2.SelectedIndex = txtCoilVal2.FindStringExact("FALSE");
                            txtCoilPayload2.Text = "0";
                        }
                        await Publish(txtCoilTopic2.Text, txtCoilPayload2.Text);

                        txtHoldResVal1.Text = modbusServer.holdingRegisters[1].ToString();
                        txtHoldResPayload1.Text = modbusServer.holdingRegisters[1].ToString();
                        await Publish(txtHoldResTopic1.Text, txtHoldResPayload1.Text);

                        txtHoldResVal2.Text = modbusServer.holdingRegisters[2].ToString();
                        txtHoldResPayload2.Text = modbusServer.holdingRegisters[2].ToString();
                        await Publish(txtHoldResTopic2.Text, txtHoldResPayload2.Text);

                        txtHoldResVal3.Text = modbusServer.holdingRegisters[3].ToString();
                        txtHoldResPayload3.Text = modbusServer.holdingRegisters[3].ToString();
                        await Publish(txtHoldResTopic3.Text, txtHoldResPayload3.Text);

                        txtHoldResVal4.Text = modbusServer.holdingRegisters[4].ToString();
                        txtHoldResPayload4.Text = modbusServer.holdingRegisters[4].ToString();
                        await Publish(txtHoldResTopic4.Text, txtHoldResPayload4.Text);
                    }
                    else
                    {
                        await Connect();
                    }
                    btnConMqtt.Text = "Disconnect";
                    PanelPublish.Enabled = true;
                    panelSubscribe.Enabled = true;
                    btnServices.Text = "Stop";
                }
                else
                {
                    txtLogAction.AppendText("POrt serial tidak ditemukan");
                }
            }
            else
            {
                StatusConnectSerial = false;
                await Disconnect();
                txtHost.Enabled = true;
                txtPort.Enabled = true;
                btnConMqtt.Text = "Connect";
                PanelPublish.Enabled = false;
                panelSubscribe.Enabled = false;
                btnConnect.Text = "Connect";
                modbusServer.StopListening();
                btnServices.Text = "Start";
            }
        }
    }
}
