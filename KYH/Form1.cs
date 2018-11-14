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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listView1;
        private ListView listView2;
        private CheckBox checkBox1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label lb1;
        private Label lb2;
        private Label lb3;

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
    
        private void Button_Load()
        {
            button1.DialogResult = DialogResult.OK;
            button1.ImageAlign = ContentAlignment.MiddleCenter;
            button1.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GDC2\Desktop\github\KYH\broom.png"), new Size(60, 60)));
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.Text = "최적화";
            button1.Size = new Size(110, 90);

            button2.DialogResult = DialogResult.OK;
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GDC2\Desktop\github\KYH\tools.png"), new Size(58, 58)));
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.Text = "관리";
            button2.Size = new Size(110, 90);
            button2.Location = new Point(0, 90);

            button3.DialogResult = DialogResult.OK;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GDC2\Desktop\github\KYH\delete.png"), new Size(58, 58)));
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.Text = "삭제";
            button3.Size = new Size(110, 90);
            button3.Location = new Point(0, 180);

            button4.DialogResult = DialogResult.OK;
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.Image = (Image)(new Bitmap(Image.FromFile(@"C:\Users\GDC2\Desktop\github\KYH\research.png"), new Size(58, 58)));
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.Text = "PC상태";
            button4.Size = new Size(110, 90);
            button4.Location = new Point(0, 270);

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
        }
        private void Button1_Click(object o, EventArgs e)   // 최적화
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            
            Panel1_Load();
        }
        private void Button2_Click(object o, EventArgs e) // 관리
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            
            Panel2_Load();
        }
        private void Button3_Click(object o, EventArgs e)  // 삭제
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            Panel3_Load();
            MyTabs();
        }
        private void Button4_Click(object o, EventArgs e)  // PC상태
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;

            Panel4_Load();
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
        private void Panel3_Load()
        {
            panel3.Location = new Point(115, 0);
            panel3.Size = new Size(600, 400);
          
            tabControl1 = MyTabs();
            Controls.Add(panel3);
        }
        private void Panel4_Load()
        {
            panel4.Location = new Point(115, 0);
            panel4.Size = new Size(600, 400);
            panel4.BackColor = Color.Crimson;

            Controls.Add(panel4);
        }
        
        private TabControl MyTabs() //삭제 탭 구성
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();

            tabControl1.Padding = new Point(22, 20);
            tabControl1.Controls.AddRange(new Control[] { tabPage1, tabPage2, tabPage3 });
            tabControl1.Size = new Size(600, 500);

            tabPage1.Text = "프로그램 삭제";
            tabPage2.Text = "개인정보 삭제";
            tabPage3.Text = "파일 강제삭제";

            btn1 = new Button();
            btn1.Text = "삭제";
            btn1.Size = new Size(80,30);
            btn1.Location = new Point(250,300);
            btn1.Click += btn1_Click;

            btn2 = new Button();
            btn2.Text = "삭제";
            btn2.Size = new Size(80, 30);
            btn2.Location = new Point(250, 300);

            btn3 = new Button();
            btn3.Text = "삭제";
            btn3.Size = new Size(80, 30);
            btn3.Location = new Point(250, 300);

            lb1 = new Label();
            lb1.Text = "내 PC에 설치된 프로그램을 관리합니다.";
            lb1.Size = new Size(224,20);
            lb1.Location = new Point(45,15);

            lb2 = new Label();
            lb2.Text = "컴퓨터나 인터넷 사용에 따른 사용기록과 목록을 삭제합니다.";
            lb2.Size = new Size(400, 20);
            lb2.Location = new Point(45, 15);

            lb3 = new Label();
            lb3.Text = "현재 사용중의 이유로 액세스 거부가 되어 삭제되지 않는 파일을 강제로 삭제합니다.";
            lb3.Size = new Size(500, 20);
            lb3.Location = new Point(45, 15);

            listView1 = ListPrint();
            checkBox1 = UserDelete();
            listView2 = LIstPrint2();
            tabPage1.Controls.Add(lb1);
            tabPage2.Controls.Add(lb2);
            tabPage3.Controls.Add(lb3);
            tabPage1.Controls.Add(btn1);
            tabPage2.Controls.Add(btn2);
            tabPage3.Controls.Add(btn3);
            tabPage1.Controls.Add(listView1);
            tabPage2.Controls.Add(checkBox1);
            tabPage3.Controls.Add(listView2);
            panel3.Controls.AddRange(new Control[] { tabControl1 });
            return tabControl1;
        }   
        private void btn1_Click(object sender, EventArgs args)
        {
            MessageBox.Show("삭제완료");
        }
        private ListView ListPrint()
        {
            listView1 = new ListView();
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Location = new Point(40, 40);
            listView1.Size = new Size(505, 250);

            listView1.Columns.Add("", 25, HorizontalAlignment.Center);
            listView1.Columns.Add("프로그램명", 180, HorizontalAlignment.Center);
            listView1.Columns.Add("제작사", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("설치일", 100, HorizontalAlignment.Center);
            listView1.BackColor = Color.Gainsboro;
            listView1.ForeColor = Color.Black;

            ListViewItem item1 = new ListViewItem(" ", 60);
            item1.SubItems.Add("Chrom");
            item1.SubItems.Add("Google.inc");
            item1.SubItems.Add("2018.09.17");

            ListViewItem item2 = new ListViewItem(" ", 40);
            item2.SubItems.Add("HeidiSQL");
            item2.SubItems.Add("Ansgar Becker");
            item2.SubItems.Add("2018.10.05");

            ListViewItem item3 = new ListViewItem(" ", 40);
            item3.SubItems.Add("FileZilla Client 3.37.0");
            item3.SubItems.Add("Tim kosse");
            item3.SubItems.Add("2018.10.23");
            
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            return listView1;
        }   //프로그램 삭제 탭
        private CheckBox UserDelete()
        {
            checkBox1 = new CheckBox();
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(160, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(86, 16);

            checkBox1.TabIndex = 0;
            checkBox1.Text = string.Format("목록 삭제");
            checkBox1.UseVisualStyleBackColor = true;

            return checkBox1;
        }   //개인정보 삭제 탭
        private ListView LIstPrint2()
        {
            listView2 = new ListView();
            listView2.View = View.Details;
            listView2.CheckBoxes = true;
            listView2.GridLines = true;
            listView2.Location = new Point(40, 40);
            listView2.Size = new Size(505, 250);

            listView2.Columns.Add(" ", 25);
            listView2.Columns.Add("파일명", 480);
            listView2.BackColor = Color.Gainsboro;
            listView2.ForeColor = Color.Black;

            ListViewItem item1 = new ListViewItem(" ", 100);
            item1.SubItems.Add("WindowsApp.exe");
            ListViewItem item2 = new ListViewItem(" ", 100);
            item2.SubItems.Add("WindowsApp2.exe");

            listView2.Items.AddRange(new ListViewItem[] { item1, item2 });

            return listView2;
        }   //파일 강제삭제 탭
    }
}


