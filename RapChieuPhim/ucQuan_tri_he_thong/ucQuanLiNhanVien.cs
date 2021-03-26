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

namespace RapChieuPhim.ucQuan_tri_he_thong
{
    public partial class ucQuanLiNhanVien : UserControl
    {
        public ucQuanLiNhanVien()
        {
            InitializeComponent();
        }
        DataTable dtbNhanVien = new DataTable();
        DataTable dtbKhachHang = new DataTable();
        Bitmap picture = null;
        OpenFileDialog openFileDialog;
        private void update()
        {
            try
            {
                string lưufile = JsonConvert.SerializeObject(dtbNhanVien);
                System.IO.File.WriteAllText(@"E:\RapChieuPhim\RapChieuPhim\Data\NhanVien.js", lưufile);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
        private string MaHoaPass(string str)
        {
            // Chuyển chuỗi thành mảng kiểu byte.
            byte[] b = Encoding.Unicode.GetBytes(str);
            // Trả về chuỗi được mã hóa theo Base64.
            return Convert.ToBase64String(b);
        }

        private string GiaiMaPass(string str)
        {
            byte[] b = Convert.FromBase64String(str);
            return Encoding.Unicode.GetString(b);
        }

        private bool checkUser(string tentaikhoan) //Mỗi tài khoản chỉ có 1 người sử dựng
        {
            DataRow[] dtrNhanVien= dtbNhanVien.Select("[Tài khoản]='"+tentaikhoan+"'");
            DataRow[] dtrKhachHang = dtbKhachHang.Select("[Tài khoản]='" + tentaikhoan + "'");
            if (dtrNhanVien.Length != 0||dtrKhachHang.Length!=0)
            {
                return true;
            }
            else return false;
        }

        private bool checkID(string ma)
        {
            DataRow[] dtr= dtbNhanVien.Select("[Mã nhân viên]='"+ma+"'");
            if (dtr.Length != 0)
                return true;
            else
                return false;
        } 

        private void txtSoCMND_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtSoCMND.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Số CMND không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtSoCMND.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Số điện thoại không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh|*.PNG;*.JPG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture = new Bitmap(openFileDialog.FileName);
                ptbAnhNV.Image = (Image)picture;
            }
        }

