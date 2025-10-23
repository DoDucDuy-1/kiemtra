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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baikiemtra
{
    public partial class frmhoatdong : Form
    {
        public frmhoatdong()
        {
            InitializeComponent();
        }

        private void frmhoatdong_Load(object sender, EventArgs e)
        {
            load_HoatDong();
        }

        public string chuoiKn = "server=DUY;" + "database=QLDV_DoDucDuy_CNTTA1;" + "uid=sa;pwd=admin123";

        SqlConnection conn;

        public void load_HoatDong()
        {
            lv_hd.Items.Clear(); 

            conn = new SqlConnection(chuoiKn);
            conn.Open();

            string sql = "SELECT * FROM tblHoatdong";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["MaHoatdong"].ToString());
                item.SubItems.Add(reader["TenHoatdong"].ToString());
                item.SubItems.Add(reader["Noidung"].ToString());
                item.SubItems.Add(Convert.ToDateTime(reader["Thoigian"]).ToShortDateString());
                item.SubItems.Add(string.Format("{0:N0}", reader["Kinhphi"]));
                lv_hd.Items.Add(item);
            }

            reader.Close();
            conn.Close();

            foreach (ColumnHeader ch in lv_hd.Columns)
                ch.Width = -2; 
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tblHoatdong (MaHoatdong, TenHoatdong, Noidung, Thoigian, Kinhphi) " +
            "VALUES (@Ma, @Ten, @Noidung, @Thoigian, @Kinhphi)";

            conn = new SqlConnection(chuoiKn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ma", txt_mahd.Text);
            cmd.Parameters.AddWithValue("@Ten", txt_tenhd.Text);
            cmd.Parameters.AddWithValue("@Noidung", txt_noidung.Text);
            cmd.Parameters.AddWithValue("@Thoigian", dtp_hd.Value);
            cmd.Parameters.AddWithValue("@Kinhphi", Convert.ToInt32(txt_kinhphi.Text));

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cập nhật thành công!");
            load_HoatDong();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mahd.Clear();
            txt_tenhd.Clear();
            txt_noidung.Clear();
            txt_kinhphi.Clear();
            dtp_hd.Value = DateTime.Now;
            txt_mahd.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_hd.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hoạt động để xóa!");
                return;
            }

            string ma = lv_hd.SelectedItems[0].SubItems[0].Text;
            string sql = "DELETE FROM tblHoatdong WHERE MaHoatdong = @Ma";

            conn = new SqlConnection(chuoiKn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ma", ma);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Xóa thành công!");
            load_HoatDong();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tblHoatdong SET TenHoatdong = @Ten, Noidung = @NoiDung, Thoigian = @ThoiGian, Kinhphi = @KinhPhi WHERE MaHoatdong = @Ma";
            conn = new SqlConnection(chuoiKn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Ma", txt_mahd.Text);
            cmd.Parameters.AddWithValue("@Ten", txt_tenhd.Text);
            cmd.Parameters.AddWithValue("@NoiDung", txt_noidung.Text);
            cmd.Parameters.AddWithValue("@ThoiGian", dtp_hd.Value);
            cmd.Parameters.AddWithValue("@KinhPhi", Convert.ToInt32(txt_kinhphi.Text));

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Cập nhật thành công!");
            load_HoatDong();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
