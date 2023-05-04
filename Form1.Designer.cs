namespace TrafficLights
{
    partial class TrafficLights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.night_timer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.NightIntervalLabel = new System.Windows.Forms.Label();
            this.NightIntervalTextBox = new System.Windows.Forms.TextBox();
            this.dayAutoRadioButton = new System.Windows.Forms.RadioButton();
            this.dayHandRadioButton = new System.Windows.Forms.RadioButton();
            this.dayDurationYesRadioButton = new System.Windows.Forms.RadioButton();
            this.dayDurationNoRadioButton = new System.Windows.Forms.RadioButton();
            this.redIntervalLabel = new System.Windows.Forms.Label();
            this.yellowIntervalLabel = new System.Windows.Forms.Label();
            this.greenIntervalLabel = new System.Windows.Forms.Label();
            this.redIntervalTextBox = new System.Windows.Forms.TextBox();
            this.yellowIntervalTextBox = new System.Windows.Forms.TextBox();
            this.greenIntervalTextBox = new System.Windows.Forms.TextBox();
            this.switchButton = new System.Windows.Forms.Button();
            this.day_timer = new System.Windows.Forms.Timer(this.components);
            this.darkLight = new System.Windows.Forms.PictureBox();
            this.greenLight = new System.Windows.Forms.PictureBox();
            this.yellowLight = new System.Windows.Forms.PictureBox();
            this.redLight = new System.Windows.Forms.PictureBox();
            this.dayTimeGroupBox = new System.Windows.Forms.GroupBox();
            this.managementGroupBox = new System.Windows.Forms.GroupBox();
            this.intervalOptionGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.darkLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).BeginInit();
            this.dayTimeGroupBox.SuspendLayout();
            this.managementGroupBox.SuspendLayout();
            this.intervalOptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // night_timer
            // 
            this.night_timer.Interval = 2000;
            this.night_timer.Tick += new System.EventHandler(this.night_timer_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(447, 416);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(116, 43);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(605, 417);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(116, 42);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(13, 28);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(60, 20);
            this.dayRadioButton.TabIndex = 6;
            this.dayRadioButton.Text = "День";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.dayRadioButton_CheckedChanged);
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(111, 28);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(49, 20);
            this.nightRadioButton.TabIndex = 7;
            this.nightRadioButton.Text = "Ніч";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            this.nightRadioButton.CheckedChanged += new System.EventHandler(this.nightRadioButton_CheckedChanged);
            // 
            // NightIntervalLabel
            // 
            this.NightIntervalLabel.AutoSize = true;
            this.NightIntervalLabel.Location = new System.Drawing.Point(380, 78);
            this.NightIntervalLabel.Name = "NightIntervalLabel";
            this.NightIntervalLabel.Size = new System.Drawing.Size(195, 16);
            this.NightIntervalLabel.TabIndex = 8;
            this.NightIntervalLabel.Text = "Введіть інтервал в секундах:\r\n";
            this.NightIntervalLabel.Visible = false;
            // 
            // NightIntervalTextBox
            // 
            this.NightIntervalTextBox.Location = new System.Drawing.Point(595, 75);
            this.NightIntervalTextBox.Name = "NightIntervalTextBox";
            this.NightIntervalTextBox.Size = new System.Drawing.Size(64, 22);
            this.NightIntervalTextBox.TabIndex = 9;
            this.NightIntervalTextBox.Visible = false;
            // 
            // dayAutoRadioButton
            // 
            this.dayAutoRadioButton.AutoSize = true;
            this.dayAutoRadioButton.Location = new System.Drawing.Point(13, 27);
            this.dayAutoRadioButton.Name = "dayAutoRadioButton";
            this.dayAutoRadioButton.Size = new System.Drawing.Size(116, 20);
            this.dayAutoRadioButton.TabIndex = 10;
            this.dayAutoRadioButton.TabStop = true;
            this.dayAutoRadioButton.Text = "Автоматичне";
            this.dayAutoRadioButton.UseVisualStyleBackColor = true;
            this.dayAutoRadioButton.Visible = false;
            this.dayAutoRadioButton.CheckedChanged += new System.EventHandler(this.dayAutoRadioButton_CheckedChanged);
            // 
            // dayHandRadioButton
            // 
            this.dayHandRadioButton.AutoSize = true;
            this.dayHandRadioButton.Location = new System.Drawing.Point(164, 27);
            this.dayHandRadioButton.Name = "dayHandRadioButton";
            this.dayHandRadioButton.Size = new System.Drawing.Size(69, 20);
            this.dayHandRadioButton.TabIndex = 11;
            this.dayHandRadioButton.TabStop = true;
            this.dayHandRadioButton.Text = "Ручне";
            this.dayHandRadioButton.UseVisualStyleBackColor = true;
            this.dayHandRadioButton.Visible = false;
            this.dayHandRadioButton.CheckedChanged += new System.EventHandler(this.dayHandRadioButton_CheckedChanged);
            // 
            // dayDurationYesRadioButton
            // 
            this.dayDurationYesRadioButton.AutoSize = true;
            this.dayDurationYesRadioButton.Location = new System.Drawing.Point(64, 21);
            this.dayDurationYesRadioButton.Name = "dayDurationYesRadioButton";
            this.dayDurationYesRadioButton.Size = new System.Drawing.Size(52, 20);
            this.dayDurationYesRadioButton.TabIndex = 14;
            this.dayDurationYesRadioButton.TabStop = true;
            this.dayDurationYesRadioButton.Text = "Так";
            this.dayDurationYesRadioButton.UseVisualStyleBackColor = true;
            this.dayDurationYesRadioButton.Visible = false;
            this.dayDurationYesRadioButton.CheckedChanged += new System.EventHandler(this.dayDurationYesRadioButton_CheckedChanged);
            // 
            // dayDurationNoRadioButton
            // 
            this.dayDurationNoRadioButton.AutoSize = true;
            this.dayDurationNoRadioButton.Location = new System.Drawing.Point(228, 21);
            this.dayDurationNoRadioButton.Name = "dayDurationNoRadioButton";
            this.dayDurationNoRadioButton.Size = new System.Drawing.Size(41, 20);
            this.dayDurationNoRadioButton.TabIndex = 15;
            this.dayDurationNoRadioButton.TabStop = true;
            this.dayDurationNoRadioButton.Text = "Ні";
            this.dayDurationNoRadioButton.UseVisualStyleBackColor = true;
            this.dayDurationNoRadioButton.Visible = false;
            this.dayDurationNoRadioButton.CheckedChanged += new System.EventHandler(this.dayDurationNoRadioButton_CheckedChanged);
            // 
            // redIntervalLabel
            // 
            this.redIntervalLabel.AutoSize = true;
            this.redIntervalLabel.Location = new System.Drawing.Point(346, 250);
            this.redIntervalLabel.Name = "redIntervalLabel";
            this.redIntervalLabel.Size = new System.Drawing.Size(243, 16);
            this.redIntervalLabel.TabIndex = 16;
            this.redIntervalLabel.Text = "Введіть час світітння для червоного";
            this.redIntervalLabel.Visible = false;
            // 
            // yellowIntervalLabel
            // 
            this.yellowIntervalLabel.AutoSize = true;
            this.yellowIntervalLabel.Location = new System.Drawing.Point(346, 284);
            this.yellowIntervalLabel.Name = "yellowIntervalLabel";
            this.yellowIntervalLabel.Size = new System.Drawing.Size(227, 16);
            this.yellowIntervalLabel.TabIndex = 17;
            this.yellowIntervalLabel.Text = "Введіть час світітння для жовтого";
            this.yellowIntervalLabel.Visible = false;
            // 
            // greenIntervalLabel
            // 
            this.greenIntervalLabel.AutoSize = true;
            this.greenIntervalLabel.Location = new System.Drawing.Point(346, 315);
            this.greenIntervalLabel.Name = "greenIntervalLabel";
            this.greenIntervalLabel.Size = new System.Drawing.Size(235, 16);
            this.greenIntervalLabel.TabIndex = 18;
            this.greenIntervalLabel.Text = "Введіть час світітння для зеленого";
            this.greenIntervalLabel.Visible = false;
            // 
            // redIntervalTextBox
            // 
            this.redIntervalTextBox.Location = new System.Drawing.Point(619, 247);
            this.redIntervalTextBox.Name = "redIntervalTextBox";
            this.redIntervalTextBox.Size = new System.Drawing.Size(64, 22);
            this.redIntervalTextBox.TabIndex = 19;
            this.redIntervalTextBox.Visible = false;
            // 
            // yellowIntervalTextBox
            // 
            this.yellowIntervalTextBox.Location = new System.Drawing.Point(619, 281);
            this.yellowIntervalTextBox.Name = "yellowIntervalTextBox";
            this.yellowIntervalTextBox.Size = new System.Drawing.Size(64, 22);
            this.yellowIntervalTextBox.TabIndex = 20;
            this.yellowIntervalTextBox.Visible = false;
            // 
            // greenIntervalTextBox
            // 
            this.greenIntervalTextBox.Location = new System.Drawing.Point(619, 315);
            this.greenIntervalTextBox.Name = "greenIntervalTextBox";
            this.greenIntervalTextBox.Size = new System.Drawing.Size(64, 22);
            this.greenIntervalTextBox.TabIndex = 21;
            this.greenIntervalTextBox.Visible = false;
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(655, 123);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(163, 35);
            this.switchButton.TabIndex = 22;
            this.switchButton.Text = "Перемкнути";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Visible = false;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // day_timer
            // 
            this.day_timer.Tick += new System.EventHandler(this.day_timer_Tick);
            // 
            // darkLight
            // 
            this.darkLight.Image = global::TrafficLights.Properties.Resources.dark;
            this.darkLight.Location = new System.Drawing.Point(29, 32);
            this.darkLight.Name = "darkLight";
            this.darkLight.Size = new System.Drawing.Size(228, 430);
            this.darkLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.darkLight.TabIndex = 3;
            this.darkLight.TabStop = false;
            // 
            // greenLight
            // 
            this.greenLight.Image = global::TrafficLights.Properties.Resources.green;
            this.greenLight.Location = new System.Drawing.Point(28, 30);
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(229, 429);
            this.greenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greenLight.TabIndex = 2;
            this.greenLight.TabStop = false;
            this.greenLight.Visible = false;
            // 
            // yellowLight
            // 
            this.yellowLight.Image = global::TrafficLights.Properties.Resources.yellow;
            this.yellowLight.Location = new System.Drawing.Point(28, 32);
            this.yellowLight.Name = "yellowLight";
            this.yellowLight.Size = new System.Drawing.Size(227, 427);
            this.yellowLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.yellowLight.TabIndex = 1;
            this.yellowLight.TabStop = false;
            this.yellowLight.Visible = false;
            // 
            // redLight
            // 
            this.redLight.Image = global::TrafficLights.Properties.Resources.red1;
            this.redLight.Location = new System.Drawing.Point(28, 31);
            this.redLight.Name = "redLight";
            this.redLight.Size = new System.Drawing.Size(229, 428);
            this.redLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redLight.TabIndex = 0;
            this.redLight.TabStop = false;
            this.redLight.Visible = false;
            // 
            // dayTimeGroupBox
            // 
            this.dayTimeGroupBox.Controls.Add(this.nightRadioButton);
            this.dayTimeGroupBox.Controls.Add(this.dayRadioButton);
            this.dayTimeGroupBox.Location = new System.Drawing.Point(349, 12);
            this.dayTimeGroupBox.Name = "dayTimeGroupBox";
            this.dayTimeGroupBox.Size = new System.Drawing.Size(232, 54);
            this.dayTimeGroupBox.TabIndex = 23;
            this.dayTimeGroupBox.TabStop = false;
            this.dayTimeGroupBox.Text = "Виберіть пору доби:";
            // 
            // managementGroupBox
            // 
            this.managementGroupBox.Controls.Add(this.dayHandRadioButton);
            this.managementGroupBox.Controls.Add(this.dayAutoRadioButton);
            this.managementGroupBox.Location = new System.Drawing.Point(362, 103);
            this.managementGroupBox.Name = "managementGroupBox";
            this.managementGroupBox.Size = new System.Drawing.Size(239, 53);
            this.managementGroupBox.TabIndex = 24;
            this.managementGroupBox.TabStop = false;
            this.managementGroupBox.Text = "Керування";
            this.managementGroupBox.Visible = false;
            // 
            // intervalOptionGroupBox
            // 
            this.intervalOptionGroupBox.Controls.Add(this.dayDurationNoRadioButton);
            this.intervalOptionGroupBox.Controls.Add(this.dayDurationYesRadioButton);
            this.intervalOptionGroupBox.Location = new System.Drawing.Point(349, 167);
            this.intervalOptionGroupBox.Name = "intervalOptionGroupBox";
            this.intervalOptionGroupBox.Size = new System.Drawing.Size(416, 51);
            this.intervalOptionGroupBox.TabIndex = 25;
            this.intervalOptionGroupBox.TabStop = false;
            this.intervalOptionGroupBox.Text = "Чи бажаєте задати інтервали світітння (в секундах)?";
            this.intervalOptionGroupBox.Visible = false;
            // 
            // TrafficLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 647);
            this.Controls.Add(this.intervalOptionGroupBox);
            this.Controls.Add(this.managementGroupBox);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.dayTimeGroupBox);
            this.Controls.Add(this.greenIntervalTextBox);
            this.Controls.Add(this.yellowIntervalTextBox);
            this.Controls.Add(this.redIntervalTextBox);
            this.Controls.Add(this.greenIntervalLabel);
            this.Controls.Add(this.yellowIntervalLabel);
            this.Controls.Add(this.redIntervalLabel);
            this.Controls.Add(this.NightIntervalTextBox);
            this.Controls.Add(this.NightIntervalLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.darkLight);
            this.Controls.Add(this.greenLight);
            this.Controls.Add(this.yellowLight);
            this.Controls.Add(this.redLight);
            this.Name = "TrafficLights";
            this.Text = "TrafficLights";
            this.Load += new System.EventHandler(this.TrafficLights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).EndInit();
            this.dayTimeGroupBox.ResumeLayout(false);
            this.dayTimeGroupBox.PerformLayout();
            this.managementGroupBox.ResumeLayout(false);
            this.managementGroupBox.PerformLayout();
            this.intervalOptionGroupBox.ResumeLayout(false);
            this.intervalOptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redLight;
        private System.Windows.Forms.PictureBox yellowLight;
        private System.Windows.Forms.PictureBox greenLight;
        private System.Windows.Forms.PictureBox darkLight;
        private System.Windows.Forms.Timer night_timer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.Label NightIntervalLabel;
        private System.Windows.Forms.TextBox NightIntervalTextBox;
        private System.Windows.Forms.RadioButton dayAutoRadioButton;
        private System.Windows.Forms.RadioButton dayHandRadioButton;
        private System.Windows.Forms.RadioButton dayDurationYesRadioButton;
        private System.Windows.Forms.RadioButton dayDurationNoRadioButton;
        private System.Windows.Forms.Label redIntervalLabel;
        private System.Windows.Forms.Label yellowIntervalLabel;
        private System.Windows.Forms.Label greenIntervalLabel;
        private System.Windows.Forms.TextBox redIntervalTextBox;
        private System.Windows.Forms.TextBox yellowIntervalTextBox;
        private System.Windows.Forms.TextBox greenIntervalTextBox;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Timer day_timer;
        private System.Windows.Forms.GroupBox dayTimeGroupBox;
        private System.Windows.Forms.GroupBox managementGroupBox;
        private System.Windows.Forms.GroupBox intervalOptionGroupBox;
    }
}

