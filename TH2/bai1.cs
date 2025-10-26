namespace TH2
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"D:\HOCTAP\HKIII\NT106\TH\input1.txt"))


                {
                    MessageBox.Show("Đã đọc file thành công!", "Thông báo", MessageBoxButtons.OK);
                    rtb_noidung.Text = sr.ReadToEnd();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file!", "Cảnh báo", MessageBoxButtons.OK);
            }

        }

        private void bai1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"D:\HOCTAP\HKIII\NT106\TH\output1.txt"))
                {
                    rtb_noidung.Text.ToUpper();
                    sw.Write(rtb_noidung.Text);
                    MessageBox.Show("Đã ghi file thành công", "Thông báo", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file!", "Cảnh báo", MessageBoxButtons.OK);

            }

        }

        private void rtb_noidung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
