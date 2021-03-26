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
    public partial class quanliphongchieu : Form
    {
        public quanliphongchieu()
        {
            InitializeComponent();
        }
        DataTable dtbPhongChieu = new DataTable();
        private void quanliphongchieu_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader = new System.IO.StreamReader(@"E:\RapChieuPhim\RapChieuPhim\Data\PhongChieu.js");
                string strjson = reader.ReadToEnd();
                dtbPhongChieu = JsonConvert.DeserializeObject<DataTable>(strjson);
                if (strjson == "[]")
                {
                    dtbPhongChieu.Columns.Add("Mã phòng  chiếu");
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

        private void btnThemPhongChieu_Click(object sender, EventArgs e)
        {

        }
    }
}
