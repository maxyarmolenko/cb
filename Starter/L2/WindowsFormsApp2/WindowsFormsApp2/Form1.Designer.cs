﻿namespace WindowsFormsApp2
{
    partial class NumberSystem
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
            this.byte1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // byte1
            // 
            this.byte1.Location = new System.Drawing.Point(189, 63);
            this.byte1.Name = "byte1";
            this.byte1.Size = new System.Drawing.Size(309, 122);
            this.byte1.TabIndex = 0;
            this.byte1.Text = "byte";
            this.byte1.UseVisualStyleBackColor = true;
            this.byte1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 123);
            this.button2.TabIndex = 1;
            this.button2.Text = "sbyte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 127);
            this.button3.TabIndex = 2;
            this.button3.Text = "short";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(183, 573);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 132);
            this.button4.TabIndex = 3;
            this.button4.Text = "ushort";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1014, 61);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(311, 124);
            this.button5.TabIndex = 4;
            this.button5.Text = "int";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1014, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(311, 126);
            this.button6.TabIndex = 5;
            this.button6.Text = "uint";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1010, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(315, 132);
            this.button7.TabIndex = 6;
            this.button7.Text = "long";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1010, 573);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(323, 127);
            this.button8.TabIndex = 7;
            this.button8.Text = "slong";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // NumberSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 799);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.byte1);
            this.Name = "NumberSystem";
            this.Text = "NumberSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button byte1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

