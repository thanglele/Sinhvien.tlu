﻿//CLIENT PROGRAM

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using Sinhvien.tlu.Login_form;
using Sinhvien.tlu.Mainboard;

namespace Sinhvien.tlu
{
    internal static class Program
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 49153;
        private const string IP_NUMBER = "172.188.28.154";
        //private const string IP_NUMBER = "127.0.0.1";

        static ASCIIEncoding encoding = new ASCIIEncoding();

        static void Active_Runner()
        {
            try
            {
                TcpClient client = new TcpClient();

                //connect
                client.Connect(IP_NUMBER, PORT_NUMBER);
                Stream stream = client.GetStream();

                System_Login New_Login = new System_Login();

                New_Login.setStream(stream);
                Application.Run(New_Login);

                //close
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Mất kết nối với Internet, kiểm tra lại kết nối và khởi động lại phần mềm.");
            }
        }

        [STAThread]
        static public void Main()
        {
            ApplicationConfiguration.Initialize();

            Active_Runner();
        }
    }
}