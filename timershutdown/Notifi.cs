using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timershutdown
{
    public partial class Notifi : Form
    {
        TimeSpan timespan = new TimeSpan(0, 5, 4);
        TimeSpan timedecrement = new TimeSpan(0, 0, 1);
        TimeSpan t = new TimeSpan(0,0,2);
       
        
        public Notifi()
        {
            InitializeComponent();
           
           FormVisible();
            // поверх всех окон
            TopMost = true;
            // Позиционирование в нижнем левом углу
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, Screen.PrimaryScreen.Bounds.Height - this.Height);

        }

        private void Notifi_Load(object sender, EventArgs e)
        {
           
            timespan = new TimeSpan(0, 5, 0);
            lblTimer.Text = Convert.ToString(timespan);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            timer1.Stop();
            this.Hide();
           
        }
        //Если нажата кнопка отмена
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            // показиваем главную форму и нажимаеим отмена на первой форме
            f1.Show();
            f1.btnCancel.PerformClick();
            Tumbler.active = false;
           
            this.Hide();

        }
        // Тикание таймера
        private void timer1_Tick(object sender, EventArgs e)
        {
            timespan -= timedecrement;
            lblTimer.Text =Convert.ToString(timespan);
            if (timespan<=t)
            {
                timer1.Stop();
                this.Hide();
                Application.Exit();

            }
        }

        private void Notifi_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible==false)
            {
                timer1.Stop();
            }
            else if(this.Visible==true)
            {
                FormVisible();
            }
        }
            private void FormVisible()
            {
                timespan = new TimeSpan(0, 5, 0);
                timer1.Start();
                lblTimer.Text = Convert.ToString(timespan);

            }
         
        
    }
}
