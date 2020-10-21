using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using uPLibrary;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MqttClient client;
        
        string clientId;

        public MainWindow()
        {
            InitializeComponent();
            txtHost.Text = "mqtt.eclipse.org";
            txtPort.Text = "1883";
            txtTopic.Text = "IOTAPP";
            
        }

        public bool Connect()
        {
            bool res = false;
            string ReceivedMessage = "";
            try
            {
                client = new MqttClient(txtHost.Text.ToString(), Convert.ToInt32(txtPort.Text.ToString()), false, null, null, MqttSslProtocols.None);
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                client.MqttMsgSubscribed += client_MqttMsgSubscribed;
                client.MqttMsgUnsubscribed += client_MqttMsgUnsubscribed;
                client.MqttMsgPublished += client_MqttMsgPublished;
                
                // use a unique id as client id, each time we start the application
                clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);
                res = true;
                ReceivedMessage = "connect to " + txtHost.Text.ToString() + "is success, ClientID : "+clientId.ToString();
                Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(ReceivedMessage);
                    UpdateScrollBar(ListResult);
                });
            }
            catch(Exception ExClient)
            {
                ReceivedMessage = "Error : " + ExClient.Message;
                Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(ReceivedMessage);
                    UpdateScrollBar(ListResult);
                });
            }

            return res;
        }

        public bool SubcribesYe()
        {
            bool res = false;
            try
            {
                if (txtTopic.Text != "")
                {
                    // whole topic
                    string KONVEYOR = txtTopic.Text + "/KONVEYOR";
                    string LED = txtTopic.Text + "/LED";
                    string TEGANGAN = txtTopic.Text + "/TEGANGAN";
                    string GETARAN = txtTopic.Text + "/GETARAN";
                    // subscribe to the topic with QoS 2
                    client.Subscribe(new string[]
                    {KONVEYOR, LED, TEGANGAN, GETARAN }, new byte[] {
                     MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                     MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                     MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE,
                     MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE
                    });
                    res = true;
                }
                else
                {
                    System.Windows.MessageBox.Show("You have to enter a topic to subscribe!");
                }
            }
            catch(Exception ex)
            {
                string ReceivedMessage = "Error : " + ex.Message;
                Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(ReceivedMessage);
                    UpdateScrollBar(ListResult);
                });
            }
            return res;
        }

        public bool PubishYe(string Topic, string Msg)
        {
            ulang:
            string ReceivedMessage = "";
            bool res = false;
            try
            {
                client.Publish(Topic, Encoding.UTF8.GetBytes(Msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
            catch(Exception ex)
            {
                ReceivedMessage = "Error : " + ex.Message;
                Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(ReceivedMessage);
                    UpdateScrollBar(ListResult);
                });
                if (Connect())
                {
                    goto ulang;
                }

            }
            return res;
        }

        void Error(object sender, MqttClientException e)
        {

        }

        void client_MqttMsgPublished(object sender, MqttMsgPublishedEventArgs e)
        {
            if(e.IsPublished)
            {
                string ReceivedMessage = "";
                ReceivedMessage = "Success : " + e.IsPublished;
                Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                    ListResult.Items.Add(ReceivedMessage);
                    UpdateScrollBar(ListResult);
                });
            }
        }

        // this code runs when a message was received
        void client_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            string ReceivedMessage = "UnSubscribed for id = " + e.MessageId;
            Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                //ListResult.Items.Add(ReceivedMessage);
                //UpdateScrollBar(ListResult);
            });
        }
        void client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            //string ReceivedMessage = "Subscribed for id = " + e.MessageId;
            //Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
            //    ListResult.Items.Add(ReceivedMessage);
            //    UpdateScrollBar(ListResult);
            //});
        }
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = "Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic;
            Dispatcher.Invoke(delegate {              // we need this construction because the receiving code in the library and the UI with textbox run on different threads
                ListResult.Items.Add(ReceivedMessage);
                UpdateScrollBar(ListResult);
            });
        }
        
        // this code runs when the main window closes (end of the app)
        protected override void OnClosed(EventArgs e)
        {
            if(client.IsConnected)
            {
                client.Disconnect();
            }
            base.OnClosed(e);
            App.Current.Shutdown();
        }
        private void UpdateScrollBar(ListBox listBox)
        {
            if (listBox != null)
            {
                var border = (Border)VisualTreeHelper.GetChild(listBox, 0);
                var scrollViewer = (ScrollViewer)VisualTreeHelper.GetChild(border, 0);
                scrollViewer.ScrollToBottom();
            }

        }
        private void btnSubcribe_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void btnPublish_Click(object sender, RoutedEventArgs e)
        {
            PubishYe(txtTopicLED.Text, txtTopicMsgLED.Text);
            PubishYe(txtTopicGETARAN.Text, txtTopicMsgGetaran.Text);
            PubishYe(txtTopicPublishkonveyor.Text, txtMessageKonveyor.Text);
            PubishYe(txtTopicTEGANGAN.Text, txtTopicMsgTegangan.Text);
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if(btnConnect.Content.ToString() == "Connect")
            {
                if (Connect())
                {
                    btnConnect.Content = "Disconnect";
                    txtHost.IsEnabled = false;
                    txtPort.IsEnabled = false;
                    txtTopic.IsEnabled = false;
                    if (!SubcribesYe())
                    {
                        btnSubcribe.Content = "Subcribe";
                    }
                    else
                    {
                        btnSubcribe.Content = "Unsubcribe";
                    }
                }
                else
                {
                    btnConnect.Content = "Connect";
                }
            }
            else
            {
                string KONVEYOR = txtTopic.Text + "/KONVEYOR";
                string LED = txtTopic.Text + "/LED";
                string TEGANGAN = txtTopic.Text + "/TEGANGAN";
                string GETARAN = txtTopic.Text + "/GETARAN";
                string[] unsub = { KONVEYOR, LED, TEGANGAN, GETARAN };
                client.Unsubscribe(unsub);
                client.Disconnect();
                btnConnect.Content = "Connect";
                btnSubcribe.Content = "Subcribe";
                txtHost.IsEnabled = true;
                txtPort.IsEnabled = true;
                txtTopic.IsEnabled = true;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            
        }


    }


}
