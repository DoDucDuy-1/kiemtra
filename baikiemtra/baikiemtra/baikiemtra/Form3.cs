using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baikiemtra
{
    public partial class frmthanhvien : Form
    {
        public frmthanhvien()
        {
            InitializeComponent();
        }

        private void frmthanhvien_Load(object sender, EventArgs e)
        {
            load_Thanhvien();
        }

        public string chuoiKn = "server=DUY;" + "database=QLDV_DoDucDuy_CNTTA1;" + "uid=sa;pwd=admin123";

        SqlConnection conn;

        public void load_Thanhvien()
        {
            lv_tv.Items.Clear();

            conn = new SqlConnection(chuoiKn);
            conn.Open();

            string sql = "SELECT * FROM tblThanhvien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaThanhvien"].ToString());
                item.SubItems.Add(reader["Hoten"].ToString());
                item.SubItems.Add(Convert.ToDateTime(reader["Ngaysinh"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(reader["Gioitinh"].ToString());
                item.SubItems.Add(reader["Donvi"].ToString());
                item.SubItems.Add(reader["Sothich"].ToString());
                item.SubItems.Add(reader["Diachi"].ToString());
                item.SubItems.Add(reader["Dienthoai"].ToString());
                item.SubItems.Add(reader["Quyenhan"].ToString());
                lv_tv.Items.Add(item);
            }

            reader.Close();
            conn.Close();

            foreach (ColumnHeader ch in lv_tv.Columns)
                ch.Width = -2;
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (txt_matv.Text == "" || txt_tentv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(chuoiKn))
            {
                conn.Open();
                string sql = "INSERT INTO tblThanhvien (MaThanhvien, Hoten, Ngaysinh, Gioitinh, Donvi, Sothich, Diachi, Dienthoai, Quyenhan) " + 
                    " VALUES (@Ma, @Hoten, @Ngaysinh, @Gioitinh, @Donvi, @Sothich, @Diachi, @Dienthoai, @Quyenhan)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", txt_matv.Text);
                cmd.Parameters.AddWithValue("@Hoten", txt_tentv.Text);
                cmd.Parameters.AddWithValue("@Ngaysinh", dtp_tv.Value);
                cmd.Parameters.AddWithValue("@Gioitinh", cbx_tv.Text);
                cmd.Parameters.AddWithValue("@Donvi", txt_donvi.Text);
                cmd.Parameters.AddWithValue("@Sothich", txt_sothich.Text);
                cmd.Parameters.AddWithValue("@Diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@Dienthoai", txt_dt.Text);
                cmd.Parameters.AddWithValue("@Quyenhan", txt_qh.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành viên thành công!");
                load_Thanhvien();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(chuoiKn))
            {
                conn.Open();
                string sql = @"UPDATE tblThanhvien 
                       SET Hoten=@Hoten, Ngaysinh=@Ngaysinh, Gioitinh=@Gioitinh, 
                           Donvi=@Donvi, Sothich=@Sothich, Diachi=@Diachi, 
                           Dienthoai=@Dienthoai, Quyenhan=@Quyenhan
                       WHERE MaThanhvien=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", txt_matv.Text);
                cmd.Parameters.AddWithValue("@Hoten", txt_tentv.Text);
                cmd.Parameters.AddWithValue("@Ngaysinh", dtp_tv.Value);
                cmd.Parameters.AddWithValue("@Gioitinh", cbx_tv.Text);
                cmd.Parameters.AddWithValue("@Donvi", txt_donvi.Text);
                cmd.Parameters.AddWithValue("@Sothich", txt_sothich.Text);
                cmd.Parameters.AddWithValue("@Diachi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("@Dienthoai", txt_dt.Text);
                cmd.Parameters.AddWithValue("@Quyenhan", txt_qh.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công!");
                load_Thanhvien();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_tv.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thành viên để xóa!");
                return;
            }

            string ma = lv_tv.SelectedItems[0].Text;

            using (SqlConnection conn = new SqlConnection(chuoiKn))
            {
                conn.Open();
                string sql = "DELETE FROM tblThanhvien WHERE MaThanhvien=@Ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", ma);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công!");
                load_Thanhvien();
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            lv_tv.Items.Clear();
            string sql = "SELECT * FROM tblThanhvien WHERE MaThanhvien LIKE @key";
            using (SqlConnection conn = new SqlConnection(chuoiKn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@key", "%" + txt_matv.Text + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["MaThanhvien"].ToString());
                    item.SubItems.Add(reader["Hoten"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["Ngaysinh"]).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(reader["Gioitinh"].ToString());
                    item.SubItems.Add(reader["Donvi"].ToString());
                    item.SubItems.Add(reader["Sothich"].ToString());
                    item.SubItems.Add(reader["Diachi"].ToString());
                    item.SubItems.Add(reader["Dienthoai"].ToString());
                    item.SubItems.Add(reader["Quyenhan"].ToString());
                    lv_tv.Items.Add(item);
                }
                reader.Close();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
