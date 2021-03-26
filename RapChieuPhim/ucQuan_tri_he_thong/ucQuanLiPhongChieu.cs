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
    public partial class ucQuanLiPhongChieu : UserControl
    {
        public ucQuanLiPhongChieu()
        {
            InitializeComponent();
        }
        DataTable dtbPhongChieu = new DataTable();
        private void ucQuanLiPhongChieu_Load(object sender, EventArgs e)
        {
            //Load file PhongChieu
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
                dgvPhongChieu.DataSource = dtbPhongChieu;
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Phòng chiếu");
            }
        }

        private bool checkID(string ma)
        {
            DataRow[] dtr = dtbPhongChieu.Select("[Mã phòng chiếu]='" + ma + "'");
            if (dtr.Length != 0)
                return true;
            else
                return false;
        }
        private void update()
        {
            try
            {
                string lưufile = JsonConvert.SerializeObject(dtbPhongChieu);
                System.IO.File.WriteAllText(@"E:\RapChieuPhim\RapChieuPhim\Data\PhongChieu.js", lưufile);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnThemPhongChieu_Click(object sender, EventArgs e)
        {
            if(checkID(txtMaPhongChieu.Text)==true)
            {
                MessageBox.Show("Mã phòng chiếu " + txtMaPhongChieu.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else if(SoCho.Value==0)
            {
                MessageBox.Show("Số chỗ không hợp lệ!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (DienTich.Value == 0)
            {
                MessageBox.Show("Diện tích phòng chiếu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtMaPhongChieu.Text!=""&&cbMayChieu.Text!=""&&cbAmThanh.Text!=""&&cbTinhTrang.Text!="")
            {
                dtbPhongChieu.Rows.Add(txtMaPhongChieu.Text, SoCho.Value, cbMayChieu.Text, cbAmThanh.Text, DienTich.Value, cbTinhTrang.Text, txtCacThietBiKhac.Text);
                update();
            }    
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin phòng chiếu","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }    
        }

        private void btnSuaPhongChieu_Click(object sender, EventArgs e)
        {
              if (SoCho.Value == 0)
            {
                MessageBox.Show("Số chỗ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DienTich.Value == 0)
            {
                MessageBox.Show("Diện tích phòng chiếu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMaPhongChieu.Text != "" && cbMayChieu.Text != "" && cbAmThanh.Text != "" && cbTinhTrang.Text != "")
            {
                int index = dgvPhongChieu.SelectedRows[0].Index;
                dtbPhongChieu.Rows[index][0] = txtMaPhongChieu.Text;
                dtbPhongChieu.Rows[index][1] = SoCho.Value;
                dtbPhongChieu.Rows[index][2] = cbMayChieu.Text;
                dtbPhongChieu.Rows[index][3] = cbAmThanh.Text;
                dtbPhongChieu.Rows[index][4] = DienTich.Value;
                dtbPhongChieu.Rows[index][5] = cbTinhTrang.Text;
                dtbPhongChieu.Rows[index][6] = txtCacThietBiKhac.Text;
                update();
                MessageBox.Show("Cập nhật thông tin phòng chiếu thành công!", "Thông báo", MessageBoxButtons.OK);
            }    
        }

        private void dgvPhongChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataRow = dgvPhongChieu.SelectedRows[0];
            txtMaPhongChieu.Text=dataRow.Cells[0].Value.ToString();
            SoCho.Value = Convert.ToDecimal (dataRow.Cells[1].Value);
            cbMayChieu.Text = dataRow.Cells[2].Value.ToString();
            cbAmThanh.Text = dataRow.Cells[3].Value.ToString();
            DienTich.Value = Convert.ToDecimal(dataRow.Cells[4].Value);
            cbTinhTrang.Text = dataRow.Cells[5].Value.ToString();
            txtCacThietBiKhac.Text = dataRow.Cells[6].Value.ToString();
        }

        private void btnXoaPhongChieu_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn xoá phòng chiếu này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.OK)
            {
                int ma = dgvPhongChieu.SelectedRows[0].Index;
                dtbPhongChieu.Rows.RemoveAt(ma);
                update();
            }
        }
    }
}
