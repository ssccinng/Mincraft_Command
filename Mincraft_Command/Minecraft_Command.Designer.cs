namespace Mincraft_Command
{
    partial class Minecraft_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minecraft_Main));
            this.Pixel_Art = new System.Windows.Forms.Label();
            this.geometry = new System.Windows.Forms.Label();
            this.mc_cmd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pixel_Art
            // 
            this.Pixel_Art.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pixel_Art.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pixel_Art.Image = global::Mincraft_Command.Properties.Resources._3;
            this.Pixel_Art.Location = new System.Drawing.Point(0, 200);
            this.Pixel_Art.Name = "Pixel_Art";
            this.Pixel_Art.Size = new System.Drawing.Size(200, 200);
            this.Pixel_Art.TabIndex = 1;
            this.Pixel_Art.Text = "像素画(文字)生成";
            this.Pixel_Art.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pixel_Art.Click += new System.EventHandler(this.label1_Click);
            // 
            // geometry
            // 
            this.geometry.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.geometry.Image = global::Mincraft_Command.Properties.Resources._2;
            this.geometry.Location = new System.Drawing.Point(0, 0);
            this.geometry.Name = "geometry";
            this.geometry.Size = new System.Drawing.Size(200, 200);
            this.geometry.TabIndex = 0;
            this.geometry.Text = "几何图形绘制";
            this.geometry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.geometry.Click += new System.EventHandler(this.geometry_Click);
            // 
            // mc_cmd
            // 
            this.mc_cmd.Font = new System.Drawing.Font("方正舒体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mc_cmd.Image = global::Mincraft_Command.Properties.Resources._2;
            this.mc_cmd.Location = new System.Drawing.Point(200, 0);
            this.mc_cmd.Name = "mc_cmd";
            this.mc_cmd.Size = new System.Drawing.Size(200, 200);
            this.mc_cmd.TabIndex = 0;
            this.mc_cmd.Text = "mc常用指令汇总";
            this.mc_cmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mc_cmd.Click += new System.EventHandler(this.mc_cmd_Click);
            // 
            // Minecraft_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 402);
            this.Controls.Add(this.Pixel_Art);
            this.Controls.Add(this.mc_cmd);
            this.Controls.Add(this.geometry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Minecraft_Main";
            this.Text = "Minecraft指令生成器";
            this.Load += new System.EventHandler(this.Minecraft_Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label geometry;
        private System.Windows.Forms.Label Pixel_Art;
        private System.Windows.Forms.Label mc_cmd;
    }
}

