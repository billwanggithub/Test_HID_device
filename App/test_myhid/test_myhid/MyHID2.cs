using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MyHID
{

    class MyHID2
    {
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_init(byte[] parm);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_register(ref int handle, int vid, int pid, int mi,
                                               int reportId, int reportSize, int reportType);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_deregister(ref int handle);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_write(int handle, byte[] buffer, int bytesToWrite, ref int bytesWritten);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_read(int handle, byte[] buffer, int bytesToRead, ref int bytesRead);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_find(int handle);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_identify(int handle, byte[] buffer, int bufferSize, ref int bytesProcessed);
        [DllImport("AHid.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int AHid_info(byte[] buffer1, int bufferSize1, byte[] buffer2, int bufferSize2);

        const int TIMER_INTERVAL = 100;
        const int TMP_BUFFER_SIZE = 1000;
        const int TMP_BUFFER_SMALL_SIZE = 24;
        const int TMP_BUFFER_VERY_SMALL_SIZE = 3;

        const int MAX_REPORT_SIZE = 64;
        const int AHID_REPORT_TYPE_INPUT = 0;
        const int AHID_REPORT_TYPE_OUTPUT = 1;
        const int AHID_OK = 0;
        const int AHID_ERROR = -1;

        static int findInterval;


        bool isConnected = false;
        int vid;
        int pid;
        int interfaceID;
        int outputHandle;
        int outputReportID;
        int outputReportSize;
        int outputCounter;
        byte[] outputBuffer;
        int inputHandle;
        int inputReportID;
        int inputReportSize;
        int inputCounter;

        protected void init()
        {
            byte[] parm = System.Text.Encoding.ASCII.GetBytes("\0");

            if (AHID_ERROR == AHid_init(parm))
            {
                byte[] buffer1 = new byte[TMP_BUFFER_SIZE];
                byte[] buffer2 = new byte[TMP_BUFFER_SIZE];

                AHid_info(buffer1, TMP_BUFFER_SIZE, buffer2, TMP_BUFFER_SIZE);
            }
        }

    }
}
