using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace TH2
{
    public partial class bai7 : Form
    {
        public bai7()
        {
            InitializeComponent();
        }

        private void FrmTrinhDuyetFile_Load(object sender, EventArgs e)
        {
            LoadDrives();
            txtNoiDung.Visible = true;
            picHinh.Visible = false;
        }

        private void LoadDrives()
        {
            tvThuMuc.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name)
                {
                    Tag = drive.Name
                };
                node.Nodes.Add(string.Empty);
                tvThuMuc.Nodes.Add(node);
            }
        }

        private void tvThuMuc_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.Tag.ToString();
            node.Nodes.Clear();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

            
                foreach (DirectoryInfo subDir in dir.GetDirectories())
                {
                    TreeNode subNode = new TreeNode(subDir.Name)
                    {
                        Tag = subDir.FullName
                    };
                    subNode.Nodes.Add(string.Empty);
                    node.Nodes.Add(subNode);
                }

              
                foreach (FileInfo file in dir.GetFiles())
                {
                    TreeNode subNode = new TreeNode(file.Name)
                    {
                        Tag = file.FullName
                    };
                    node.Nodes.Add(subNode);
                }
            }
            catch
            {
                MessageBox.Show("Không thể mở thư mục này!", "Lỗi truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TryShowImage(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            string[] imgExts = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

            if (Array.Exists(imgExts, e => e == ext))
            {
                try
                {
                    using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        picHinh.Image = Image.FromStream(fs);
                    }
                    picHinh.Visible = true;
                    txtNoiDung.Visible = false;
                    return true;
                }
                catch
                {
                    MessageBox.Show("Không thể hiển thị hình ảnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            picHinh.Visible = false;
            txtNoiDung.Visible = true;
            return false;
        }

        private void tvThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();

            if (File.Exists(path))
            {
                
                if (TryShowImage(path)) return;

                try
                {
                  
                    txtNoiDung.Text = File.ReadAllText(path, Encoding.UTF8);
                }
                catch
                {
                    MessageBox.Show("Không thể đọc file văn bản này!", "Lỗi đọc file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNoiDung.Clear();
                }

                txtNoiDung.Visible = true;
                picHinh.Visible = false;
            }
            else
            {
                txtNoiDung.Clear();
                picHinh.Image = null;
                txtNoiDung.Visible = true;
                picHinh.Visible = false;
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
