using System;
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

namespace Sinhvien.tlu.Login_form
{
    public partial class System_Login : Form
    {
        private string USR_inp;
        private string PASS_inp;

        private string static_login_raw = "0";
        private bool static_login = false;
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

        public bool getStatic()
        {
            return static_login;
        }

        public void getStream(Stream new_stream)
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

            if (static_login_raw == "1")
            {
                static_login = true;
                Login_action.Text = "Đang chuyển vào màn hình chính...";

                this.Close();
            }
            else
            {
                Login_action.Text = "Mã sinh viên hoặc mật khẩu không đúng!";
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
