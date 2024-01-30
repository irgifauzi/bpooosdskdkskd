using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.Controller
{
    internal class Diamond_jasa
    {
        Koneksi koneksi = new Koneksi();
        //Method insert
        // Method to insert data into t_diamond and t_jasa_joki tables
        public bool Insert(M_Diamond_Jasa diamond_Jasas)
        {
            bool status = false;
            SqlTransaction transaction = null;

            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_diamond_jasa (id_username, id_server, jumlah_diamond, bonus_diamond, harga_diamond,jenis_jasa,rank,hatga_jasa,penjoki,email,password,jenis_akun,metode_pembayaran,status) VALUES('" + diamond_Jasas.Id_username + "', '" + diamond_Jasas.Id_server + "', '" + diamond_Jasas.Jumlah_diamond + "', '" + diamond_Jasas.Bonus_diamond + "', '" + diamond_Jasas.Harga_diamond + "', '" + diamond_Jasas.Email + "', '" + diamond_Jasas.Metode_pembayaran + "','" + diamond_Jasas.Status + "','" + diamond_Jasas.Jenis_jasa  + "', '" + diamond_Jasas.Rank + "', '" + diamond_Jasas.Jumlah_bintang + "', '" + diamond_Jasas.Harga_jasa + "', '" + diamond_Jasas.Penjoki + "', '" + diamond_Jasas.Email + "',  '" + diamond_Jasas.Password + "', '" + diamond_Jasas.Jenis_akun + "','" + diamond_Jasas.Metode_pembayaran + "','"+diamond_Jasas.Total_semua+"', '" + diamond_Jasas.Status +"')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();


                // Insert into t_diamond_jasa table
                /*using (SqlCommand cmdDiamond_jasa = new SqlCommand("INSERT INTO t_diamond_jasa (id_username, id_server, jumlah_diamond, bonus_diamond, harga_diamond,jenis_jasa,rank,hatga_jasa,penjoki,email,password,jenis_akun,metode_pembayaran,status) VALUES(@IdUsername, @IdServer, @JumlahDiamond, @BonusDiamond, @Hargadiamond,@JenisJasa, @Rank, @Hargajasa, @Penjoki,@Email, @Password,  @JenisAkun, @MetodePembayaran"))
                {
                    cmdDiamond_jasa.Parameters.AddWithValue("@IdUsername", diamond_Jasas.Id_username);
                    cmdDiamond_jasa.Parameters.AddWithValue("@IdServer", diamond_Jasas.Id_server);
                    cmdDiamond_jasa.Parameters.AddWithValue("@JumlahDiamond", diamond_Jasas.Jumlah_diamond);
                    cmdDiamond_jasa.Parameters.AddWithValue("@BonusDiamond", diamond_Jasas.Bonus_diamond);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Harga", diamond_Jasas.Harga_diamond);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Email", diamond_Jasas.Email);
                    cmdDiamond_jasa.Parameters.AddWithValue("@MetodePembayaran", diamond_Jasas.Metode_pembayaran);
                    cmdDiamond_jasa.Parameters.AddWithValue("@JenisJasa", diamond_Jasas.Jenis_jasa);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Rank", diamond_Jasas.Rank);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Harga", diamond_Jasas.Harga_jasa);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Penjoki", diamond_Jasas.Penjoki);
                    cmdDiamond_jasa.Parameters.AddWithValue("@MetodePembayaran", diamond_Jasas.Metode_pembayaran);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Email", diamond_Jasas.Email);
                    cmdDiamond_jasa.Parameters.AddWithValue("@Password", diamond_Jasas.Password);
                    cmdDiamond_jasa.Parameters.AddWithValue("@JenisAkun", diamond_Jasas.Jenis_akun);

                    cmdDiamond_jasa.ExecuteNonQuery();
                }*/

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }
    }
}