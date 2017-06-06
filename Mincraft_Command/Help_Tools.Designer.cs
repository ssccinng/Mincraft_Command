namespace Mincraft_Command
{
    partial class Help_Tools
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
            this.GIFImage_Path = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GIF_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GIF_Break = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GIF_Break);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GIF_Path);
            this.groupBox1.Controls.Add(this.GIFImage_Path);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GIF图片拆解";
            // 
            // GIFImage_Path
            // 
            this.GIFImage_Path.Location = new System.Drawing.Point(20, 51);
            this.GIFImage_Path.Name = "GIFImage_Path";
            this.GIFImage_Path.Size = new System.Drawing.Size(136, 21);
            this.GIFImage_Path.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(163, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "选择GIF图片路径";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GIF_Path
            // 
            this.GIF_Path.Location = new System.Drawing.Point(20, 104);
            this.GIF_Path.Name = "GIF_Path";
            this.GIF_Path.Size = new System.Drawing.Size(136, 21);
            this.GIF_Path.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择生成文件夹路径";
            // 
            // GIF_Break
            // 
            this.GIF_Break.Location = new System.Drawing.Point(62, 131);
            this.GIF_Break.Name = "GIF_Break";
            this.GIF_Break.Size = new System.Drawing.Size(75, 23);
            this.GIF_Break.TabIndex = 1;
            this.GIF_Break.Text = "生成";
            this.GIF_Break.UseVisualStyleBackColor = true;
            this.GIF_Break.Click += new System.EventHandler(this.GIF_Break_Click);
            // 
            // Help_Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 525);
            this.Controls.Add(this.groupBox1);
            this.Name = "Help_Tools";
            this.Text = "辅助工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox GIFImage_Path;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GIF_Path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GIF_Break;
    }
}