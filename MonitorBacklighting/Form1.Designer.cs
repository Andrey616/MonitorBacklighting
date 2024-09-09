namespace MonitorBacklighting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.butOpen = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.OnOofTape = new System.Windows.Forms.CheckBox();
            this.Futor = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRed = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelBlue = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Mode0 = new System.Windows.Forms.RadioButton();
            this.Mode1 = new System.Windows.Forms.RadioButton();
            this.Mode3 = new System.Windows.Forms.RadioButton();
            this.Mode4 = new System.Windows.Forms.RadioButton();
            this.Mode5 = new System.Windows.Forms.RadioButton();
            this.trackSpeedMode = new System.Windows.Forms.TrackBar();
            this.SpeedModeLable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColorRed = new System.Windows.Forms.RadioButton();
            this.ColorCyan = new System.Windows.Forms.RadioButton();
            this.ColorLime = new System.Windows.Forms.RadioButton();
            this.ColorMagenta = new System.Windows.Forms.RadioButton();
            this.ColorYellow = new System.Windows.Forms.RadioButton();
            this.ColorDarkPink = new System.Windows.Forms.RadioButton();
            this.ColorDarkCany = new System.Windows.Forms.RadioButton();
            this.ColorDarkMagenta = new System.Windows.Forms.RadioButton();
            this.ColorWhite = new System.Windows.Forms.RadioButton();
            this.ColorSwamp = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColorPalePink = new System.Windows.Forms.RadioButton();
            this.ColorWhiteOrange = new System.Windows.Forms.RadioButton();
            this.ColorBlue = new System.Windows.Forms.RadioButton();
            this.ColorOrange = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.labelBrightness = new System.Windows.Forms.Label();
            this.trackBrightness = new System.Windows.Forms.TrackBar();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeedMode)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // PortBox
            // 
            this.PortBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PortBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PortBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortBox.ForeColor = System.Drawing.Color.White;
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(15, 20);
            this.PortBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortBox.Name = "PortBox";
            this.PortBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PortBox.Size = new System.Drawing.Size(122, 21);
            this.PortBox.TabIndex = 0;
            this.PortBox.Text = "Выберите порт";
            this.PortBox.SelectedIndexChanged += new System.EventHandler(this.PortBox_SelectedIndexChanged);
            // 
            // butOpen
            // 
            this.butOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.butOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOpen.ForeColor = System.Drawing.Color.White;
            this.butOpen.Location = new System.Drawing.Point(141, 20);
            this.butOpen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.butOpen.Name = "butOpen";
            this.butOpen.Size = new System.Drawing.Size(74, 26);
            this.butOpen.TabIndex = 1;
            this.butOpen.Text = "Открыть";
            this.butOpen.UseVisualStyleBackColor = false;
            this.butOpen.Click += new System.EventHandler(this.butOpen_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.ForeColor = System.Drawing.Color.White;
            this.butClose.Location = new System.Drawing.Point(221, 20);
            this.butClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(74, 26);
            this.butClose.TabIndex = 2;
            this.butClose.Text = "Закрыть";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // OnOofTape
            // 
            this.OnOofTape.AutoSize = true;
            this.OnOofTape.ForeColor = System.Drawing.Color.White;
            this.OnOofTape.Location = new System.Drawing.Point(15, 49);
            this.OnOofTape.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OnOofTape.Name = "OnOofTape";
            this.OnOofTape.Size = new System.Drawing.Size(168, 17);
            this.OnOofTape.TabIndex = 4;
            this.OnOofTape.Text = "Включить\\Выключить ленту";
            this.OnOofTape.UseVisualStyleBackColor = true;
            this.OnOofTape.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Futor
            // 
            this.Futor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Futor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Futor.ForeColor = System.Drawing.Color.White;
            this.Futor.Location = new System.Drawing.Point(0, 429);
            this.Futor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Futor.Name = "Futor";
            this.Futor.Size = new System.Drawing.Size(828, 13);
            this.Futor.TabIndex = 5;
            this.Futor.TextChanged += new System.EventHandler(this.Futor_TextChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackBarRed.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBarRed.Location = new System.Drawing.Point(12, 117);
            this.trackBarRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(192, 45);
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.TickFrequency = 0;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackBarGreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBarGreen.Location = new System.Drawing.Point(12, 169);
            this.trackBarGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(192, 45);
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.TickFrequency = 0;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackBarBlue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBarBlue.Location = new System.Drawing.Point(12, 221);
            this.trackBarBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(192, 45);
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.TickFrequency = 0;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Red";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Blue";
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.ForeColor = System.Drawing.Color.White;
            this.labelRed.Location = new System.Drawing.Point(238, 185);
            this.labelRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(13, 13);
            this.labelRed.TabIndex = 12;
            this.labelRed.Text = "0";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.ForeColor = System.Drawing.Color.White;
            this.labelGreen.Location = new System.Drawing.Point(264, 185);
            this.labelGreen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(13, 13);
            this.labelGreen.TabIndex = 13;
            this.labelGreen.Text = "0";
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ForeColor = System.Drawing.Color.White;
            this.labelBlue.Location = new System.Drawing.Point(288, 185);
            this.labelBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(13, 13);
            this.labelBlue.TabIndex = 14;
            this.labelBlue.Text = "0";
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ColorBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBox.Location = new System.Drawing.Point(240, 107);
            this.ColorBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(74, 78);
            this.ColorBox.TabIndex = 15;
            this.ColorBox.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(530, 237);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Реагировать на звук";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Mode0
            // 
            this.Mode0.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Mode0.Checked = true;
            this.Mode0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode0.ForeColor = System.Drawing.Color.White;
            this.Mode0.Location = new System.Drawing.Point(12, 26);
            this.Mode0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode0.Name = "Mode0";
            this.Mode0.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mode0.Size = new System.Drawing.Size(240, 26);
            this.Mode0.TabIndex = 19;
            this.Mode0.TabStop = true;
            this.Mode0.Text = "Радуга";
            this.Mode0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mode0.UseVisualStyleBackColor = false;
            this.Mode0.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Mode1
            // 
            this.Mode1.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Mode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode1.ForeColor = System.Drawing.Color.White;
            this.Mode1.Location = new System.Drawing.Point(12, 55);
            this.Mode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode1.Name = "Mode1";
            this.Mode1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mode1.Size = new System.Drawing.Size(240, 26);
            this.Mode1.TabIndex = 20;
            this.Mode1.Text = "Бегущая радуга";
            this.Mode1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mode1.UseVisualStyleBackColor = false;
            this.Mode1.CheckedChanged += new System.EventHandler(this.Mode1_CheckedChanged);
            // 
            // Mode3
            // 
            this.Mode3.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Mode3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode3.ForeColor = System.Drawing.Color.White;
            this.Mode3.Location = new System.Drawing.Point(12, 88);
            this.Mode3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode3.Name = "Mode3";
            this.Mode3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mode3.Size = new System.Drawing.Size(240, 26);
            this.Mode3.TabIndex = 21;
            this.Mode3.Text = "Дыхание";
            this.Mode3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mode3.UseVisualStyleBackColor = false;
            this.Mode3.CheckedChanged += new System.EventHandler(this.Mode3_CheckedChanged);
            // 
            // Mode4
            // 
            this.Mode4.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Mode4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode4.ForeColor = System.Drawing.Color.White;
            this.Mode4.Location = new System.Drawing.Point(12, 117);
            this.Mode4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode4.Name = "Mode4";
            this.Mode4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mode4.Size = new System.Drawing.Size(240, 26);
            this.Mode4.TabIndex = 22;
            this.Mode4.Text = "Постоянный цвет";
            this.Mode4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mode4.UseVisualStyleBackColor = false;
            this.Mode4.CheckedChanged += new System.EventHandler(this.Mode4_CheckedChanged);
            // 
            // Mode5
            // 
            this.Mode5.Appearance = System.Windows.Forms.Appearance.Button;
            this.Mode5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Mode5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode5.ForeColor = System.Drawing.Color.White;
            this.Mode5.Location = new System.Drawing.Point(12, 143);
            this.Mode5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mode5.Name = "Mode5";
            this.Mode5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Mode5.Size = new System.Drawing.Size(240, 26);
            this.Mode5.TabIndex = 23;
            this.Mode5.Text = "Дым";
            this.Mode5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Mode5.UseVisualStyleBackColor = false;
            this.Mode5.CheckedChanged += new System.EventHandler(this.Mode5_CheckedChanged);
            // 
            // trackSpeedMode
            // 
            this.trackSpeedMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackSpeedMode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackSpeedMode.Location = new System.Drawing.Point(530, 260);
            this.trackSpeedMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackSpeedMode.Maximum = 250;
            this.trackSpeedMode.Name = "trackSpeedMode";
            this.trackSpeedMode.Size = new System.Drawing.Size(240, 45);
            this.trackSpeedMode.TabIndex = 24;
            this.trackSpeedMode.TickFrequency = 0;
            this.trackSpeedMode.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackSpeedMode.Value = 4;
            this.trackSpeedMode.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SpeedModeLable
            // 
            this.SpeedModeLable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeedModeLable.ForeColor = System.Drawing.Color.White;
            this.SpeedModeLable.Location = new System.Drawing.Point(562, 286);
            this.SpeedModeLable.Margin = new System.Windows.Forms.Padding(0);
            this.SpeedModeLable.Name = "SpeedModeLable";
            this.SpeedModeLable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SpeedModeLable.Size = new System.Drawing.Size(163, 19);
            this.SpeedModeLable.TabIndex = 25;
            this.SpeedModeLable.Text = "Скорость режимов: 4";
            this.SpeedModeLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SpeedModeLable.UseWaitCursor = true;
            this.SpeedModeLable.Click += new System.EventHandler(this.SpeedModeLable_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mode5);
            this.groupBox1.Controls.Add(this.Mode4);
            this.groupBox1.Controls.Add(this.Mode3);
            this.groupBox1.Controls.Add(this.Mode1);
            this.groupBox1.Controls.Add(this.Mode0);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(529, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox1.Size = new System.Drawing.Size(262, 182);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режимы свечения:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ColorRed
            // 
            this.ColorRed.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorRed.BackColor = System.Drawing.Color.Red;
            this.ColorRed.Checked = true;
            this.ColorRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorRed.Location = new System.Drawing.Point(10, 23);
            this.ColorRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorRed.Name = "ColorRed";
            this.ColorRed.Size = new System.Drawing.Size(22, 20);
            this.ColorRed.TabIndex = 27;
            this.ColorRed.TabStop = true;
            this.ColorRed.UseVisualStyleBackColor = false;
            // 
            // ColorCyan
            // 
            this.ColorCyan.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorCyan.BackColor = System.Drawing.Color.Cyan;
            this.ColorCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorCyan.Location = new System.Drawing.Point(34, 23);
            this.ColorCyan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorCyan.Name = "ColorCyan";
            this.ColorCyan.Size = new System.Drawing.Size(22, 20);
            this.ColorCyan.TabIndex = 28;
            this.ColorCyan.UseVisualStyleBackColor = false;
            // 
            // ColorLime
            // 
            this.ColorLime.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorLime.BackColor = System.Drawing.Color.Lime;
            this.ColorLime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorLime.Location = new System.Drawing.Point(60, 23);
            this.ColorLime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorLime.Name = "ColorLime";
            this.ColorLime.Size = new System.Drawing.Size(22, 20);
            this.ColorLime.TabIndex = 29;
            this.ColorLime.UseVisualStyleBackColor = false;
            // 
            // ColorMagenta
            // 
            this.ColorMagenta.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorMagenta.BackColor = System.Drawing.Color.Magenta;
            this.ColorMagenta.Cursor = System.Windows.Forms.Cursors.No;
            this.ColorMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorMagenta.Location = new System.Drawing.Point(86, 23);
            this.ColorMagenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorMagenta.Name = "ColorMagenta";
            this.ColorMagenta.Size = new System.Drawing.Size(22, 20);
            this.ColorMagenta.TabIndex = 30;
            this.ColorMagenta.UseVisualStyleBackColor = false;
            // 
            // ColorYellow
            // 
            this.ColorYellow.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.ColorYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorYellow.Location = new System.Drawing.Point(110, 23);
            this.ColorYellow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorYellow.Name = "ColorYellow";
            this.ColorYellow.Size = new System.Drawing.Size(22, 20);
            this.ColorYellow.TabIndex = 31;
            this.ColorYellow.UseVisualStyleBackColor = false;
            // 
            // ColorDarkPink
            // 
            this.ColorDarkPink.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorDarkPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(0)))), ((int)(((byte)(127)))));
            this.ColorDarkPink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorDarkPink.Location = new System.Drawing.Point(10, 49);
            this.ColorDarkPink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorDarkPink.Name = "ColorDarkPink";
            this.ColorDarkPink.Size = new System.Drawing.Size(22, 20);
            this.ColorDarkPink.TabIndex = 32;
            this.ColorDarkPink.UseVisualStyleBackColor = false;
            // 
            // ColorDarkCany
            // 
            this.ColorDarkCany.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorDarkCany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(167)))), ((int)(((byte)(224)))));
            this.ColorDarkCany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorDarkCany.Location = new System.Drawing.Point(34, 49);
            this.ColorDarkCany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorDarkCany.Name = "ColorDarkCany";
            this.ColorDarkCany.Size = new System.Drawing.Size(22, 20);
            this.ColorDarkCany.TabIndex = 33;
            this.ColorDarkCany.UseVisualStyleBackColor = false;
            // 
            // ColorDarkMagenta
            // 
            this.ColorDarkMagenta.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorDarkMagenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(25)))), ((int)(((byte)(134)))));
            this.ColorDarkMagenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorDarkMagenta.Location = new System.Drawing.Point(60, 49);
            this.ColorDarkMagenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorDarkMagenta.Name = "ColorDarkMagenta";
            this.ColorDarkMagenta.Size = new System.Drawing.Size(22, 20);
            this.ColorDarkMagenta.TabIndex = 34;
            this.ColorDarkMagenta.UseVisualStyleBackColor = false;
            // 
            // ColorWhite
            // 
            this.ColorWhite.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorWhite.BackColor = System.Drawing.Color.White;
            this.ColorWhite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorWhite.Location = new System.Drawing.Point(86, 49);
            this.ColorWhite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorWhite.Name = "ColorWhite";
            this.ColorWhite.Size = new System.Drawing.Size(22, 20);
            this.ColorWhite.TabIndex = 35;
            this.ColorWhite.UseVisualStyleBackColor = false;
            // 
            // ColorSwamp
            // 
            this.ColorSwamp.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorSwamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(179)))), ((int)(((byte)(36)))));
            this.ColorSwamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorSwamp.Location = new System.Drawing.Point(110, 49);
            this.ColorSwamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorSwamp.Name = "ColorSwamp";
            this.ColorSwamp.Size = new System.Drawing.Size(22, 20);
            this.ColorSwamp.TabIndex = 36;
            this.ColorSwamp.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ColorPalePink);
            this.groupBox2.Controls.Add(this.ColorWhiteOrange);
            this.groupBox2.Controls.Add(this.ColorBlue);
            this.groupBox2.Controls.Add(this.ColorOrange);
            this.groupBox2.Controls.Add(this.ColorSwamp);
            this.groupBox2.Controls.Add(this.ColorWhite);
            this.groupBox2.Controls.Add(this.ColorDarkMagenta);
            this.groupBox2.Controls.Add(this.ColorDarkCany);
            this.groupBox2.Controls.Add(this.ColorDarkPink);
            this.groupBox2.Controls.Add(this.ColorYellow);
            this.groupBox2.Controls.Add(this.ColorMagenta);
            this.groupBox2.Controls.Add(this.ColorLime);
            this.groupBox2.Controls.Add(this.ColorCyan);
            this.groupBox2.Controls.Add(this.ColorRed);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(14, 273);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.groupBox2.Size = new System.Drawing.Size(190, 75);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Готовые цвета";
            // 
            // ColorPalePink
            // 
            this.ColorPalePink.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorPalePink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(113)))), ((int)(((byte)(174)))));
            this.ColorPalePink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPalePink.Location = new System.Drawing.Point(166, 49);
            this.ColorPalePink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorPalePink.Name = "ColorPalePink";
            this.ColorPalePink.Size = new System.Drawing.Size(22, 20);
            this.ColorPalePink.TabIndex = 40;
            this.ColorPalePink.UseVisualStyleBackColor = false;
            // 
            // ColorWhiteOrange
            // 
            this.ColorWhiteOrange.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorWhiteOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(51)))));
            this.ColorWhiteOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorWhiteOrange.Location = new System.Drawing.Point(138, 49);
            this.ColorWhiteOrange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorWhiteOrange.Name = "ColorWhiteOrange";
            this.ColorWhiteOrange.Size = new System.Drawing.Size(22, 20);
            this.ColorWhiteOrange.TabIndex = 39;
            this.ColorWhiteOrange.UseVisualStyleBackColor = false;
            // 
            // ColorBlue
            // 
            this.ColorBlue.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorBlue.BackColor = System.Drawing.Color.Blue;
            this.ColorBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorBlue.Location = new System.Drawing.Point(166, 23);
            this.ColorBlue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorBlue.Name = "ColorBlue";
            this.ColorBlue.Size = new System.Drawing.Size(22, 20);
            this.ColorBlue.TabIndex = 38;
            this.ColorBlue.UseVisualStyleBackColor = false;
            // 
            // ColorOrange
            // 
            this.ColorOrange.Appearance = System.Windows.Forms.Appearance.Button;
            this.ColorOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.ColorOrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorOrange.Location = new System.Drawing.Point(138, 23);
            this.ColorOrange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorOrange.Name = "ColorOrange";
            this.ColorOrange.Size = new System.Drawing.Size(22, 20);
            this.ColorOrange.TabIndex = 37;
            this.ColorOrange.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(218, 221);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(143, 23);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.Text = "Использовать свой цвет";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // labelBrightness
            // 
            this.labelBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBrightness.ForeColor = System.Drawing.Color.White;
            this.labelBrightness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelBrightness.Location = new System.Drawing.Point(555, 347);
            this.labelBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.labelBrightness.Name = "labelBrightness";
            this.labelBrightness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelBrightness.Size = new System.Drawing.Size(174, 21);
            this.labelBrightness.TabIndex = 40;
            this.labelBrightness.Text = "Яркость режимов: 50";
            this.labelBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBrightness.UseWaitCursor = true;
            // 
            // trackBrightness
            // 
            this.trackBrightness.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.trackBrightness.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBrightness.Location = new System.Drawing.Point(530, 321);
            this.trackBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackBrightness.Maximum = 100;
            this.trackBrightness.Name = "trackBrightness";
            this.trackBrightness.Size = new System.Drawing.Size(240, 45);
            this.trackBrightness.TabIndex = 39;
            this.trackBrightness.TickFrequency = 0;
            this.trackBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBrightness.Value = 50;
            this.trackBrightness.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(828, 449);
            this.Controls.Add(this.labelBrightness);
            this.Controls.Add(this.trackBrightness);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpeedModeLable);
            this.Controls.Add(this.trackSpeedMode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.Futor);
            this.Controls.Add(this.OnOofTape);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butOpen);
            this.Controls.Add(this.PortBox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выберите порт";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeedMode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button butOpen;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.CheckBox OnOofTape;
        private System.Windows.Forms.TextBox Futor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Button ColorBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton Mode0;
        private System.Windows.Forms.RadioButton Mode1;
        private System.Windows.Forms.RadioButton Mode3;
        private System.Windows.Forms.RadioButton Mode4;
        private System.Windows.Forms.RadioButton Mode5;
        private System.Windows.Forms.TrackBar trackSpeedMode;
        private System.Windows.Forms.Label SpeedModeLable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ColorRed;
        private System.Windows.Forms.RadioButton ColorCyan;
        private System.Windows.Forms.RadioButton ColorLime;
        private System.Windows.Forms.RadioButton ColorMagenta;
        private System.Windows.Forms.RadioButton ColorYellow;
        private System.Windows.Forms.RadioButton ColorDarkPink;
        private System.Windows.Forms.RadioButton ColorDarkCany;
        private System.Windows.Forms.RadioButton ColorDarkMagenta;
        private System.Windows.Forms.RadioButton ColorWhite;
        private System.Windows.Forms.RadioButton ColorSwamp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ColorPalePink;
        private System.Windows.Forms.RadioButton ColorWhiteOrange;
        private System.Windows.Forms.RadioButton ColorBlue;
        private System.Windows.Forms.RadioButton ColorOrange;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label labelBrightness;
        private System.Windows.Forms.TrackBar trackBrightness;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}

