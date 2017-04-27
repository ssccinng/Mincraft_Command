namespace Mincraft_Command
{
    partial class Image_Model_set
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Draw_z = new System.Windows.Forms.RadioButton();
            this.Draw_x = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Draw_mode2 = new System.Windows.Forms.CheckBox();
            this.Draw_mode1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.level = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Height1 = new System.Windows.Forms.Label();
            this.Width1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Center_z = new System.Windows.Forms.TextBox();
            this.Center_y = new System.Windows.Forms.TextBox();
            this.Center_x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Draw_z);
            this.groupBox1.Controls.Add(this.Draw_x);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择在哪个轴上绘制:";
            // 
            // Draw_z
            // 
            this.Draw_z.AutoSize = true;
            this.Draw_z.Location = new System.Drawing.Point(99, 20);
            this.Draw_z.Name = "Draw_z";
            this.Draw_z.Size = new System.Drawing.Size(29, 16);
            this.Draw_z.TabIndex = 0;
            this.Draw_z.Text = "z";
            this.Draw_z.UseVisualStyleBackColor = true;
            // 
            // Draw_x
            // 
            this.Draw_x.AutoSize = true;
            this.Draw_x.Checked = true;
            this.Draw_x.Location = new System.Drawing.Point(31, 20);
            this.Draw_x.Name = "Draw_x";
            this.Draw_x.Size = new System.Drawing.Size(29, 16);
            this.Draw_x.TabIndex = 0;
            this.Draw_x.TabStop = true;
            this.Draw_x.Text = "x";
            this.Draw_x.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Draw_mode2);
            this.groupBox2.Controls.Add(this.Draw_mode1);
            this.groupBox2.Location = new System.Drawing.Point(12, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "请选择绘图模式:";
            // 
            // Draw_mode2
            // 
            this.Draw_mode2.AutoSize = true;
            this.Draw_mode2.Location = new System.Drawing.Point(31, 42);
            this.Draw_mode2.Name = "Draw_mode2";
            this.Draw_mode2.Size = new System.Drawing.Size(72, 16);
            this.Draw_mode2.TabIndex = 0;
            this.Draw_mode2.Text = "水平翻转";
            this.Draw_mode2.UseVisualStyleBackColor = true;
            // 
            // Draw_mode1
            // 
            this.Draw_mode1.AutoSize = true;
            this.Draw_mode1.Location = new System.Drawing.Point(31, 20);
            this.Draw_mode1.Name = "Draw_mode1";
            this.Draw_mode1.Size = new System.Drawing.Size(72, 16);
            this.Draw_mode1.TabIndex = 0;
            this.Draw_mode1.Text = "垂直翻转";
            this.Draw_mode1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.level);
            this.groupBox3.Location = new System.Drawing.Point(12, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 47);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "是否平摊";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(93, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "否";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Checked = true;
            this.level.Location = new System.Drawing.Point(25, 20);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(35, 16);
            this.level.TabIndex = 0;
            this.level.TabStop = true;
            this.level.Text = "是";
            this.level.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Height1);
            this.groupBox4.Controls.Add(this.Width1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.Center_z);
            this.groupBox4.Controls.Add(this.Center_y);
            this.groupBox4.Controls.Add(this.Center_x);
            this.groupBox4.Location = new System.Drawing.Point(195, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 171);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "请输入命令方块位于文字图片的何位置(默认图片左下角为0,0,0)";
            // 
            // Height1
            // 
            this.Height1.AutoSize = true;
            this.Height1.Location = new System.Drawing.Point(134, 42);
            this.Height1.Name = "Height1";
            this.Height1.Size = new System.Drawing.Size(0, 12);
            this.Height1.TabIndex = 5;
            // 
            // Width1
            // 
            this.Width1.AutoSize = true;
            this.Width1.Location = new System.Drawing.Point(38, 42);
            this.Width1.Name = "Width1";
            this.Width1.Size = new System.Drawing.Size(0, 12);
            this.Width1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            // 
            // Center_z
            // 
            this.Center_z.Location = new System.Drawing.Point(79, 126);
            this.Center_z.Name = "Center_z";
            this.Center_z.Size = new System.Drawing.Size(100, 21);
            this.Center_z.TabIndex = 0;
            // 
            // Center_y
            // 
            this.Center_y.Location = new System.Drawing.Point(79, 99);
            this.Center_y.Name = "Center_y";
            this.Center_y.Size = new System.Drawing.Size(100, 21);
            this.Center_y.TabIndex = 0;
            // 
            // Center_x
            // 
            this.Center_x.Location = new System.Drawing.Point(79, 72);
            this.Center_x.Name = "Center_x";
            this.Center_x.Size = new System.Drawing.Size(100, 21);
            this.Center_x.TabIndex = 0;
            this.Center_x.TextChanged += new System.EventHandler(this.Center_x_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Image_Model_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Image_Model_set";
            this.Text = "Image_Model_set";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Image_Model_set_FormClosing);
            this.Load += new System.EventHandler(this.Image_Model_set_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Draw_z;
        private System.Windows.Forms.RadioButton Draw_x;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Draw_mode2;
        private System.Windows.Forms.CheckBox Draw_mode1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton level;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Center_z;
        private System.Windows.Forms.TextBox Center_y;
        private System.Windows.Forms.TextBox Center_x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Height1;
        private System.Windows.Forms.Label Width1;
    }
}