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

namespace KasirBaru_Pertemuan7
{
	public partial class MainForm : Form
	{
		//4
        private SqlCommand cmd; 
        private DataSet ds; 
        private SqlDataAdapter da;
        
        //5
        Koneksi Konn = new Koneksi();
        
        void NoOtomatis() {
			long hitung;
			string urutan;
			SqlDataReader rd;
			SqlConnection conn = Konn.GetConn();
			conn.Open();
			cmd = new SqlCommand("select KodeBarang from TBL_BARANG where KodeBarang in(select max(KodeBarang) from TBL_BARANG) order by kodebarang desc", conn);
			rd = cmd.ExecuteReader();
			rd.Read();
			if(rd.HasRows)
			{
				hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3))+1;
				string kodeurutan = "000" + hitung;
				urutan = "BRG" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
			} else {
				urutan = "BRG001";
			}
			rd.Close();
			textBox1.Text = urutan;
			conn.Close();
			
		}
        
		public MainForm()
		{
			InitializeComponent();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Bersihkan()
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "0";
			textBox4.Text = "0";
			textBox5.Text = "0";
		    comboBox1.Text = "";
			textBox7.Text = "";
			TampilBarang();
			NoOtomatis();
		}
		
		void MunculSatuan()
		{
			comboBox1.Items.Add("Unit");
			comboBox1.Items.Add("Pcs");
			comboBox1.Items.Add("Kg");
			comboBox1.Items.Add("gram");
			comboBox1.Items.Add(7000);
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			TampilBarang();
			Bersihkan();
			MunculSatuan();
			NoOtomatis();
		}
		
		/*************************************************************
		 * Membuat Event Tombol "Simpan"
		 * **********************************************************/
		private void ButtonSimpanClick(object sender, EventArgs e)
		{
			/*********************************************************
 			* Memeriksa apakah kolom Text kosong
 			*********************************************************/
 			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" ||  textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
 			{
 				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
 			}
 			else
 			{
 				/*****************************************************
 				 * Simpan Data
 				 * **************************************************/
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					cmd = new SqlCommand("INSERT INTO TBL_BARANG VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+comboBox1.Text+"')", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Insert Data Berhasil!");
 					TampilBarang();
 					Bersihkan();  
 				}
 				catch(Exception X)
 				{
 					MessageBox.Show("Tidak dapat menyimpan Data");
 				}
 			}
		}
		
		void TampilBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		void CariBarang()
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG where kodebarang like '%"+textBox7.Text+"%' or namabarang like '%"+textBox7.Text+"%'", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		
		/*
		void MainFormLoad(object sender, EventArgs e)
		{
			SqlConnection conn = Konn.GetConn();
			try
			{
				conn.Open();
				cmd = new SqlCommand("Select * from TBL_BARANG", conn);
			
				ds = new DataSet();
				da = new SqlDataAdapter(cmd);
				da.Fill(ds, "TBL_BARANG");
				dataGridView1.DataSource = ds;
				dataGridView1.DataMember = "TBL_BARANG";
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			catch (Exception G)
			{
				MessageBox.Show(G.ToString());
			}
			finally
			{
				conn.Close();
			}
		}
		*/
		
		void DataGridView1CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBox1.Text = row.Cells["KodeBarang"].Value.ToString(); 
				textBox2.Text = row.Cells["NamaBarang"].Value.ToString();
				textBox3.Text = row.Cells["HargaJual"].Value.ToString();
				textBox4.Text = row.Cells["HargaBeli"].Value.ToString();
				textBox5.Text = row.Cells["JumlahBarang"].Value.ToString();
				comboBox1.Text = row.Cells["SatuanBarang"].Value.ToString();
			}
			catch (Exception e1)
			{
				MessageBox.Show(e1.ToString());
			}
		}
		
		void ButtonUpdateClick(object sender, EventArgs e)
		{
			/*********************************************************
 			* Memeriksa apakah kolom Text kosong
 			*********************************************************/
 			if(textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" ||  textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || comboBox1.Text.Trim() == "")
 			{
 				MessageBox.Show("Mohon isikan terlebih dahulu kolom-kolom yang tersedia");
 			}
 			else
 			{
 				/*****************************************************
 				 * Update Data
 				 * **************************************************/
 				SqlConnection conn = Konn.GetConn();
 				try
 				{
 					conn.Open();
 					cmd = new SqlCommand("UPDATE TBL_BARANG SET KodeBarang='"+textBox1.Text+"', NamaBarang='"+textBox2.Text+"', HargaJual='"+textBox3.Text+"', HargaBeli='"+textBox4.Text+"', JumlahBarang='"+textBox5.Text+"', SatuanBarang='"+comboBox1.Text+"' WHERE KodeBarang='"+textBox1.Text+"'", conn);
 					cmd.ExecuteNonQuery();
 					MessageBox.Show("Update Data Berhasil!");
 					TampilBarang();
 					Bersihkan();  
 				}
 				catch(Exception X)
 				{
 					MessageBox.Show("Tidak dapat mengupdate Data");
 				}
 			}
		}
		
		void ButtonHapusClick(object sender, EventArgs e)
		{
			if(MessageBox.Show(textBox2.Text+", Yakin ingin dihapus?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				/*****************************************************
 				 * Hapus Data
 				 * **************************************************/
 				SqlConnection conn = Konn.GetConn();
 				conn.Open();
 				cmd = new SqlCommand("DELETE TBL_BARANG WHERE KodeBarang='"+textBox1.Text+"'", conn);
 				cmd.ExecuteNonQuery();
 				MessageBox.Show("Hapus Data Berhasil!");
 				TampilBarang();
 				Bersihkan();  
			}
		}
		
		void TextBox7TextChanged(object sender, EventArgs e)
		{
			CariBarang();
		}
		
		void ButtonRefreshClick(object sender, EventArgs e)
		{
			Bersihkan();
		}
		
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
		
		void TextBox5KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
		}
	}
}
