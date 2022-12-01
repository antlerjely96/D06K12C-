using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinhTongHieuTichThuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soA_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tinh_Click(object sender, EventArgs e)
        {
            double a = double.Parse(soA.Text);
            double b = double.Parse(soB.Text);
            double tong = a + b;
            double hieu = a - b;
            double thuong = a / b;
            double tich = a * b;
            tongAB.Text = "" + tong;
            hieuAB.Text = "" + hieu;
            tichAB.Text = "" + tich;
            thuongAB.Text = "" + thuong;
        }
    }
}