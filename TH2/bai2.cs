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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bai2_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    richTextBox1.Text = sr.ReadToEnd();


                }
                tb_name.Text = ofd.SafeFileName.ToString();
                tb_url.Text = ofd.FileName.ToString();

                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    int d = 0;
                    while (sr.ReadLine() != null)
                    {
                        d++;
                    }
                    tb_linecount.Text = d.ToString();



                    int c = 0;
                    char[] ch = richTextBox1.Text.Trim().ToCharArray();
                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (!char.IsWhiteSpace(ch[i]))
                            c++;
                    }
                    tb_char.Text = c.ToString();
                }


                char[] separators = { ' ', '\n', '\r', '\t' };
                int wordCount = richTextBox1.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;

                tb_words.Text = wordCount.ToString();


                FileInfo file = new FileInfo(ofd.FileName);
                tb_size.Text = file.Length.ToString() + " Bytes";

            }

            catch { }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bai2_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBoxInfo_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
