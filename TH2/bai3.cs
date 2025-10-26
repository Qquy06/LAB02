using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2
{
    public partial class bai3 : Form
    {
        public bai3()
        {
            InitializeComponent();
        }

        static List<double> computed = new List<double>();
        static List<string> maths = new List<string>();
        private static double Calculate(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return 0;
            s = s.Replace(" ", "");
            List<string> tokens = new List<string>();
            string num = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c) || c == '.')
                {
                    num += c;
                }
                else if ("+-*/".Contains(c))
                {
                    if (num != "")
                    {
                        tokens.Add(num);
                        num = "";
                    }
                    tokens.Add(c.ToString());
                }
            }
            if (num != "") tokens.Add(num);
            List<string> step1 = new List<string>();
            double temp = 0;

            for (int i = 0; i < tokens.Count; i++)
            {
                string t = tokens[i];
                if (t == "*" || t == "/")
                {
                    double left = double.Parse(step1.Last());
                    step1.RemoveAt(step1.Count - 1);
                    double right = double.Parse(tokens[++i]);
                    temp = (t == "*") ? left * right : left / right;
                    step1.Add(temp.ToString());
                }
                else
                {
                    step1.Add(t);
                }
            }
            double result = double.Parse(step1[0]);
            for (int i = 1; i < step1.Count; i += 2)
            {
                string op = step1[i];
                double val = double.Parse(step1[i + 1]);
                if (op == "+") result += val;
                else if (op == "-") result -= val;
            }

            return Math.Round(result, 2);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_doc_Click(object sender, EventArgs e)
        {
            try
            {
                computed.Clear();
                maths.Clear();
                using (StreamReader rd = new StreamReader("input3.txt"))
                {
                    rtb_NoiDung.Text = rd.ReadToEnd();
                    maths = rtb_NoiDung.Text.Split('\n').ToList();
                    foreach (string math in maths)
                    {
                        computed.Add(Calculate(math));
                    }
                    MessageBox.Show("Đã đọc thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đọc file, {ex.Message}");
            }
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {

            try
            {
                using (StreamWriter wt = new StreamWriter("output3.txt", true))
                {
                    for (int i = 0; i < maths.Count; i++)


                    {
                        string temp = maths[i] + " = " + computed[i].ToString();
                        wt.WriteLine(temp);
                    }
                    MessageBox.Show("Đã ghi thành công!", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi ghi file, {ex.Message}");
            }
        }

        private void rtbNoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
