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
            this.alarmScheduleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.addAlarm.Text = "Add An Alarm";
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
            // alarmScheduleLabel
            // 
            this.alarmScheduleLabel.AutoSize = true;
            this.alarmScheduleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.alarmScheduleLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmScheduleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.alarmScheduleLabel.Location = new System.Drawing.Point(391, 182);
            this.alarmScheduleLabel.Name = "alarmScheduleLabel";
            this.alarmScheduleLabel.Size = new System.Drawing.Size(229, 19);
            this.alarmScheduleLabel.TabIndex = 14;
            this.alarmScheduleLabel.Text = "Do Task From: 0:00 to 0:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(956, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "You Should Do Homework For 3600 More Seconds";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.alarmScheduleLabel);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.alarmName);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.addAlarm);
            this.Controls.Add(this.setTimer);
            this.Controls.Add(this.setLength);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Focus";
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
        private System.Windows.Forms.Label alarmScheduleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Timer;
    }
}