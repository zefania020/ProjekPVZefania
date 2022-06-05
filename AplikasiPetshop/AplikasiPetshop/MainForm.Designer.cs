/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 5/25/2022
 * Time: 8:44 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AplikasiPetshop
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.buttonPerbarui = new System.Windows.Forms.Button();
			this.buttonHapus = new System.Windows.Forms.Button();
			this.buttonBersihkan = new System.Windows.Forms.Button();
			this.textBoxCari = new System.Windows.Forms.TextBox();
			this.buttonCari = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxHargaJual = new System.Windows.Forms.TextBox();
			this.textBoxHargaBeli = new System.Windows.Forms.TextBox();
			this.comboBoxKategori = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxJlhDibeli = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Pink;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(-1, -6);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(45, 20, 10, 0);
			this.label1.Size = new System.Drawing.Size(1183, 69);
			this.label1.TabIndex = 1;
			this.label1.Text = "Petshop Manager App";
			// 
			// buttonTambah
			// 
			this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
			this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonTambah.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonTambah.Location = new System.Drawing.Point(529, 219);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(104, 36);
			this.buttonTambah.TabIndex = 13;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.ButtonTambahClick);
			// 
			// buttonPerbarui
			// 
			this.buttonPerbarui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(178)))), ((int)(((byte)(202)))));
			this.buttonPerbarui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPerbarui.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.buttonPerbarui.Location = new System.Drawing.Point(529, 263);
			this.buttonPerbarui.Name = "buttonPerbarui";
			this.buttonPerbarui.Size = new System.Drawing.Size(104, 35);
			this.buttonPerbarui.TabIndex = 14;
			this.buttonPerbarui.Text = "Perbarui";
			this.buttonPerbarui.UseVisualStyleBackColor = false;
			this.buttonPerbarui.Click += new System.EventHandler(this.ButtonPerbaruiClick);
			// 
			// buttonHapus
			// 
			this.buttonHapus.BackColor = System.Drawing.Color.LightCoral;
			this.buttonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonHapus.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.buttonHapus.Location = new System.Drawing.Point(529, 308);
			this.buttonHapus.Name = "buttonHapus";
			this.buttonHapus.Size = new System.Drawing.Size(104, 32);
			this.buttonHapus.TabIndex = 16;
			this.buttonHapus.Text = "Hapus";
			this.buttonHapus.UseVisualStyleBackColor = false;
			this.buttonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
			// 
			// buttonBersihkan
			// 
			this.buttonBersihkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
			this.buttonBersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonBersihkan.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.buttonBersihkan.Location = new System.Drawing.Point(529, 347);
			this.buttonBersihkan.Name = "buttonBersihkan";
			this.buttonBersihkan.Size = new System.Drawing.Size(104, 35);
			this.buttonBersihkan.TabIndex = 19;
			this.buttonBersihkan.Text = "Bersihkan";
			this.buttonBersihkan.UseVisualStyleBackColor = false;
			this.buttonBersihkan.Click += new System.EventHandler(this.ButtonBersihkanClick);
			// 
			// textBoxCari
			// 
			this.textBoxCari.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCari.ForeColor = System.Drawing.SystemColors.GrayText;
			this.textBoxCari.Location = new System.Drawing.Point(769, 391);
			this.textBoxCari.Name = "textBoxCari";
			this.textBoxCari.Size = new System.Drawing.Size(283, 29);
			this.textBoxCari.TabIndex = 20;
			this.textBoxCari.Text = "masukkan nama atau kategori";
			this.textBoxCari.Enter += new System.EventHandler(this.TextBoxCariEnter);
			// 
			// buttonCari
			// 
			this.buttonCari.BackColor = System.Drawing.Color.LightCoral;
			this.buttonCari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonCari.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
			this.buttonCari.Location = new System.Drawing.Point(1070, 390);
			this.buttonCari.Name = "buttonCari";
			this.buttonCari.Size = new System.Drawing.Size(58, 36);
			this.buttonCari.TabIndex = 21;
			this.buttonCari.Text = "Cari";
			this.buttonCari.UseVisualStyleBackColor = false;
			this.buttonCari.Click += new System.EventHandler(this.ButtonCariClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "ID Transaksi";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(46, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama Produk Dibeli";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(46, 229);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 29);
			this.label4.TabIndex = 4;
			this.label4.Text = "Kategori";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(46, 270);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 31);
			this.label5.TabIndex = 5;
			this.label5.Text = "Harga Jual";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(46, 311);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 34);
			this.label6.TabIndex = 6;
			this.label6.Text = "Harga Beli";
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Yu Gothic UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxID.Location = new System.Drawing.Point(250, 96);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(257, 29);
			this.textBoxID.TabIndex = 7;
			// 
			// textBoxNama
			// 
			this.textBoxNama.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.textBoxNama.Location = new System.Drawing.Point(250, 137);
			this.textBoxNama.Multiline = true;
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(257, 77);
			this.textBoxNama.TabIndex = 8;
			// 
			// textBoxHargaJual
			// 
			this.textBoxHargaJual.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.textBoxHargaJual.Location = new System.Drawing.Point(250, 270);
			this.textBoxHargaJual.Name = "textBoxHargaJual";
			this.textBoxHargaJual.Size = new System.Drawing.Size(257, 29);
			this.textBoxHargaJual.TabIndex = 10;
			this.textBoxHargaJual.Enter += new System.EventHandler(this.TextBoxHargaJualEnter);
			this.textBoxHargaJual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHargaJualKeyPress);
			// 
			// textBoxHargaBeli
			// 
			this.textBoxHargaBeli.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.textBoxHargaBeli.Location = new System.Drawing.Point(250, 311);
			this.textBoxHargaBeli.Name = "textBoxHargaBeli";
			this.textBoxHargaBeli.Size = new System.Drawing.Size(257, 29);
			this.textBoxHargaBeli.TabIndex = 11;
			this.textBoxHargaBeli.Enter += new System.EventHandler(this.TextBoxHargaBeliEnter);
			this.textBoxHargaBeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxHargaBeliKeyPress);
			// 
			// comboBoxKategori
			// 
			this.comboBoxKategori.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.comboBoxKategori.FormattingEnabled = true;
			this.comboBoxKategori.Items.AddRange(new object[] {
									"Makanan Anjing",
									"Makanan Kucing",
									"Snack Anjing",
									"Snack Kucing",
									"Kandang Hewan",
									"Aksesori Hewan",
									"Mainan Hewan"});
			this.comboBoxKategori.Location = new System.Drawing.Point(250, 227);
			this.comboBoxKategori.Name = "comboBoxKategori";
			this.comboBoxKategori.Size = new System.Drawing.Size(257, 29);
			this.comboBoxKategori.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(46, 354);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(126, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Jumlah Dibeli";
			// 
			// textBoxJlhDibeli
			// 
			this.textBoxJlhDibeli.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F, System.Drawing.FontStyle.Bold);
			this.textBoxJlhDibeli.Location = new System.Drawing.Point(250, 351);
			this.textBoxJlhDibeli.Name = "textBoxJlhDibeli";
			this.textBoxJlhDibeli.Size = new System.Drawing.Size(257, 29);
			this.textBoxJlhDibeli.TabIndex = 18;
			this.textBoxJlhDibeli.Enter += new System.EventHandler(this.TextBoxJlhDibeliEnter);
			this.textBoxJlhDibeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxJlhDibeliKeyPress);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(678, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(461, 300);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(46, 445);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(1082, 225);
			this.dataGridView1.TabIndex = 23;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
			this.ClientSize = new System.Drawing.Size(1178, 695);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonCari);
			this.Controls.Add(this.textBoxCari);
			this.Controls.Add(this.buttonBersihkan);
			this.Controls.Add(this.textBoxJlhDibeli);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.buttonHapus);
			this.Controls.Add(this.buttonPerbarui);
			this.Controls.Add(this.buttonTambah);
			this.Controls.Add(this.comboBoxKategori);
			this.Controls.Add(this.textBoxHargaBeli);
			this.Controls.Add(this.textBoxHargaJual);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Petshop Manager";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonCari;
		private System.Windows.Forms.TextBox textBoxCari;
		private System.Windows.Forms.Button buttonBersihkan;
		private System.Windows.Forms.TextBox textBoxJlhDibeli;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonHapus;
		private System.Windows.Forms.Button buttonPerbarui;
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.ComboBox comboBoxKategori;
		private System.Windows.Forms.TextBox textBoxHargaBeli;
		private System.Windows.Forms.TextBox textBoxHargaJual;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		
	}
}
