using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace latihanResponsi2023
{
    public partial class Form1 : Form
    {
        public string TxtName 
        {
            get { return txtName.Text; } 
            set {  txtName.Text = value; } 
        }
        public string TxtAlamat
        {
            get { return txtAlamat.Text; }
            set { txtAlamat.Text = value; }
        }
        public string TxtNo_Handphone
        {
            get { return txtNo_Handphone.Text; }
            set { txtNo_Handphone.Text = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=latihan";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        public void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "SELECT * FROM st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_insert(:_name,:_alamat,:_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_name", txtName.Text);
                cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_no_handphone", txtNo_Handphone.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil Ditambahkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoaddata.PerformClick();
                    txtName.Text = txtAlamat.Text = txtNo_Handphone.Text = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvData.Rows[e.RowIndex];
                txtName.Text = r.Cells["_name"].Value.ToString();
                txtAlamat.Text = r.Cells["_alamat"].Value.ToString();
                txtNo_Handphone.Text = r.Cells["_no_handphone"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data!", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"SELECT * FROM st_update(:_id,:_name,:_alamat,:_no_handphone)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_name", txtName.Text);
                cmd.Parameters.AddWithValue("_alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("_no_handphone", txtNo_Handphone.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil Diedit", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnLoaddata.PerformClick();
                    txtName.Text = txtAlamat.Text = txtNo_Handphone.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "update FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Apakah benar akan menghapus data " + r.Cells["_name"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = @"SELECT * FROM st_delete(:_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value).ToString();
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data users Berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        btnLoaddata.PerformClick();
                        txtName.Text = txtAlamat.Text = txtNo_Handphone.Text = null;
                        r = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "delete FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }
    }
}