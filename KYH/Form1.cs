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
            this.IsMdiContainer = true;
            this.BackColor = Color.WhiteSmoke;

            //https://support.microsoft.com/ko-kr/help/319465/how-to-change-the-background-color-for-an-mdi-parent-form-in-visual-c
            MdiClient mdiClient;
            foreach (Control control in this.Controls)
            {
                try
                {
                    mdiClient = (MdiClient)control;

                    mdiClient.BackColor = this.BackColor;
                }
                catch (InvalidCastException) { }
            }

            Button_Load();
            Panel1_Load();
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
            Form2 form2 = new Form2();
            form2.MdiParent = this;

            panel1.Location = new Point(111, 3);
            panel1.Size = new Size(650, 400);

            Controls.Add(panel1);
            panel1.Controls.Add(form2);
            form2.Show();
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
            Form2 form2 = new Form2();
            form2.MdiParent = this;

            panel2.Location = new Point(111, 3);
            panel2.Size = new Size(650, 400);

            Controls.Add(panel2);
            panel2.Controls.Add(form2);
            form2.Show();
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
            Form2 form2 = new Form2();
            form2.MdiParent = this;

            panel3.Location = new Point(111, 3);
            panel3.Size = new Size(650, 400);

            Controls.Add(panel3);
            panel3.Controls.Add(form2);
            form2.Show();
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
            Form2 form2 = new Form2();
            form2.MdiParent = this;

            panel4.Location = new Point(111, 3);
            panel4.Size = new Size(650, 400);

            Controls.Add(panel4);
            panel4.Controls.Add(form2);
            form2.Show();
        }

        private void Button_Load()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(new BtnSet(this, "", 110, 90, 0, 0, "image1", Button1_Click));
            arrayList.Add(new BtnSet(this, "", 110, 90, 0, 90, "image2", Button2_Click));
            arrayList.Add(new BtnSet(this, "", 110, 90, 0, 180, "image3", Button3_Click));
            arrayList.Add(new BtnSet(this, "", 110, 90, 0, 270, "image4", Button4_Click));
            
            for (int i = 0; i < arrayList.Count; i++)
            {
                btnClass.button((BtnSet)arrayList[i]);
            }
        }
    }
}
