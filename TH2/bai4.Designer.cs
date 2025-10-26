namespace TH2
{
    partial class bai4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            groupInput = new GroupBox();
            btn_save = new Button();
            rtb_sv = new RichTextBox();
            groupView = new GroupBox();
            btn_back = new Button();
            btn_next = new Button();
            btn_read = new Button();
            tb_page = new TextBox();
            label9 = new Label();
            tb_avr = new TextBox();
            label8 = new Label();
            tb_c3 = new TextBox();
            label7 = new Label();
            tb_c2 = new TextBox();
            label6 = new Label();
            tb_c1 = new TextBox();
            label5 = new Label();
            tb_phone = new TextBox();
            label4 = new Label();
            tb_id = new TextBox();
            label3 = new Label();
            tb_name = new TextBox();
            label2 = new Label();
            groupInput.SuspendLayout();
            groupView.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(860, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BÀI 4 - QUẢN LÝ SINH VIÊN ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupInput
            // 
            groupInput.Controls.Add(btn_save);
            groupInput.Controls.Add(rtb_sv);
            groupInput.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupInput.Location = new Point(12, 47);
            groupInput.Name = "groupInput";
            groupInput.Size = new Size(860, 220);
            groupInput.TabIndex = 1;
            groupInput.TabStop = false;
            groupInput.Text = "Nhập danh sách sinh viên (mỗi sinh viên 6 dòng)";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.LightSteelBlue;
            btn_save.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_save.Location = new Point(750, 90);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(90, 40);
            btn_save.TabIndex = 1;
            btn_save.Text = "💾 Ghi file";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += button1_Click;
            // 
            // rtb_sv
            // 
            rtb_sv.Location = new Point(15, 30);
            rtb_sv.Name = "rtb_sv";
            rtb_sv.Size = new Size(720, 170);
            rtb_sv.TabIndex = 0;
            rtb_sv.Text = "";
       
            // 
            // groupView
            // 
            groupView.Controls.Add(btn_back);
            groupView.Controls.Add(btn_next);
            groupView.Controls.Add(btn_read);
            groupView.Controls.Add(tb_page);
            groupView.Controls.Add(label9);
            groupView.Controls.Add(tb_avr);
            groupView.Controls.Add(label8);
            groupView.Controls.Add(tb_c3);
            groupView.Controls.Add(label7);
            groupView.Controls.Add(tb_c2);
            groupView.Controls.Add(label6);
            groupView.Controls.Add(tb_c1);
            groupView.Controls.Add(label5);
            groupView.Controls.Add(tb_phone);
            groupView.Controls.Add(label4);
            groupView.Controls.Add(tb_id);
            groupView.Controls.Add(label3);
            groupView.Controls.Add(tb_name);
            groupView.Controls.Add(label2);
            groupView.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupView.Location = new Point(12, 280);
            groupView.Name = "groupView";
            groupView.Size = new Size(860, 356);
            groupView.TabIndex = 2;
            groupView.TabStop = false;
            groupView.Text = "Xem thông tin sinh viên";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.LightCoral;
            btn_back.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_back.Location = new Point(37, 267);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(120, 40);
            btn_back.TabIndex = 5;
            btn_back.Text = "⬅ Trang trước";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_backClick;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.LightGreen;
            btn_next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_next.Location = new Point(340, 267);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(120, 40);
            btn_next.TabIndex = 4;
            btn_next.Text = "➡ Trang sau";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.LightSkyBlue;
            btn_read.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_read.Location = new Point(189, 190);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(120, 47);
            btn_read.TabIndex = 3;
            btn_read.Text = "📖 Đọc file";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // tb_page
            // 
            tb_page.Location = new Point(269, 276);
            tb_page.Name = "tb_page";
            tb_page.Size = new Size(40, 30);
            tb_page.TabIndex = 6;
            // 
            // label9
            // 
            label9.Location = new Point(189, 279);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 7;
            label9.Text = "Trang:";
            // 
            // tb_avr
            // 
            tb_avr.Location = new Point(723, 121);
            tb_avr.Name = "tb_avr";
            tb_avr.Size = new Size(80, 30);
            tb_avr.TabIndex = 8;
            // 
            // label8
            // 
            label8.Location = new Point(617, 128);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 9;
            label8.Text = "Điểm TB:";
            // 
            // tb_c3
            // 
            tb_c3.Location = new Point(503, 131);
            tb_c3.Name = "tb_c3";
            tb_c3.Size = new Size(80, 30);
            tb_c3.TabIndex = 10;
            // 
            // label7
            // 
            label7.Location = new Point(397, 128);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 11;
            label7.Text = "Điểm 3:";
            // 
            // tb_c2
            // 
            tb_c2.Location = new Point(290, 128);
            tb_c2.Name = "tb_c2";
            tb_c2.Size = new Size(80, 30);
            tb_c2.TabIndex = 12;
            // 
            // label6
            // 
            label6.Location = new Point(209, 131);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 13;
            label6.Text = "Điểm 2:";
            // 
            // tb_c1
            // 
            tb_c1.Location = new Point(99, 128);
            tb_c1.Name = "tb_c1";
            tb_c1.Size = new Size(80, 30);
            tb_c1.TabIndex = 14;
            // 
            // label5
            // 
            label5.Location = new Point(15, 128);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 15;
            label5.Text = "Điểm 1:";
            // 
            // tb_phone
            // 
            tb_phone.Location = new Point(503, 95);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new Size(150, 30);
            tb_phone.TabIndex = 16;
            // 
            // label4
            // 
            label4.Location = new Point(397, 95);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 17;
            label4.Text = "SĐT:";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(99, 88);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(120, 30);
            tb_id.TabIndex = 18;
           
            // 
            // label3
            // 
            label3.Location = new Point(15, 88);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 19;
            label3.Text = "MSSV:";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(99, 40);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(250, 30);
            tb_name.TabIndex = 20;
           
            // 
            // label2
            // 
            label2.Location = new Point(14, 40);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 21;
            label2.Text = "Họ tên:";
            // 
            // bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1072, 673);
            Controls.Add(groupView);
            Controls.Add(groupInput);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "bai4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4 - Quản lý sinh viên (JSON)";
            groupInput.ResumeLayout(false);
            groupView.ResumeLayout(false);
            groupView.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.RichTextBox rtb_sv;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox groupView;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_c1;
        private System.Windows.Forms.TextBox tb_c2;
        private System.Windows.Forms.TextBox tb_c3;
        private System.Windows.Forms.TextBox tb_avr;
        private System.Windows.Forms.TextBox tb_page;
        private System.Windows.Forms.Label label2, label3, label4, label5, label6, label7, label8, label9;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_back;
    }
}
