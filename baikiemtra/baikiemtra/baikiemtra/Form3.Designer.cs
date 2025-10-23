namespace baikiemtra
{
    partial class frmthanhvien
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
            this.Donvi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaThanhvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_tv = new System.Windows.Forms.ListView();
            this.Gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sothich = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dienthoai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quyenhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.dtp_tv = new System.Windows.Forms.DateTimePicker();
            this.txt_sothich = new System.Windows.Forms.TextBox();
            this.txt_tentv = new System.Windows.Forms.TextBox();
            this.txt_matv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_tv = new System.Windows.Forms.ComboBox();
            this.txt_donvi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_qh = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Donvi
            // 
            this.Donvi.Text = "Đơn vị";
            this.Donvi.Width = 69;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.Text = "Ngày sinh";
            this.Ngaysinh.Width = 100;
            // 
            // Hoten
            // 
            this.Hoten.Text = "Tên thanh viên";
            this.Hoten.Width = 143;
            // 
            // MaThanhvien
            // 
            this.MaThanhvien.Text = "Mã thành viên";
            this.MaThanhvien.Width = 136;
            // 
            // lv_tv
            // 
            this.lv_tv.AllowColumnReorder = true;
            this.lv_tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_tv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaThanhvien,
            this.Hoten,
            this.Ngaysinh,
            this.Gioitinh,
            this.Donvi,
            this.Sothich,
            this.Diachi,
            this.Dienthoai,
            this.Quyenhan});
            this.lv_tv.FullRowSelect = true;
            this.lv_tv.GridLines = true;
            this.lv_tv.HideSelection = false;
            this.lv_tv.Location = new System.Drawing.Point(124, 504);
            this.lv_tv.MultiSelect = false;
            this.lv_tv.Name = "lv_tv";
            this.lv_tv.Size = new System.Drawing.Size(817, 187);
            this.lv_tv.TabIndex = 29;
            this.lv_tv.UseCompatibleStateImageBehavior = false;
            this.lv_tv.View = System.Windows.Forms.View.Details;
            // 
            // Gioitinh
            // 
            this.Gioitinh.Text = "Giới tính";
            this.Gioitinh.Width = 88;
            // 
            // Sothich
            // 
            this.Sothich.Text = "Sở thích";
            // 
            // Diachi
            // 
            this.Diachi.Text = "Địa chỉ";
            // 
            // Dienthoai
            // 
            this.Dienthoai.Text = "Điện thoại";
            // 
            // Quyenhan
            // 
            this.Quyenhan.Text = "Quyền hạn";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_sua.Location = new System.Drawing.Point(844, 231);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 57);
            this.btn_sua.TabIndex = 28;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_xoa.Location = new System.Drawing.Point(844, 130);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 78);
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_timkiem.Location = new System.Drawing.Point(844, 314);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(104, 68);
            this.btn_timkiem.TabIndex = 26;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_capnhat.Location = new System.Drawing.Point(844, 35);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(104, 65);
            this.btn_capnhat.TabIndex = 25;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // dtp_tv
            // 
            this.dtp_tv.Location = new System.Drawing.Point(302, 130);
            this.dtp_tv.Name = "dtp_tv";
            this.dtp_tv.Size = new System.Drawing.Size(438, 30);
            this.dtp_tv.TabIndex = 24;
            // 
            // txt_sothich
            // 
            this.txt_sothich.Location = new System.Drawing.Point(302, 282);
            this.txt_sothich.Name = "txt_sothich";
            this.txt_sothich.Size = new System.Drawing.Size(438, 30);
            this.txt_sothich.TabIndex = 22;
            // 
            // txt_tentv
            // 
            this.txt_tentv.Location = new System.Drawing.Point(302, 83);
            this.txt_tentv.Name = "txt_tentv";
            this.txt_tentv.Size = new System.Drawing.Size(438, 30);
            this.txt_tentv.TabIndex = 21;
            // 
            // txt_matv
            // 
            this.txt_matv.Location = new System.Drawing.Point(302, 35);
            this.txt_matv.Name = "txt_matv";
            this.txt_matv.Size = new System.Drawing.Size(438, 30);
            this.txt_matv.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(119, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(119, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Sở thích";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(119, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(119, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên thành viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(119, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã thành viên";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(302, 327);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(438, 30);
            this.txt_diachi.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(119, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Giới tính";
            // 
            // cbx_tv
            // 
            this.cbx_tv.FormattingEnabled = true;
            this.cbx_tv.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_tv.Location = new System.Drawing.Point(302, 180);
            this.cbx_tv.Name = "cbx_tv";
            this.cbx_tv.Size = new System.Drawing.Size(438, 33);
            this.cbx_tv.TabIndex = 31;
            // 
            // txt_donvi
            // 
            this.txt_donvi.Location = new System.Drawing.Point(302, 231);
            this.txt_donvi.Name = "txt_donvi";
            this.txt_donvi.Size = new System.Drawing.Size(438, 30);
            this.txt_donvi.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Location = new System.Drawing.Point(119, 234);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Đơn vị";
            // 
            // txt_dt
            // 
            this.txt_dt.Location = new System.Drawing.Point(302, 377);
            this.txt_dt.Name = "txt_dt";
            this.txt_dt.Size = new System.Drawing.Size(438, 30);
            this.txt_dt.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Location = new System.Drawing.Point(119, 425);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Quyền hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Location = new System.Drawing.Point(119, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 25);
            this.label9.TabIndex = 34;
            this.label9.Text = "Điện thoại";
            // 
            // txt_qh
            // 
            this.txt_qh.Location = new System.Drawing.Point(302, 422);
            this.txt_qh.Name = "txt_qh";
            this.txt_qh.Size = new System.Drawing.Size(438, 30);
            this.txt_qh.TabIndex = 37;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_back.Location = new System.Drawing.Point(844, 399);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 76);
            this.btn_back.TabIndex = 38;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frmthanhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 780);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_dt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_qh);
            this.Controls.Add(this.txt_donvi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbx_tv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lv_tv);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.dtp_tv);
            this.Controls.Add(this.txt_sothich);
            this.Controls.Add(this.txt_tentv);
            this.Controls.Add(this.txt_matv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_diachi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmthanhvien";
            this.Text = "Frm Thành viên";
            this.Load += new System.EventHandler(this.frmthanhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Donvi;
        private System.Windows.Forms.ColumnHeader Ngaysinh;
        private System.Windows.Forms.ColumnHeader Hoten;
        private System.Windows.Forms.ColumnHeader MaThanhvien;
        private System.Windows.Forms.ListView lv_tv;
        private System.Windows.Forms.ColumnHeader Gioitinh;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.DateTimePicker dtp_tv;
        private System.Windows.Forms.TextBox txt_sothich;
        private System.Windows.Forms.TextBox txt_tentv;
        private System.Windows.Forms.TextBox txt_matv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_tv;
        private System.Windows.Forms.TextBox txt_donvi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader Sothich;
        private System.Windows.Forms.ColumnHeader Diachi;
        private System.Windows.Forms.ColumnHeader Dienthoai;
        private System.Windows.Forms.ColumnHeader Quyenhan;
        private System.Windows.Forms.TextBox txt_dt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_qh;
        private System.Windows.Forms.Button btn_back;
    }
}