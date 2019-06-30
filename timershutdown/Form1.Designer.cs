namespace timershutdown
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.деактивироватьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numUpdHour = new System.Windows.Forms.NumericUpDown();
            this.numUpdMinut = new System.Windows.Forms.NumericUpDown();
            this.numUpdSec = new System.Windows.Forms.NumericUpDown();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rBtnShut = new System.Windows.Forms.RadioButton();
            this.RbtnSleep = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chbNotifi = new System.Windows.Forms.CheckBox();
            this.trackBVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblVolume2 = new System.Windows.Forms.Label();
            this.lblProcentVolume = new System.Windows.Forms.Label();
            this.будильникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdMinut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdSec)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOn
            // 
            this.buttonOn.Location = new System.Drawing.Point(434, 34);
            this.buttonOn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(126, 39);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "Активировать таймер";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(434, 112);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 40);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Деактивировать таймер";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(496, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.Location = new System.Drawing.Point(121, 34);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(92, 31);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "label2";
            // 
            // lblTimerText
            // 
            this.lblTimerText.AutoSize = true;
            this.lblTimerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimerText.Location = new System.Drawing.Point(12, 44);
            this.lblTimerText.Name = "lblTimerText";
            this.lblTimerText.Size = new System.Drawing.Size(112, 20);
            this.lblTimerText.TabIndex = 6;
            this.lblTimerText.Text = "Выкл через:";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Выкл через";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.деактивироватьТаймерToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(229, 70);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // деактивироватьТаймерToolStripMenuItem
            // 
            this.деактивироватьТаймерToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.деактивироватьТаймерToolStripMenuItem.Name = "деактивироватьТаймерToolStripMenuItem";
            this.деактивироватьТаймерToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.деактивироватьТаймерToolStripMenuItem.Text = "Деактивировать таймер";
            this.деактивироватьТаймерToolStripMenuItem.Click += new System.EventHandler(this.деактивироватьТаймерToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // numUpdHour
            // 
            this.numUpdHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdHour.Location = new System.Drawing.Point(26, 44);
            this.numUpdHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numUpdHour.Name = "numUpdHour";
            this.numUpdHour.Size = new System.Drawing.Size(46, 24);
            this.numUpdHour.TabIndex = 7;
            // 
            // numUpdMinut
            // 
            this.numUpdMinut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdMinut.Location = new System.Drawing.Point(73, 43);
            this.numUpdMinut.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpdMinut.Name = "numUpdMinut";
            this.numUpdMinut.Size = new System.Drawing.Size(42, 24);
            this.numUpdMinut.TabIndex = 8;
            // 
            // numUpdSec
            // 
            this.numUpdSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUpdSec.Location = new System.Drawing.Point(116, 43);
            this.numUpdSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numUpdSec.Name = "numUpdSec";
            this.numUpdSec.Size = new System.Drawing.Size(44, 24);
            this.numUpdSec.TabIndex = 9;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblH.Location = new System.Drawing.Point(29, 22);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(43, 18);
            this.lblH.TabIndex = 10;
            this.lblH.Text = "часы";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblM.Location = new System.Drawing.Point(73, 22);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(39, 18);
            this.lblM.TabIndex = 11;
            this.lblM.Text = "мин.";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblS.Location = new System.Drawing.Point(118, 22);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(36, 18);
            this.lblS.TabIndex = 12;
            this.lblS.Text = "сек.";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(221, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // rBtnShut
            // 
            this.rBtnShut.AutoSize = true;
            this.rBtnShut.Location = new System.Drawing.Point(21, 112);
            this.rBtnShut.Name = "rBtnShut";
            this.rBtnShut.Size = new System.Drawing.Size(91, 19);
            this.rBtnShut.TabIndex = 14;
            this.rBtnShut.TabStop = true;
            this.rBtnShut.Text = "Выключить";
            this.rBtnShut.UseVisualStyleBackColor = true;
            // 
            // RbtnSleep
            // 
            this.RbtnSleep.AutoSize = true;
            this.RbtnSleep.Location = new System.Drawing.Point(138, 112);
            this.RbtnSleep.Name = "RbtnSleep";
            this.RbtnSleep.Size = new System.Drawing.Size(95, 19);
            this.RbtnSleep.TabIndex = 15;
            this.RbtnSleep.TabStop = true;
            this.RbtnSleep.Text = "Гибернация";
            this.RbtnSleep.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem,
            this.будильникToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // выйтиToolStripMenuItem1
            // 
            this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
            this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.выйтиToolStripMenuItem1.Text = "Выйти";
            this.выйтиToolStripMenuItem1.Click += new System.EventHandler(this.выйтиToolStripMenuItem1_Click_1);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // chbNotifi
            // 
            this.chbNotifi.AutoSize = true;
            this.chbNotifi.Location = new System.Drawing.Point(20, 137);
            this.chbNotifi.MaximumSize = new System.Drawing.Size(213, 19);
            this.chbNotifi.MinimumSize = new System.Drawing.Size(213, 19);
            this.chbNotifi.Name = "chbNotifi";
            this.chbNotifi.Size = new System.Drawing.Size(213, 19);
            this.chbNotifi.TabIndex = 17;
            this.chbNotifi.Text = "Включить звуковое оповещение за 5 мин. до выключения";
            this.chbNotifi.UseVisualStyleBackColor = true;
            this.chbNotifi.EnabledChanged += new System.EventHandler(this.chbNotifi_EnabledChanged);
            this.chbNotifi.Click += new System.EventHandler(this.chbNotifi_Click);
            // 
            // trackBVolume
            // 
            this.trackBVolume.Location = new System.Drawing.Point(21, 181);
            this.trackBVolume.Maximum = 100;
            this.trackBVolume.Name = "trackBVolume";
            this.trackBVolume.Size = new System.Drawing.Size(240, 45);
            this.trackBVolume.TabIndex = 19;
            this.trackBVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBVolume.Value = 50;
            this.trackBVolume.Visible = false;
            this.trackBVolume.Scroll += new System.EventHandler(this.trackBVolume_Scroll);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(29, 163);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(145, 15);
            this.lblVolume.TabIndex = 20;
            this.lblVolume.Text = "Громкость оповещения";
            this.lblVolume.Visible = false;
            // 
            // lblVolume2
            // 
            this.lblVolume2.AutoSize = true;
            this.lblVolume2.Location = new System.Drawing.Point(230, 138);
            this.lblVolume2.Name = "lblVolume2";
            this.lblVolume2.Size = new System.Drawing.Size(151, 15);
            this.lblVolume2.TabIndex = 21;
            this.lblVolume2.Text = "за 5 мин. до выключения";
            // 
            // lblProcentVolume
            // 
            this.lblProcentVolume.AutoSize = true;
            this.lblProcentVolume.Location = new System.Drawing.Point(177, 163);
            this.lblProcentVolume.Name = "lblProcentVolume";
            this.lblProcentVolume.Size = new System.Drawing.Size(32, 15);
            this.lblProcentVolume.TabIndex = 22;
            this.lblProcentVolume.Text = "50%";
            this.lblProcentVolume.Visible = false;
            // 
            // будильникToolStripMenuItem
            // 
            this.будильникToolStripMenuItem.Name = "будильникToolStripMenuItem";
            this.будильникToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.будильникToolStripMenuItem.Text = "Будильник";
            this.будильникToolStripMenuItem.Click += new System.EventHandler(this.будильникToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 228);
            this.Controls.Add(this.lblProcentVolume);
            this.Controls.Add(this.lblVolume2);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trackBVolume);
            this.Controls.Add(this.chbNotifi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RbtnSleep);
            this.Controls.Add(this.rBtnShut);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.numUpdSec);
            this.Controls.Add(this.numUpdMinut);
            this.Controls.Add(this.numUpdHour);
            this.Controls.Add(this.lblTimerText);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.buttonOn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(570, 237);
            this.Name = "Form1";
            this.Text = "Таймер отключения ПК";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdMinut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdSec)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimerText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NumericUpDown numUpdHour;
        private System.Windows.Forms.NumericUpDown numUpdMinut;
        private System.Windows.Forms.NumericUpDown numUpdSec;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rBtnShut;
        private System.Windows.Forms.RadioButton RbtnSleep;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem деактивироватьТаймерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.CheckBox chbNotifi;
        private System.Windows.Forms.TrackBar trackBVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblVolume2;
        private System.Windows.Forms.Label lblProcentVolume;
        private System.Windows.Forms.ToolStripMenuItem будильникToolStripMenuItem;
    }
}

