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
    public partial class Form4 : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView listView1;
        private ListView listView2;
        private CheckBox checkBox1;

        public Form4()
        {
            InitializeComponent();
            Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
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

            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage3.BackColor = Color.WhiteSmoke;
            
            Modulecs mc = new Modulecs();
            ArrayList arr = new ArrayList();

            //탭페이지 안에 버튼 생성
            arr.Add(new tabbtn(tabPage1, "btn_1", "삭제", 80, 30, 250, 300));
            arr.Add(new tabbtn(tabPage2, "btn_1", "삭제", 80, 30, 250, 300));
            arr.Add(new tabbtn(tabPage3, "btn_1", "삭제", 80, 30, 250, 300));

            //탭페이지 안에 라벨 생성
            arr.Add(new tablb(tabPage1, "lb", "내 PC에 설치된 프로그램을 관리합니다.", 224, 20, 45, 15));
            arr.Add(new tablb(tabPage2, "lb", "컴퓨터나 인터넷 사용에 따른 사용기록과 목록을 삭제합니다.", 400, 20, 45, 15));
            arr.Add(new tablb(tabPage3, "lb", "현재 사용중의 이유로 액세스 거부가 되어 삭제되지 않는 파일을 강제로 삭제합니다.", 500, 20, 45, 15));


            for (int i = 0; i < arr.Count; i++)
            {
                if (typeof(tabbtn) == arr[i].GetType())  //arr[i] 객체가 btn의 객체이면 (type을 비교)
                {
                    mc.btn((tabbtn)arr[i]);
                }
                else if (typeof(tablb) == arr[i].GetType()) //arr[i] 객체가 lb (type 비교)
                {
                    mc.lb((tablb)arr[i]);
                }
            }

            listView1 = ListPrint();
            checkBox1 = UserDelete();
            listView2 = LIstPrint2();
            tabPage1.Controls.Add(listView1);
            
            tabPage3.Controls.Add(listView2);
            Controls.AddRange(new Control[] { tabControl1 });
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
        } //프로그램 삭제 탭
        private CheckBox UserDelete()
        {
            for(int i = 0; i<2; i++)
            {
                for(int j=0; i<4; i++)
                {
                    checkBox1 = new CheckBox();
                    checkBox1.AutoSize = true;
                    checkBox1.Location = new Point(130, (i * 30) + 80);
                    checkBox1.Name = "checkBox1";
                    checkBox1.Size = new Size(86, 60);
                    checkBox1.Text = string.Format("목록 삭제");
                    checkBox1.UseVisualStyleBackColor = true;
                    tabPage2.Controls.Add(checkBox1);
                }
            }

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
        }   //파일 강제삭제
    }
}
