//#define SINGLE_THREADED_POLLING_APPROACH
#define SINGLE_THREADED_WAITHANDLE_APPROACH
//#define THREAD_POOL_RECEIVED_EVENT_APPROACH
//#define RAW_APPROACH

#define SHOW_CHANGES_ONLY

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HidSharp;
//using MyHID1;
//using HID_SIMPLE;
//using MyUI;
using HidSharp.Experimental;
using HidSharp.Reports;
using HidSharp.Reports.Encodings;
using HidSharp.Utility;

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

        ReportDescriptor reportDescriptor;
        HidSharp.Reports.Input.HidDeviceInputReceiver inputReceiver;
        HidSharp.Reports.Input.DeviceItemInputParser inputParser;

        byte[] inputReportBuffer;
        byte[] hid_in_report;
        byte[] hid_out_report;

        ushort out_count = 1;

        DeviceList device_list;
        HidStream hidStream;
        HidDevice hidDevice;
      
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
            HidSharpDiagnostics.EnableTracing = true;
            HidSharpDiagnostics.PerformStrictChecks = true;
            device_list = DeviceList.Local;
            device_list.Changed += (x, y) =>
            {
                UI.console_print(richTextBox_console, "Device list changed\n", Color.Red);
                //hidDevice = null;
                //hidStream = null;
                //hidDevice = connect();
            };

            hidDevice =  connect();
        }

        public void read_parameters()
        {

            UInt32.TryParse(textBox_usb_vid.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint number);
            usb_vid = (ushort)number;

            UInt32.TryParse(textBox_usb_pid.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_pid = (ushort)number;

            UInt32.TryParse(textBox_usb_usage_page.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_usage_page = (ushort)number;

            UInt32.TryParse(textBox_out_count.Text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out number);
            usb_usage = (ushort)number;

            UInt32.TryParse(textBox_out_count.Text, NumberStyles.Integer, CultureInfo.InvariantCulture, out number);
            out_count  = (ushort)number;

        }

        void WriteDeviceItemInputParserResult(HidSharp.Reports.Input.DeviceItemInputParser parser)
        {
#if SHOW_CHANGES_ONLY
            while (parser.HasChanged)
            {
                int changedIndex = parser.GetNextChangedIndex();
                var previousDataValue = parser.GetPreviousValue(changedIndex);
                var dataValue = parser.GetValue(changedIndex);

                string string_print = string.Format("  {0}: {1} -> {2}",
                                  (Usage)dataValue.Usages.FirstOrDefault(), previousDataValue.GetPhysicalValue(), dataValue.GetPhysicalValue());
                UI.console_printline(richTextBox_console, string_print);
            }
#else
            if (parser.HasChanged)
            {
                int valueCount = parser.ValueCount;

                for (int valueIndex = 0; valueIndex < valueCount; valueIndex++)
                {
                    var dataValue = parser.GetValue(valueIndex);
                    Console.Write(string.Format("  {0}: {1}",
                                      (Usage)dataValue.Usages.FirstOrDefault(), dataValue.GetPhysicalValue()));

                }

                UI.console_printline(richTextBox_console,);
            }
#endif
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if (hidDevice == null)
                return;
            read_parameters();

            var reportDescriptor = hidDevice.GetReportDescriptor();
            Array.Resize(ref hid_in_report, reportDescriptor.MaxInputReportLength);
            Array.Resize(ref hid_out_report, reportDescriptor.MaxOutputReportLength);
            /* Convert command text to byte array */
            string command_string = richTextBox_out_report.Text.Replace("\\n", "\n");
            byte[] command_bytes = Encoding.ASCII.GetBytes(command_string);

            Array.Copy(command_bytes, hid_out_report, command_bytes.Length);
            //hidStream.ReadTimeout = 5000;
            //hidStream.WriteTimeout = 5000;

            for (int i =0; i < out_count; i++)
                hidStream.Write(hid_out_report);

            //inputReceiver.Start(hidStream);
        }

        public void read()
        {
            if (hidDevice == null)
                return;
            if (hidStream == null)
                return;

            //hidStream.ReadTimeout = 5000;
            reportDescriptor = hidDevice.GetReportDescriptor();

            inputReportBuffer = new byte[hidDevice.GetMaxInputReportLength()];
            inputReceiver = reportDescriptor.CreateHidDeviceInputReceiver();
            inputParser = reportDescriptor.DeviceItems[0].CreateDeviceItemInputParser();
            inputReceiver.Start(hidStream);

            inputReceiver.Received += (x, y) =>
            {
                inputReportBuffer = new byte[hidDevice.GetMaxInputReportLength()];
                int count= hidStream.Read(inputReportBuffer);
                byte[] buffer = new byte[64];
                Array.Copy(inputReportBuffer, 1, buffer, 0, 64);
                string result = System.Text.Encoding.ASCII.GetString(buffer);
                UI.console_print(richTextBox_in_report, result);
            };
        }

        public HidDevice connect()
        {
            var hidDeviceList = device_list.GetHidDevices().ToArray();
            read_parameters();
            foreach (HidDevice dev in hidDeviceList)
            {
                //UI.console_printline(richTextBox_console, dev.DevicePath);
                //UI.console_printline(richTextBox_console, dev.ToString());

                //try
                //{
                //    UI.console_printline(richTextBox_console, string.Format("Max Lengths: Input {0}, Output {1}, Feature {2}",
                //        dev.GetMaxInputReportLength(),
                //        dev.GetMaxOutputReportLength(),
                //        dev.GetMaxFeatureReportLength()));
                //}
                //catch (UnauthorizedAccessException ex)
                //{
                //    UI.console_printline(richTextBox_console, ex.ToString());
                //    continue;
                //}

                try
                {
                    if ((dev.ProductID == usb_pid) && (dev.VendorID== usb_vid))
                    {
                        UI.console_printline(richTextBox_console, "Device Found");

                        //HidStream hidStream_test;
                        if (dev.TryOpen(out hidStream) == false)
                        {
                            hidStream = null;
                            break;
                        }
                        //hidStream = hidStream_test;
                        hidDevice = dev;
                        read();
                        return dev;
                    }

                }
                catch (Exception ex)
                {
                    UI.console_printline(richTextBox_console, ex.ToString());
                    return null;
                }
            }
            UI.console_printline(richTextBox_console, "Device Not Found");
            return null;
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

        private void button_connect_Click(object sender, EventArgs e)
        {
        }
    }
}