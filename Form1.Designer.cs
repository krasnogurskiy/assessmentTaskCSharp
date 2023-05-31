
using System;

namespace app
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
            this.answerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelBuy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelScoreInt = new System.Windows.Forms.Label();
            this.alphabet_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.answer_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.check_button = new System.Windows.Forms.Button();
            this.tool_panel = new System.Windows.Forms.Panel();
            this.question = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.round_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.player1_score = new System.Windows.Forms.Label();
            this.player1_name = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.player2_score = new System.Windows.Forms.Label();
            this.player2_name = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.player3_score = new System.Windows.Forms.Label();
            this.player3_name = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.status_lb = new System.Windows.Forms.Label();
            this.tool_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // answerBox
            // 
            this.answerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.answerBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerBox.Location = new System.Drawing.Point(544, 7);
            this.answerBox.Margin = new System.Windows.Forms.Padding(4);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(187, 31);
            this.answerBox.TabIndex = 35;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(326, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Знаєте повну відповідь?";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBuy.BackColor = System.Drawing.Color.Gold;
            this.buttonBuy.FlatAppearance.BorderSize = 0;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBuy.Location = new System.Drawing.Point(159, 5);
            this.buttonBuy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(114, 32);
            this.buttonBuy.TabIndex = 37;
            this.buttonBuy.Text = "Купити";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelBuy
            // 
            this.labelBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBuy.AutoSize = true;
            this.labelBuy.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuy.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBuy.Location = new System.Drawing.Point(14, 14);
            this.labelBuy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(128, 19);
            this.labelBuy.TabIndex = 38;
            this.labelBuy.Text = "Голосна літера";
            this.labelBuy.Click += new System.EventHandler(this.labelBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(1065, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Бали:";
            // 
            // labelScoreInt
            // 
            this.labelScoreInt.AutoSize = true;
            this.labelScoreInt.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreInt.ForeColor = System.Drawing.Color.Gold;
            this.labelScoreInt.Location = new System.Drawing.Point(1176, 239);
            this.labelScoreInt.Name = "labelScoreInt";
            this.labelScoreInt.Size = new System.Drawing.Size(24, 25);
            this.labelScoreInt.TabIndex = 43;
            this.labelScoreInt.Text = "0";
            // 
            // alphabet_panel
            // 
            this.alphabet_panel.Location = new System.Drawing.Point(80, 346);
            this.alphabet_panel.Name = "alphabet_panel";
            this.alphabet_panel.Size = new System.Drawing.Size(648, 206);
            this.alphabet_panel.TabIndex = 45;
            // 
            // answer_panel
            // 
            this.answer_panel.Location = new System.Drawing.Point(80, 248);
            this.answer_panel.Name = "answer_panel";
            this.answer_panel.Size = new System.Drawing.Size(648, 58);
            this.answer_panel.TabIndex = 46;
            this.answer_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.answer_panel_Paint);
            // 
            // check_button
            // 
            this.check_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.check_button.BackColor = System.Drawing.Color.Gold;
            this.check_button.FlatAppearance.BorderSize = 0;
            this.check_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check_button.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.check_button.Location = new System.Drawing.Point(566, 46);
            this.check_button.Margin = new System.Windows.Forms.Padding(4);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(140, 32);
            this.check_button.TabIndex = 47;
            this.check_button.Text = "Перевірити";
            this.check_button.UseVisualStyleBackColor = false;
            this.check_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // tool_panel
            // 
            this.tool_panel.Controls.Add(this.labelBuy);
            this.tool_panel.Controls.Add(this.check_button);
            this.tool_panel.Controls.Add(this.buttonBuy);
            this.tool_panel.Controls.Add(this.label1);
            this.tool_panel.Controls.Add(this.answerBox);
            this.tool_panel.Location = new System.Drawing.Point(42, 583);
            this.tool_panel.Name = "tool_panel";
            this.tool_panel.Size = new System.Drawing.Size(783, 100);
            this.tool_panel.TabIndex = 48;
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.question.ForeColor = System.Drawing.Color.Gold;
            this.question.Location = new System.Drawing.Point(76, 138);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(306, 23);
            this.question.TabIndex = 49;
            this.question.Text = "Питання: Яка столиця Франції?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(76, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 50;
            this.label5.Text = "Відповідь:";
            // 
            // round_lb
            // 
            this.round_lb.AutoSize = true;
            this.round_lb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.round_lb.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.round_lb.ForeColor = System.Drawing.Color.Gold;
            this.round_lb.Location = new System.Drawing.Point(394, 49);
            this.round_lb.Name = "round_lb";
            this.round_lb.Size = new System.Drawing.Size(120, 33);
            this.round_lb.TabIndex = 51;
            this.round_lb.Text = "Раунд 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.player1_score);
            this.panel1.Controls.Add(this.player1_name);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(884, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 117);
            this.panel1.TabIndex = 52;
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_score.ForeColor = System.Drawing.Color.White;
            this.player1_score.Location = new System.Drawing.Point(20, 88);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(62, 16);
            this.player1_score.TabIndex = 55;
            this.player1_score.Text = "Рахунок";
            // 
            // player1_name
            // 
            this.player1_name.AutoSize = true;
            this.player1_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player1_name.ForeColor = System.Drawing.Color.White;
            this.player1_name.Location = new System.Drawing.Point(20, 58);
            this.player1_name.Name = "player1_name";
            this.player1_name.Size = new System.Drawing.Size(74, 16);
            this.player1_name.TabIndex = 54;
            this.player1_name.Text = "Гравець 1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::app.Properties.Resources._1;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(32, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.player2_score);
            this.panel2.Controls.Add(this.player2_name);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(1047, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 117);
            this.panel2.TabIndex = 53;
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_score.ForeColor = System.Drawing.Color.White;
            this.player2_score.Location = new System.Drawing.Point(20, 88);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(62, 16);
            this.player2_score.TabIndex = 55;
            this.player2_score.Text = "Рахунок";
            // 
            // player2_name
            // 
            this.player2_name.AutoSize = true;
            this.player2_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player2_name.ForeColor = System.Drawing.Color.White;
            this.player2_name.Location = new System.Drawing.Point(20, 58);
            this.player2_name.Name = "player2_name";
            this.player2_name.Size = new System.Drawing.Size(74, 16);
            this.player2_name.TabIndex = 54;
            this.player2_name.Text = "Гравець 2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::app.Properties.Resources._2;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(32, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 53;
            this.pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.player3_score);
            this.panel3.Controls.Add(this.player3_name);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(1202, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 117);
            this.panel3.TabIndex = 54;
            // 
            // player3_score
            // 
            this.player3_score.AutoSize = true;
            this.player3_score.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_score.ForeColor = System.Drawing.Color.White;
            this.player3_score.Location = new System.Drawing.Point(20, 88);
            this.player3_score.Name = "player3_score";
            this.player3_score.Size = new System.Drawing.Size(62, 16);
            this.player3_score.TabIndex = 55;
            this.player3_score.Text = "Рахунок";
            // 
            // player3_name
            // 
            this.player3_name.AutoSize = true;
            this.player3_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.player3_name.ForeColor = System.Drawing.Color.White;
            this.player3_name.Location = new System.Drawing.Point(20, 58);
            this.player3_name.Name = "player3_name";
            this.player3_name.Size = new System.Drawing.Size(74, 16);
            this.player3_name.TabIndex = 54;
            this.player3_name.Text = "Гравець 3";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::app.Properties.Resources._3;
            this.pictureBox5.InitialImage = null;
            this.pictureBox5.Location = new System.Drawing.Point(32, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 53;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::app.Properties.Resources.Red_Triangle;
            this.pictureBox2.Location = new System.Drawing.Point(1132, 269);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 22);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::app.Properties.Resources.kolo;
            this.pictureBox1.Location = new System.Drawing.Point(963, 299);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // status_lb
            // 
            this.status_lb.AutoSize = true;
            this.status_lb.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.status_lb.ForeColor = System.Drawing.Color.Gold;
            this.status_lb.Location = new System.Drawing.Point(879, 192);
            this.status_lb.Name = "status_lb";
            this.status_lb.Size = new System.Drawing.Size(0, 25);
            this.status_lb.TabIndex = 55;
            // 
            // MainForm
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.status_lb);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.round_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.question);
            this.Controls.Add(this.tool_panel);
            this.Controls.Add(this.answer_panel);
            this.Controls.Add(this.alphabet_panel);
            this.Controls.Add(this.labelScoreInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Колесо Фортуни";
            this.tool_panel.ResumeLayout(false);
            this.tool_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Label labelBuy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelScoreInt;
        private System.Windows.Forms.FlowLayoutPanel alphabet_panel;
        private System.Windows.Forms.FlowLayoutPanel answer_panel;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Panel tool_panel;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label round_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label player1_score;
        private System.Windows.Forms.Label player1_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label player2_score;
        private System.Windows.Forms.Label player2_name;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label player3_score;
        private System.Windows.Forms.Label player3_name;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label status_lb;
    }
}

