namespace TH2
{
    partial class bai2
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
            labelTitle = new Label();
            groupBoxInfo = new GroupBox();
            tb_size = new TextBox();
            label6 = new Label();
            tb_char = new TextBox();
            label5 = new Label();
            tb_words = new TextBox();
            label4 = new Label();
            tb_linecount = new TextBox();
            label3 = new Label();
            tb_url = new TextBox();
            label2 = new Label();
            tb_name = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            btn_read = new Button();
            btn_exit = new Button();
            label7 = new Label();
            groupBoxInfo.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkBlue;
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(776, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐỌC NỘI DUNG FILE VĂN BẢN";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(tb_size);
            groupBoxInfo.Controls.Add(label6);
            groupBoxInfo.Controls.Add(tb_char);
            groupBoxInfo.Controls.Add(label5);
            groupBoxInfo.Controls.Add(tb_words);
            groupBoxInfo.Controls.Add(label4);
            groupBoxInfo.Controls.Add(tb_linecount);
            groupBoxInfo.Controls.Add(label3);
            groupBoxInfo.Controls.Add(tb_url);
            groupBoxInfo.Controls.Add(label2);
            groupBoxInfo.Controls.Add(tb_name);
            groupBoxInfo.Controls.Add(label1);
            groupBoxInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxInfo.Location = new Point(12, 53);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new Size(813, 180);
            groupBoxInfo.TabIndex = 1;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin file";
            groupBoxInfo.Enter += groupBoxInfo_Enter;
            // 
            // tb_size
            // 
            tb_size.Location = new Point(720, 88);
            tb_size.Name = "tb_size";
            tb_size.ReadOnly = true;
            tb_size.Size = new Size(87, 30);
            tb_size.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(614, 91);
            label6.Name = "label6";
            label6.Size = new Size(130, 23);
            label6.TabIndex = 1;
            label6.Text = "Kích thước:";
            // 
            // tb_char
            // 
            tb_char.Location = new Point(490, 88);
            tb_char.Name = "tb_char";
            tb_char.ReadOnly = true;
            tb_char.Size = new Size(100, 30);
            tb_char.TabIndex = 2;
            // 
            // label5
            // 
            label5.Location = new Point(408, 91);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 3;
            label5.Text = "Số ký tự:";
            label5.Click += label5_Click;
            // 
            // tb_words
            // 
            tb_words.Location = new Point(302, 88);
            tb_words.Name = "tb_words";
            tb_words.ReadOnly = true;
            tb_words.Size = new Size(100, 30);
            tb_words.TabIndex = 4;
            // 
            // label4
            // 
            label4.Location = new Point(236, 90);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 5;
            label4.Text = "Số từ:";
            // 
            // tb_linecount
            // 
            tb_linecount.Location = new Point(130, 88);
            tb_linecount.Name = "tb_linecount";
            tb_linecount.ReadOnly = true;
            tb_linecount.Size = new Size(100, 30);
            tb_linecount.TabIndex = 6;
            // 
            // label3
            // 
            label3.Location = new Point(20, 90);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "Số dòng:";
            // 
            // tb_url
            // 
            tb_url.Location = new Point(130, 58);
            tb_url.Name = "tb_url";
            tb_url.ReadOnly = true;
            tb_url.Size = new Size(584, 30);
            tb_url.TabIndex = 8;
            // 
            // label2
            // 
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 9;
            label2.Text = "Đường dẫn:";
            // 
            // tb_name
            // 
            tb_name.Location = new Point(130, 28);
            tb_name.Name = "tb_name";
            tb_name.ReadOnly = true;
            tb_name.Size = new Size(584, 30);
            tb_name.TabIndex = 10;
            // 
            // label1
            // 
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 11;
            label1.Text = "Tên file:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(43, 264);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 270);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // btn_read
            // 
            btn_read.BackColor = Color.LightSteelBlue;
            btn_read.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_read.Location = new Point(220, 540);
            btn_read.Name = "btn_read";
            btn_read.Size = new Size(150, 40);
            btn_read.TabIndex = 3;
            btn_read.Text = "📂 Đọc file";
            btn_read.UseVisualStyleBackColor = false;
            btn_read.Click += btn_read_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.LightCoral;
            btn_exit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_exit.Location = new Point(462, 540);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(150, 40);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "❌ Thoát";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 241);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 5;
            label7.Text = "Nội dung";
            label7.Click += label7_Click;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 580);
            Controls.Add(label7);
            Controls.Add(btn_exit);
            Controls.Add(btn_read);
            Controls.Add(richTextBox1);
            Controls.Add(groupBoxInfo);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "bai2";
            StartPosition = FormStartPosition.CenterScreen;
            Load += bai2_Load_1;
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_linecount;
        private System.Windows.Forms.TextBox tb_words;
        private System.Windows.Forms.TextBox tb_char;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_exit;
        private Label label7;
    }
}
