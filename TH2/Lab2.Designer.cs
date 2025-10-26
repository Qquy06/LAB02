namespace TH2
{
    partial class Lab2
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

        private void InitializeComponent()
        {
            labelTitle = new Label();
            btnBai1 = new Button();
            btnBai2 = new Button();
            btnBai3 = new Button();
            btnBai4 = new Button();
            btnBai5 = new Button();
            btnBai6 = new Button();
            btnBai7 = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.DarkBlue;
            labelTitle.Location = new Point(12, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(800, 50);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "💻 LAB 2 - Lập trình Windows Forms";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBai1
            // 
            btnBai1.Font = new Font("Segoe UI", 12F);
            btnBai1.Location = new Point(114, 90);
            btnBai1.Name = "btnBai1";
            btnBai1.Size = new Size(576, 45);
            btnBai1.TabIndex = 1;
            btnBai1.Text = "Bài 1: Đọc & Ghi File";
            btnBai1.TextAlign = ContentAlignment.MiddleLeft;
            btnBai1.UseVisualStyleBackColor = true;
            btnBai1.Click += btnBai1_Click;
            // 
            // btnBai2
            // 
            btnBai2.Font = new Font("Segoe UI", 12F);
            btnBai2.Location = new Point(114, 152);
            btnBai2.Name = "btnBai2";
            btnBai2.Size = new Size(576, 45);
            btnBai2.TabIndex = 2;
            btnBai2.Text = "Bài 2: Đọc thông tin một file.txt";
            btnBai2.TextAlign = ContentAlignment.MiddleLeft;
            btnBai2.UseVisualStyleBackColor = true;
            btnBai2.Click += btnBai2_Click;
            // 
            // btnBai3
            // 
            btnBai3.Font = new Font("Segoe UI", 12F);
            btnBai3.Location = new Point(114, 229);
            btnBai3.Name = "btnBai3";
            btnBai3.Size = new Size(576, 45);
            btnBai3.TabIndex = 3;
            btnBai3.Text = "Bài 3: Đọc, ghi file và tính toán";
            btnBai3.TextAlign = ContentAlignment.MiddleLeft;
            btnBai3.UseVisualStyleBackColor = true;
            btnBai3.Click += btnBai3_Click;
            // 
            // btnBai4
            // 
            btnBai4.Font = new Font("Segoe UI", 12F);
            btnBai4.Location = new Point(114, 298);
            btnBai4.Name = "btnBai4";
            btnBai4.Size = new Size(576, 45);
            btnBai4.TabIndex = 4;
            btnBai4.Text = "Bài 4 - Đọc và Ghi file sử dụng BinaryFormatter (JsonSerializer)";
            btnBai4.TextAlign = ContentAlignment.MiddleLeft;
            btnBai4.UseVisualStyleBackColor = true;
            btnBai4.Click += btnBai4_Click;
            // 
            // btnBai5
            // 
            btnBai5.Font = new Font("Segoe UI", 12F);
            btnBai5.Location = new Point(114, 362);
            btnBai5.Name = "btnBai5";
            btnBai5.Size = new Size(576, 45);
            btnBai5.TabIndex = 5;
            btnBai5.Text = "Bài 05 – Quản lý phòng vé";
            btnBai5.TextAlign = ContentAlignment.MiddleLeft;
            btnBai5.UseVisualStyleBackColor = true;
            btnBai5.Click += btnBai5_Click;
            // 
            // btnBai6
            // 
            btnBai6.Font = new Font("Segoe UI", 12F);
            btnBai6.Location = new Point(114, 433);
            btnBai6.Name = "btnBai6";
            btnBai6.Size = new Size(576, 45);
            btnBai6.TabIndex = 6;
            btnBai6.Text = "Bài 06 – Hôm nay ăn gì?";
            btnBai6.TextAlign = ContentAlignment.MiddleLeft;
            btnBai6.UseVisualStyleBackColor = true;
            btnBai6.Click += btnBai6_Click;
            // 
            // btnBai7
            // 
            btnBai7.Font = new Font("Segoe UI", 12F);
            btnBai7.Location = new Point(114, 493);
            btnBai7.Name = "btnBai7";
            btnBai7.Size = new Size(576, 45);
            btnBai7.TabIndex = 7;
            btnBai7.Text = "Bài 07 – Duyệt thư mục";
            btnBai7.TextAlign = ContentAlignment.MiddleLeft;
            btnBai7.UseVisualStyleBackColor = true;
            btnBai7.Click += btnBai7_Click;
            // 
            // Lab2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(829, 550);
            Controls.Add(labelTitle);
            Controls.Add(btnBai1);
            Controls.Add(btnBai2);
            Controls.Add(btnBai3);
            Controls.Add(btnBai4);
            Controls.Add(btnBai5);
            Controls.Add(btnBai6);
            Controls.Add(btnBai7);
            Name = "Lab2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 2 - TH2";
            Load += Lab2_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnBai1;
        private System.Windows.Forms.Button btnBai2;
        private System.Windows.Forms.Button btnBai3;
        private System.Windows.Forms.Button btnBai4;
        private System.Windows.Forms.Button btnBai5;
        private System.Windows.Forms.Button btnBai6;
        private System.Windows.Forms.Button btnBai7;
    }
}
