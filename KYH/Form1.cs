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
        TabControl tabControl1 = new TabControl();
        TabPage tabPage1 = new TabPage();
        TabPage tabPage2 = new TabPage();
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
            tabControl1.TabPages.Clear();

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;

            Panel2_Load();
        }

        private void Panel2_Load()
        {
            panel2.Location = new Point(115, 10);
            panel2.Size = new Size(600, 400);
            panel2.BackColor = Color.WhiteSmoke;

            ArrayList col_list = new ArrayList();
            ArrayList item_list = new ArrayList();
            ArrayList col2_list = new ArrayList();
            ArrayList item2_list = new ArrayList();

            ////가상 데이터1----------------------------------------------------------------------------------------------------------------
            //col_list.Add(new string[] { " ", "30", "L" });
            //col_list.Add(new string[] { "중요", "50", "L" });
            //col_list.Add(new string[] { "상태", "70", "L" });
            //col_list.Add(new string[] { "프로그램", "150", "L" });
            //col_list.Add(new string[] { "경로", "200", "L" });
            //col_list.Add(new string[] { "위치1", "80", "L" });
            //col_list.Add(new string[] { "위치2", "80", "L" });

            //item_list.Add(new Items(new string[] { " ", "-", "비활성", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            //item_list.Add(new Items(new string[] { " ", "●", "활성", " WindowsDefen...", "\\%ProgramFiles%\\win/... ", "HKLM", "SOFT... " }));
            //item_list.Add(new Items(new string[] { " ", "-", "활성", " GooDee", "\\%ProgramFiles%\\win/... ", "HKLM", "SOFT... " }));

            ////----------------------------------------------------------------------------------------------------------------------------
            ////가상 데이터2----------------------------------------------------------------------------------------------------------------
            //col2_list.Add(new string[] { " ", "30", "L" });
            //col2_list.Add(new string[] { "상태", "70", "L" });
            //col2_list.Add(new string[] { "프로그램", "150", "L" });
            //col2_list.Add(new string[] { "제작사", "130", "L" });
            //col2_list.Add(new string[] { "시작유형", "100", "L" });
            //col2_list.Add(new string[] { "설명", "200", "L" });

            //item2_list.Add(new Items2(new string[] { " ", "중지", " aswblDSAg... ", "", "", "" }));
            //item2_list.Add(new Items2(new string[] { " ", "중지", " OpenSSH A...", "", "사용안함", "Agent to hold private kets us..." }));
            //item2_list.Add(new Items2(new string[] { " ", "실행", " GooDee", "", "", "Good" }));

            ////----------------------------------------------------------------------------------------------------------------------------

            ListView lv = lv_create(col_list, item_list);
            ListView lv2 = lv2_create(col2_list, item2_list);

            //탭페이지---------------------------------------------------------------------------------------------------------------------
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.SelectedIndex = 0;
            tabControl1.Padding = new Point(22, 20);
            tabControl1.Size = new Size(600, 400);
            tabControl1.TabIndex = 0;
            

            tabPage1.Location = new Point(4, 22);
            tabPage1.Size = new Size(466, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "시작 프로그램";
            tabPage1.UseVisualStyleBackColor = true;

            tabPage2.Location = new Point(4, 22);
            tabPage2.Size = new Size(192, 74);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "서비스 관리";
            tabPage2.UseVisualStyleBackColor = true;
            //----------------------------------------------------------------------------------------------------------------------------
            //라벨------------------------------------------------------------------------------------------------------------------------

            Label lb = new Label();
            lb.Text = "시작 프로그램이 많을 경우 컴퓨터가 느려지고 부팅 속도도 많이 느려집니다.";
            lb.AutoSize = true;
            lb.Location = new Point(50, 40);

            Label lb2 = new Label();
            lb2.Text = "서비스 프로그램을 시작/중지 시키는 기능입니다.";
            lb2.AutoSize = true;
            lb2.Location = new Point(50, 20);

            Label lb2a = new Label();
            lb2a.Text = "부팅을 빠르게 하고, 인터넷이 느릴때 도움되는 기능입니다.";
            lb2a.AutoSize = true;
            lb2a.Location = new Point(50, 40);

            tabPage1.Controls.Add(lb);  // 라벨 추가
            tabPage2.Controls.Add(lb2);  // 라벨 추가
            tabPage2.Controls.Add(lb2a);  // 라벨 추가
            //----------------------------------------------------------------------------------------------------------------------------

            //버튼------------------------------------------------------------------------------------------------------------------------
            Button btn1 = new Button();
            Button btn2 = new Button();

            btn1.DialogResult = DialogResult.OK;
            btn1.Text = "비활성화";
            btn1.Location = new Point(350, 280);
            btn1.Size = new Size(90, 50);
            Controls.Add(btn1);

            btn2.DialogResult = DialogResult.OK;
            btn2.Text = "활성화";
            btn2.Location = new Point(360+90, 280);
            btn2.Size = new Size(90, 50);
            Controls.Add(btn2);

            Button btn1a = new Button();
            Button btn2a = new Button();

            btn1a.DialogResult = DialogResult.OK;
            btn1a.Text = "중지";
            btn1a.Location = new Point(350, 280);
            btn1a.Size = new Size(90, 50);
            Controls.Add(btn1a);

            btn2a.DialogResult = DialogResult.OK;
            btn2a.Text = "실행";
            btn2a.Location = new Point(360 + 90, 280);
            btn2a.Size = new Size(90, 50);
            Controls.Add(btn2a);

            tabPage1.Controls.Add(btn1);// 버튼1 추가
            tabPage1.Controls.Add(btn2);// 버튼2 추가
            tabPage2.Controls.Add(btn1a);// 버튼1 추가
            tabPage2.Controls.Add(btn2a);// 버튼2 추가
            //----------------------------------------------------------------------------------------------------------------------------
            tabPage1.Controls.Add(lv);  // 탭 페이지 에 lv(리스트뷰 추가)
            tabPage2.Controls.Add(lv2);
            panel2.Controls.Add(tabControl1);
            
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
            lv.Location = new Point(50, 70);
            lv.CheckBoxes = true;
            lv.GridLines = true;
            lv.Name = "listView1";
            lv.Size = new Size(500, 200);
            lv.TabIndex = 0;
            lv.UseCompatibleStateImageBehavior = false;
            lv.View = View.Details;
            lv.BackColor = Color.Gainsboro;
            lv.ForeColor = Color.Black;

            bool I_check = Items_create(item_list, lv);
            bool h_check = col_create(col_list, lv);
            

            return lv;
        }

        private ListView lv2_create(ArrayList col2_list, ArrayList item2_list) //관리 리스트 뷰
        {
            
            ListView lv2 = new ListView();

            lv2.GridLines = true;
            lv2.Location = new Point(50, 70);
            lv2.CheckBoxes = true;
            lv2.GridLines = true;
            lv2.Name = "listView2";
            lv2.Size = new Size(500, 200);
            lv2.TabIndex = 0;
            lv2.UseCompatibleStateImageBehavior = false;
            lv2.View = View.Details;
            lv2.BackColor = Color.Gainsboro;
            lv2.ForeColor = Color.Black;

            bool I2_check = Items2_create(item2_list, lv2);
            bool h2_check = col2_create(col2_list, lv2);

            
            return lv2;
        }

        private bool Items_create(ArrayList item_list, ListView lv)
        {
            for (int i = 0; i < item_list.Count; i++)
            {
                Items row = (Items)item_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                item.SubItems.Add(row.getCol4());
                item.SubItems.Add(row.getCol5());
                item.SubItems.Add(row.getCol6());
                item.SubItems.Add(row.getCol7());
                lv.Items.Add(item);
            }
            return true;
        }
        
        private bool col_create(ArrayList col_list, ListView lv)
        {
            for(int i = 0; i < col_list.Count; i++)
            {
                string[] arr = (string[])col_list[i]; //(string[]) 명시적 형변환
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32( arr[1]);
                columnHeader.TextAlign = HorizontalAlignment.Center;
                lv.Columns.Add(columnHeader);

            }
            return true;
        }

        private bool Items2_create(ArrayList item2_list, ListView lv2)
        {
            for (int i = 0; i < item2_list.Count; i++)
            {
                Items2 row = (Items2)item2_list[i];
                ListViewItem item = new ListViewItem(row.getCol1());
                item.SubItems.Add(row.getCol2());
                item.SubItems.Add(row.getCol3());
                item.SubItems.Add(row.getCol4());
                item.SubItems.Add(row.getCol5());
                item.SubItems.Add(row.getCol6());
                lv2.Items.Add(item);
            }
            return true;
        }

        private bool col2_create(ArrayList col2_list, ListView lv2)
        {
            for (int i = 0; i < col2_list.Count; i++)
            {
                string[] arr = (string[])col2_list[i]; //(string[]) 명시적 형변환
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32(arr[1]);
                columnHeader.TextAlign = HorizontalAlignment.Center;
                lv2.Columns.Add(columnHeader);

            }
            return true;
        }

        //private bool Tab_create()//탭 화면 매서드
        //{
        //    tabStartProgram.Text = "시작프로그램";
        //    tabStartProgram.Size = new Size(256, 214);
        //    tabStartProgram.TabIndex = 0;
        //    tabService.Text = "서비스관리";
        //    tabService.Size = new Size(256, 214);
        //    tabService.TabIndex = 1;

        //    return true;
        //}
    }

    //public class Items
    //{
    //    string col1;
    //    string col2;
    //    string col3;
    //    string col4;
    //    string col5;
    //    string col6;
    //    string col7;
    //    public Items(string[] a)
    //    {
    //        col1 = a[0];
    //        col2 = a[1];
    //        col3 = a[2];
    //        col4 = a[3];
    //        col5 = a[4];
    //        col6 = a[5];
    //        col7 = a[6];
    //    }

    //    public string getCol1()
    //    {
    //        return col1;
    //    }
    //    public string getCol2()
    //    {
    //        return col2;
    //    }
    //    public string getCol3()
    //    {
    //        return col3;
    //    }
    //    public string getCol4()
    //    {
    //        return col4;
    //    }
    //    public string getCol5()
    //    {
    //        return col5;
    //    }
    //    public string getCol6()
    //    {
    //        return col6;
    //    }
    //    public string getCol7()
    //    {
    //        return col7;
    //    }
    //} //아이템

    
}
