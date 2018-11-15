﻿using System;
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
            col_list.Add(new string[] { " ", "30"});
            col_list.Add(new string[] { "중요", "50"});
            col_list.Add(new string[] { "상태", "70"});
            col_list.Add(new string[] { "프로그램", "150"});
            col_list.Add(new string[] { "경로", "200"});
            col_list.Add(new string[] { "위치1", "80"});
            col_list.Add(new string[] { "위치2", "80"});

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
            item2_list.Add(new Items2(new string[] { " ", "실행", " GooDee", "", "", "Good" }));

            //----------------------------------------------------------------------------------------------------------------------------
            ListView lv = lv_create(col_list, item_list);
            

            Col_Y Col = new Col_Y(col_list,item_list);      //헤더 아이템 크리에이터1
            Col_Y Col2 = new Col_Y(col2_list, item2_list);  //헤더 아이템 크리에이터2
            ClassY Cy = new ClassY(col_list, item_list);

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


            tabPage1.Controls.Add(lv);
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
    }
}