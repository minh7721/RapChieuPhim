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
    public partial class ucQuanLiPhim : UserControl
    {
        public ucQuanLiPhim()
        {
            InitializeComponent();
        }
        DataTable dtbPhim = new DataTable();
        OpenFileDialog openFileDialog;
        private void update()
        {
            try
            {
                string lưufile = JsonConvert.SerializeObject(dtbPhim);
                System.IO.File.WriteAllText(@"E:\RapChieuPhim\RapChieuPhim\Data\Phim.js", lưufile);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private bool checkID(string ma)
        {
            DataRow[] dtr = dtbPhim.Select("[Mã phim]='" + ma + "'");
            if (dtr.Length != 0)
                return true;
            else
                return false;
        }
        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Hình ảnh|*.PNG;*.JPG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap picture = new Bitmap(openFileDialog.FileName);
                ptbAnhPhim.Image = (Image)picture;
            }
        }
        private void ucQuanLiPhim_Load(object sender, EventArgs e)
        {
            //Load file phim
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\Phim.js");
                string strjson = reader.ReadToEnd();
                dtbPhim = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbPhim.Columns.Add("Mã phim");
                    dtbPhim.Columns.Add("Tên phim");
                    dtbPhim.Columns.Add("Thể loại");
                    dtbPhim.Columns.Add("Quốc gia sản xuất");
                    dtbPhim.Columns.Add("Đạo diễn");
                    dtbPhim.Columns.Add("Khởi chiếu");
                    dtbPhim.Columns.Add("Thời lượng");
                    dtbPhim.Columns.Add("Các diễn viên tham gia");
                    dtbPhim.Columns.Add("Nội dung chính");
                    dtbPhim.Columns.Add("Hình ảnh");
                }
                dgvPhim.DataSource = dtbPhim;
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Phim");
            }
        }
        private void dgvPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvPhim.SelectedRows[0];
            txtMaPhim.Text = dataRow.Cells[0].Value.ToString();
            txtTenPhim.Text = dataRow.Cells[1].Value.ToString();
            txtTheLoai.Text = dataRow.Cells[2].Value.ToString();
            txtQuocGiaSanXuat.Text = dataRow.Cells[3].Value.ToString();
            txtDaoDien.Text= dataRow.Cells[4].Value.ToString();
            dtNgayKhoiChieu.Value = Convert.ToDateTime(dataRow.Cells[5].Value);
            ThoiLuong.Value = Convert.ToDecimal(dataRow.Cells[6].Value);
            txtDienVienThamGia.Text = dataRow.Cells[7].Value.ToString();
            txtNoiDung.Text = dataRow.Cells[8].Value.ToString();
            //Mã text-> hoá ảnh
            if (dataRow.Cells[9].Value.ToString() != "") //Nếu có ảnh thì hiển thị lên giao diện
            {
                string text = dataRow.Cells[9].Value.ToString();
                byte[] textArray = Convert.FromBase64String(text);
                MemoryStream memoryStream = new MemoryStream(textArray, 0, textArray.Length);
                ptbAnhPhim.Image = Image.FromStream(memoryStream, true);
            }
            else
            {
                ptbAnhPhim.Image = null;
            }
        }
        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            if (checkID(txtMaPhim.Text) == true)
            {
                MessageBox.Show("Mã phim " + txtMaPhim.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaPhim.Text != "" && txtTenPhim.Text != "" && txtTheLoai.Text != "" && txtQuocGiaSanXuat.Text != "" &&txtDaoDien.Text!=""
            && txtDienVienThamGia.Text != "" && txtNoiDung.Text != "")
            {
                if (ThoiLuong.Value == 0)
                {
                    MessageBox.Show("Thời lượng phim không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Mã hoá ảnh được chọn
                    string imagetext = "";
                    if (openFileDialog!=null)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                        imagetext = Convert.ToBase64String(imageArray);
                    }

                    dtbPhim.Rows.Add(txtMaPhim.Text, txtTenPhim.Text, txtTheLoai.Text, txtQuocGiaSanXuat.Text,txtDaoDien.Text,
                        dtNgayKhoiChieu.Value.ToString("dd/MM/yyyy"), ThoiLuong.Value.ToString(),
                        txtDienVienThamGia.Text, txtNoiDung.Text, imagetext);
                    openFileDialog = null;
                    //Reset control
                    txtMaPhim.Text = "";
                    txtTenPhim.Text = "";
                    txtTheLoai.Text = "";
                    txtQuocGiaSanXuat.Text = "";
                    txtDaoDien.Text = "";
                    ThoiLuong.Value = 0;
                    txtDienVienThamGia.Text = "";
                    txtNoiDung.Text = "";
                }

            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin phim", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            update();
        }
        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            if (txtMaPhim.Text != "" && txtTenPhim.Text != "" && txtTheLoai.Text != "" && txtQuocGiaSanXuat.Text != ""&&txtDaoDien.Text!=""
            && txtDienVienThamGia.Text != "" && txtNoiDung.Text != "")
            {
                int index = dgvPhim.SelectedRows[0].Index;        
                dtbPhim.Rows[index][0] = txtMaPhim.Text;
                dtbPhim.Rows[index][1] = txtTenPhim.Text;
                dtbPhim.Rows[index][2] = txtTheLoai.Text;
                dtbPhim.Rows[index][3] = txtQuocGiaSanXuat.Text;
                dtbPhim.Rows[index][4] = txtDaoDien.Text;
                dtbPhim.Rows[index][5] = dtNgayKhoiChieu.Value.ToString("dd/MM/yyyy");
                dtbPhim.Rows[index][6] = ThoiLuong.Value;
                dtbPhim.Rows[index][7] = txtDienVienThamGia.Text;
                dtbPhim.Rows[index][8] = txtNoiDung.Text;
                //Mã hoá ảnh
                if (openFileDialog != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    string imagetext = Convert.ToBase64String(imageArray);
                    dtbPhim.Rows[index][8] = imagetext;
                }
                update();
                MessageBox.Show("Cập nhật thông tin phim thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Bạn hãy điền đủ thông tin trước khi sửa thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá phim này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int ma = dgvPhim.SelectedRows[0].Index;
                dtbPhim.Rows.RemoveAt(ma);
                update();
            }
        }

        private void btnThongKePhim_Click(object sender, EventArgs e)
        {

        }
    }
}
