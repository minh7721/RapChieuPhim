
namespace RapChieuPhim
{
    partial class quanliphongchieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.DienTich = new System.Windows.Forms.NumericUpDown();
            this.SoCho = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhongChieu = new System.Windows.Forms.Button();
            this.btnThongKePhongChieu = new System.Windows.Forms.Button();
            this.btnXoaPhongChieu = new System.Windows.Forms.Button();
            this.btnSuaPhongChieu = new System.Windows.Forms.Button();
            this.dgvPhongChieu = new System.Windows.Forms.DataGridView();
            this.txtCacThietBiKhac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbAmThanh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaPhongChieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMayChieu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DienTich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 143;
            this.label9.Text = "mét vuông";
            // 
            // DienTich
            // 
            this.DienTich.Location = new System.Drawing.Point(547, 58);
            this.DienTich.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.DienTich.Name = "DienTich";
            this.DienTich.Size = new System.Drawing.Size(60, 20);
            this.DienTich.TabIndex = 127;
            // 
            // SoCho
            // 
            this.SoCho.Location = new System.Drawing.Point(131, 77);
            this.SoCho.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.SoCho.Name = "SoCho";
            this.SoCho.Size = new System.Drawing.Size(60, 20);
            this.SoCho.TabIndex = 124;
            // 
            // btnThemPhongChieu
            // 
            this.btnThemPhongChieu.Location = new System.Drawing.Point(274, 178);
            this.btnThemPhongChieu.Name = "btnThemPhongChieu";
            this.btnThemPhongChieu.Size = new System.Drawing.Size(105, 30);
            this.btnThemPhongChieu.TabIndex = 139;
            this.btnThemPhongChieu.Text = "Thêm phòng chiếu";
            this.btnThemPhongChieu.UseVisualStyleBackColor = true;
            this.btnThemPhongChieu.Click += new System.EventHandler(this.btnThemPhongChieu_Click);
            // 
            // btnThongKePhongChieu
            // 
            this.btnThongKePhongChieu.Location = new System.Drawing.Point(643, 178);
            this.btnThongKePhongChieu.Name = "btnThongKePhongChieu";
            this.btnThongKePhongChieu.Size = new System.Drawing.Size(139, 30);
            this.btnThongKePhongChieu.TabIndex = 142;
            this.btnThongKePhongChieu.Text = "Thống kê phòng chiếu";
            this.btnThongKePhongChieu.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhongChieu
            // 
            this.btnXoaPhongChieu.Location = new System.Drawing.Point(522, 178);
            this.btnXoaPhongChieu.Name = "btnXoaPhongChieu";
            this.btnXoaPhongChieu.Size = new System.Drawing.Size(108, 30);
            this.btnXoaPhongChieu.TabIndex = 140;
            this.btnXoaPhongChieu.Text = "Xoá phòng chiếu";
            this.btnXoaPhongChieu.UseVisualStyleBackColor = true;
            // 
            // btnSuaPhongChieu
            // 
            this.btnSuaPhongChieu.Location = new System.Drawing.Point(393, 178);
            this.btnSuaPhongChieu.Name = "btnSuaPhongChieu";
            this.btnSuaPhongChieu.Size = new System.Drawing.Size(115, 30);
            this.btnSuaPhongChieu.TabIndex = 141;
            this.btnSuaPhongChieu.Text = "Sửa phòng chiếu";
            this.btnSuaPhongChieu.UseVisualStyleBackColor = true;
            // 
            // dgvPhongChieu
            // 
            this.dgvPhongChieu.AllowUserToAddRows = false;
            this.dgvPhongChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongChieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhongChieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongChieu.Location = new System.Drawing.Point(-45, 222);
            this.dgvPhongChieu.Name = "dgvPhongChieu";
            this.dgvPhongChieu.ReadOnly = true;
            this.dgvPhongChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongChieu.Size = new System.Drawing.Size(983, 293);
            this.dgvPhongChieu.TabIndex = 138;
            // 
            // txtCacThietBiKhac
            // 
            this.txtCacThietBiKhac.Location = new System.Drawing.Point(547, 122);
            this.txtCacThietBiKhac.Name = "txtCacThietBiKhac";
            this.txtCacThietBiKhac.Size = new System.Drawing.Size(168, 20);
            this.txtCacThietBiKhac.TabIndex = 129;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 137;
            this.label8.Text = "Các thiết bị khác";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Tốt ",
            "Đang bảo trì"});
            this.cbTinhTrang.Location = new System.Drawing.Point(547, 88);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(121, 21);
            this.cbTinhTrang.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(461, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 136;
            this.label7.Text = "Tính trạng";
            // 
            // cbAmThanh
            // 
            this.cbAmThanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAmThanh.FormattingEnabled = true;
            this.cbAmThanh.Items.AddRange(new object[] {
            "Loại A",
            "Loại B",
            "Loại C",
            "Loại D",
            "Loại E",
            ""});
            this.cbAmThanh.Location = new System.Drawing.Point(131, 132);
            this.cbAmThanh.Name = "cbAmThanh";
            this.cbAmThanh.Size = new System.Drawing.Size(121, 21);
            this.cbAmThanh.TabIndex = 126;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 134;
            this.label5.Text = "Âm thanh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 131;
            this.label4.Text = "Máy chiếu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Số chỗ";
            // 
            // txtMaPhongChieu
            // 
            this.txtMaPhongChieu.Location = new System.Drawing.Point(131, 51);
            this.txtMaPhongChieu.Name = "txtMaPhongChieu";
            this.txtMaPhongChieu.Size = new System.Drawing.Size(137, 20);
            this.txtMaPhongChieu.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Mã phòng chiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí phòng chiếu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 135;
            this.label6.Text = "Diện tích";
            // 
            // cbMayChieu
            // 
            this.cbMayChieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMayChieu.FormattingEnabled = true;
            this.cbMayChieu.Items.AddRange(new object[] {
            "Loại A",
            "Loại B",
            "Loại C",
            "Loại D",
            "Loại E",
            ""});
            this.cbMayChieu.Location = new System.Drawing.Point(131, 104);
            this.cbMayChieu.Name = "cbMayChieu";
            this.cbMayChieu.Size = new System.Drawing.Size(121, 21);
            this.cbMayChieu.TabIndex = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 40);
            this.panel1.TabIndex = 130;
            // 
            // quanliphongchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DienTich);
            this.Controls.Add(this.SoCho);
            this.Controls.Add(this.btnThemPhongChieu);
            this.Controls.Add(this.btnThongKePhongChieu);
            this.Controls.Add(this.btnXoaPhongChieu);
            this.Controls.Add(this.btnSuaPhongChieu);
            this.Controls.Add(this.dgvPhongChieu);
            this.Controls.Add(this.txtCacThietBiKhac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbAmThanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPhongChieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMayChieu);
            this.Controls.Add(this.panel1);
            this.Name = "quanliphongchieu";
            this.Text = "quanliphongchieu";
            this.Load += new System.EventHandler(this.quanliphongchieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DienTich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongChieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown DienTich;
        private System.Windows.Forms.NumericUpDown SoCho;
        private System.Windows.Forms.Button btnThemPhongChieu;
        private System.Windows.Forms.Button btnThongKePhongChieu;
        private System.Windows.Forms.Button btnXoaPhongChieu;
        private System.Windows.Forms.Button btnSuaPhongChieu;
        public System.Windows.Forms.DataGridView dgvPhongChieu;
        private System.Windows.Forms.TextBox txtCacThietBiKhac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbAmThanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaPhongChieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMayChieu;
        private System.Windows.Forms.Panel panel1;
    }
}