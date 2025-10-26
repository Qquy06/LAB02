using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TH2
{
    public partial class bai4 : Form
    {
        class sinhvien
        {
            public string hoten { get; set; }
            public int mssv { get; set; }
            public float d1 { get; set; }
            public float d2 { get; set; }
            public float d3 { get; set; }
            public string sdt { get; set; }

            public float dtb()
            {
                return (d1 + d2 + d3) / 3.0f;
            }
        }

        public bai4()
        {
            InitializeComponent();
        }

        private readonly List<sinhvien> dssv = new List<sinhvien>();
        private int page = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            dssv.Clear();
            string[] lines = rtb_sv.Lines;
            bool dataError = false;
            string filePath = @"D:\HOCTAP\HKIII\NT106\TH\input4.txt";


            for (int i = 0; i + 5 < lines.Length; i += 6)
            {
                while (i < lines.Length && string.IsNullOrEmpty(lines[i]))
                {
                    i++;
                }

                if (i + 5 >= lines.Length) break;

                string name = lines[i];
                string idString = lines[i + 1];
                string phone = lines[i + 2];
                string d1String = lines[i + 3];
                string d2String = lines[i + 4];
                string d3String = lines[i + 5];

                int mssv_parsed;
                float d1_parsed, d2_parsed, d3_parsed;
                bool idValid = int.TryParse(idString, out mssv_parsed) && idString.Length == 8;
                bool phoneValid = phone.Length == 10 && phone.StartsWith("0");
                bool d1Valid = float.TryParse(d1String, out d1_parsed) && d1_parsed >= 0 && d1_parsed <= 10;
                bool d2Valid = float.TryParse(d2String, out d2_parsed) && d2_parsed >= 0 && d2_parsed <= 10;
                bool d3Valid = float.TryParse(d3String, out d3_parsed) && d3_parsed >= 0 && d3_parsed <= 10;

                if (!(idValid && phoneValid && d1Valid && d2Valid && d3Valid))
                {
                    dataError = true;
                    
                   

                    MessageBox.Show("Thông tin sai định dạng, Vui lòng nhập lại!", "Cảnh báo Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
                else
                {
                    sinhvien sv = new sinhvien
                    {
                        hoten = name,
                        mssv = mssv_parsed,
                        sdt = phone,
                        d1 = d1_parsed,
                        d2 = d2_parsed,
                        d3 = d3_parsed
                    };
                    dssv.Add(sv);
                }
            }

            if (!dataError && dssv.Count > 0)
            {
                try
                {
                    string directoryPath = Path.GetDirectoryName(filePath);
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    string json = JsonSerializer.Serialize(dssv, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);
                    MessageBox.Show("Đã ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi Ghi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (!dataError && dssv.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sinh viên hợp lệ để ghi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            page = 1;
            UpdateNavigationButtonStates();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            string filePath = @"D:\HOCTAP\HKIII\NT106\TH\input4.txt";
            dssv.Clear();

            try
            {
                string json = File.ReadAllText(filePath);
                List<sinhvien> loadedList = JsonSerializer.Deserialize<List<sinhvien>>(json);
                if (loadedList != null)
                {
                    dssv.AddRange(loadedList);
                    MessageBox.Show($"Đã đọc file thành công! Tìm thấy {dssv.Count} sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Lỗi: Không tìm thấy file tại đường dẫn:\n{filePath}", "Lỗi Đọc File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file: " + ex.Message, "Lỗi Đọc File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dssv.Count > 0)
            {
                page = 1;
                DisplayStudent(page);
            }
            else
            {
                ClearDisplayFields();
                page = 0;
                MessageBox.Show("File không chứa dữ liệu sinh viên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateNavigationButtonStates();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (page < dssv.Count)
            {
                page++;
                DisplayStudent(page);
            }
            UpdateNavigationButtonStates();
        }

        private void btn_backClick(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                DisplayStudent(page);
            }
            UpdateNavigationButtonStates();
        }

        private void DisplayStudent(int pageNumber)
        {
            if (pageNumber > 0 && pageNumber <= dssv.Count)
            {
                sinhvien sv = dssv[pageNumber - 1];
                tb_name.Text = sv.hoten;
                tb_id.Text = sv.mssv.ToString();
                tb_phone.Text = sv.sdt;
                tb_c1.Text = sv.d1.ToString();
                tb_c2.Text = sv.d2.ToString();
                tb_c3.Text = sv.d3.ToString();
                tb_avr.Text = sv.dtb().ToString("F2");
                tb_page.Text = $"{pageNumber} / {dssv.Count}";
            }
        }

        private void ClearDisplayFields()
        {
            tb_name.Text = string.Empty;
            tb_id.Text = string.Empty;
            tb_phone.Text = string.Empty;
            tb_c1.Text = string.Empty;
            tb_c2.Text = string.Empty;
            tb_c3.Text = string.Empty;
            tb_avr.Text = string.Empty;
            tb_page.Text = "0 / 0";
        }

        private void UpdateNavigationButtonStates()
        {
            if (dssv.Count == 0)
            {
                btn_back.Enabled = false;
                btn_next.Enabled = false;
            }
            else
            {
                btn_back.Enabled = (page > 1);
                btn_next.Enabled = (page < dssv.Count);
            }
        }

        private void bai4_Load(object sender, EventArgs e)
        {
            UpdateNavigationButtonStates();
        }
    }
}