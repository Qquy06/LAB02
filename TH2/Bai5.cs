using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongVe_Bai5
{
    public partial class Bai5 : Form
    {
        Dictionary<string, List<string>> dsPhim_Phong = new Dictionary<string, List<string>>();
        Dictionary<string, double> giaChuanPhim = new Dictionary<string, double>();
        Dictionary<string, HashSet<string>> gheDaMua = new Dictionary<string, HashSet<string>>();
        Dictionary<string, double> heSoGia = new Dictionary<string, double>()
        {
            { "Thường", 1.0 },
            { "VIP", 1.5 },
            { "Vớt", 0.7 }
        };
        Dictionary<string, ThongKePhim> thongKe = new Dictionary<string, ThongKePhim>();

        // ================= FORM ==================
        public Bai5()
        {
            InitializeComponent();
            DocDuLieuTuFile();
            NapDanhSachPhim();
            this.clb_chonghe.ItemCheck += new ItemCheckEventHandler(this.clb_chonve_ItemCheck);
        }

    
        class ThongKePhim
        {
            public string TenPhim { get; set; }
            public int SoVeBan { get; set; }
            public int TongSoVe { get; set; } = 15;
            public double TongDoanhThu { get; set; } = 0;
            public double TyLeBan => (double)SoVeBan / TongSoVe * 100;
        }

        private void DocDuLieuTuFile()
        {
            string file = "input5.txt";
            if (!File.Exists(file))
            {
                MessageBox.Show($"Không tìm thấy file {file}!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(file);
            string tenPhim = null;
            int gia = 0;
            List<string> phongList = new List<string>();

            foreach (string line in lines)
            {
                string trimmed = line.Trim();

                if (trimmed == "")
                {
                    if (tenPhim != null)
                    {
                        dsPhim_Phong[tenPhim] = new List<string>(phongList);
                        giaChuanPhim[tenPhim] = gia;
                        phongList.Clear();
                        gia = 0;
                        tenPhim = null;
                    }
                    continue;
                }

                if (tenPhim == null)
                    tenPhim = trimmed;
                else if (gia == 0)
                    gia = int.Parse(trimmed);
                else
                    phongList.Add(trimmed);
            }

            if (tenPhim != null)
            {
                dsPhim_Phong[tenPhim] = new List<string>(phongList);
                giaChuanPhim[tenPhim] = gia;
            }

            foreach (var dsPhong in dsPhim_Phong.Values)
                foreach (var p in dsPhong)
                    gheDaMua[p] = new HashSet<string>();
        }

        
        private void NapDanhSachPhim()
        {
            cb_phim.Items.Clear();
            cb_phim.Items.AddRange(dsPhim_Phong.Keys.ToArray());
        }

        private void cb_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_phongve.Items.Clear();
            if (cb_phim.SelectedItem == null) return;
            string phimChon = cb_phim.SelectedItem.ToString();

            if (dsPhim_Phong.ContainsKey(phimChon))
            {
                foreach (var phong in dsPhim_Phong[phimChon])
                    cb_phongve.Items.Add(phong);

                if (cb_phongve.Items.Count > 0)
                    cb_phongve.SelectedIndex = 0;
            }
        }

        private void cb_phongve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_phongve.SelectedItem != null)
                CapNhatDanhSachGhe(cb_phongve.SelectedItem.ToString());
        }

        // ================= GHẾ ==================
        private string XacDinhLoaiGhe(string ghe)
        {
            if (new[] { "A1", "A5", "C1", "C5" }.Contains(ghe)) return "Vớt";
            if (new[] { "B2", "B3", "B4" }.Contains(ghe)) return "VIP";
            return "Thường";
        }

        private void CapNhatDanhSachGhe(string phong)
        {
            clb_chonghe.Items.Clear();
            char hang = 'A';
            int soHang = 3;
            int soCot = 5;

            for (int i = 0; i < soHang; i++)
            {
                for (int j = 1; j <= soCot; j++)
                {
                    string tenGhe = $"{(char)(hang + i)}{j}";
                    string loai = XacDinhLoaiGhe(tenGhe);
                    bool daMua = gheDaMua[phong].Contains(tenGhe);
                    string hienThi = daMua ? $"{tenGhe} ({loai}) - ĐÃ MUA" : $"{tenGhe} ({loai})";
                    clb_chonghe.Items.Add(hienThi, false);
                }
            }
        }

        private void clb_chonve_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string text = clb_chonghe.Items[e.Index].ToString();
            if (text.Contains("ĐÃ MUA") && e.NewValue == CheckState.Checked)
            {
                e.NewValue = e.CurrentValue;
                MessageBox.Show("Ghế này đã được mua. Vui lòng chọn ghế khác.");
            }
        }

      
        private void btn_datve_Click(object sender, EventArgs e)
        {
            if (cb_phim.SelectedItem == null || cb_phongve.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn phim và phòng chiếu!");
                return;
            }

            if (clb_chonghe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!");
                return;
            }

            string tenKH = tb_khachhang.Text.Trim();
            if (tenKH == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                return;
            }

            string phong = cb_phongve.SelectedItem.ToString();
            string phim = cb_phim.SelectedItem.ToString();
            double giaChuan = giaChuanPhim[phim];
            List<string> gheChon = new List<string>();
            double tongTien = 0;

            foreach (var item in clb_chonghe.CheckedItems)
            {
                string text = item.ToString();
                string ghe = text.Split(' ')[0];
                string loai = XacDinhLoaiGhe(ghe);
                gheChon.Add(ghe);
                tongTien += giaChuan * heSoGia[loai];
                gheDaMua[phong].Add(ghe);
            }

            if (gheChon.Count > 2)
            {
                MessageBox.Show("Không thể chọn nhiều hơn 2 vé!");
                foreach (string ghe in gheChon)
                    gheDaMua[phong].Remove(ghe);
                CapNhatDanhSachGhe(phong);
                return;
            }


            if (!thongKe.ContainsKey(phim))
                thongKe[phim] = new ThongKePhim { TenPhim = phim };
            thongKe[phim].SoVeBan += gheChon.Count;

            string ve = string.Join(", ", gheChon);
            string formattedTongTien = tongTien.ToString("N0", new CultureInfo("vi-VN")) + " VND";
            thongKe[phim].TongDoanhThu += tongTien;

            string thongTin =
                $"Khách hàng: {tenKH}\nPhim: {phim}\nPhòng: {phong}\nGhế: {ve}\nTổng tiền: {formattedTongTien}";
            MessageBox.Show(thongTin, "Thông tin vé đã đặt");

            CapNhatDanhSachGhe(phong);
            tb_khachhang.Text = "";
        }

        private async void btn_xuatfile_Click(object sender, EventArgs e)
        {
            if (thongKe.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu thống kê!");
                return;
            }

            string fileOut = "output5.txt";
            progressBar1.Value = 0;

            using (StreamWriter sw = new StreamWriter(fileOut))
            {
                var sapXep = thongKe.Values.OrderByDescending(t => t.TongDoanhThu).ToList();
                int rank = 1;

                foreach (var item in sapXep)
                {
                    sw.WriteLine($"{rank}. {item.TenPhim}");
                    sw.WriteLine($"   Vé bán: {item.SoVeBan}");
                    sw.WriteLine($"   Vé tồn: {item.TongSoVe - item.SoVeBan}");
                    sw.WriteLine($"   Tỉ lệ bán: {item.TyLeBan:F2}%");
                    sw.WriteLine($"   Doanh thu: {item.TongDoanhThu.ToString("N0", new CultureInfo("vi-VN"))} VND");
                    sw.WriteLine();
                    await Task.Delay(500); // Giả lập tiến trình
                    progressBar1.Value = (int)(rank * 100.0 / sapXep.Count);
                    rank++;
                }
            }

            MessageBox.Show("Đã ghi thống kê ra file output5.txt", "Hoàn tất");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clb_chonve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
