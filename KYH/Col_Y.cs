using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYH
{
    class Col_Y
    {
        ArrayList col_list;
        ArrayList item_list;
        public Col_Y(ArrayList col_list, ArrayList item_list)
        {
            this.col_list = col_list;
            this.item_list = item_list;

        }
        //public bool col_Create(ArrayList col_list)
        //{
        //    for (int i = 0; i < col_list.Count; i++)
        //    {
        //        string[] arr = (string[])col_list[i]; //(string[]) 명시적 형변환
        //        ColumnHeader columnHeader = new ColumnHeader();
        //        columnHeader.Text = arr[0];
        //        columnHeader.Width = Convert.ToInt32(arr[1]);
        //        columnHeader.TextAlign = HorizontalAlignment.Center;
        //    }
        //    return true;
        //}
        //public bool col2_create(ArrayList col2_list)
        //{
        //    for (int i = 0; i < col2_list.Count; i++)
        //    {
        //        string[] arr = (string[])col2_list[i]; //(string[]) 명시적 형변환
        //        ColumnHeader columnHeader = new ColumnHeader();
        //        columnHeader.Text = arr[0];
        //        columnHeader.Width = Convert.ToInt32(arr[1]);
        //        columnHeader.TextAlign = HorizontalAlignment.Center;
                

        //    }
        //    return true;
        //}

        //public bool item_Create(ArrayList item_list)
        //{
        //    for (int i = 0; i < item_list.Count; i++)
        //    {
        //        Items row = (Items)item_list[i];
        //        ListViewItem item = new ListViewItem(row.getCol1());
        //        item.SubItems.Add(row.getCol2());
        //        item.SubItems.Add(row.getCol3());
        //        item.SubItems.Add(row.getCol4());
        //        item.SubItems.Add(row.getCol5());
        //        item.SubItems.Add(row.getCol6());
        //        item.SubItems.Add(row.getCol7());
        //    }
        //    return true;
        //}

        //public bool Items2_create(ArrayList item2_list, ListView lv2)
        //{
        //    for (int i = 0; i < item2_list.Count; i++)
        //    {
        //        Items2 row = (Items2)item2_list[i];
        //        ListViewItem item = new ListViewItem(row.getCol1());
        //        item.SubItems.Add(row.getCol2());
        //        item.SubItems.Add(row.getCol3());
        //        item.SubItems.Add(row.getCol4());
        //        item.SubItems.Add(row.getCol5());
        //        item.SubItems.Add(row.getCol6());
        //        lv2.Items.Add(item);
        //    }
        //    return true;
        //}
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
