using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class QuanLi : Form
    {
        public QuanLi()
        {
            InitializeComponent();
        }
        Button btn=null;
        DataTable dtbNhanVien = new DataTable();
        DataTable dtbKhachHang = new DataTable();
        private void ActiveButton(Button button)
        {
            if(btn!=null)
            {
                btn.BackColor = Color.FromArgb(0, 158, 250); //Đổi lại màu cũ
                btn.ForeColor = Color.White;
            }
            btn = button;
            btn.BackColor = Color.FromArgb(192, 255, 255);
            btn.ForeColor = Color.Black;
        }

        private void AddUserControl(UserControl control)
        {
            Menu.Controls.Clear();
            control.Dock = DockStyle.Fill;
            Menu.Controls.Add(control);
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
            //Gợi ý cho tìm kiếm nhân viên
            if (Menu.Tag.ToString() == "Quản lí nhân viên")
            {
                AutoCompleteStringCollection atcNhanVien = new AutoCompleteStringCollection();
                foreach (DataRow item in dtbNhanVien.Rows)
                {
                    atcNhanVien.Add(item[1].ToString()); //Thêm tên nhân viên lưu trữ vào atcNhanVien 
                }
                txtTimKiem.AutoCompleteCustomSource = atcNhanVien;
            }

        }

        private void QuanLi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (Menu.Tag.ToString() == "Quản lí nhân viên")
            {
                DataRow[] dtrNhanVien = dtbNhanVien.Select("[Tên Nhân Viên]='" + txtTimKiem.Text + "'");
                if (dtrNhanVien.Length > 0)
                {
                    ucQuan_tri_he_thong.ucQuanLiNhanVien ucQuanLiNhanVien = new ucQuan_tri_he_thong.ucQuanLiNhanVien();
                    AddUserControl(ucQuanLiNhanVien);
                    DataGridView dgv = (DataGridView)ucQuanLiNhanVien.Controls["dgvNhanVien"];
                    //Chuyển mảng datarow về dataTable và hiển thị lên DataGridView
                    DataTable dtb = new DataTable();
                    dtb.Columns.Add("Mã NV");
                    dtb.Columns.Add("Tên nhân viên");
                    dtb.Columns.Add("Giới tính");
                    dtb.Columns.Add("Ngày sinh");
                    dtb.Columns.Add("Quên quán");
                    dtb.Columns.Add("Số CMND");
                    dtb.Columns.Add("Số điện thoại");
                    dtb.Columns.Add("Tài khoản");
                    dtb.Columns.Add("Mật khẩu");
                    dtb.Columns.Add("Chức vụ");
                    dtb.Columns.Add("Hình ảnh");
                    int dem = 0;
                    foreach (DataRow item in dtrNhanVien)
                    {
                        dtb.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5],
                            item[6], item[7], item[8], item[9], item[10]);
                        dem++;
                    }
                    dgv.DataSource = dtb;
                    MessageBox.Show("Tìm thấy " + dem + " nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(Menu.Tag.ToString() == "Quản lí khách hàng")
            {
                DataRow[] dtrKhachHang = dtbKhachHang.Select("[Tên khách hàng]='" + txtTimKiem.Text + "'");
                if (dtrKhachHang.Length > 0)
                {
                    ucQuan_tri_he_thong.ucQuanLiNhanVien ucQuanLiNhanVien = new ucQuan_tri_he_thong.ucQuanLiNhanVien();
                    AddUserControl(ucQuanLiNhanVien);
                    DataGridView dgv = (DataGridView)ucQuanLiNhanVien.Controls["dgvNhanVien"];
                    //Chuyển mảng datarow về dataTable và hiển thị lên DataGridView
                    DataTable dtb = new DataTable();
                    dtb.Columns.Add("Mã NV");
                    dtb.Columns.Add("Tên nhân viên");
                    dtb.Columns.Add("Giới tính");
                    dtb.Columns.Add("Ngày sinh");
                    dtb.Columns.Add("Quên quán");
                    dtb.Columns.Add("Số CMND");
                    dtb.Columns.Add("Số điện thoại");
                    dtb.Columns.Add("Tài khoản");
                    dtb.Columns.Add("Mật khẩu");
                    dtb.Columns.Add("Chức vụ");
                    dtb.Columns.Add("Hình ảnh");
                    int dem = 0;
                    foreach (DataRow item in dtrKhachHang)
                    {
                        dtb.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5],
                            item[6], item[7], item[8], item[9], item[10]);
                        dem++;
                    }
                    dgv.DataSource = dtb;
                    MessageBox.Show("Tìm thấy " + dem + " nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void QuanLi_Load(object sender, EventArgs e)
        {
            //Đọc file json nhân viên
            StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\NhanVien.js");
            string nhanvien = reader.ReadToEnd();
            dtbNhanVien = JsonConvert.DeserializeObject<DataTable>(nhanvien);
            reader.Close();
        }

        private void QLNhanVien_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiNhanVien ucQuanLiNhanVien = new ucQuan_tri_he_thong.ucQuanLiNhanVien();
            AddUserControl(ucQuanLiNhanVien);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập tên nhân viên...";
            Menu.Tag = "Quản lí nhân viên";
        }

        private void QLKhachHang_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiKhachHang ucQuanLiKhachHang = new ucQuan_tri_he_thong.ucQuanLiKhachHang();
            AddUserControl(ucQuanLiKhachHang);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập tên khách hàng...";
            Menu.Tag = "Quản lí khách hàng";
        }

        private void QLDanhSachPhim_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiPhim ucQuanLiPhim = new ucQuan_tri_he_thong.ucQuanLiPhim();
            AddUserControl(ucQuanLiPhim);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập tên phim...";
            Menu.Tag = "Quản lí phim";
        }

        private void QLDanhSachPhongChieu_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiPhongChieu ucQuanLiPhongChieu = new ucQuan_tri_he_thong.ucQuanLiPhongChieu();
            AddUserControl(ucQuanLiPhongChieu);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập phòng chiếu...";
            Menu.Tag = "Quản lí phòng chiếu";
        }

        private void QLLichChieu_Click(object sender, EventArgs e)

        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiLichChieu ucQuanLiLichChieu = new ucQuan_tri_he_thong.ucQuanLiLichChieu();
            AddUserControl(ucQuanLiLichChieu);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập tên phim chiếu...";
            Menu.Tag = "Quản lí lịch chiếu";
        }

        private void btnQuanLiVe_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucQuanLiVe ucQuanLiVe = new ucQuan_tri_he_thong.ucQuanLiVe();
            AddUserControl(ucQuanLiVe);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập khách hàng...";
            Menu.Tag = "Quản lí lịch vé";
        }

        private void QLDoanhThu_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ActiveButton(button);
            ucQuan_tri_he_thong.ucDoanhThu ucDoanhThu = new ucQuan_tri_he_thong.ucDoanhThu();
            AddUserControl(ucDoanhThu);
            //Cho phép tìm kiếm
            txtTimKiem.Enabled = true;
            txtTimKiem.Text = "Mời nhập doanh thu tháng...";
            Menu.Tag = "Quản lí doanh thu";
        }
    }
}
