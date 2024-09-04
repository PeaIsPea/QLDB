namespace QuanLyDoiBong.Views
{
    partial class fTaiTro
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpkNgayTaiTro = new System.Windows.Forms.DateTimePicker();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNhaTaiTro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaTaiTro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTaiTro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(501, 52);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 34);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.TabStop = false;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(410, 52);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 34);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.TabStop = false;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(319, 52);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 34);
            this.btnSua.TabIndex = 5;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(228, 52);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 5;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpkNgayTaiTro
            // 
            this.dtpkNgayTaiTro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgayTaiTro.Location = new System.Drawing.Point(768, 10);
            this.dtpkNgayTaiTro.Name = "dtpkNgayTaiTro";
            this.dtpkNgayTaiTro.Size = new System.Drawing.Size(90, 26);
            this.dtpkNgayTaiTro.TabIndex = 2;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(43, 10);
            this.numID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(49, 26);
            this.numID.TabIndex = 0;
            this.numID.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày tài trợ:";
            // 
            // txbNhaTaiTro
            // 
            this.txbNhaTaiTro.Location = new System.Drawing.Point(408, 10);
            this.txbNhaTaiTro.MaxLength = 100;
            this.txbNhaTaiTro.Name = "txbNhaTaiTro";
            this.txbNhaTaiTro.Size = new System.Drawing.Size(264, 26);
            this.txbNhaTaiTro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhà tài trợ:";
            // 
            // txbMaTaiTro
            // 
            this.txbMaTaiTro.Location = new System.Drawing.Point(176, 10);
            this.txbMaTaiTro.MaxLength = 100;
            this.txbMaTaiTro.Name = "txbMaTaiTro";
            this.txbMaTaiTro.Size = new System.Drawing.Size(143, 26);
            this.txbMaTaiTro.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã tài trợ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.dtpkNgayTaiTro);
            this.panel1.Controls.Add(this.numID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbNhaTaiTro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbMaTaiTro);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 100);
            this.panel1.TabIndex = 2;
            // 
            // dgvTaiTro
            // 
            this.dgvTaiTro.AllowUserToAddRows = false;
            this.dgvTaiTro.AllowUserToDeleteRows = false;
            this.dgvTaiTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvTaiTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiTro.Location = new System.Drawing.Point(0, 100);
            this.dgvTaiTro.Name = "dgvTaiTro";
            this.dgvTaiTro.ReadOnly = true;
            this.dgvTaiTro.RowHeadersVisible = false;
            this.dgvTaiTro.RowTemplate.Height = 28;
            this.dgvTaiTro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTaiTro.Size = new System.Drawing.Size(870, 334);
            this.dgvTaiTro.TabIndex = 4;
            this.dgvTaiTro.TabStop = false;
            this.dgvTaiTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiTro_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaNhaTaiTro";
            this.Column2.HeaderText = "MÃ TÀI TRỢ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 320;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenNhaTaiTro";
            this.Column3.HeaderText = "TÊN NHÀ TÀI TRỢ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 320;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayTaiTro";
            this.Column4.HeaderText = "NGÀY TÀI TRỢ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // fTaiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 434);
            this.Controls.Add(this.dgvTaiTro);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fTaiTro";
            this.Text = "fTaiTro";
            this.Load += new System.EventHandler(this.fTaiTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpkNgayTaiTro;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNhaTaiTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaTaiTro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}