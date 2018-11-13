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
            ArrayList col_list = new ArrayList();
            ArrayList item_list = new ArrayList();

            col_list.Add(new string[] { "ㅁ", "30", "L" });
            col_list.Add(new string[] { "중요", "50", "L" });
            col_list.Add(new string[] { "프로그램", "150", "L" });
            col_list.Add(new string[] { "경로", "200", "L" });
            col_list.Add(new string[] { "위치1", "80", "L" });
            col_list.Add(new string[] { "위치2", "80", "L" });

            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " AlCaptur ","\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " WindowsDefen...", "\\%ProgramFiles%\\win/... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ㅁ ", " - ", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            

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

            Controls.Add(panel2);

            tabStartProgram.Text = "시작프로그램";
            tabStartProgram.Size = new Size(256, 214);
            tabStartProgram.TabIndex = 0;
            tabService.Text = "서비스관리";
            tabService.Size = new Size(256, 214);
            tabService.TabIndex = 1;

            




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
            button1.Image = (Image)(new Bitmap(Image.FromFile(@"D:\GIt\KYH\broom.png"), new Size(60, 60)));
            button1.TextAlign = ContentAlignment.BottomRight;
            button1.Text = "최적화";
            button1.Size = new Size(110, 90);

            button2.DialogResult = DialogResult.OK;
            button2.ImageAlign = ContentAlignment.MiddleCenter;
            button2.Image = (Image)(new Bitmap(Image.FromFile(@"D:\GIt\KYH\tools.png"), new Size(58, 58)));
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.Text = "관리";
            button2.Size = new Size(110, 90);
            button2.Location = new Point(0, 90);

            button3.DialogResult = DialogResult.OK;
            button3.ImageAlign = ContentAlignment.MiddleCenter;
            button3.Image = (Image)(new Bitmap(Image.FromFile(@"D:\GIt\KYH\delete.png"), new Size(58, 58)));
            button3.TextAlign = ContentAlignment.BottomRight;
            button3.Text = "삭제";
            button3.Size = new Size(110, 90);
            button3.Location = new Point(0, 180);

            button4.DialogResult = DialogResult.OK;
            button4.ImageAlign = ContentAlignment.MiddleCenter;
            button4.Image = (Image)(new Bitmap(Image.FromFile(@"D:\GIt\KYH\research.png"), new Size(58, 58)));
            button4.TextAlign = ContentAlignment.BottomRight;
            button4.Text = "PC상태";
            button4.Size = new Size(110, 90);
            button4.Location = new Point(0, 270);

            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
        }

        private ListView lv_create(ArrayList col_list, ArrayList item_list) //관리 리스트 뷰
        {
            ListView lv = new ListView();

            lv.GridLines = true;
            lv.Location = new Point(12, 12);
            lv.Name = "listView1";
            lv.Size = new Size(776, 426);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;

            bool I_check = Items_create(item_list, lv);

            return lv;
        }

        private bool Items_create(ArrayList item_list, ListView lv)
        {
            for (int i = 0; i < item_list.Count; i++)
            {
                Items row = (Items)item_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                lv.Items.Add(item);
            }
            return true;
        }
    }

    

    public class Items
    {
        string col1;
        string col2;
        string col3;
        string col4;
        string col5;
        string col6;
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
            col4 = a[2];
            col5 = a[2];
            col6 = a[2];
        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col1;
        }
        public string getCol3()
        {
            return col1;
        }
        public string getCol4()
        {
            return col1;
        }
        public string getCol5()
        {
            return col1;
        }
        public string getCol6()
        {
            return col1;
        }
    } //아이템
}
