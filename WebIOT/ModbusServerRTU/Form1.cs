using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using ModbusServerRTU.Model;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net;
using System.IO.Ports;
using System.Threading;


namespace ModbusServerRTU
{
    public partial class Form1 : Form
    {
        public delegate void settingsChangedEvent();
        private bool debug = false;
        ModbusServer ModbusRTU;

        private UInt16 startingAddressDiscreteInputs = 1;
        private UInt16 startingAddressCoils = 1;
        private UInt16 startingAddressHoldingRegisters = 1;
        private UInt16 startingAddressInputRegisters = 1;
        private SerialPort serialport;
        private System.IO.Ports.Parity parity = Parity.Even;
        private System.IO.Ports.StopBits stopBits = StopBits.One;
        object lockCoils = new object();
        object lockHoldingRegisters = new object();
        public ModbusServer.Coils coils;
        Settings settings = new Settings();
        Settings settingsFromMainForm = new Settings();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach(string p in ports)
            {
                txtComPort.Items.Add(p);
            }

            EasyModbus.ModbusServer modbusServer = new EasyModbus.ModbusServer();
            modbusServer.SerialPort = "COM5";
            modbusServer.Baudrate = 9600;
            modbusServer.UnitIdentifier = 1;
            modbusServer.Listen();
            modbusServer.HoldingRegistersChanged += new EasyModbus.ModbusServer.HoldingRegistersChangedHandler(holdingRegistersChanged);

            modbusServer.StopListening();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ModbusRTU.SerialPort = txtComPort.Text;
                ModbusRTU.Port = 502;
                ModbusRTU.UnitIdentifier = settings.SlaveAddress;
                ModbusRTU.Baudrate = 9600;
                ModbusRTU.UDPFlag = false;
                ModbusRTU.SerialFlag = true;
                if (ModbusRTU.SerialFlag)
                {
                    if (serialport == null)
                    {
                        if (debug) EasyModbus.StoreLogData.Instance.Store("EasyModbus RTU-Server listing for incomming data at Serial Port " + settings.ComPort, System.DateTime.Now);
                        serialport = new SerialPort();
                        serialport.PortName = ModbusRTU.SerialPort;
                        serialport.BaudRate = 9600;
                        serialport.Parity = this.parity;
                        serialport.StopBits = stopBits;
                        serialport.WriteTimeout = 10000;
                        serialport.ReadTimeout = 1000;
                        serialport.Open();
                    }
                }
                ModbusRTU.Listen();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void holdingRegistersChanged(int startingAddress, int quantity)
        {
            Console.WriteLine(startingAddress);
            Console.WriteLine(quantity);

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                numericUpDown1.Value = startingAddressDiscreteInputs;
                dg_DI.Rows.Clear();
                for (int i = startingAddressDiscreteInputs; i < 20 + startingAddressDiscreteInputs; i++)
                {
                    dg_DI.Rows.Add(i, ModbusRTU.discreteInputs[i]);

                    if (ModbusRTU.discreteInputs[i])
                        dg_DI[1, i - startingAddressDiscreteInputs].Style.BackColor = Color.Green;
                    else
                        dg_DI[1, i - startingAddressDiscreteInputs].Style.BackColor = Color.Red;
                }
            }
            if (tabControl1.SelectedIndex == 1)
            {

                numericUpDown1.Value = startingAddressCoils;
                dg_Coils.Rows.Clear();
                for (int i = startingAddressCoils; i < 20 + startingAddressCoils; i++)
                {
                    dg_Coils.Rows.Add(i, ModbusRTU.coils[i]);
                    if (ModbusRTU.coils[i])
                        dg_Coils[1, i - startingAddressCoils].Style.BackColor = Color.Green;
                    else
                        dg_Coils[1, i - startingAddressCoils].Style.BackColor = Color.Red;
                }
            }
            if (tabControl1.SelectedIndex == 2)
            {
                numericUpDown1.Value = startingAddressInputRegisters;
                dg_IR.Rows.Clear();
                for (int i = startingAddressInputRegisters; i < 20 + startingAddressInputRegisters; i++)
                    dg_IR.Rows.Add(i, ModbusRTU.inputRegisters[i]);
            }
            if (tabControl1.SelectedIndex == 3)
            {
                numericUpDown1.Value = startingAddressHoldingRegisters;
                dg_HoldReg.Rows.Clear();
                for (int i = startingAddressHoldingRegisters; i < 20 + startingAddressHoldingRegisters; i++)
                    dg_HoldReg.Rows.Add(i, ModbusRTU.holdingRegisters[i]);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


    }

}
