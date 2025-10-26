namespace TH2
{
    partial class bai3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            btnDoc = new Button();
            btnGhi = new Button();
            btnThoat = new Button();
            rtb_NoiDung = new RichTextBox();
            pnlNut = new Panel();
            pnlNut.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.MidnightBlue;
            lblTieuDe.Location = new Point(0, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(800, 60);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "📁 Đọc - Ghi File Và Tính Toán";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDoc
            // 
            btnDoc.BackColor = Color.LightSteelBlue;
            btnDoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDoc.Location = new Point(107, 15);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(107, 40);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "📖 Đọc File";
            btnDoc.UseVisualStyleBackColor = false;
            btnDoc.Click += btn_doc_Click;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = Color.LightGreen;
            btnGhi.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGhi.Location = new Point(329, 15);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(107, 40);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "💾 Ghi File";
            btnGhi.UseVisualStyleBackColor = false;
            btnGhi.Click += btn_ghi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightCoral;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnThoat.Location = new Point(551, 15);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(107, 40);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "❌ Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btn_thoat_Click;
            // 
            // rtb_NoiDung
            // 
            rtb_NoiDung.BackColor = Color.White;
            rtb_NoiDung.Dock = DockStyle.Fill;
            rtb_NoiDung.Font = new Font("Consolas", 12F);
            rtb_NoiDung.Location = new Point(0, 130);
            rtb_NoiDung.Name = "rtb_NoiDung";
            rtb_NoiDung.Size = new Size(800, 470);
            rtb_NoiDung.TabIndex = 2;
            rtb_NoiDung.Text = "";
            rtb_NoiDung.TextChanged += rtbNoiDung_TextChanged;
            // 
            // pnlNut
            // 
            pnlNut.BackColor = Color.AliceBlue;
            pnlNut.Controls.Add(btnDoc);
            pnlNut.Controls.Add(btnGhi);
            pnlNut.Controls.Add(btnThoat);
            pnlNut.Dock = DockStyle.Top;
            pnlNut.Location = new Point(0, 60);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(800, 70);
            pnlNut.TabIndex = 1;
            // 
            // bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 600);
            Controls.Add(rtb_NoiDung);
            Controls.Add(pnlNut);
            Controls.Add(lblTieuDe);
            Name = "bai3";
            Text = "Bài 3 - Đọc Ghi File";
            pnlNut.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RichTextBox rtb_NoiDung;
        private System.Windows.Forms.Panel pnlNut;
    }
}
