using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    public partial class Form2 : Form
    {
        Button btnHard = new Button();
        Button btnProcess = new Button();

        public Form2()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;

            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnHard.Text = "하드디스크 최적화";
            btnHard.Size = new Size(200, 80);
            btnHard.Location = new Point(80, 80);
            btnHard.BackColor = Color.Gainsboro;
            btnHard.Cursor = Cursors.Hand;

            btnProcess.Text = "프로세스 최적화";
            btnProcess.Size = new Size(200, 80);
            btnProcess.Location = new Point(80, 200);
            btnProcess.BackColor = Color.Gainsboro;
            btnProcess.Cursor = Cursors.Hand;

            Controls.Add(btnHard);
            Controls.Add(btnProcess);
        }
    }
}
