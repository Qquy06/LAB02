namespace TH2
{
    partial class bai6
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
            lblKetQua = new Label();
            btn_timMonAn = new Button();
            lv_monan = new ListView();
            pb_hinhanh = new PictureBox();
            lb_monan = new ListBox();
            lb_monanhomnay = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pb_hinhanh).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTieuDe.ForeColor = Color.DarkRed;
            lblTieuDe.Location = new Point(520, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(349, 41);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "🍽 MÓN ĂN HÔM NAY";
            // 
            // lblKetQua
            // 
            lblKetQua.AutoSize = true;
            lblKetQua.Font = new Font("Segoe UI", 12F);
            lblKetQua.Location = new Point(280, 100);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(184, 28);
            lblKetQua.TabIndex = 1;
            lblKetQua.Text = "Món ăn hôm nay là:";
            // 
            // btn_timMonAn
            // 
            btn_timMonAn.BackColor = Color.PeachPuff;
            btn_timMonAn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_timMonAn.Location = new Point(30, 220);
            btn_timMonAn.Name = "btn_timMonAn";
            btn_timMonAn.Size = new Size(150, 45);
            btn_timMonAn.TabIndex = 3;
            btn_timMonAn.Text = "🎲 Chọn món";
            btn_timMonAn.UseVisualStyleBackColor = false;
            btn_timMonAn.Click += btn__Click;
            // 
            // lv_monan
            // 
            lv_monan.BackColor = SystemColors.Window;
            lv_monan.FullRowSelect = true;
            lv_monan.GridLines = true;
            lv_monan.Location = new Point(860, 80);
            lv_monan.Name = "lv_monan";
            lv_monan.Size = new Size(940, 320);
            lv_monan.TabIndex = 4;
            lv_monan.UseCompatibleStateImageBehavior = false;
            lv_monan.View = View.Details;
            lv_monan.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // pb_hinhanh
            // 
            pb_hinhanh.BorderStyle = BorderStyle.FixedSingle;
            pb_hinhanh.Location = new Point(231, 192);
            pb_hinhanh.Name = "pb_hinhanh";
            pb_hinhanh.Size = new Size(589, 321);
            pb_hinhanh.SizeMode = PictureBoxSizeMode.Zoom;
            pb_hinhanh.TabIndex = 5;
            pb_hinhanh.TabStop = false;
            pb_hinhanh.Click += pb_hinhanh_Click;
            // 
            // lb_monan
            // 
            lb_monan.FormattingEnabled = true;
            lb_monan.Location = new Point(30, 70);
            lb_monan.Name = "lb_monan";
            lb_monan.Size = new Size(180, 124);
            lb_monan.TabIndex = 6;
            lb_monan.Visible = false;
            lb_monan.SelectedIndexChanged += lb_monan_SelectedIndexChanged;
            // 
            // lb_monanhomnay
            // 
            lb_monanhomnay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lb_monanhomnay.FormattingEnabled = true;
            lb_monanhomnay.ItemHeight = 28;
            lb_monanhomnay.Location = new Point(497, 100);
            lb_monanhomnay.Name = "lb_monanhomnay";
            lb_monanhomnay.Size = new Size(323, 60);
            lb_monanhomnay.TabIndex = 7;
            lb_monanhomnay.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1830, 650);
            Controls.Add(lb_monanhomnay);
            Controls.Add(lb_monan);
            Controls.Add(pb_hinhanh);
            Controls.Add(lv_monan);
            Controls.Add(btn_timMonAn);
            Controls.Add(lblKetQua);
            Controls.Add(lblTieuDe);
            Name = "bai6";
            Text = "Món ăn hôm nay";
            Load += bai6_Load;
            ((System.ComponentModel.ISupportInitialize)pb_hinhanh).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btn_timMonAn;
        private System.Windows.Forms.ListView lv_monan;
        private System.Windows.Forms.PictureBox pb_hinhanh;
        private System.Windows.Forms.ListBox lb_monan;
        private ListBox lb_monanhomnay;
    }
}
