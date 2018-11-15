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
    public partial class Form5 : Form
    {
        Label label = new Label();
        Label label_1 = new Label();
        Label label1 = new Label();
        Label label2 = new Label();

        public Form5()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;

            Load += Form5_Load;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label.AutoSize = true;
            label.Font = new Font("굴림", 15, FontStyle.Bold);
            label.Location = new Point(90, 50);
            label.Text = "하드디스크상태";

            label_1.AutoSize = true;
            label_1.Font = new Font("굴림",12F, FontStyle.Bold);
            label_1.Location = new Point(240, 55);
            label_1.Text = "?";

            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.ShowAlways = true;
            tt.SetToolTip(label_1, "0  ~ 50도 : 적정온도 \n51 ~ 60도 : 약간 높은 상태\n60도 이상 : 위험한 상태로 백업 요망");

            Controls.Add(label_1);
            Controls.Add(label);

            label1.AutoSize = true;
            label1.Font = new Font("굴림", 15, FontStyle.Bold);
            label1.Location = new Point(450,50);
            label1.Text = "CPU 온도";
            Controls.Add(label1);

            label2.AutoSize = true;
            label2.Font = new Font("굴림", 15, FontStyle.Bold);
            label2.Location = new Point(420, 230);
            label2.Text = "그래픽카드 온도";
            Controls.Add(label2);
        }
    }
}
