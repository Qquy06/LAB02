namespace QLPhongVe_Bai5
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            cb_phim = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cb_phongve = new ComboBox();
            tb_khachhang = new TextBox();
            btn_datve = new Button();
            btn_xuatfile = new Button();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            clb_chonghe = new CheckedListBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cb_phim
            // 
            cb_phim.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_phim.FormattingEnabled = true;
            cb_phim.Location = new Point(120, 38);
            cb_phim.Margin = new Padding(3, 4, 3, 4);
            cb_phim.Name = "cb_phim";
            cb_phim.Size = new Size(200, 24);
            cb_phim.TabIndex = 0;
            cb_phim.SelectedIndexChanged += cb_phim_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 41);
            label1.Name = "label1";
            label1.Size = new Size(74, 16);
            label1.TabIndex = 1;
            label1.Text = "Chọn Phim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 91);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 3;
            label2.Text = "Chọn Phòng:";
            // 
            // cb_phongve
            // 
            cb_phongve.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_phongve.FormattingEnabled = true;
            cb_phongve.Location = new Point(120, 88);
            cb_phongve.Margin = new Padding(3, 4, 3, 4);
            cb_phongve.Name = "cb_phongve";
            cb_phongve.Size = new Size(200, 24);
            cb_phongve.TabIndex = 2;
            cb_phongve.SelectedIndexChanged += cb_phongve_SelectedIndexChanged;
            // 
            // tb_khachhang
            // 
            tb_khachhang.Location = new Point(120, 138);
            tb_khachhang.Margin = new Padding(3, 4, 3, 4);
            tb_khachhang.Name = "tb_khachhang";
            tb_khachhang.Size = new Size(200, 22);
            tb_khachhang.TabIndex = 6;
            // 
            // btn_datve
            // 
            btn_datve.BackColor = Color.PaleGreen;
            btn_datve.FlatAppearance.BorderSize = 0;
            btn_datve.FlatStyle = FlatStyle.Flat;
            btn_datve.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_datve.Location = new Point(20, 38);
            btn_datve.Margin = new Padding(3, 4, 3, 4);
            btn_datve.Name = "btn_datve";
            btn_datve.Size = new Size(300, 50);
            btn_datve.TabIndex = 7;
            btn_datve.Text = "ĐẶT VÉ ";
            btn_datve.UseVisualStyleBackColor = false;
            btn_datve.Click += btn_datve_Click;
            // 
            // btn_xuatfile
            // 
            btn_xuatfile.BackColor = Color.LightSkyBlue;
            btn_xuatfile.FlatAppearance.BorderSize = 0;
            btn_xuatfile.FlatStyle = FlatStyle.Flat;
            btn_xuatfile.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_xuatfile.Location = new Point(20, 100);
            btn_xuatfile.Margin = new Padding(3, 4, 3, 4);
            btn_xuatfile.Name = "btn_xuatfile";
            btn_xuatfile.Size = new Size(300, 50);
            btn_xuatfile.TabIndex = 8;
            btn_xuatfile.Text = "XUẤT THỐNG KÊ RA FILE";
            btn_xuatfile.UseVisualStyleBackColor = false;
            btn_xuatfile.Click += btn_xuatfile_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(20, 162);
            progressBar1.Margin = new Padding(3, 4, 3, 4);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 25);
            progressBar1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 141);
            label4.Name = "label4";
            label4.Size = new Size(80, 16);
            label4.TabIndex = 10;
            label4.Text = "Khách hàng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cb_phim);
            groupBox1.Controls.Add(tb_khachhang);
            groupBox1.Controls.Add(cb_phongve);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(340, 188);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "THÔNG TIN ĐẶT VÉ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_datve);
            groupBox3.Controls.Add(btn_xuatfile);
            groupBox3.Controls.Add(progressBar1);
            groupBox3.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(12, 219);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(340, 215);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "TÁC VỤ";
            // 
            // clb_chonghe
            // 
            clb_chonghe.CheckOnClick = true;
            clb_chonghe.FormattingEnabled = true;
            clb_chonghe.Location = new Point(6, 12);
            clb_chonghe.Margin = new Padding(3, 4, 3, 4);
            clb_chonghe.Name = "clb_chonghe";
            clb_chonghe.Size = new Size(320, 310);
            clb_chonghe.TabIndex = 4;
            clb_chonghe.SelectedIndexChanged += clb_chonve_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(clb_chonghe);
            groupBox2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(365, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(350, 338);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 441);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Bai5";
            Text = "Quản Lý Bán Vé Xem Phim - Phiên bản nâng cao";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_phim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_phongve;
        private System.Windows.Forms.CheckedListBox clb_chonghe;
        private System.Windows.Forms.TextBox tb_khachhang;
        private System.Windows.Forms.Button btn_datve;
        private System.Windows.Forms.Button btn_xuatfile;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}