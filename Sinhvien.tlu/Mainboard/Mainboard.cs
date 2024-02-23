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
        public System_Main(Stream current_stream)
        {
            stream = current_stream;
            getInformation();

            InitializeComponent();
        }

        void getInformation()
        {
            var reader = new StreamReader(stream);
            var writer = new StreamWriter(stream);
            writer.AutoFlush = true;

            writer.WriteLine("MAINBOARD");
        }

    }
}
