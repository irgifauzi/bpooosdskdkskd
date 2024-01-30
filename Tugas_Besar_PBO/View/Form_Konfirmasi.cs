using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_Konfirmasi : Form
    {
        public Form_Konfirmasi()
        {
            InitializeComponent();
        }
        Koneksi koneksi = new Koneksi();
        M_Konfirmasis m_Konfirmasi = new M_Konfirmasis();
        M_Jasa m_Jasa = new M_Jasa();

        string id_diamond;
        string id_jasa;


        public void TampilDiamond()
        {
            datatrandi.DataSource = koneksi.ShowData("SELECT * FROM t_diamond");
            datatrandi.Columns[0].HeaderText = "ID_diamond";
            datatrandi.Columns[1].HeaderText = "ID_user";
            datatrandi.Columns[2].HeaderText = "id_server";
            datatrandi.Columns[3].HeaderText = "jumlah_diamond";
            datatrandi.Columns[4].HeaderText = "Bonus_diamond";
            datatrandi.Columns[5].HeaderText = "harga";
            datatrandi.Columns[6].HeaderText = "email";
            datatrandi.Columns[7].HeaderText = "metode_pembayaran";
            datatrandi.Columns[8].HeaderText = "status";

        }
        public void Tampiljoki()
        {
            datatranjok.DataSource = koneksi.ShowData("SELECT * FROM t_jasa_joki");
            datatranjok.Columns[0].HeaderText = "ID_jasa";
            datatranjok.Columns[1].HeaderText = "Jenis_jasa";
            datatranjok.Columns[2].HeaderText = "Rank";
            datatranjok.Columns[3].HeaderText = "Jumlah_bintang";
            datatranjok.Columns[4].HeaderText = "Harga";
            datatranjok.Columns[5].HeaderText = "Total_harga";
            datatranjok.Columns[6].HeaderText = "Penjoki";
            datatranjok.Columns[7].HeaderText = "Metode_pembayaran";
            datatranjok.Columns[8].HeaderText = "No_whatsapp";
            datatranjok.Columns[9].HeaderText = "Email";
            datatranjok.Columns[10].HeaderText = "Password";
            datatranjok.Columns[11].HeaderText = "Jenis_akun";
            datatranjok.Columns[12].HeaderText = "Status";


        }

        private void Form_Konfirmasi_Load(object sender, EventArgs e)
        {
            TampilDiamond();
            Tampiljoki();
        }

        private void datatrandi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_diamond = datatrandi.Rows[e.RowIndex].Cells[0].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[1].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[2].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[3].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[4].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[5].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[6].Value.ToString();
            datatrandi.Rows[e.RowIndex].Cells[7].Value.ToString();
            cdproses.Text = datatrandi.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        private void datatranjok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_jasa = datatranjok.Rows[e.RowIndex].Cells[0].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[1].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[2].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[3].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[4].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[5].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[6].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[8].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[9].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[10].Value.ToString();
            datatranjok.Rows[e.RowIndex].Cells[11].Value.ToString();
           
            cjproses.Text = datatranjok.Rows[e.RowIndex].Cells[12].Value.ToString();
        }

        private void bdproses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cdproses.Text) || (cdproses.Text).All(Char.IsLetter))
 

            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Konfirmasis konf = new Konfirmasis();
                m_Konfirmasi.Status = cdproses.Text;
              

                konf.Update(m_Konfirmasi);

                TampilDiamond();
            }
        }

        private void bjproses_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cjproses.Text) || (cjproses.Text).All(Char.IsLetter))
  
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Jasa ja = new Jasa();
                m_Jasa.Status = cjproses.Text;

                ja.Update(m_Jasa);

                Tampiljoki();
            }
        }
        private void ExportToExcel(DataGridView dataGridView, string searchData)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet =
               excelPackage.Workbook.Worksheets.Add("Sheet1");
                // Export Headers
                for (int j = 1; j <= dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Columns[j - 1].HeaderText != null)
                    {
                        worksheet.Cells[1, j].Value = dataGridView.Columns[j -
                       1].HeaderText;
                    }
                }
                // Export Data
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = (dataGridView.Rows[i].Cells[j].Value !=
                       null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "");
                        worksheet.Cells[i + 2, j + 1].Value = cellValue;
                    }
                }
                FileInfo excelFile = new FileInfo(searchData);
                excelPackage.SaveAs(excelFile);
            }
        }

    


        private void cetak_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Data Diamond.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt =
               Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt}({count}){extension}"); count++;

                }
                ExportToExcel(datatrandi, filePath);
            }
        }

        private void cetakjoki_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Data Joki.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(save.FileName);
                string fileNameWithoutExt =
               Path.GetFileNameWithoutExtension(save.FileName);
                string extension = Path.GetExtension(save.FileName);
                int count = 1;
                string filePath = save.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt}({count}){extension}"); count++;

                }
                ExportToExcel(datatranjok, filePath);
            }
        }

        private void tbcaridiamond_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id_diamonds, id_username, id_server, jumlah_diamond, bonus_diamond, harga, email, metode_pembayaran, status FROM t_diamond " +
                        "WHERE id_diamonds LIKE '%" + tbcaridiamond.Text + "%' OR id_username LIKE '%" + tbcaridiamond.Text + "%' OR " +
                        "id_server LIKE '%" + tbcaridiamond.Text + "%' OR jumlah_diamond LIKE '%" + tbcaridiamond.Text + "%' OR " +
                        "bonus_diamond LIKE '%" + tbcaridiamond.Text + "%' OR harga LIKE '%" + tbcaridiamond.Text + "%' OR " +
                        "email LIKE '%" + tbcaridiamond.Text + "%' OR metode_pembayaran LIKE '%" + tbcaridiamond.Text + "%' OR " +
                        "status LIKE '%" + tbcaridiamond.Text + "%'";

            datatrandi.DataSource = koneksi.ShowData(query);
        }

        private void tbcarijoki_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT id_jasa, jenis_jasa, rank, jumlah_bintang, harga, total_harga, penjoki, metode_pembayaran, no_whatsapp, email, password, jenis_akun, status FROM t_jasa_joki " +
                           "WHERE id_jasa LIKE '%" + tbcarijoki.Text + "%' OR jenis_jasa LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "rank LIKE '%" + tbcarijoki.Text + "%' OR jumlah_bintang LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "harga LIKE '%" + tbcarijoki.Text + "%' OR total_harga LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "penjoki LIKE '%" + tbcarijoki.Text + "%' OR metode_pembayaran LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "no_whatsapp LIKE '%" + tbcarijoki.Text + "%' OR email LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "password LIKE '%" + tbcarijoki.Text + "%' OR jenis_akun LIKE '%" + tbcarijoki.Text + "%' OR " +
                           "status LIKE '%" + tbcarijoki.Text + "%'";

            datatranjok.DataSource = koneksi.ShowData(query);
        }
    }
}
