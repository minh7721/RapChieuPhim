using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapChieuPhim
{
    public partial class GheNgoi : Form
    {
        public GheNgoi(int soghe)
        {
            soghengoi = soghe;
            InitializeComponent();
        }
        int soghengoi;
        int soghechon ;
        private void GheNgoi_Load(object sender, EventArgs e)
        {
           for(int i=0;i<soghengoi;i++)
            {
                Button button = new Button();
                int textbutton = i + 1;
                button.Text = textbutton.ToString();
                button.Width = 50;
                button.Height = 50;
                flowLayoutPanel1.Controls.Add(button);
            }    
        }

        private Button Click()
        {
            throw new NotImplementedException();
        }
    }
}
