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
using Newtonsoft.Json;
namespace RapChieuPhim
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DataTable dtbNhanvien = new DataTable();
        private DataTable Loadfile(string link)
        {
            StreamReader reader = new System.IO.StreamReader(link);
            string str = reader.ReadToEnd();
            return JsonConvert.DeserializeObject<DataTable>(str);
        }
        private DataRow seach(DataTable dtb)
        {
           DataRow[]dtr= dtb.Select("[Tài khoản]='"+txttaikhoan.Text+"'");
            if (dtr.Length != 0)
            {
                return dtr[0];
            }
            else
                return null;
        }
        private void DangNhap_Load(object sender, EventArgs e)
        {
            //Load file chứa dữ liệu tài khoản
              dtbNhanvien= Loadfile(@"E:\RapChieuPhim\RapChieuPhim\Data\NhanVien.js");
             
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (seach(dtbNhanvien) != null) //Nếu tìm thấy tên tài khoản trong file dữ liệu
            {    
                DataRow dtr = seach(dtbNhanvien);
                string passconvert = dtr.ItemArray[8].ToString();
                byte[] str = Convert.FromBase64String(passconvert);
                string pass= Encoding.Unicode.GetString(str);
                if (pass == txtmatkhau.Text&&dtr.ItemArray[9].ToString()=="Quản trị hệ thống")
                {
                    QuanLi quanLi = new QuanLi();
                    this.Hide();
                    quanLi.Show();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
