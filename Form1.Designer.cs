using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fcfscheck = new System.Windows.Forms.CheckBox();
            this.sjfcheck = new System.Windows.Forms.CheckBox();
            this.prioritycheck = new System.Windows.Forms.CheckBox();
            this.RRcheck = new System.Windows.Forms.CheckBox();
            this.processesnumber = new System.Windows.Forms.TextBox();
            this.waitinglable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nonpreemcheck = new System.Windows.Forms.CheckBox();
            this.preemptivecheck = new System.Windows.Forms.CheckBox();
            this.timelabel = new System.Windows.Forms.Label();
            this.timetextbox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gantchart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "choose the name of schedular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter number of processes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(885, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "waiting time ";
            // 
            // Fcfscheck
            // 
            this.Fcfscheck.AutoSize = true;
            this.Fcfscheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fcfscheck.Location = new System.Drawing.Point(13, 33);
            this.Fcfscheck.Name = "Fcfscheck";
            this.Fcfscheck.Size = new System.Drawing.Size(70, 22);
            this.Fcfscheck.TabIndex = 3;
            this.Fcfscheck.Text = "FCFS";
            this.Fcfscheck.UseVisualStyleBackColor = true;
            // 
            // sjfcheck
            // 
            this.sjfcheck.AutoSize = true;
            this.sjfcheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sjfcheck.Location = new System.Drawing.Point(103, 33);
            this.sjfcheck.Name = "sjfcheck";
            this.sjfcheck.Size = new System.Drawing.Size(56, 22);
            this.sjfcheck.TabIndex = 4;
            this.sjfcheck.Text = "SJF";
            this.sjfcheck.UseVisualStyleBackColor = true;
            this.sjfcheck.CheckedChanged += new System.EventHandler(this.sjfcheck_CheckedChanged);
            // 
            // prioritycheck
            // 
            this.prioritycheck.AutoSize = true;
            this.prioritycheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prioritycheck.Location = new System.Drawing.Point(183, 33);
            this.prioritycheck.Name = "prioritycheck";
            this.prioritycheck.Size = new System.Drawing.Size(76, 22);
            this.prioritycheck.TabIndex = 5;
            this.prioritycheck.Text = "Priority";
            this.prioritycheck.UseVisualStyleBackColor = true;
            this.prioritycheck.CheckedChanged += new System.EventHandler(this.prioritycheck_CheckedChanged);
            // 
            // RRcheck
            // 
            this.RRcheck.AutoSize = true;
            this.RRcheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRcheck.Location = new System.Drawing.Point(271, 33);
            this.RRcheck.Name = "RRcheck";
            this.RRcheck.Size = new System.Drawing.Size(49, 22);
            this.RRcheck.TabIndex = 6;
            this.RRcheck.Text = "RR";
            this.RRcheck.UseVisualStyleBackColor = true;
            this.RRcheck.CheckedChanged += new System.EventHandler(this.RRcheck_CheckedChanged);
            // 
            // processesnumber
            // 
            this.processesnumber.Location = new System.Drawing.Point(202, 72);
            this.processesnumber.Name = "processesnumber";
            this.processesnumber.Size = new System.Drawing.Size(100, 20);
            this.processesnumber.TabIndex = 7;
            // 
            // waitinglable
            // 
            this.waitinglable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waitinglable.Location = new System.Drawing.Point(880, 517);
            this.waitinglable.Name = "waitinglable";
            this.waitinglable.Size = new System.Drawing.Size(100, 23);
            this.waitinglable.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(772, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nonpreemcheck
            // 
            this.nonpreemcheck.AutoSize = true;
            this.nonpreemcheck.Enabled = false;
            this.nonpreemcheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonpreemcheck.Location = new System.Drawing.Point(120, 132);
            this.nonpreemcheck.Name = "nonpreemcheck";
            this.nonpreemcheck.Size = new System.Drawing.Size(130, 22);
            this.nonpreemcheck.TabIndex = 12;
            this.nonpreemcheck.Text = "nonpreemptive";
            this.nonpreemcheck.UseVisualStyleBackColor = true;
            // 
            // preemptivecheck
            // 
            this.preemptivecheck.AutoSize = true;
            this.preemptivecheck.Enabled = false;
            this.preemptivecheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preemptivecheck.Location = new System.Drawing.Point(13, 132);
            this.preemptivecheck.Name = "preemptivecheck";
            this.preemptivecheck.Size = new System.Drawing.Size(105, 22);
            this.preemptivecheck.TabIndex = 13;
            this.preemptivecheck.Text = "preemptive";
            this.preemptivecheck.UseVisualStyleBackColor = true;
           
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Enabled = false;
            this.timelabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelabel.Location = new System.Drawing.Point(10, 181);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(105, 18);
            this.timelabel.TabIndex = 14;
            this.timelabel.Text = "Time quantum";
            // 
            // timetextbox
            // 
            this.timetextbox.Enabled = false;
            this.timetextbox.Location = new System.Drawing.Point(116, 182);
            this.timetextbox.Name = "timetextbox";
            this.timetextbox.Size = new System.Drawing.Size(100, 20);
            this.timetextbox.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(789, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 259);
            this.textBox1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(789, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Press to enter arrival and brust time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gantchart
            // 
            this.gantchart.Location = new System.Drawing.Point(13, 326);
            this.gantchart.Multiline = true;
            this.gantchart.Name = "gantchart";
            this.gantchart.Size = new System.Drawing.Size(967, 132);
            this.gantchart.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gantt chart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 566);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gantchart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.timetextbox);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.preemptivecheck);
            this.Controls.Add(this.nonpreemcheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.waitinglable);
            this.Controls.Add(this.processesnumber);
            this.Controls.Add(this.RRcheck);
            this.Controls.Add(this.prioritycheck);
            this.Controls.Add(this.sjfcheck);
            this.Controls.Add(this.Fcfscheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Processes scheduling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Fcfscheck;
        private System.Windows.Forms.CheckBox sjfcheck;
        private System.Windows.Forms.CheckBox prioritycheck;
        private System.Windows.Forms.CheckBox RRcheck;
        private System.Windows.Forms.TextBox processesnumber;
        private System.Windows.Forms.Label waitinglable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox nonpreemcheck;
        private System.Windows.Forms.CheckBox preemptivecheck;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.TextBox timetextbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private TextBox gantchart;
        private Label label4;
    }
}

