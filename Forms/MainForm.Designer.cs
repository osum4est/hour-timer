using System.ComponentModel;

namespace HourTimer.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.StartLargeTimer = new System.Windows.Forms.Button();
            this.StartSmallTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.TimerLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerSetup = new System.Windows.Forms.GroupBox();
            this.StartNow = new System.Windows.Forms.CheckBox();
            this.TimerDataBinding = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimerLength)).BeginInit();
            this.TimerSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDataBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // StartLargeTimer
            // 
            this.StartLargeTimer.Location = new System.Drawing.Point(19, 203);
            this.StartLargeTimer.Margin = new System.Windows.Forms.Padding(10);
            this.StartLargeTimer.Name = "StartLargeTimer";
            this.StartLargeTimer.Size = new System.Drawing.Size(451, 46);
            this.StartLargeTimer.TabIndex = 0;
            this.StartLargeTimer.Text = "Start Large Timer";
            this.StartLargeTimer.UseVisualStyleBackColor = true;
            this.StartLargeTimer.Click += new System.EventHandler(this.StartLargeTimer_Click);
            // 
            // StartSmallTimer
            // 
            this.StartSmallTimer.Location = new System.Drawing.Point(19, 269);
            this.StartSmallTimer.Margin = new System.Windows.Forms.Padding(10);
            this.StartSmallTimer.Name = "StartSmallTimer";
            this.StartSmallTimer.Size = new System.Drawing.Size(451, 46);
            this.StartSmallTimer.TabIndex = 1;
            this.StartSmallTimer.Text = "Start Small Timer";
            this.StartSmallTimer.UseVisualStyleBackColor = true;
            this.StartSmallTimer.Click += new System.EventHandler(this.StartSmallTimer_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(141, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timer Length:";
            // 
            // StartDate
            // 
            this.StartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.TimerDataBinding, "StartDate", true));
            this.StartDate.Location = new System.Drawing.Point(145, 117);
            this.StartDate.Margin = new System.Windows.Forms.Padding(10);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(292, 26);
            this.StartDate.TabIndex = 4;
            this.StartDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // StartTime
            // 
            this.StartTime.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.TimerDataBinding, "StartDate", true));
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTime.Location = new System.Drawing.Point(145, 73);
            this.StartTime.Margin = new System.Windows.Forms.Padding(10);
            this.StartTime.Name = "StartTime";
            this.StartTime.ShowUpDown = true;
            this.StartTime.Size = new System.Drawing.Size(292, 26);
            this.StartTime.TabIndex = 5;
            this.StartTime.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // TimerLength
            // 
            this.TimerLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.TimerDataBinding, "TimerLength", true));
            this.TimerLength.Location = new System.Drawing.Point(275, 33);
            this.TimerLength.Margin = new System.Windows.Forms.Padding(10);
            this.TimerLength.Name = "TimerLength";
            this.TimerLength.Size = new System.Drawing.Size(162, 26);
            this.TimerLength.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date:";
            // 
            // TimerSetup
            // 
            this.TimerSetup.Controls.Add(this.StartNow);
            this.TimerSetup.Controls.Add(this.label1);
            this.TimerSetup.Controls.Add(this.label3);
            this.TimerSetup.Controls.Add(this.label2);
            this.TimerSetup.Controls.Add(this.TimerLength);
            this.TimerSetup.Controls.Add(this.StartDate);
            this.TimerSetup.Controls.Add(this.StartTime);
            this.TimerSetup.Location = new System.Drawing.Point(19, 19);
            this.TimerSetup.Margin = new System.Windows.Forms.Padding(10);
            this.TimerSetup.Name = "TimerSetup";
            this.TimerSetup.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimerSetup.Size = new System.Drawing.Size(451, 164);
            this.TimerSetup.TabIndex = 9;
            this.TimerSetup.TabStop = false;
            this.TimerSetup.Text = "Timer Setup";
            // 
            // StartNow
            // 
            this.StartNow.AutoSize = true;
            this.StartNow.Location = new System.Drawing.Point(14, 34);
            this.StartNow.Margin = new System.Windows.Forms.Padding(10);
            this.StartNow.Name = "StartNow";
            this.StartNow.Size = new System.Drawing.Size(98, 24);
            this.StartNow.TabIndex = 9;
            this.StartNow.Text = "Start Now";
            this.StartNow.UseVisualStyleBackColor = true;
            this.StartNow.CheckedChanged += new System.EventHandler(this.StartNow_CheckedChanged);
            // 
            // TimerDataBinding
            // 
            this.TimerDataBinding.DataSource = typeof(HourTimer.TimerData);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 340);
            this.Controls.Add(this.TimerSetup);
            this.Controls.Add(this.StartSmallTimer);
            this.Controls.Add(this.StartLargeTimer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Hour Timer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimerLength)).EndInit();
            this.TimerSetup.ResumeLayout(false);
            this.TimerSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDataBinding)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartLargeTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Button StartSmallTimer;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.NumericUpDown TimerLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox TimerSetup;
        private System.Windows.Forms.CheckBox StartNow;
        private System.Windows.Forms.BindingSource TimerDataBinding;
    }
}