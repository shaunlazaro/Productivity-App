namespace GetOnTrack
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.setLength = new System.Windows.Forms.Button();
            this.setTimer = new System.Windows.Forms.Button();
            this.addAlarm = new System.Windows.Forms.Button();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.alarmName = new System.Windows.Forms.TextBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.instructionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timerSound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Focus";
            // 
            // setLength
            // 
            this.setLength.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLength.Location = new System.Drawing.Point(291, 260);
            this.setLength.Name = "setLength";
            this.setLength.Size = new System.Drawing.Size(132, 23);
            this.setLength.TabIndex = 3;
            this.setLength.Text = "Set Length";
            this.setLength.UseVisualStyleBackColor = true;
            this.setLength.Click += new System.EventHandler(this.setLength_Click);
            // 
            // setTimer
            // 
            this.setTimer.Enabled = false;
            this.setTimer.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setTimer.Location = new System.Drawing.Point(567, 260);
            this.setTimer.Name = "setTimer";
            this.setTimer.Size = new System.Drawing.Size(132, 23);
            this.setTimer.TabIndex = 5;
            this.setTimer.Text = "Start Timer";
            this.setTimer.UseVisualStyleBackColor = true;
            this.setTimer.Click += new System.EventHandler(this.setTimer_Click);
            // 
            // addAlarm
            // 
            this.addAlarm.Enabled = false;
            this.addAlarm.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAlarm.Location = new System.Drawing.Point(429, 260);
            this.addAlarm.Name = "addAlarm";
            this.addAlarm.Size = new System.Drawing.Size(132, 23);
            this.addAlarm.TabIndex = 6;
            this.addAlarm.Text = "Set Task";
            this.addAlarm.UseVisualStyleBackColor = true;
            this.addAlarm.Click += new System.EventHandler(this.addAlarm_Click);
            // 
            // lengthInput
            // 
            this.lengthInput.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthInput.ForeColor = System.Drawing.Color.Lime;
            this.lengthInput.Location = new System.Drawing.Point(291, 289);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(132, 21);
            this.lengthInput.TabIndex = 7;
            this.lengthInput.Text = "60:00";
            this.lengthInput.TextChanged += new System.EventHandler(this.lengthInput_TextChanged);
            // 
            // alarmName
            // 
            this.alarmName.Enabled = false;
            this.alarmName.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmName.ForeColor = System.Drawing.Color.Lime;
            this.alarmName.Location = new System.Drawing.Point(429, 289);
            this.alarmName.Name = "alarmName";
            this.alarmName.Size = new System.Drawing.Size(132, 21);
            this.alarmName.TabIndex = 10;
            this.alarmName.Text = "Do Homework";
            this.alarmName.TextChanged += new System.EventHandler(this.alarmName_TextChanged);
            // 
            // progressBar2
            // 
            this.progressBar2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar2.Location = new System.Drawing.Point(22, 204);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(960, 50);
            this.progressBar2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(886, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "You will Do Homework for 3600 more seconds";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("DengXian", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(850, 9);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(132, 23);
            this.Back.TabIndex = 16;
            this.Back.Text = "Back/Cancel Timer";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "How long you\r\nwant to do task\r\n";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "The task that\ryou will perform\r\n";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "This starts the timer\r\nwhen the bottom is green";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 54);
            this.label6.TabIndex = 20;
            this.label6.Text = "What your task is:\r\nRed means not ready\r\nGreen means ready";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "This bar shows how much time is left\r\n";
            this.label7.Visible = false;
            // 
            // instructionButton
            // 
            this.instructionButton.Location = new System.Drawing.Point(850, 37);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(132, 23);
            this.instructionButton.TabIndex = 22;
            this.instructionButton.Text = "Show Instructions";
            this.instructionButton.UseVisualStyleBackColor = true;
            this.instructionButton.Click += new System.EventHandler(this.instructionButton_Click);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 31);
            this.label8.TabIndex = 23;
            this.label8.Text = "How To Operate:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(182, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(589, 108);
            this.label9.TabIndex = 24;
            this.label9.Text = resources.GetString("label9.Text");
            this.label9.Visible = false;
            // 
            // timerSound
            // 
            this.timerSound.AutoSize = true;
            this.timerSound.Checked = true;
            this.timerSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timerSound.Location = new System.Drawing.Point(404, 184);
            this.timerSound.Name = "timerSound";
            this.timerSound.Size = new System.Drawing.Size(167, 17);
            this.timerSound.TabIndex = 25;
            this.timerSound.Text = "Play sound when timer Is over";
            this.timerSound.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.timerSound);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.instructionButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.alarmName);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.addAlarm);
            this.Controls.Add(this.setTimer);
            this.Controls.Add(this.setLength);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ontrack Focus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setLength;
        private System.Windows.Forms.Button setTimer;
        private System.Windows.Forms.Button addAlarm;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.TextBox alarmName;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox timerSound;
    }
}