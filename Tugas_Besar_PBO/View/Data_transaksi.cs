using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class Data_transaksi : Form
    {
        public Data_transaksi()
        {
            InitializeComponent();
        }
        Koneksi koneksi = new Koneksi();
        M_Diamond m_Diamond = new M_Diamond();
        M_Jasa m_Jasa = new M_Jasa();
        string id_diamond;
        string id_jasa;

        public void TampilDiamond()
        {
            dataTraDiamond.DataSource = koneksi.ShowData("SELECT * FROM t_diamond");
            dataTraDiamond.Columns[0].HeaderText = "ID_diamond";
            dataTraDiamond.Columns[1].HeaderText = "ID_user";
            dataTraDiamond.Columns[2].HeaderText = "id_server";
            dataTraDiamond.Columns[3].HeaderText = "jumlah_diamond";
            dataTraDiamond.Columns[4].HeaderText = "Bonus_diamond";
            dataTraDiamond.Columns[5].HeaderText = "harga";
            dataTraDiamond.Columns[6].HeaderText = "email";
            dataTraDiamond.Columns[7].HeaderText = "metode_pembayaran";
            dataTraDiamond.Columns[8].HeaderText = "status";

        }
        public void Tampiljoki()
        {
            dataTraJoki.DataSource = koneksi.ShowData("SELECT * FROM t_jasa_joki");
            dataTraJoki.Columns[0].HeaderText = "ID_jasa";
            dataTraJoki.Columns[1].HeaderText = "Jenis_jasa";
            dataTraJoki.Columns[2].HeaderText = "Rank";
            dataTraJoki.Columns[3].HeaderText = "Jumlah_bintang";
            dataTraJoki.Columns[4].HeaderText = "Harga";
            dataTraJoki.Columns[5].HeaderText = "Total_harga";
            dataTraJoki.Columns[6].HeaderText = "Penjoki";
            dataTraJoki.Columns[7].HeaderText = "Metode_pembayaran";
            dataTraJoki.Columns[8].HeaderText = "No_whatsapp";
            dataTraJoki.Columns[9].HeaderText = "Email";
            dataTraJoki.Columns[10].HeaderText = "Jenis_akun";


        }
        public void Tampildija()
        {
            // Using the ShowData method from the koneksi object to populate the DataGridView
            datatradija.DataSource = koneksi.ShowData("SELECT * FROM t_diamond_jasa");

            // Setting custom header texts for each column in the DataGridView
            datatradija.Columns[0].HeaderText = "ID_diamond_jasa";
            datatradija.Columns[1].HeaderText = "ID_user";
            datatradija.Columns[2].HeaderText = "id_server";
            datatradija.Columns[3].HeaderText = "jumlah_diamond";
            datatradija.Columns[4].HeaderText = "Bonus_diamond";
            datatradija.Columns[5].HeaderText = "harga_diamond";
            datatradija.Columns[6].HeaderText = "Jenis_jasa";
            datatradija.Columns[7].HeaderText = "Rank";
            datatradija.Columns[8].HeaderText = "Jumlah_bintang";
            datatradija.Columns[9].HeaderText = "Harga";
            datatradija.Columns[10].HeaderText = "Total_harga";
            datatradija.Columns[11].HeaderText = "Penjoki";
            datatradija.Columns[12].HeaderText = "Metode_pembayaran";
            datatradija.Columns[13].HeaderText = "No_whatsapp";
            datatradija.Columns[14].HeaderText = "Email";
            dataTraJoki.Columns[15].HeaderText = "Jenis_akun";
            dataTraJoki.Columns[16].HeaderText = "Status";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_transaksi_Load(object sender, EventArgs e)
        {
            TampilDiamond();
            Tampiljoki();
            Tampildija();
        }
    }
}
