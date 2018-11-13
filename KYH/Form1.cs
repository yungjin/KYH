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

    public partial class Form1 : Form
    {
        Button button1 = new Button();  // 최적화
        Panel panel1 = new Panel();

        Button button2 = new Button();  // 관리
        Panel panel2 = new Panel();

        Button button3 = new Button();  // 삭제
        Panel panel3 = new Panel();

        Button button4 = new Button();  // PC상태
        Panel panel4 = new Panel();

        Button btnHard = new Button();
        Button btnProcess = new Button();

        TabPage tabStartProgram = new TabPage();
        TabPage tabService = new TabPage();

        TabControl TabControl = new TabControl();

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Load();

            Panel1_Load();

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += Button4_Click;
        }

        private void Button1_Click(object o, EventArgs e)   // 최적화
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel1_Load();
        }

        private void Panel1_Load()
        {
            panel1.Location = new Point(115, 0);
            panel1.Size = new Size(600, 400);
            Controls.Add(panel1);

            btnHard.Text = "하드디스크 최적화";
            btnHard.Size = new Size(200, 80);
            btnHard.Location = new Point(95, 80);

            btnProcess.Text = "프로세스 최적화";
            btnProcess.Size = new Size(200, 80);
            btnProcess.Location = new Point(95, 170);

            panel1.Controls.Add(btnHard);
            panel1.Controls.Add(btnProcess);
        }

        private void Button2_Click(object o, EventArgs e) // 관리
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel2_Load();
        }

        private void Panel2_Load()
        {
            panel2.Location = new Point(115, 0);
            panel2.Size = new Size(600, 400);

            tabStartProgram.Text = "시작프로그램";
            tabStartProgram.Size = new System.Drawing.Size(256, 214);
            tabStartProgram.TabIndex = 0;
            tabService.Text = "서비스관리";
            tabService.Size = new System.Drawing.Size(256, 214);
            tabService.TabIndex = 1;

            Controls.Add(panel2);

        }

        private void Button3_Click(object o, EventArgs e)  // 삭제
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            Panel3_Load();
        }

        private void Panel3_Load()
        {
            panel3.Location = new Point(115, 0);
            panel3.Size = new Size(600, 400);
            panel3.BackColor = Color.Aqua;

            Controls.Add(panel3);
        }

        private void Button4_Click(object o, EventArgs e)  // PC상태
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

            Panel4_Load();
        }

        private void Panel4_Load()
        {
            panel4.Location = new Point(115, 0);
            panel4.Size = new Size(600, 400);
            panel4.BackColor = Color.Crimson;

            Controls.Add(panel4);
        }

        private void Button_Load()
        {
            button1.DialogResult = DialogResult.OK;
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GD10\Source\Repos\yungjin\KYH\broom.png"), new Size(60, 60)));
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.Text = "최적화";
            button1.Size = new Size(110, 90);

            button2.DialogResult = DialogResult.OK;
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GD10\Source\Repos\yungjin\KYH\tools.png"), new Size(58, 58)));
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.Text = "관리";
            button2.Size = new Size(110, 90);
            button2.Location = new Point(0, 90);

            button3.DialogResult = DialogResult.OK;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GD10\Source\Repos\yungjin\KYH\delete.png"), new Size(58, 58)));
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.Text = "삭제";
            button3.Size = new Size(110, 90);
            button3.Location = new Point(0, 180);

            button4.DialogResult = DialogResult.OK;
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GD10\Source\Repos\yungjin\KYH\research.png"), new Size(58, 58)));
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.Text = "PC상태";
            button4.Size = new Size(110, 90);
            button4.Location = new Point(0, 270);

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
        }
    }

}
