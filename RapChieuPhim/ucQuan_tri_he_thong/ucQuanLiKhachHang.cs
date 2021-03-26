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
    public partial class ucQuanLiKhachHang : UserControl
    {
        public ucQuanLiKhachHang()
        {
            InitializeComponent();
           
        }
        DataTable dtbKhachHang = new DataTable();
        DataTable dtbNhanVien = new DataTable();
        OpenFileDialog openFileDialog;
        private void update()
        {
            try
            {
                string lưufile = JsonConvert.SerializeObject(dtbKhachHang);
                System.IO.File.WriteAllText(@"E:\RapChieuPhim\RapChieuPhim\Data\KhachHang.js", lưufile);
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

        public bool checkUser(string tentaikhoan)
        {
            DataRow[] dtrNhanVien = dtbNhanVien.Select("[Tài khoản]='" + tentaikhoan + "'");
            DataRow[] dtrKhachHang = dtbKhachHang.Select("[Tài khoản]='" + tentaikhoan + "'");
            if (dtrNhanVien.Length != 0 || dtrKhachHang.Length != 0)
            {
                return true;
            }
            else return false;
        }
        private bool checkID(string ma)
        {
            DataRow[] dtr = dtbNhanVien.Select("[Mã nhân viên]='" + ma + "'");
            if (dtr.Length != 0)
                return true;
            else
                return false;
        }
        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtSoDienThoai.Text);
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
                Bitmap picture = new Bitmap(openFileDialog.FileName);
                ptbAnhKH.Image = (Image)picture;
            }
        }

        private void ucQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            //Load file khách hàng
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
                    dtbKhachHang.Columns.Add("Hình ảnh");
                }
                dgvKhachHang.DataSource = dtbKhachHang;
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Khách hàng");
            }
            //Load file Nhân Viên để tránh tài khoản trùng nhau
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\NhanVien.js");
                string strjson = reader.ReadToEnd();
                dtbNhanVien = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbNhanVien.Columns.Add("Mã Nhân Viên");
                    dtbNhanVien.Columns.Add("Tên Nhân Viên");
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
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Sinh Viên");
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {

            if(checkID(txtMaKhachHang.Text)==true)
            {
                MessageBox.Show("Mã khách hàng " + txtMaKhachHang.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaKhachHang.Text != "" && txtTenKhachHang.Text != "" && txtQueQuan.Text != "" &&txtEmail.Text!=""&&
                txtSoDienThoai.Text != "" )
            {
                string gioitinh = (Nam.Checked == true) ? "Nam" : "Nữ";
              
                //Mã hoá ảnh được chọn
                string imagetext = "";
                if (openFileDialog != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                     imagetext = Convert.ToBase64String(imageArray);
                }
                dtbKhachHang.Rows.Add(txtMaKhachHang.Text, txtTenKhachHang.Text, gioitinh, dtNgaySinh.Value.ToString("dd/MM/yyyy"),
               txtQueQuan.Text, txtEmail.Text, txtSoDienThoai.Text, imagetext);
                //Cập nhật lưu trên file
                update();
                MessageBox.Show("Thêm khách hàng thành công");
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int ma = dgvKhachHang.SelectedRows[0].Index;
                dtbKhachHang.Rows.RemoveAt(ma);
                update();
            }
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text != "" && txtTenKhachHang.Text != "" && txtQueQuan.Text != "" &&
                txtEmail.Text != "" && txtSoDienThoai.Text != "")
            {
                int index = dgvKhachHang.SelectedRows[0].Index;
                dtbKhachHang.Rows[index]["Mã khách hàng"] = txtMaKhachHang.Text;
                dtbKhachHang.Rows[index]["Tên khách hàng"] = txtTenKhachHang.Text;
                dtbKhachHang.Rows[index]["Giới tính"] = (Nam.Checked == true) ? "Nam" : "Nữ";
                dtbKhachHang.Rows[index]["Ngày sinh"] = dtNgaySinh.Value.ToString("dd/MM/yyyy");
                dtbKhachHang.Rows[index]["Quê quán"] = txtQueQuan.Text;
                dtbKhachHang.Rows[index]["Email"] = txtEmail.Text;
                dtbKhachHang.Rows[index]["Số điện thoại"] = txtSoDienThoai.Text;
                //Mã hoá ảnh
                if (openFileDialog != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    string imagetext = Convert.ToBase64String(imageArray);
                    dtbKhachHang.Rows[index]["Hình ảnh"] = imagetext;
                }
                update();
                MessageBox.Show("Cập nhật thông khách hàng công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn hãy điền đủ thông tin trước khi sửa thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvKhachHang.SelectedRows[0];
            txtMaKhachHang.Text = dataRow.Cells[0].Value.ToString();
            txtTenKhachHang.Text = dataRow.Cells[1].Value.ToString();
            if (dataRow.Cells[2].Value.ToString() == "Nam")
            {
                Nam.Checked = true;
            }
            else
                Nu.Checked = true;
            dtNgaySinh.Value = Convert.ToDateTime(dataRow.Cells[3].Value);
            txtQueQuan.Text = dataRow.Cells[4].Value.ToString();
            txtEmail.Text = dataRow.Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataRow.Cells[6].Value.ToString();
            //chuyển text -> byte[] ->Image
            if (dataRow.Cells[9].Value.ToString() != "") //Nếu có ảnh thì hiển thị lên giao diện
            {
                string text = dataRow.Cells[9].Value.ToString();
                byte[] textArray = Convert.FromBase64String(text);
                MemoryStream memoryStream = new MemoryStream(textArray, 0, textArray.Length);
                ptbAnhKH.Image = Image.FromStream(memoryStream, true);
            }
            else
            {
                ptbAnhKH.Image = null;
            }
        }
    }
}
