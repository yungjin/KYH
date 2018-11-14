using System;
using System.Collections;
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
        BtnClass btnClass = new BtnClass();

        // 최적화
        Panel panel1 = new Panel();
        Button btnHard = new Button();
        Button btnProcess = new Button();

        // 관리
        TabControl tabControl1 = new TabControl();
        TabPage tabPage1 = new TabPage();
        TabPage tabPage2 = new TabPage();
        Panel panel2 = new Panel();

        // 삭제
        Panel panel3 = new Panel();

        // PC상태
        Panel panel4 = new Panel();


        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button_Load();
            Panel1_Load();
        }

        private void Button1_Click(object o, EventArgs e)   // 최적화
        {
            panel2.Controls.Clear();

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
            tabControl1.TabPages.Clear();

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

            panel2.Controls.Add(tabControl1);

            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 400);
            tabControl1.TabIndex = 0;

            tabPage1.Location = new Point(4, 22);
            tabPage1.Size = new Size(466, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "중요";
            tabPage1.UseVisualStyleBackColor = true;

            tabPage2.Location = new Point(4, 22);
            tabPage2.Size = new Size(192, 74);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;

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
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new BtnSet(this, "최적화", 110, 90, 0, 0, @"C:\Users\GD10\Desktop\화면설계\broom.png", Button1_Click));
            arrayList.Add(new BtnSet(this, "관리", 110, 90, 0, 90, @"C:\Users\GD10\Desktop\화면설계\tools.png", Button2_Click));
            arrayList.Add(new BtnSet(this, "삭제", 110, 90, 0, 180, @"C:\Users\GD10\Desktop\화면설계\delete.png", Button3_Click));
            arrayList.Add(new BtnSet(this, "PC상태", 110, 90, 0, 270, @"C:\Users\GD10\Desktop\화면설계\research.png", Button4_Click));

            for (int i = 0; i < arrayList.Count; i++)
            {
                btnClass.button((BtnSet)arrayList[i]);
            }
        }
    }
}
