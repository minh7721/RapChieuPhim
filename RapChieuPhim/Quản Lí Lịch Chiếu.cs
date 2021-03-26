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
    public partial class Quản_Lí_Lịch_Chiếu : Form
    {
        DataTable dtbLichChieu = new DataTable();
        DataTable dtbPhim = new DataTable();
        DataTable dtbPhongChieu = new DataTable();
        public Quản_Lí_Lịch_Chiếu()
        {
            InitializeComponent();
        }

        private void Quản_Lí_Lịch_Chiếu_Load(object sender, EventArgs e)
        {

            //Load file LichChieu
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\LichChieu.js");
                string strjson = reader.ReadToEnd();
                dtbLichChieu = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbLichChieu.Columns.Add("Mã lịch chiếu");
                    dtbLichChieu.Columns.Add("Phim chiếu");
                    dtbLichChieu.Columns.Add("Ngày chiếu");
                    dtbLichChieu.Columns.Add("Ca chiếu");
                    dtbLichChieu.Columns.Add("Phòng chiếu");
                    dtbLichChieu.Columns.Add("Số vé bán ra");
                }
                dgvLichChieu.DataSource = dtbLichChieu;
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Lịch chiếu");
            }
            //Load file Phim gán dữ liệu cbPhim
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
                cbPhimChieu.DataSource = dtbPhim;
                cbPhimChieu.DisplayMember = dtbPhim.Columns[1].ToString();
                cbPhimChieu.ValueMember = dtbPhim.Columns[1].ToString();

                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu phim");
            }
            //Load file Phim gán dữ liệu cbPhongChieu
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\PhongChieu.js");
                string strjson = reader.ReadToEnd();
                dtbPhongChieu = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbPhongChieu.Columns.Add("Mã phòng chiếu");
                    dtbPhongChieu.Columns.Add("Số chỗ");
                    dtbPhongChieu.Columns.Add("Máy chiếu");
                    dtbPhongChieu.Columns.Add("Âm thanh");
                    dtbPhongChieu.Columns.Add("Diện tích");
                    dtbPhongChieu.Columns.Add("Tình trạng");
                    dtbPhongChieu.Columns.Add("Các thiết bị khác");
                }
                cbPhongChieu.DataSource = dtbPhongChieu;
                cbPhongChieu.DisplayMember = dtbPhongChieu.Columns[0].ToString();
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Phòng chiếu");
            }
            cbPhimChieu.SelectedItem = null;
            cbPhongChieu.SelectedItem = null;
            lblSoVe.Text = "0";
        }
        private bool checkID(string ma)
        {
            DataRow[] dtr = dtbLichChieu.Select("[Mã lịch chiếu]='" + ma + "'");
            if (dtr.Length != 0)
                return true;
            else
                return false;
        }
        private bool check(string ngaychieu, string cachieu, string phongchieu) //Kiểm tra xem có lịch chiếu nào trùng nhau 
        {
            string chuoitimkiem = "[Ngày chiếu]='" + ngaychieu + "'" + "AND[Ca chiếu]='" + cachieu + "'" + "AND[Phòng chiếu]='" + phongchieu + "'";
            DataRow[] dtr = dtbLichChieu.Select(chuoitimkiem);
            if (dtr.Length > 0)
                return true;
            else
                return false;
        }
        private void update()
        {
            try
            {
                string luufile = JsonConvert.SerializeObject(dtbLichChieu);
                System.IO.File.WriteAllText(@"E:\RapChieuPhim\RapChieuPhim\Data\LichChieu.js", luufile);
                txtMaLichChieu.Text = "";
                cbPhimChieu.Text = "";
                cbCaChieu.Text = "";
                cbPhongChieu.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            if (checkID(txtMaLichChieu.Text) == true)
            {
                MessageBox.Show("Mã lịch chiếu " + txtMaLichChieu.Text + " đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (check(dtNgayChieu.Value.ToString("dd/MM/yyyy"), cbCaChieu.Text, cbPhongChieu.Text) == true)
            {
                MessageBox.Show("Lịch chiếu đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaLichChieu.Text != "" && cbPhimChieu.Text != "" && cbCaChieu.Text != "" && cbPhimChieu.Text != "")
            {
                dtbLichChieu.Rows.Add(txtMaLichChieu.Text, cbPhimChieu.Text,
                    dtNgayChieu.Value.ToString("dd/MM/yyyy"), cbCaChieu.Text, cbPhongChieu.Text, lblSoVe.Text);
                update();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin lịch chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá lịch chiếu này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.OK)
                {
                    int ma = dgvLichChieu.SelectedRows[0].Index;
                    dtbLichChieu.Rows.RemoveAt(ma);
                    update();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có dữ liệu .");
            }

        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            try
            {
                if(check(dtNgayChieu.Value.ToString("dd/MM/yyyy"), cbCaChieu.Text, cbPhongChieu.Text) == true)
                {
                    MessageBox.Show("Lịch chiếu đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
                else if(txtMaLichChieu.Text != "" && cbPhimChieu.Text != "" && cbCaChieu.Text != "" && cbPhimChieu.Text != "")
                {
                    int index = dgvLichChieu.SelectedRows[0].Index;
                    dtbLichChieu.Rows[index][0] = txtMaLichChieu.Text;
                    dtbLichChieu.Rows[index][1] = cbPhimChieu.Text;
                    dtbLichChieu.Rows[index][2] = dtNgayChieu.Value.ToString("dd/MM/yyyy");
                    dtbLichChieu.Rows[index][3] = cbCaChieu.Text;
                    dtbLichChieu.Rows[index][4] = cbPhongChieu.Text;
                    dtbLichChieu.Rows[index][5] = lblSoVe.Text;
                    update();
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin lịch chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có dữ liệu lịch chiếu.");
                
            }
           
        }

        private void btnThongKePhim_Click(object sender, EventArgs e)
        {
            string chuoithongke = "";
            if (cbPhimChieu.Text != "")
            {
                if (chuoithongke == "")
                    chuoithongke = "[Phim chiếu]='" + cbPhimChieu.Text + "'";
                else
                    chuoithongke += "and [Phim chiếu]='" + cbPhimChieu.Text + "'";
            }
            if (dtNgayChieu.Value.ToString("dd/MM/yyyy") != "01/01/2021")
            {
                if (chuoithongke == "")
                    chuoithongke = "[Ngày chiếu]='" + dtNgayChieu.Value.ToString("dd/MM/yyyy") + "'";
                else
                    chuoithongke += "and [Ngày chiếu]='" + dtNgayChieu.Value.ToString("dd/MM/yyyy") + "'";
            }
           
            if (cbCaChieu.Text != "")
            {
                if (chuoithongke == "")
                    chuoithongke = "[Ca chiếu]='" + cbCaChieu.Text + "'";
                else
                    chuoithongke += "and [Ca chiếu]='" + cbCaChieu.Text + "'";
            }
            
            if (cbPhongChieu.Text != "")
            {
                if (chuoithongke == "")
                    chuoithongke = "[Phòng chiếu]='" + cbPhongChieu.Text + "'";
                else
                    chuoithongke += "and [Phòng chiếu]='" + cbPhongChieu.Text + "'";
            }
            DataRow[] lichchieu =  dtbLichChieu.Select(chuoithongke) ;
            DataTable thongke = new DataTable();
            thongke.Columns.Add("Mã lịch chiếu");
            thongke.Columns.Add("Phim chiếu");
            thongke.Columns.Add("Ngày chiếu");
            thongke.Columns.Add("Ca chiếu");
            thongke.Columns.Add("Phòng chiếu");
            thongke.Columns.Add("Số vé bán ra");
            foreach (DataRow item in lichchieu)

            {
                thongke.Rows.Add(item.ItemArray[0].ToString(), item.ItemArray[1].ToString(), item.ItemArray[2].ToString(), item.ItemArray[3].ToString(),
                    item.ItemArray[4].ToString(), item.ItemArray[5].ToString());
            }

            dgvLichChieu.DataSource = thongke;
        }

        private void cbPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in dtbPhongChieu.Rows)
            {
                if (item.ItemArray[0].ToString() == cbPhongChieu.Text)
                {
                    lblSoVe.Text = item.ItemArray[1].ToString();
                }
            }
        }

        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvLichChieu.SelectedRows[0];
            txtMaLichChieu.Text = dataRow.Cells[0].Value.ToString();
            cbPhimChieu.Text = dataRow.Cells[1].Value.ToString();
            dtNgayChieu.Value = Convert.ToDateTime(dataRow.Cells[2].Value);
            cbCaChieu.Text = dataRow.Cells[3].Value.ToString();
            cbPhongChieu.Text = dataRow.Cells[4].Value.ToString();
            lblSoVe.Text = dataRow.Cells[5].Value.ToString();
        }
    }
}
