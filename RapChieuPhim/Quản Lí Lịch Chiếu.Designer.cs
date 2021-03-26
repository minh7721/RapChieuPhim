
namespace RapChieuPhim
{
    partial class Quản_Lí_Lịch_Chiếu
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
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.btnThongKePhim = new System.Windows.Forms.Button();
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.btnSuaPhim = new System.Windows.Forms.Button();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.lblSoVe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNgayChieu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPhongChieu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCaChieu = new System.Windows.Forms.ComboBox();
            this.cbPhimChieu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLichChieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.AllowUserToAddRows = false;
            this.dgvLichChieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichChieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichChieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichChieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichChieu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichChieu.Location = new System.Drawing.Point(-2, 183);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.ReadOnly = true;
            this.dgvLichChieu.RowHeadersWidth = 51;
            this.dgvLichChieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichChieu.Size = new System.Drawing.Size(913, 349);
            this.dgvLichChieu.TabIndex = 128;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // btnThongKePhim
            // 
            this.btnThongKePhim.Location = new System.Drawing.Point(603, 135);
            this.btnThongKePhim.Name = "btnThongKePhim";
            this.btnThongKePhim.Size = new System.Drawing.Size(116, 30);
            this.btnThongKePhim.TabIndex = 127;
            this.btnThongKePhim.Text = "Thống kê lịch chiếu";
            this.btnThongKePhim.UseVisualStyleBackColor = true;
            this.btnThongKePhim.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(492, 135);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(93, 30);
            this.btnXoaPhim.TabIndex = 126;
            this.btnXoaPhim.Text = "Xoá lịch chiếu";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            this.btnXoaPhim.Click += new System.EventHandler(this.btnXoaPhim_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Location = new System.Drawing.Point(381, 135);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(93, 30);
            this.btnSuaPhim.TabIndex = 125;
            this.btnSuaPhim.Text = "Sửa lịch chiếu";
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(268, 135);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(93, 30);
            this.btnThemPhim.TabIndex = 124;
            this.btnThemPhim.Text = "Thêm lịch chiếu";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // lblSoVe
            // 
            this.lblSoVe.AutoSize = true;
            this.lblSoVe.Location = new System.Drawing.Point(513, 91);
            this.lblSoVe.Name = "lblSoVe";
            this.lblSoVe.Size = new System.Drawing.Size(13, 13);
            this.lblSoVe.TabIndex = 123;
            this.lblSoVe.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "Suất vé bán ra:";
            // 
            // dtNgayChieu
            // 
            this.dtNgayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayChieu.Location = new System.Drawing.Point(152, 84);
            this.dtNgayChieu.Name = "dtNgayChieu";
            this.dtNgayChieu.Size = new System.Drawing.Size(188, 20);
            this.dtNgayChieu.TabIndex = 121;
            this.dtNgayChieu.Value = new System.DateTime(2021, 1, 1, 20, 58, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 120;
            this.label6.Text = "Ngày chiếu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 119;
            this.label5.Text = "Phòng chiếu";
            // 
            // cbPhongChieu
            // 
            this.cbPhongChieu.FormattingEnabled = true;
            this.cbPhongChieu.Location = new System.Drawing.Point(504, 54);
            this.cbPhongChieu.Name = "cbPhongChieu";
            this.cbPhongChieu.Size = new System.Drawing.Size(168, 21);
            this.cbPhongChieu.TabIndex = 118;
            this.cbPhongChieu.SelectedIndexChanged += new System.EventHandler(this.cbPhongChieu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Ca chiếu";
            // 
            // cbCaChieu
            // 
            this.cbCaChieu.FormattingEnabled = true;
            this.cbCaChieu.Items.AddRange(new object[] {
            "Ca 1: Từ 8 giờ -12 giờ",
            "Ca 2: Từ 13 giờ -16 giờ",
            "Ca 3: Từ 16 giờ -19 giờ",
            "Ca 4: Từ 19 giờ -22 giờ"});
            this.cbCaChieu.Location = new System.Drawing.Point(503, 25);
            this.cbCaChieu.Name = "cbCaChieu";
            this.cbCaChieu.Size = new System.Drawing.Size(168, 21);
            this.cbCaChieu.TabIndex = 116;
            // 
            // cbPhimChieu
            // 
            this.cbPhimChieu.FormattingEnabled = true;
            this.cbPhimChieu.Location = new System.Drawing.Point(152, 53);
            this.cbPhimChieu.Name = "cbPhimChieu";
            this.cbPhimChieu.Size = new System.Drawing.Size(188, 21);
            this.cbPhimChieu.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Phim chiếu";
            // 
            // txtMaLichChieu
            // 
            this.txtMaLichChieu.Location = new System.Drawing.Point(152, 25);
            this.txtMaLichChieu.Name = "txtMaLichChieu";
            this.txtMaLichChieu.Size = new System.Drawing.Size(188, 20);
            this.txtMaLichChieu.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Mã lịch chiếu";
            // 
            // Quản_Lí_Lịch_Chiếu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 531);
            this.Controls.Add(this.dgvLichChieu);
            this.Controls.Add(this.btnThongKePhim);
            this.Controls.Add(this.btnXoaPhim);
            this.Controls.Add(this.btnSuaPhim);
            this.Controls.Add(this.btnThemPhim);
            this.Controls.Add(this.lblSoVe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtNgayChieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPhongChieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCaChieu);
            this.Controls.Add(this.cbPhimChieu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLichChieu);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Quản_Lí_Lịch_Chiếu";
            this.Text = "Quản Lí Lịch Chiếu";
            this.Load += new System.EventHandler(this.Quản_Lí_Lịch_Chiếu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvLichChieu;
        private System.Windows.Forms.Button btnThongKePhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnSuaPhim;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Label lblSoVe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNgayChieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPhongChieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCaChieu;
        private System.Windows.Forms.ComboBox cbPhimChieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLichChieu;
        private System.Windows.Forms.Label label2;
    }
}