using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Tugas_Besar_PBO.Model
{
    public class M_Diamond_Jasa
    {
        // Properties representing attributes of the diamond service
        string id_username, id_server, jumlah_diamond, bonus_diamond, harga_diamond, jenis_jasa, rank, jumlah_bintang, harga_jasa, total_harga, penjoki, metode_pembayaran, email, password, jenis_akun, total_semua, status;
        public M_Diamond_Jasa()
        {
        }
        public M_Diamond_Jasa(string id_username, string id_server, string jumlah_diamond, string bonus_diamond, string harga_diamond, string jenis_jasa, string rank, string jumlah_bintang, string harga_jasa, string penjoki, string metode_pembayaran, string email, string password, string jenis_akun, string total_semua, string status)
        {
            this.Id_username = id_username;
            this.Id_server = id_server;
            this.Jumlah_diamond = jumlah_diamond;
            this.Bonus_diamond = bonus_diamond;
            this.Harga_diamond = harga_diamond;
            this.Jenis_jasa = jenis_jasa;
            this.Rank = rank;
            this.Jumlah_bintang = jumlah_bintang;
            this.Harga_jasa = harga_jasa;
            this.Penjoki = penjoki;
            this.Metode_pembayaran = metode_pembayaran;
            this.Email = email;
            this.Password = password;
            this.Jenis_akun = jenis_akun;
            this.Total_semua = total_semua;
            this.Status = status;

        }
        public string Id_username { get => id_username; set => id_username = value; }
        public string Id_server { get => id_server; set => id_server = value; }
        public string Jumlah_diamond { get => jumlah_diamond; set => jumlah_diamond = value; }
        public string Bonus_diamond { get => bonus_diamond; set => bonus_diamond = value; }
        public string Harga_diamond { get => harga_diamond; set => harga_diamond = value; }
        public string Jenis_jasa { get => jenis_jasa; set => jenis_jasa = value; }
        public string Rank { get => rank; set => rank = value; }
        public string Jumlah_bintang { get => jumlah_bintang; set => jumlah_bintang = value; }
        public string Harga_jasa { get => harga_jasa; set => harga_jasa = value; }
        public string Total_harga { get => total_harga; set => total_harga = value; }
        public string Penjoki { get => penjoki; set => penjoki = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Jenis_akun { get => jenis_akun; set => jenis_akun = value; }
        public string Total_semua { get => total_semua; set => total_semua = value; }
        public string Status { get => status; set => status = value; }
    }


}




