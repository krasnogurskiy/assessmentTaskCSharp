﻿
using System;

namespace app
{
    partial class WelcomeForm
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
            this.start_bt = new System.Windows.Forms.Button();
            this.player1_tb = new System.Windows.Forms.TextBox();
            this.player2_tb = new System.Windows.Forms.TextBox();
            this.player3_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.level_cb = new System.Windows.Forms.ComboBox();
            this.player3_cb = new System.Windows.Forms.CheckBox();
            this.player2_cb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_bt
            // 
            this.start_bt.FlatAppearance.BorderSize = 0;
            this.start_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bt.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start_bt.ForeColor = System.Drawing.Color.Gold;
            this.start_bt.Location = new System.Drawing.Point(252, 537);
            this.start_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start_bt.Name = "start_bt";
            this.start_bt.Size = new System.Drawing.Size(164, 49);
            this.start_bt.TabIndex = 0;
            this.start_bt.Text = "Почати";
            this.start_bt.UseVisualStyleBackColor = true;
            // 
            // player1_tb
            // 
            this.player1_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player1_tb.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1_tb.Location = new System.Drawing.Point(229, 149);
            this.player1_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player1_tb.Name = "player1_tb";
            this.player1_tb.Size = new System.Drawing.Size(187, 33);
            this.player1_tb.TabIndex = 1;
            // 
            // player2_tb
            // 
            this.player2_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player2_tb.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2_tb.Location = new System.Drawing.Point(229, 207);
            this.player2_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2_tb.Name = "player2_tb";
            this.player2_tb.Size = new System.Drawing.Size(187, 33);
            this.player2_tb.TabIndex = 2;
            // 
            // player3_tb
            // 
            this.player3_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.player3_tb.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player3_tb.Location = new System.Drawing.Point(229, 278);
            this.player3_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player3_tb.Name = "player3_tb";
            this.player3_tb.Size = new System.Drawing.Size(187, 33);
            this.player3_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(151, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вітаємо";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.level_cb);
            this.panel1.Controls.Add(this.player3_cb);
            this.panel1.Controls.Add(this.player2_cb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.start_bt);
            this.panel1.Controls.Add(this.player3_tb);
            this.panel1.Controls.Add(this.player1_tb);
            this.panel1.Controls.Add(this.player2_tb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 640);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(45, 431);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "складності";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(31, 400);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Оберіть рівень";
            // 
            // level_cb
            // 
            this.level_cb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level_cb.FormattingEnabled = true;
            this.level_cb.Items.AddRange(new object[] {
            "Легкий",
            "Середній",
            "Складний"});
            this.level_cb.Location = new System.Drawing.Point(229, 410);
            this.level_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level_cb.Name = "level_cb";
            this.level_cb.Size = new System.Drawing.Size(160, 27);
            this.level_cb.TabIndex = 13;
            // 
            // player3_cb
            // 
            this.player3_cb.AutoSize = true;
            this.player3_cb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_cb.ForeColor = System.Drawing.Color.Gold;
            this.player3_cb.Location = new System.Drawing.Point(229, 318);
            this.player3_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player3_cb.Name = "player3_cb";
            this.player3_cb.Size = new System.Drawing.Size(92, 23);
            this.player3_cb.TabIndex = 12;
            this.player3_cb.Text = "Відсутній";
            this.player3_cb.UseVisualStyleBackColor = true;
            // 
            // player2_cb
            // 
            this.player2_cb.AutoSize = true;
            this.player2_cb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_cb.ForeColor = System.Drawing.Color.Gold;
            this.player2_cb.Location = new System.Drawing.Point(229, 246);
            this.player2_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player2_cb.Name = "player2_cb";
            this.player2_cb.Size = new System.Drawing.Size(92, 23);
            this.player2_cb.TabIndex = 11;
            this.player2_cb.Text = "Відсутній";
            this.player2_cb.UseVisualStyleBackColor = true;
            this.player2_cb.CheckedChanged += new System.EventHandler(this.player2_cb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(252, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(20, 537);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Завершити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(16, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ім\'я третього гравця";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я другого гравця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ім\'я першого гравця";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::app.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1103, 640);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomeForm";
            this.Text = "Колесо фортуни";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void player2_cb_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button start_bt;
        private System.Windows.Forms.TextBox player1_tb;
        private System.Windows.Forms.TextBox player2_tb;
        private System.Windows.Forms.TextBox player3_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox level_cb;
        private System.Windows.Forms.CheckBox player3_cb;
        private System.Windows.Forms.CheckBox player2_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}