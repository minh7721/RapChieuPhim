
namespace RapChieuPhim
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(137, 112);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(156, 20);
            this.txtmatkhau.TabIndex = 41;
            this.txtmatkhau.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(49, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 45;
            this.label4.Text = "Mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(137, 75);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(156, 20);
            this.txttaikhoan.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(46, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 30);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tài khoản";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // btnthoat
            // 
            this.btnthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnthoat.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.Image")));
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(218, 151);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(76, 23);
            this.btnthoat.TabIndex = 43;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.Image")));
            this.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndangnhap.Location = new System.Drawing.Point(127, 151);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(85, 23);
            this.btndangnhap.TabIndex = 42;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Đăng kí";
            // 
            // DangNhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Label label1;
    }
}