
using TH2;
using QLPhongVe_Bai5;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TH2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            bai1 b1 = new bai1();
            b1.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            bai2 b2 = new bai2();
            b2.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            bai3 b3 = new bai3();
            b3.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            bai4 b4 = new bai4();
            b4.Show();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            Bai5 b5 = new Bai5();
            b5.ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            bai6 b6 = new bai6();
            b6.ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            bai7 b7 = new bai7();
            b7.ShowDialog();
        }


        private void label_title_Click(object sender, EventArgs e)
        {

        }

        private void Lab2_Load(object sender, EventArgs e)
        {

        }
    }
}