        private void ucQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            //Load file dữ liệu NhanVien
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\NhanVien.js");
                string strjson = reader.ReadToEnd();
                dtbNhanVien = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbNhanVien.Columns.Add("Mã nhân viên");
                    dtbNhanVien.Columns.Add("Tên nhân viên");
                    dtbNhanVien.Columns.Add("Giới tính");
                    dtbNhanVien.Columns.Add("Ngày sinh");
                    dtbNhanVien.Columns.Add("Quê quán");
                    dtbNhanVien.Columns.Add("Số CMND");
                    dtbNhanVien.Columns.Add("Số điện thoại");
                    dtbNhanVien.Columns.Add("Tài khoản");
                    dtbNhanVien.Columns.Add("Mật khẩu");
                    dtbNhanVien.Columns.Add("Chức vụ");
                    dtbNhanVien.Columns.Add("Hình ảnh");
                }
                dgvNhanVien.DataSource = dtbNhanVien;
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Nhân viên");
            }
            //Load file dữ liệu Khách hàng để tránh tài khoản đăng kí trùng nhau
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\KhachHang.js");
                string strjson = reader.ReadToEnd();
                dtbKhachHang = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbKhachHang.Columns.Add("Mã khách hàng");
                    dtbKhachHang.Columns.Add("Tên khách hàng");
                    dtbKhachHang.Columns.Add("Giới tính");
                    dtbKhachHang.Columns.Add("Ngày sinh");
                    dtbKhachHang.Columns.Add("Quê quán");
                    dtbKhachHang.Columns.Add("Email");
                    dtbKhachHang.Columns.Add("Số điện thoại");
                    dtbKhachHang.Columns.Add("Tài khoản");
                    dtbKhachHang.Columns.Add("Mật khẩu");
                    dtbKhachHang.Columns.Add("Chức vụ");
                    dtbKhachHang.Columns.Add("Hình ảnh");
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Khách hàng");
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(checkUser(txtTaiKhoan.Text) == true)
            {
                MessageBox.Show("Tài khoản "+txtTaiKhoan.Text+" đã tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }   
            else if(checkID(txtMaNhanVien.Text)==true)
            {
                MessageBox.Show("Mã nhân viên" + txtMaNhanVien.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if(txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtQueQuan.Text != "" &&
                txtSoCMND.Text != "" && txtSoDienThoai.Text != "" && txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && cbChucVu.Text != "")
            {
                string gioitinh = (Nam.Checked == true) ? "Nam" : "Nữ";
                //Mã hoá mật khẩu
                string pass = MaHoaPass(txtMatKhau.Text);
                //Mã hoá ảnh được chọn
                string imagetext = "";
               if (openFileDialog != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    imagetext = Convert.ToBase64String(imageArray);
                }
                dtbNhanVien.Rows.Add(txtMaNhanVien.Text, txtTenNhanVien.Text, gioitinh, dtNgaySinh.Value.ToString("dd/MM/yyyy"),
               txtQueQuan.Text, txtSoCMND.Text, txtSoDienThoai.Text, txtTaiKhoan.Text, pass, cbChucVu.Text, imagetext);
                //Cập nhật lưu trên file
                update();
            }     
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
             if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtQueQuan.Text != "" &&
                txtSoCMND.Text != "" && txtSoDienThoai.Text != "" && txtTaiKhoan.Text != "" && txtMatKhau.Text != "" && cbChucVu.Text != "")
            {
                int index = dgvNhanVien.SelectedRows[0].Index;
                dtbNhanVien.Rows[index]["Mã nhân viên"]= txtMaNhanVien.Text;
                dtbNhanVien.Rows[index]["Tên nhân viên"] = txtTenNhanVien.Text;
                dtbNhanVien.Rows[index]["Giới tính"] = (Nam.Checked == true) ? "Nam" : "Nữ";
                dtbNhanVien.Rows[index]["Ngày sinh"] = dtNgaySinh.Value.ToString("dd/MM/yyyy");
                dtbNhanVien.Rows[index]["Quê quán"] = txtQueQuan.Text;
                dtbNhanVien.Rows[index]["Số CMND"] = txtSoCMND.Text;
                dtbNhanVien.Rows[index]["Số điện thoại"] = txtSoDienThoai.Text;
                dtbNhanVien.Rows[index]["Tài khoản"] = txtTaiKhoan.Text;
                //Mã hoá mật khẩu
                dtbNhanVien.Rows[index]["Mật khẩu"] = MaHoaPass(txtMatKhau.Text);
                dtbNhanVien.Rows[index]["Chức vụ"] = cbChucVu.Text;
                //Mã hoá ảnh
                    if (openFileDialog != null)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                        string imagetext = Convert.ToBase64String(imageArray);
                        dtbNhanVien.Rows[index]["Hình ảnh"]= imagetext;
                    }
                update();
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn hãy điền đủ thông tin trước khi sửa thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá nhân viên này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int ma = dgvNhanVien.SelectedRows[0].Index;
                dtbNhanVien.Rows.RemoveAt(ma);
                update();
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvNhanVien.SelectedRows[0];
            txtMaNhanVien.Text = dataRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataRow.Cells[1].Value.ToString();
            if (dataRow.Cells[2].Value.ToString() == "Nam")
            {
                Nam.Checked = true;
            }
            else
                Nu.Checked = true;
            dtNgaySinh.Value = Convert.ToDateTime(dataRow.Cells[3].Value);
            txtQueQuan.Text = dataRow.Cells[4].Value.ToString();
            txtSoCMND.Text = dataRow.Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataRow.Cells[6].Value.ToString();
            txtTaiKhoan.Text = dataRow.Cells[7].Value.ToString();
            //Giải mã pass rồi hiển thị lên giao diện
            txtMatKhau.Text =GiaiMaPass(dataRow.Cells[8].Value.ToString());
            cbChucVu.Text = dataRow.Cells[9].Value.ToString();
            //chuyển text -> byte[] ->Image
            if (dataRow.Cells[10].Value.ToString() != "") //Nếu có ảnh thì hiển thị lên giao diện
            {
                string text = dataRow.Cells[10].Value.ToString();
                byte[] textArray = Convert.FromBase64String(text);
                MemoryStream memoryStream = new MemoryStream(textArray, 0, textArray.Length);
                ptbAnhNV.Image = Image.FromStream(memoryStream, true);
            }
            else
            {
                ptbAnhNV.Image = null;
            }
        }

       
    }
}
