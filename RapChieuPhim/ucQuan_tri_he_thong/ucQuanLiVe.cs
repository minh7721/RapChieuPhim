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
    public partial class ucQuanLiVe : UserControl
    {
        public ucQuanLiVe()
        {
            InitializeComponent();
        }
        DataTable dtbVe = new DataTable();
        DataTable dtbLichChieu = new DataTable();
        private void LoadPhim()
        {
            DataRow[] dtr = dtbLichChieu.Select("[Ngày chiếu]='" + dtNgayChieu.Value.ToString("dd/MM/yyyy") + "'");
            DataTable dtbketqua = new DataTable();
            dtbketqua.Columns.Add("Phim chiếu");
            dtbketqua.Columns.Add("Ngày chiếu");
            foreach (DataRow item in dtr)
            {
                //Kiểm tra nếu tên phim trùng không thêm
                DataRow []check= dtbketqua.Select("[Phim chiếu]='" + item.ItemArray[1]+"'");
                if (check.Length==0)
                dtbketqua.Rows.Add(item.ItemArray[1], item.ItemArray[2]);
            }
            cbTenPhim.DataSource = dtbketqua;
            cbTenPhim.DisplayMember = dtbketqua.Columns[0].ToString();
        }
        private void ucQuanLiVe_Load(object sender, EventArgs e)
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
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa có file dữ liệu Phòng chiếu");
            }
            //Load tên phim với ngày hiện tại
            LoadPhim();
        }

        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void dtNgayChieu_Leave(object sender, EventArgs e)
        {
            //Sau khi chọn thời gian sẽ load phim cùng thời gian đó
            LoadPhim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chongoi = 50;
            GheNgoi gheNgoi = new GheNgoi(chongoi);
            gheNgoi.ShowDialog();
        }
    }
}
