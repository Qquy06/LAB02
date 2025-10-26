using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace TH2
{
    public partial class bai6 : Form
    {
        string connectionString = "Data Source=.;Initial Catalog=monanhomnay;Integrated Security=True";
        Dictionary<string, string> dsAnh = new Dictionary<string, string>();
        Dictionary<string, string> dsNcc = new Dictionary<string, string>();
        Random rd = new Random();
        public bai6()
        {
            InitializeComponent();



        }

        private void bai6_Load(object sender, EventArgs e)
        {
            lb_monan.Items.Clear();
            dsAnh.Clear();
            lv_monan.View = View.Details;
            lv_monan.Columns.Clear();
            lv_monan.Items.Clear();

            lv_monan.Columns.Add("ID Món", 80);
            lv_monan.Columns.Add("Tên món ăn", 150);
            lv_monan.Columns.Add("Hình ảnh(link)", 300);
            lv_monan.Columns.Add("Người đăng", 150);
            lv_monan.Columns.Add("Quyền hạn", 150);


            string query = @"
                SELECT MA.IDMA, MA.TenMonAn, MA.HinhAnh, ND.HoVaTen , ND.QuyenHan
                FROM MonAn MA
                INNER JOIN NguoiDung ND ON MA.IDNCC = ND.IDNCC";

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))

                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(query, cn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        ListViewItem item = new ListViewItem(rd["IDMA"].ToString());
                        item.SubItems.Add(rd["TenMonAn"].ToString());
                        item.SubItems.Add(rd["HinhAnh"].ToString());
                        item.SubItems.Add(rd["HoVaTen"].ToString());

                        item.SubItems.Add(rd["QuyenHan"].ToString());


                        string tenMon = rd["TenMonAn"].ToString();
                        string linkAnh = rd["HinhAnh"].ToString();
                        string ncc = rd["HovaTen"].ToString();



                        lb_monan.Items.Add(tenMon);
                        pb_hinhanh.SizeMode = PictureBoxSizeMode.Zoom;

                        dsAnh[tenMon] = linkAnh;
                        dsNcc[tenMon] = ncc;
                        lv_monan.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }




        private void lb_monan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_monan_TextChanged(object sender, EventArgs e)
        {

        }



        private void btn__Click(object sender, EventArgs e)
        {
            lb_monanhomnay.Items.Clear();
            int soluong = lb_monan.Items.Count;
            if (soluong == 0)
            {
                MessageBox.Show("Chưa có món ăn trong danh sách!");
                return;
            }
            int index = rd.Next(0, soluong);
            string tenmonan = lb_monan.Items[index].ToString();
            lb_monanhomnay.Items.Add(tenmonan + "\n");
            lb_monanhomnay.Items.Add("Người Cung cấp: " + dsNcc[tenmonan]);
            pb_hinhanh.Load(dsAnh[tenmonan]);
        }

        private void pb_hinhanh_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

