namespace TH2
{
    partial class bai7 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify  
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            tvThuMuc = new TreeView();
            txtNoiDung = new RichTextBox();
            picHinh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinh).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvThuMuc);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtNoiDung);
            splitContainer1.Panel2.Controls.Add(picHinh);
            splitContainer1.Size = new Size(984, 701);
            splitContainer1.SplitterDistance = 328;
            splitContainer1.TabIndex = 0;
            // 
            // tvThuMuc
            // 
            tvThuMuc.Dock = DockStyle.Fill;
            tvThuMuc.Location = new Point(0, 0);
            tvThuMuc.Margin = new Padding(3, 4, 3, 4);
            tvThuMuc.Name = "tvThuMuc";
            tvThuMuc.Size = new Size(328, 701);
            tvThuMuc.TabIndex = 0;
            tvThuMuc.BeforeExpand += tvThuMuc_BeforeExpand;
            tvThuMuc.AfterSelect += tvThuMuc_AfterSelect;
            // 
            // txtNoiDung
            // 
            txtNoiDung.Dock = DockStyle.Fill;
            txtNoiDung.Location = new Point(0, 0);
            txtNoiDung.Margin = new Padding(3, 4, 3, 4);
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new Size(652, 701);
            txtNoiDung.TabIndex = 0;
            txtNoiDung.Text = "";
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            // 
            // picHinh
            // 
            picHinh.Dock = DockStyle.Fill;
            picHinh.Location = new Point(0, 0);
            picHinh.Margin = new Padding(3, 4, 3, 4);
            picHinh.Name = "picHinh";
            picHinh.Size = new Size(652, 701);
            picHinh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinh.TabIndex = 1;
            picHinh.TabStop = false;
            picHinh.Visible = false;
            // 
            // bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 701);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "bai7";
            Text = "Trình duyệt file & xem nội dung";
            Load += FrmTrinhDuyetFile_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinh).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvThuMuc;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.PictureBox picHinh;
    }
}
