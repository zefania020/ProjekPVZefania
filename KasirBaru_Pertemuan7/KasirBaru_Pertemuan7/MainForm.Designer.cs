/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 3/31/2022
 * Time: 11:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KasirBaru_Pertemuan7
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.buttonSimpan = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonHapus = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(36, 322);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(954, 347);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 293);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "DB: Kasir, Table: TBL_BARANG";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(36, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kode Barang";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(215, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nama Barang";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(36, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Harga Jual";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(36, 159);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Harga Beli";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(36, 198);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Jumlah";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(36, 239);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Satuan";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(184, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(124, 26);
			this.textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(184, 74);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(796, 26);
			this.textBox2.TabIndex = 2;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(184, 115);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(124, 26);
			this.textBox3.TabIndex = 3;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3KeyPress);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(184, 156);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(124, 26);
			this.textBox4.TabIndex = 4;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4KeyPress);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(184, 198);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(124, 26);
			this.textBox5.TabIndex = 5;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5KeyPress);
			// 
			// buttonSimpan
			// 
			this.buttonSimpan.Location = new System.Drawing.Point(384, 239);
			this.buttonSimpan.Name = "buttonSimpan";
			this.buttonSimpan.Size = new System.Drawing.Size(128, 35);
			this.buttonSimpan.TabIndex = 7;
			this.buttonSimpan.Text = "Simpan";
			this.buttonSimpan.UseVisualStyleBackColor = true;
			this.buttonSimpan.Click += new System.EventHandler(this.ButtonSimpanClick);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(530, 239);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(132, 35);
			this.buttonUpdate.TabIndex = 8;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
			// 
			// buttonHapus
			// 
			this.buttonHapus.Location = new System.Drawing.Point(684, 239);
			this.buttonHapus.Name = "buttonHapus";
			this.buttonHapus.Size = new System.Drawing.Size(139, 35);
			this.buttonHapus.TabIndex = 9;
			this.buttonHapus.Text = "Hapus";
			this.buttonHapus.UseVisualStyleBackColor = true;
			this.buttonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Location = new System.Drawing.Point(384, 115);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(596, 100);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian Nama Barang";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(31, 44);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(527, 26);
			this.textBox7.TabIndex = 0;
			this.textBox7.TextChanged += new System.EventHandler(this.TextBox7TextChanged);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(841, 239);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(139, 35);
			this.buttonRefresh.TabIndex = 11;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefreshClick);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(184, 239);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(124, 28);
			this.comboBox1.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 703);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonHapus);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonSimpan);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Koneksi Ke SQL Server";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonHapus;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonSimpan;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
