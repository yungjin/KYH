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
        LblClass lblClass = new LblClass();

        Timer timer;
        Panel pan1, pan2,pan3;

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

            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add(new LblSet(this, "CPU사용률", "고딕", 15, FontStyle.Bold, 370, 280, Color.Black));

            for (int i = 0; i < arrayList1.Count; i++)
            {
                Control control = (lblClass.label((LblSet)arrayList1[i]));
                Controls.Add(lblClass.label((LblSet)arrayList1[i]));
            }

            pan1 = new Panel();
            pan1.Height = 150;
            pan1.Width = 30;
            pan1.Location = new Point(400, 120);
            pan1.BackColor = Color.DarkBlue;

            pan2 = new Panel();
            pan2.Height = 150;
            pan2.Width = 30;
            pan2.Location = new Point(400, 120);
            pan2.BackColor = Color.DarkBlue;

            pan3 = new Panel();
            pan3.Height = 230;
            pan3.Width = 30;
            pan3.Location = new Point(400, 40);
            pan3.BackColor = Color.Silver;

            Controls.Add(pan1);
            Controls.Add(pan2);
            Controls.Add(pan3);

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pan1.Height > 100)
            {
                pan1.Height = 1;
                
            }
            else if (pan1.Height == 100) timer.Stop();
            else
            {
                pan1.Height = pan1.Height + 1;
                pan1.BackColor = Color.Silver;
            }
            
            //if (pan1.Height > 100) pan1.Height = 1;
            //else pan1.Height = pan1.Height + 1;

            timer.Start();
        }

        private void BtnHard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("하드디스크 최적화");

            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            timer.Start();
            
        }

        private void BtnProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로세스 최적화");
        }
    }
}
