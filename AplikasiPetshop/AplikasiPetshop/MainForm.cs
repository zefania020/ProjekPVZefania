// Nama: Zefania Agustina Lumbangaol, NIM: 201401020, KOM: A

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//3
using System.Data.SqlClient;

namespace AplikasiPetshop
{
	public partial class MainForm : Form
	{
		//4
        private SqlCommand cmd; 
        private DataSet ds; 
        private SqlDataAdapter da;
        
        //5
        Koneksi Konn = new Koneksi();
        
		public MainForm()
		{
			InitializeComponent();
		}
		
		void TampilkanData()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_TRANSAKSI ORDER BY id_transaksi", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_TRANSAKSI");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_TRANSAKSI";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			TampilkanData();
			IDOtomatis();
		}
		
		void ButtonTambahClick(object sender, EventArgs e)
		{
			if(textBoxID.Text.Trim() == "" || textBoxNama.Text.Trim() == "" ||  comboBoxKategori.Text.Trim() == "" || textBoxHargaJual.Text.Trim() == "" || textBoxHargaBeli.Text.Trim() == "" || textBoxJlhDibeli.Text.Trim() == "")
 			{
 				MessageBox.Show("Harap isi semua kolom");
 			}
 			else
 			{
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					int keuntungan = (int.Parse(textBoxHargaJual.Text) - int.Parse(textBoxHargaBeli.Text)) * int.Parse(textBoxJlhDibeli.Text);
 					cmd = new SqlCommand("INSERT INTO TBL_TRANSAKSI VALUES('"+textBoxID.Text+"','"+textBoxNama.Text+"','"+comboBoxKategori.Text+"','"+textBoxHargaJual.Text+"','"+textBoxHargaBeli.Text+"','"+textBoxJlhDibeli.Text+"','"+keuntungan+"')", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Berhasil menambah data!");
 					TampilkanData();
 					Bersihkan();
 				}
 				catch(Exception ex)
 				{
 					MessageBox.Show("Gagal menambah data!");
 				}
 			}
		}
		
		void ButtonPerbaruiClick(object sender, EventArgs e)
		{
			if(textBoxID.Text.Trim() == "" || textBoxNama.Text.Trim() == "" ||  comboBoxKategori.Text.Trim() == "" || textBoxHargaJual.Text.Trim() == "" || textBoxHargaBeli.Text.Trim() == "" || textBoxJlhDibeli.Text.Trim() == "")
 			{
 				MessageBox.Show("Harap isi semua kolom");
 			}
 			else
 			{
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					int keuntungan = (int.Parse(textBoxHargaJual.Text) - int.Parse(textBoxHargaBeli.Text)) * int.Parse(textBoxJlhDibeli.Text);
 					cmd = new SqlCommand("UPDATE TBL_TRANSAKSI SET id_transaksi='"+textBoxID.Text+"', nama_produk='"+textBoxNama.Text+"', kategori='"+comboBoxKategori.Text+"', harga_jual='"+textBoxHargaJual.Text+"', harga_beli='"+textBoxHargaBeli.Text+"', jumlah_dibeli='"+textBoxJlhDibeli.Text+"', keuntungan='"+keuntungan+"' WHERE id_transaksi='"+textBoxID.Text+"'", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Berhasil memperbarui data!");
 					TampilkanData();
 					Bersihkan();
 				}
 				catch(Exception ex)
 				{
 					MessageBox.Show("Gagal memperbarui data!");
 				}
 			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBoxID.Text = row.Cells["id_transaksi"].Value.ToString(); 
				textBoxNama.Text = row.Cells["nama_produk"].Value.ToString();
				comboBoxKategori.Text = row.Cells["kategori"].Value.ToString();
				textBoxHargaJual.Text = row.Cells["harga_jual"].Value.ToString();
				textBoxHargaBeli.Text = row.Cells["harga_beli"].Value.ToString();
				textBoxJlhDibeli.Text = row.Cells["jumlah_dibeli"].Value.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}			
		}
		
		void Bersihkan()
		{
			textBoxID.Text = "";
			textBoxNama.Text = "";
			comboBoxKategori.Text = "";
			textBoxHargaJual.Text = "0";
			textBoxHargaBeli.Text = "0";
		    textBoxJlhDibeli.Text = "0";
		    TampilkanData();
		    IDOtomatis();
		}
		
		void ButtonHapusClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Yakin ingin menghapus "+textBoxNama.Text+"?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				SqlConnection conn = Konn.GetConn();
 				conn.Open();
 				cmd = new SqlCommand("DELETE TBL_TRANSAKSI WHERE id_transaksi='"+textBoxID.Text+"'", conn);
 				cmd.ExecuteNonQuery();
 				MessageBox.Show("Berhasil menghapus data!");
 				TampilkanData();
 				Bersihkan();
			}
		}
		
		void IDOtomatis() {
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select id_transaksi from TBL_TRANSAKSI where id_transaksi in(select max(id_transaksi) from TBL_TRANSAKSI) order by id_transaksi desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["id_transaksi"].ToString().Length - 3, 3))+1;
				string kodeurutan = "000" + hitung;
				urutan = "TRX" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} else {
				urutan = "TRX001";
			}
			rd.Close();
			textBoxID.Text = urutan;
			conn.Close();
			
		}
		
		void ButtonBersihkanClick(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		void ButtonCariClick(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_TRANSAKSI where nama_produk like '%"+textBoxCari.Text+"%' or kategori like '%"+textBoxCari.Text+"%'", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_TRANSAKSI");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_TRANSAKSI";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				conn.Close();
			}			
		}
		
		void TextBoxHargaJualKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBoxHargaBeliKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBoxJlhDibeliKeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBoxCariEnter(object sender, EventArgs e)
		{
			if (textBoxCari.Text == "masukkan nama atau kategori"){
				textBoxCari.Text = "";
				textBoxCari.ForeColor = Color.Black;
				
			}
		}
		
		
		void TextBoxHargaJualEnter(object sender, EventArgs e)
		{
			if (textBoxHargaJual.Text == "0"){
				textBoxHargaJual.Text = "";
			}
		}
		
		void TextBoxHargaBeliEnter(object sender, EventArgs e)
		{
			if (textBoxHargaBeli.Text == "0"){
				textBoxHargaBeli.Text = "";
			}
		}
		
		void TextBoxJlhDibeliEnter(object sender, EventArgs e)
		{
			if (textBoxJlhDibeli.Text == "0"){
				textBoxJlhDibeli.Text = "";
			}
		}
	}
}
