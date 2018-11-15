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
    public partial class FormY : Form
    {
        public FormY()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;
            Load += FormY_Load;
        }

        private void FormY_Load(object sender, EventArgs e)
        {
            ArrayList col_list = new ArrayList();
            ArrayList item_list = new ArrayList();
            ArrayList col2_list = new ArrayList();
            ArrayList item2_list = new ArrayList();

            TabControl tabControl1 = new TabControl();
            TabPage tabPage1 = new TabPage();
            TabPage tabPage2 = new TabPage();

            //가상 데이터1----------------------------------------------------------------------------------------------------------------
            col_list.Add(new string[] { " ", "30" });
            col_list.Add(new string[] { "중요", "50" });
            col_list.Add(new string[] { "상태", "70" });
            col_list.Add(new string[] { "프로그램", "150" });
            col_list.Add(new string[] { "경로", "200" });
            col_list.Add(new string[] { "위치1", "80" });
            col_list.Add(new string[] { "위치2", "80" });

            item_list.Add(new Items(new string[] { " ", "-", "비활성", " AlCaptur ", "\"c#Program Files (x86)\\... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ", "●", "활성", " WindowsDefen...", "\\%ProgramFiles%\\win/... ", "HKLM", "SOFT... " }));
            item_list.Add(new Items(new string[] { " ", "-", "활성", " GooDee", "\\%ProgramFiles%\\win/... ", "HKLM", "SOFT... " }));

            //----------------------------------------------------------------------------------------------------------------------------
            //가상 데이터2----------------------------------------------------------------------------------------------------------------
            col2_list.Add(new string[] { " ", "30", "L" });
            col2_list.Add(new string[] { "상태", "70", "L" });
            col2_list.Add(new string[] { "프로그램", "150", "L" });
            col2_list.Add(new string[] { "제작사", "130", "L" });
            col2_list.Add(new string[] { "시작유형", "100", "L" });
            col2_list.Add(new string[] { "설명", "200", "L" });

            item2_list.Add(new Items2(new string[] { " ", "중지", " aswblDSAg... ", "", "", "" }));
            item2_list.Add(new Items2(new string[] { " ", "중지", " OpenSSH A...", "", "사용안함", "Agent to hold private kets us..." }));
            item2_list.Add(new Items2(new string[] { " ", "실행", " GooDee", "구디 아카데미", "", "Good" }));

            //----------------------------------------------------------------------------------------------------------------------------
            ListView lv = lv_create(col_list, item_list);
            ListView lv2 = lv2_create(col2_list, item2_list);

            //Col_Y Col = new Col_Y(col_list, item_list);      //헤더 아이템 크리에이터1
            //Col_Y Col2 = new Col_Y(col2_list, item2_list);  //헤더 아이템 크리에이터2
            //ClassY Cy = new ClassY(col_list, item_list);

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
            btn2.Location = new Point(360 + 90, 280);
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

            tabPage1.Controls.Add(lv);
            tabPage2.Controls.Add(lv2);
            Controls.Add(tabControl1);



        }
        public ListView lv_create(ArrayList col_list, ArrayList item_list) //관리 리스트 뷰
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

        public ListView lv2_create(ArrayList col2_list, ArrayList item2_list) //관리 리스트 뷰
        {

            ListView lv2 = new ListView();

            lv2.GridLines = true;
            lv2.Location = new Point(50, 70);
            lv2.CheckBoxes = true;
            lv2.GridLines = true;
            lv2.Name = "listView1";
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

        private bool col_create(ArrayList col_list, ListView lv)
        {
            for (int i = 0; i < col_list.Count; i++)
            {
                string[] arr = (string[])col_list[i]; //(string[]) 명시적 형변환
                ColumnHeader columnHeader = new ColumnHeader();
                columnHeader.Text = arr[0];
                columnHeader.Width = Convert.ToInt32(arr[1]);
                columnHeader.TextAlign = HorizontalAlignment.Center;
                lv.Columns.Add(columnHeader);

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
    }
    public class Items
    {
        string col1;
        string col2;
        string col3;
        string col4;
        string col5;
        string col6;
        string col7;
        public Items(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
            col4 = a[3];
            col5 = a[4];
            col6 = a[5];
            col7 = a[6];
        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
        public string getCol4()
        {
            return col4;
        }
        public string getCol5()
        {
            return col5;
        }
        public string getCol6()
        {
            return col6;
        }
        public string getCol7()
        {
            return col7;
        }
    } //아이템

    public class Items2
    {
        string col1;
        string col2;
        string col3;
        string col4;
        string col5;
        string col6;

        public Items2(string[] a)
        {
            col1 = a[0];
            col2 = a[1];
            col3 = a[2];
            col4 = a[3];
            col5 = a[4];
            col6 = a[5];

        }

        public string getCol1()
        {
            return col1;
        }
        public string getCol2()
        {
            return col2;
        }
        public string getCol3()
        {
            return col3;
        }
        public string getCol4()
        {
            return col4;
        }
        public string getCol5()
        {
            return col5;
        }
        public string getCol6()
        {
            return col6;
        }

    } //아이템
}
