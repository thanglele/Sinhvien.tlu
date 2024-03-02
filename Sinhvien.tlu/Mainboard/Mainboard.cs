using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinhvien.tlu.Mainboard
{
    public partial class System_Main : Form
    {
        private Stream stream;

        void getInformation()
        {
            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("MAINBOARD");
        }

        void Exit_Program(object sender, FormClosingEventArgs e)
        {
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("EXIT");

            Application.Exit();
        }

        public System_Main(Stream current_stream)
        {
            stream = current_stream;
            getInformation();

            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 13;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 14;
        }

        private void Trangchu_button_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 0;
        }

        private void Dangkyhocmoi_button_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 1;
        }

        private void Ketquadangkyhoc_button_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 2;
        }

        private void Tracuudiemtonghop_button_Click(object sender, EventArgs e)
        {
            Main_Dashboard.SelectedIndex = 3;
        }
    }
}
