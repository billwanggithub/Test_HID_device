using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MyHID1;
using HID_SIMPLE;
using MyUI;

namespace test_myhid
{
    public partial class Form_main : Form
    {
        //HID my_hid;
        ushort usb_pid = 0x0483;
        ushort usb_vid = 0x5750;
        ushort usb_usage_page = 0x01;
        ushort usb_usage = 0x00;

        //#region parameter Define
        //HIDInterface hid = new HIDInterface();


        //struct connectStatusStruct
        //{
        //    public bool preStatus;
        //    public bool curStatus;
        //}

        //connectStatusStruct connectStatus = new connectStatusStruct();

        ////推送連接狀態信息
        //public delegate void isConnectedDelegate(bool isConnected);
        //public isConnectedDelegate isConnectedFunc;


        ////推送接收數據信息
        //public delegate void PushReceiveDataDele(byte[] datas);
        //public PushReceiveDataDele pushReceiveData;

        //#endregion

        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }

        public void read_parameters()
        {

            UInt32.TryParse(textBox_usb_vid.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint number);
            usb_vid = (ushort)number;

            UInt32.TryParse(textBox_usb_pid.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_pid = (ushort)number;

            UInt32.TryParse(textBox_usb_usage_page.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_usage_page = (ushort)number;

            UInt32.TryParse(textBox_usb_usage.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_usage = (ushort)number;

        }

        private void button_send_Click(object sender, EventArgs e)
        {
 
        }

        ////第一步需要初始化，傳入vid、pid，並開啓自動連接
        //public void Initial()
        //{
        //    read_parameters();
        //    hid.StatusConnected = StatusConnected;
        //    hid.DataReceived = DataReceived;

        //    HIDInterface.HidDevice hidDevice = new HIDInterface.HidDevice();
        //    hidDevice.vID = usb_vid;
        //    hidDevice.pID = usb_pid;
        //    hidDevice.serial = "";
        //    hid.AutoConnect(hidDevice);
        //}

        ////不使用則關閉
        //public void close()
        //{
        //    hid.StopAutoConnect();
        //}

        ////發送數據
        //public bool SendBytes(byte[] data)
        //{

        //    return hid.Send(data);

        //}

        ////接受到數據
        //public void DataReceived(object sender, byte[] e)
        //{
        //    if (pushReceiveData != null)
        //        pushReceiveData(e);
        //}

        ////狀態改變接收
        //public void StatusConnected(object sender, bool isConnect)
        //{
        //    connectStatus.curStatus = isConnect;
        //    if (connectStatus.curStatus == connectStatus.preStatus)  //connect
        //        return;
        //    connectStatus.preStatus = connectStatus.curStatus;

        //    if (connectStatus.curStatus)
        //    {
        //        isConnectedFunc(true);
        //        //ReportMessage(MessagesType.Message, "連接成功");
        //    }
        //    else //disconnect
        //    {
        //        isConnectedFunc(false);
        //        //ReportMessage(MessagesType.Error, "無法連接");
        //    }
        //}

        private void button_send_Click_old(object sender, EventArgs e)
        {            

            //if (my_hid == null)
            //    my_hid = new HID();

            ///* read input textboxs */
            //read_parameters();

            ///* Convert command text to byte array */
            //string command_string = richTextBox_out_report.Text.Replace("\\n", "\n");
            //byte[] command_bytes = Encoding.ASCII.GetBytes(command_string);
            //Array.Copy(command_bytes, my_hid.outReport, command_bytes.Length);

            ///* test HID and connect */
            //if (my_hid.isFound() == false)
            //{
            //    my_hid.detect_device(usb_vid, usb_pid);
            //}
                
            //if (my_hid.isFound())
            //{
            //    UI.console_print(richTextBox_console, "Device Found!!\n");

            //    /* Send command */
            //    my_hid.sendReport();
            //    Thread.Sleep(5000);

            //    /* Read response */
            //    my_hid.readReport();
            //    string result = System.Text.Encoding.ASCII.GetString(my_hid.inReport);
            //    UI.console_print(richTextBox_in_report, result);
            //}
            //else
            //{
            //    UI.console_print(richTextBox_console, "Device not Found!!\n", Color.Red);
            //}
        }

        private void button_read_Click(object sender, EventArgs e)
        {
        }
    }
}