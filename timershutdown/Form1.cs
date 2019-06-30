using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace timershutdown
{
    
    public partial class Form1 : Form
    {
        SoundPlayer sound = new SoundPlayer();
        Notifi FormNotifi = new Notifi();
        internal WindowsMediaPlayer WMP;
       
        TimeSpan t = new TimeSpan(0, 5, 0);   
            TimeSpan timespan;
            TimeSpan TimeDecrement = new TimeSpan(0, 0, 1);
            string commandShutOf = "shutdown /a";
            string command = "shutdown /s /t 1 ";
            string commandGiber = "shutdown /h";
             string commandOnGiber="powercfg.exe -h on";


        public Form1()
        {
            InitializeComponent();
            
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            
            lblTimer.Text = "";
            lblTimerText.Visible = false;
            progressBar1.Visible = false;
            rBtnShut.Checked = true;
            RbtnSleep.Checked = false;
            toolTip1.SetToolTip(RbtnSleep,"Спящий режим");
        }
        // Кнопка активации таймера
        private void buttonOn_Click(object sender, EventArgs e)
        {
            
          
            //если таймер равен нулю то ошибка
            timespan = Convert_Time();
            TimeSpan t = new TimeSpan(0,1,0);
            if (timespan<=t)
            {
                MessageBox.Show("Минимальное значение таймера 2 минуты","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            { 
                Tumbler.active = true;
                // запуск таймера
                timer.Start();
                // максимум прогресс бара ставим по значениям секунд таймера
                progressBar1.Maximum = timespan.Seconds + (timespan.Minutes * 60) + (timespan.Hours * 3600);
                progressBar1.Visible = true;
              

               
            
               lblTimer.Text = Convert.ToString(timespan);
                //какая кнопка нажата и установка текста в лейблах
               if (rBtnShut.Checked == true)
               {
                   lblTimerText.Visible = true;
                   lblTimerText.Text = "Выкл через:";
               }
               else if (RbtnSleep.Checked == true)
               {
                   lblTimerText.Visible = true;
                   lblTimerText.Text = "Сон через:";
               }
                 
                btnCancel.Enabled = true;
                buttonOn.Enabled = false;
                VisibleEl(false);
               


            }
                
            }
                
          
        //Кнопка деактивации
        private void btnCancel_Click(object sender, EventArgs e)
        {
            chbNotifi.Enabled = true;
            trackBVolume.Enabled = true;
            lblVolume.Enabled = true;
            lblVolume2.Enabled = true;
            lblProcentVolume.Enabled = true;
            timer.Stop();
            lblTimer.Text = "";
            lblTimerText.Visible = false;
            try {
                GetCommand(commandShutOf);
                FormNotifi.Visible = false;
                FormNotifi.timer1.Stop();
                btnCancel.Enabled = false;
                buttonOn.Enabled = true;
                Tumbler.active = false;
                VisibleEl(true);
                progressBar1.Visible = false;
                
            }

            catch { MessageBox.Show("Таймер не активирован"); }
            
        }
       // команда для командной строки
        private void GetCommand(string command)
        {
            try
            {
                Process cmd = new Process();

                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Arguments = "/C " + command;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
            }
            catch (Exception er)
            {
                MessageBox.Show("Ошибка кода" + er.Message);
            }
        }
        // по нажатию enter активировать
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { buttonOn.PerformClick(); ; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Tumbler.active)
            {
               
                if (Mesage() == DialogResult.OK)
                {
                   Tumbler.exit = true;
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
           
        }

       
        //тикание таймера
        private void timer_Tick(object sender, EventArgs e)
        {
            // убавляем таймер
            timespan -= TimeDecrement;
            if(timespan<t)
            {
                chbNotifi.Enabled = false;
                trackBVolume.Enabled = false;
                lblVolume.Enabled = false;
                lblVolume2.Enabled = false;
                lblProcentVolume.Enabled = false;
            }
            // Проверка сколько осталось таймера
            if(timespan==t)
            {
                //Если стоит галочка для оповещения
                if (chbNotifi.Checked == true)
                {

                    try
                    {
                       
                        WMP = new WindowsMediaPlayer();
                        WMP.URL = Application.StartupPath + @"\Audio\fanfare10.wav";
                        WMP.settings.volume = trackBVolume.Value;
                        WMP.controls.play();
                    }
                    catch
                    {
                        SoundPlayer sp = new SoundPlayer(Application.StartupPath + @"\Audio\fanfare10.wav");
                        sp.Play();
                    }
                }
                FormNotifi.Owner = this;
                
                //если осталось 5 минут то показать оповещение
                FormNotifi.Show();
                              
            }
            lblTimer.Text = Convert.ToString(timespan);
            
            notifyIcon1.Text = lblTimerText.Text + Convert.ToString(timespan);
           
           
            progressBar1.Value = timespan.Seconds + (timespan.Minutes * 60) + (timespan.Hours * 3600);
          // Если таймер равен 0 то выключить немедленно
            if (timespan<=TimeDecrement ){
                // проверяем какая радио кнопка активна 
                // И вызываем нужную кнопку
                if (rBtnShut.Checked == true)
                {
                    timer.Stop();
                    GetCommand(command);
                    Application.Exit();
                }
                    //Coн
                else if (RbtnSleep.Checked == true)
                {
                    
                    timer.Stop();
                    Tumbler.exit = true;
                    Tumbler.active = false;
                    notifyIcon1.Text="";
                    GetCommand(commandGiber);
                    btnExit.PerformClick();
                    GetCommand(commandOnGiber);
                    Application.Exit();
                }
            }
        }
      
        //закрытие формы
  private void Form1_FormClosing(object sender, FormClosingEventArgs e)
  {
      // если таймер запущен то просто свернуть по else выйти
      if (!Tumbler.exit&Tumbler.active)
      {

          this.Hide();
          notifyIcon1.Visible = true;
          
          e.Cancel = true;
      }
      else
      {

          Application.Exit();
      }

  }

  private void notifyIcon1_Click(object sender, EventArgs e)
  {
     // this.Show();
  }

 //зписываем и конвертируем время которое ввел пользователь
  private TimeSpan Convert_Time()
  {
    TimeSpan  timespan = new TimeSpan(Convert.ToInt32(numUpdHour.Text), Convert.ToInt32(numUpdMinut.Text), Convert.ToInt32(numUpdSec.Text));
      return timespan;
  }
        // функцыя для показа кнопок
        private void VisibleEl(bool status)
  {
      numUpdHour.Visible = status;
      numUpdMinut.Visible = status;
      numUpdSec.Visible = status;
      lblH.Visible = status;
      lblM.Visible = status;
      lblS.Visible = status;
      RbtnSleep.Enabled = status;
      rBtnShut.Enabled = status;
  }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            btnExit.PerformClick();
            this.Hide();
         
           
        }

        private void деактивироватьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            btnCancel.PerformClick();
            this.Hide();
        }
       
        // 
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private DialogResult Mesage()
        {
            DialogResult res = MessageBox.Show("Выйти и отключить таймер", "???", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return res;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

      

       

        private void выйтиToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            btnExit.PerformClick();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void chbNotifi_EnabledChanged(object sender, EventArgs e)
        {
           
        }

        private void chbNotifi_Click(object sender, EventArgs e)
        {
            if(chbNotifi.Checked==true)
            {
                trackBVolume.Visible = true;
                lblVolume.Visible = true;
                lblProcentVolume.Visible = true;
            }
            else if(chbNotifi.Checked==false)
            {
                trackBVolume.Visible = false;
                lblVolume.Visible = false;
                lblProcentVolume.Visible = false;
            }
        }

        private void trackBVolume_Scroll(object sender, EventArgs e)
        {
            lblProcentVolume.Text = Convert.ToString(trackBVolume.Value) + "%";
        }

        public static bool EnableHibernate()
        {
            Process p = new Process();
            p.StartInfo.FileName = "powercfg.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = "/hibernate on"; // this might be different in other locales
            return p.Start();
        }

      

        private void будильникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlarm formalarm = new FormAlarm();
            formalarm.Show();
        }
        }
  
    }

