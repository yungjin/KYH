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
    public partial class Form2 : Form
    {
        BtnClass btnClass = new BtnClass();

        public Form2()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Color.WhiteSmoke;

            Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new BtnSet(this,"하드디스크 최적화", 200, 80, 80, 80, BtnHard_Click));
            arrayList.Add(new BtnSet(this, "프로세스 최적화",200, 80, 80, 200, BtnProcess_Click));

            for (int i = 0; i < arrayList.Count; i++)
            {
                btnClass.button1((BtnSet)arrayList[i]);
            }
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("하드디스크 최적화");
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로세스 최적화");
        }
    }
}
