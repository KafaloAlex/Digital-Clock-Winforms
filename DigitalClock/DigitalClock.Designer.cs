namespace DigitalClock
{
    partial class DigitalClock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPm = new System.Windows.Forms.Label();
            this.lblSnde = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblPm);
            this.panel1.Controls.Add(this.lblSnde);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 423);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DS-Digital", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(330, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "DIGITAL CLOCK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDay
            // 
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDay.Font = new System.Drawing.Font("DS-Digital", 38F, System.Drawing.FontStyle.Italic);
            this.lblDay.Location = new System.Drawing.Point(564, 312);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(347, 65);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "JEUDI";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("DS-Digital", 38F, System.Drawing.FontStyle.Italic);
            this.lblDate.Location = new System.Drawing.Point(27, 312);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(347, 65);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "10/07/2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPm
            // 
            this.lblPm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPm.Font = new System.Drawing.Font("DS-Digital", 38F, System.Drawing.FontStyle.Italic);
            this.lblPm.Location = new System.Drawing.Point(623, 182);
            this.lblPm.Name = "lblPm";
            this.lblPm.Size = new System.Drawing.Size(154, 65);
            this.lblPm.TabIndex = 2;
            this.lblPm.Text = "AM";
            this.lblPm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSnde
            // 
            this.lblSnde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSnde.Font = new System.Drawing.Font("DS-Digital", 38F, System.Drawing.FontStyle.Italic);
            this.lblSnde.Location = new System.Drawing.Point(623, 97);
            this.lblSnde.Name = "lblSnde";
            this.lblSnde.Size = new System.Drawing.Size(154, 74);
            this.lblSnde.TabIndex = 1;
            this.lblSnde.Text = "00";
            this.lblSnde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("DS-Digital", 70F, System.Drawing.FontStyle.Italic);
            this.lblTime.Location = new System.Drawing.Point(269, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(376, 178);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DigitalClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(957, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DigitalClock";
            this.Text = "DigitalClock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPm;
        private System.Windows.Forms.Label lblSnde;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}