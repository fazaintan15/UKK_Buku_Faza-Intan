using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace US_Buku_Faza_Intan
{
    public partial class Form1 : Form
    {
        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable(); //datatable untuk menampilkan tabel yg ada di localhost

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable getDataBuku()
        {
            dataTable.Reset(); //Mengosongkan objek dataTable agar siap digunakan kembali.
            dataTable = new DataTable(); //Membuat objek DataTable baru yang akan diisi dengan data dari database.
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM bukubuk", koneksi)) //Mendefinisikan objek MySqlCommand yang berisi perintah SQL -
                                                                                          //untuk mengambil data dari tabel bukubuk di database.
            {
                koneksi.Open(); //Membuka koneksi ke database.
                MySqlDataReader reader = cmd.ExecuteReader(); //Menjalankan perintah SQL dan mendapatkan hasilnya dalam bentuk MySqlDataReader.
                dataTable.Load(reader); //Memuat data dari MySqlDataReader ke dalam objek DataTable.
            }
            return dataTable; //Mengembalikan objek DataTable yang berisi data dari database.

        }

        public void filldataTable()
        {
            databuku.DataSource = getDataBuku();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            databuku.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            databuku.Columns.Add(colDelete);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //connections.Open();
            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO bukubuk(id, judul_buku, jenis_buku, stok) VALUE (@id, @judul_buku, @jenis_buku, @stok)";
                cmd.Parameters.AddWithValue("@id", ID.Text);
                cmd.Parameters.AddWithValue("@Judul_Buku", Judul_Buku.Text);
                cmd.Parameters.AddWithValue("@Jenis_Buku", Jenis_Buku.Text);
                cmd.Parameters.AddWithValue("@stok", Stok.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Ditambah");
                // long id = cmd.LastInsertedId;
                koneksi.Close();

                databuku.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {
                // ex. Message.EndsWith("");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void databuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int id = Convert.ToInt32(databuku.CurrentCell.RowIndex.ToString());
                ID.Text = databuku.Rows[id].Cells[0].Value.ToString();
                Judul_Buku.Text = databuku.Rows[id].Cells[1].Value.ToString();
                Jenis_Buku.Text = databuku.Rows[id].Cells[2].Value.ToString();
                Stok.Text = databuku.Rows[id].Cells[3].Value.ToString();

                Judul_Buku.Enabled = true;
                Jenis_Buku.Enabled = true;
                Stok.Enabled = true;
                button3.Enabled = true;
            }
            if (e.ColumnIndex == 5)
            {
                MySqlCommand cmd;
                //connections.Open();
                try
                {

                    cmd = koneksi.CreateCommand();
                    cmd.CommandText = "DELETE FROM bukubuk where id=@id";
                    cmd.Parameters.AddWithValue("@id", ID.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Dihapus");
                    // long id = cmd.LastInsertedId;
                    koneksi.Close();

                    databuku.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }

                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            //connections.Open();
            try
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE bukubuk set judul_buku=@Judul_Buku, jenis_buku=@Jenis_Buku, stok=@stok where id=@id";
                cmd.Parameters.AddWithValue("@id", ID.Text);
                cmd.Parameters.AddWithValue("@Judul_Buku", Judul_Buku.Text);
                cmd.Parameters.AddWithValue("@Jenis_Buku", Jenis_Buku.Text);
                cmd.Parameters.AddWithValue("@stok", Stok.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Berhasil Disimpan");
                // long id = cmd.LastInsertedId;
                koneksi.Close();

                databuku.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }

            catch (Exception ex)
            {
                // ex. Message.EndsWith("");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}