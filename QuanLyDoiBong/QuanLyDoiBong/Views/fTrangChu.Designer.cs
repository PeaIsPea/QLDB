namespace QuanLyDoiBong.Views
{
    partial class fTrangChu
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
            this.lbDongHo = new System.Windows.Forms.Label();
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.lbXinChao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbDongHo
            // 
            this.lbDongHo.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongHo.ForeColor = System.Drawing.Color.Blue;
            this.lbDongHo.Location = new System.Drawing.Point(285, 96);
            this.lbDongHo.Name = "lbDongHo";
            this.lbDongHo.Size = new System.Drawing.Size(300, 88);
            this.lbDongHo.TabIndex = 0;
            this.lbDongHo.Text = "00:00:00";
            this.lbDongHo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.Location = new System.Drawing.Point(322, 175);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(226, 61);
            this.lbNgayThang.TabIndex = 0;
            this.lbNgayThang.Text = "12/12/2023";
            this.lbNgayThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbXinChao
            // 
            this.lbXinChao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXinChao.ForeColor = System.Drawing.Color.Red;
            this.lbXinChao.Location = new System.Drawing.Point(296, 247);
            this.lbXinChao.Name = "lbXinChao";
            this.lbXinChao.Size = new System.Drawing.Size(279, 34);
            this.lbXinChao.TabIndex = 1;
            this.lbXinChao.Text = "Xin chào: Admin";
            this.lbXinChao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 434);
            this.Controls.Add(this.lbXinChao);
            this.Controls.Add(this.lbNgayThang);
            this.Controls.Add(this.lbDongHo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTrangChu";
            this.Text = "fTrangChu";
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbDongHo;
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label lbXinChao;
        private System.Windows.Forms.Timer timer1;
    }
}