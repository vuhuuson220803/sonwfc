namespace WFP_QuanLyNhanVien
{
    partial class Form1
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
            this.uiMã_Màu = new System.Windows.Forms.ComboBox();
            this.uiNăm_Sản_Xuất = new System.Windows.Forms.TextBox();
            this.uiNút_Hủy = new System.Windows.Forms.Button();
            this.uiNút_Lưu = new System.Windows.Forms.Button();
            this.uiNút_Duyệt_Ảnh = new System.Windows.Forms.Button();
            this.uiCổng_Kết_Nối = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiĐơn_Giá = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTên = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiẢnh = new System.Windows.Forms.PictureBox();
            this.uiNút_Đầu_Tiên = new System.Windows.Forms.Button();
            this.uiNút_Trước_Đó = new System.Windows.Forms.Button();
            this.uiNút_Sau_Đó = new System.Windows.Forms.Button();
            this.uiNút_Cuối_Cùng = new System.Windows.Forms.Button();
            this.uiNút_Xóa = new System.Windows.Forms.Button();
            this.uiNút_Sửa = new System.Windows.Forms.Button();
            this.uiNút_Thêm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uiBảng = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBảng)).BeginInit();
            this.SuspendLayout();
            // 
            // uiMã_Màu
            // 
            this.uiMã_Màu.FormattingEnabled = true;
            this.uiMã_Màu.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "-------",
            "A",
            "B",
            "O"});
            this.uiMã_Màu.Location = new System.Drawing.Point(377, 473);
            this.uiMã_Màu.Name = "uiMã_Màu";
            this.uiMã_Màu.Size = new System.Drawing.Size(139, 21);
            this.uiMã_Màu.TabIndex = 103;
            // 
            // uiNăm_Sản_Xuất
            // 
            this.uiNăm_Sản_Xuất.Location = new System.Drawing.Point(346, 383);
            this.uiNăm_Sản_Xuất.Name = "uiNăm_Sản_Xuất";
            this.uiNăm_Sản_Xuất.Size = new System.Drawing.Size(248, 20);
            this.uiNăm_Sản_Xuất.TabIndex = 102;
            // 
            // uiNút_Hủy
            // 
            this.uiNút_Hủy.Location = new System.Drawing.Point(507, 571);
            this.uiNút_Hủy.Name = "uiNút_Hủy";
            this.uiNút_Hủy.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Hủy.TabIndex = 101;
            this.uiNút_Hủy.Text = "Hủy";
            this.uiNút_Hủy.UseVisualStyleBackColor = true;
            // 
            // uiNút_Lưu
            // 
            this.uiNút_Lưu.Location = new System.Drawing.Point(392, 571);
            this.uiNút_Lưu.Name = "uiNút_Lưu";
            this.uiNút_Lưu.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Lưu.TabIndex = 100;
            this.uiNút_Lưu.Text = "Lưu";
            this.uiNút_Lưu.UseVisualStyleBackColor = true;
            // 
            // uiNút_Duyệt_Ảnh
            // 
            this.uiNút_Duyệt_Ảnh.Location = new System.Drawing.Point(83, 558);
            this.uiNút_Duyệt_Ảnh.Name = "uiNút_Duyệt_Ảnh";
            this.uiNút_Duyệt_Ảnh.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Duyệt_Ảnh.TabIndex = 99;
            this.uiNút_Duyệt_Ảnh.Text = "Duyệt Ảnh";
            this.uiNút_Duyệt_Ảnh.UseVisualStyleBackColor = true;
            // 
            // uiCổng_Kết_Nối
            // 
            this.uiCổng_Kết_Nối.FormattingEnabled = true;
            this.uiCổng_Kết_Nối.Items.AddRange(new object[] {
            "Đực",
            "Cái",
            "Nam",
            "Nữ"});
            this.uiCổng_Kết_Nối.Location = new System.Drawing.Point(416, 515);
            this.uiCổng_Kết_Nối.Name = "uiCổng_Kết_Nối";
            this.uiCổng_Kết_Nối.Size = new System.Drawing.Size(139, 21);
            this.uiCổng_Kết_Nối.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Bit (Giới Tính, Cổng Kết Nối)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Kí Tự (Mã Màu, Nhóm Máu)";
            // 
            // uiĐơn_Giá
            // 
            this.uiĐơn_Giá.Location = new System.Drawing.Point(334, 430);
            this.uiĐơn_Giá.Name = "uiĐơn_Giá";
            this.uiĐơn_Giá.Size = new System.Drawing.Size(248, 20);
            this.uiĐơn_Giá.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(216, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 94;
            this.label3.Text = "Số Thực";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "Số Nguyên (Năm)";
            // 
            // uiTên
            // 
            this.uiTên.Location = new System.Drawing.Point(346, 345);
            this.uiTên.Name = "uiTên";
            this.uiTên.Size = new System.Drawing.Size(248, 20);
            this.uiTên.TabIndex = 92;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Chuỗi Kí Tự (Tên)";
            // 
            // uiẢnh
            // 
            this.uiẢnh.InitialImage = null;
            this.uiẢnh.Location = new System.Drawing.Point(27, 328);
            this.uiẢnh.Name = "uiẢnh";
            this.uiẢnh.Size = new System.Drawing.Size(156, 208);
            this.uiẢnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiẢnh.TabIndex = 90;
            this.uiẢnh.TabStop = false;
            // 
            // uiNút_Đầu_Tiên
            // 
            this.uiNút_Đầu_Tiên.Location = new System.Drawing.Point(457, 276);
            this.uiNút_Đầu_Tiên.Name = "uiNút_Đầu_Tiên";
            this.uiNút_Đầu_Tiên.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Đầu_Tiên.TabIndex = 89;
            this.uiNút_Đầu_Tiên.Text = "<<";
            this.uiNút_Đầu_Tiên.UseVisualStyleBackColor = true;
            // 
            // uiNút_Trước_Đó
            // 
            this.uiNút_Trước_Đó.Location = new System.Drawing.Point(509, 276);
            this.uiNút_Trước_Đó.Name = "uiNút_Trước_Đó";
            this.uiNút_Trước_Đó.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Trước_Đó.TabIndex = 88;
            this.uiNút_Trước_Đó.Text = "<";
            this.uiNút_Trước_Đó.UseVisualStyleBackColor = true;
            // 
            // uiNút_Sau_Đó
            // 
            this.uiNút_Sau_Đó.Location = new System.Drawing.Point(561, 276);
            this.uiNút_Sau_Đó.Name = "uiNút_Sau_Đó";
            this.uiNút_Sau_Đó.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Sau_Đó.TabIndex = 87;
            this.uiNút_Sau_Đó.Text = ">";
            this.uiNút_Sau_Đó.UseVisualStyleBackColor = true;
            // 
            // uiNút_Cuối_Cùng
            // 
            this.uiNút_Cuối_Cùng.Location = new System.Drawing.Point(613, 276);
            this.uiNút_Cuối_Cùng.Name = "uiNút_Cuối_Cùng";
            this.uiNút_Cuối_Cùng.Size = new System.Drawing.Size(46, 23);
            this.uiNút_Cuối_Cùng.TabIndex = 86;
            this.uiNút_Cuối_Cùng.Text = ">>";
            this.uiNút_Cuối_Cùng.UseVisualStyleBackColor = true;
            // 
            // uiNút_Xóa
            // 
            this.uiNút_Xóa.Location = new System.Drawing.Point(189, 286);
            this.uiNút_Xóa.Name = "uiNút_Xóa";
            this.uiNút_Xóa.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Xóa.TabIndex = 85;
            this.uiNút_Xóa.Text = "Xóa";
            this.uiNút_Xóa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Sửa
            // 
            this.uiNút_Sửa.Location = new System.Drawing.Point(108, 286);
            this.uiNút_Sửa.Name = "uiNút_Sửa";
            this.uiNút_Sửa.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Sửa.TabIndex = 84;
            this.uiNút_Sửa.Text = "Sửa";
            this.uiNút_Sửa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Thêm
            // 
            this.uiNút_Thêm.Location = new System.Drawing.Point(27, 286);
            this.uiNút_Thêm.Name = "uiNút_Thêm";
            this.uiNút_Thêm.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Thêm.TabIndex = 83;
            this.uiNút_Thêm.Text = "Thêm Mới";
            this.uiNút_Thêm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Phần Mềm Quản Lý";
            // 
            // uiBảng
            // 
            this.uiBảng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiBảng.Location = new System.Drawing.Point(27, 49);
            this.uiBảng.Name = "uiBảng";
            this.uiBảng.Size = new System.Drawing.Size(700, 221);
            this.uiBảng.TabIndex = 81;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 611);
            this.Controls.Add(this.uiMã_Màu);
            this.Controls.Add(this.uiNăm_Sản_Xuất);
            this.Controls.Add(this.uiNút_Hủy);
            this.Controls.Add(this.uiNút_Lưu);
            this.Controls.Add(this.uiNút_Duyệt_Ảnh);
            this.Controls.Add(this.uiCổng_Kết_Nối);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiĐơn_Giá);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiTên);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiẢnh);
            this.Controls.Add(this.uiNút_Đầu_Tiên);
            this.Controls.Add(this.uiNút_Trước_Đó);
            this.Controls.Add(this.uiNút_Sau_Đó);
            this.Controls.Add(this.uiNút_Cuối_Cùng);
            this.Controls.Add(this.uiNút_Xóa);
            this.Controls.Add(this.uiNút_Sửa);
            this.Controls.Add(this.uiNút_Thêm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiBảng);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiBảng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiMã_Màu;
        private System.Windows.Forms.TextBox uiNăm_Sản_Xuất;
        private System.Windows.Forms.Button uiNút_Hủy;
        private System.Windows.Forms.Button uiNút_Lưu;
        private System.Windows.Forms.Button uiNút_Duyệt_Ảnh;
        private System.Windows.Forms.ComboBox uiCổng_Kết_Nối;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiĐơn_Giá;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTên;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox uiẢnh;
        private System.Windows.Forms.Button uiNút_Đầu_Tiên;
        private System.Windows.Forms.Button uiNút_Trước_Đó;
        private System.Windows.Forms.Button uiNút_Sau_Đó;
        private System.Windows.Forms.Button uiNút_Cuối_Cùng;
        private System.Windows.Forms.Button uiNút_Xóa;
        private System.Windows.Forms.Button uiNút_Sửa;
        private System.Windows.Forms.Button uiNút_Thêm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiBảng;
    }
}

