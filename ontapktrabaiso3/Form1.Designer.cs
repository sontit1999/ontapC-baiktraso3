namespace ontapktrabaiso3
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDOngia = new System.Windows.Forms.TextBox();
            this.cbLoaisp = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mã sp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Loại sản phẩm";
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Location = new System.Drawing.Point(42, 270);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.Size = new System.Drawing.Size(745, 173);
            this.dgvSanpham.TabIndex = 6;
            this.dgvSanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellClick);
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(119, 53);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.Size = new System.Drawing.Size(212, 20);
            this.txtMasp.TabIndex = 7;
            // 
            // txtTensp
            // 
            this.txtTensp.Location = new System.Drawing.Point(119, 90);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(212, 20);
            this.txtTensp.TabIndex = 8;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(119, 131);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(212, 20);
            this.txtSoluong.TabIndex = 9;
            // 
            // txtDOngia
            // 
            this.txtDOngia.Location = new System.Drawing.Point(119, 178);
            this.txtDOngia.Name = "txtDOngia";
            this.txtDOngia.Size = new System.Drawing.Size(212, 20);
            this.txtDOngia.TabIndex = 10;
            // 
            // cbLoaisp
            // 
            this.cbLoaisp.FormattingEnabled = true;
            this.cbLoaisp.Location = new System.Drawing.Point(119, 221);
            this.cbLoaisp.Name = "cbLoaisp";
            this.cbLoaisp.Size = new System.Drawing.Size(212, 21);
            this.cbLoaisp.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(474, 65);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(605, 65);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(474, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(605, 131);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 15;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbLoaisp);
            this.Controls.Add(this.txtDOngia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTensp);
            this.Controls.Add(this.txtMasp);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDOngia;
        private System.Windows.Forms.ComboBox cbLoaisp;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
    }
}

