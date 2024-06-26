﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sinhvien.tlu.Mainboard;

namespace Sinhvien.tlu.Login_form
{
    public partial class System_Login : Form
    {
        private string USR_inp;
        private string PASS_inp;

        private string static_login_raw = "0";
        //private bool static_login = false;
        private Stream stream;

        public System_Login()
        {
            InitializeComponent();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("EXIT");

            Application.Exit();
        }

        public void setStream(Stream new_stream)
        {
            stream = new_stream;
        }

        private void login()
        {
            //Login_action.Text = "Đang xác thực thông tin đăng nhập...";

            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("LOGIN");

            USR_inp = USR_label.Text;
            PASS_inp = PASS_label.Text;

            //send
            writer.WriteLine(USR_inp);
            writer.WriteLine(PASS_inp);

            //receive
            static_login_raw = reader.ReadLine();

            switch (static_login_raw)
            {
                case "1":
                    //static_login = true;
                    Login_action.Text = "Đang chuyển vào màn hình chính...";
                    this.Hide();

                    System_Main new_main = new System_Main(stream);
                    new_main.Show();
                    break;
                case "5":
                    //static_login = false;
                    Login_action.Text = "Tài khoản đăng nhập bị cấm!";
                    MessageBox.Show("Bạn đăng nhập tài khoản bị cấm, hãy liên hệ với phòng Đào tạo.");
                    break;
                default:
                    Login_action.Text = "Mã sinh viên hoặc mật khẩu không đúng!";
                    break;
            }
        }

        private void Exit_label_Click(object sender, EventArgs e)
        {
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("EXIT");

            Application.Exit();
        }

        private void Login_label_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }
    }
}
