namespace TH2
{
    partial class bai1
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
            lbl_title = new Label();
            rtb_noidung = new RichTextBox();
            btn_doc = new Button();
            btn_ghi = new Button();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lbl_title.ForeColor = Color.DodgerBlue;
            lbl_title.Location = new Point(160, 20);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(289, 38);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "📝 Đọc & Ghi File TXT";
            // 
            // rtb_noidung
            // 
            rtb_noidung.BackColor = Color.White;
            rtb_noidung.BorderStyle = BorderStyle.FixedSingle;
            rtb_noidung.Font = new Font("Segoe UI", 11F);
            rtb_noidung.Location = new Point(40, 80);
            rtb_noidung.Name = "rtb_noidung";
            rtb_noidung.Size = new Size(520, 250);
            rtb_noidung.TabIndex = 1;
            rtb_noidung.Text = "";
            rtb_noidung.TextChanged += rtb_noidung_TextChanged;
            // 
            // btn_doc
            // 
            btn_doc.BackColor = Color.SteelBlue;
            btn_doc.FlatAppearance.BorderSize = 0;
            btn_doc.FlatStyle = FlatStyle.Flat;
            btn_doc.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_doc.ForeColor = Color.White;
            btn_doc.Location = new Point(120, 350);
            btn_doc.Name = "btn_doc";
            btn_doc.Size = new Size(140, 45);
            btn_doc.TabIndex = 2;
            btn_doc.Text = "📂 Đọc File";
            btn_doc.UseVisualStyleBackColor = false;
            btn_doc.Click += button1_Click;
            // 
            // btn_ghi
            // 
            btn_ghi.BackColor = Color.MediumSeaGreen;
            btn_ghi.FlatAppearance.BorderSize = 0;
            btn_ghi.FlatStyle = FlatStyle.Flat;
            btn_ghi.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_ghi.ForeColor = Color.White;
            btn_ghi.Location = new Point(320, 350);
            btn_ghi.Name = "btn_ghi";
            btn_ghi.Size = new Size(140, 45);
            btn_ghi.TabIndex = 3;
            btn_ghi.Text = "💾 Ghi File";
            btn_ghi.UseVisualStyleBackColor = false;
            btn_ghi.Click += btn_ghi_Click;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(600, 420);
            Controls.Add(btn_ghi);
            Controls.Add(btn_doc);
            Controls.Add(rtb_noidung);
            Controls.Add(lbl_title);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1 - Đọc & Ghi File Văn Bản";
            Load += bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.RichTextBox rtb_noidung;
        private System.Windows.Forms.Button btn_doc;
        private System.Windows.Forms.Button btn_ghi;
    }
}
