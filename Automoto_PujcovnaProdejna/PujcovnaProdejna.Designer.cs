namespace Automoto_PujcovnaProdejna
{
	partial class PujcovnaProdejna
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Sklad = new Label();
			Zakaznici = new Label();
			Vypujcky = new Label();
			Prodeje = new Label();
			btnVypujcit = new Button();
			btnVratit = new Button();
			dgvVypujcky = new DataGridView();
			dgvProdeje = new DataGridView();
			dgvZakaznici = new DataGridView();
			dgvSklad = new DataGridView();
			btnProdat = new Button();
			btnEditace = new Button();
			btnNovyZakaznik = new Button();
			btnOdkup = new Button();
			((System.ComponentModel.ISupportInitialize)dgvVypujcky).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvProdeje).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvZakaznici).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvSklad).BeginInit();
			SuspendLayout();
			// 
			// Sklad
			// 
			Sklad.AutoSize = true;
			Sklad.Location = new Point(12, 9);
			Sklad.Name = "Sklad";
			Sklad.Size = new Size(38, 15);
			Sklad.TabIndex = 0;
			Sklad.Text = "Sklad:";
			// 
			// Zakaznici
			// 
			Zakaznici.AutoSize = true;
			Zakaznici.Location = new Point(448, 9);
			Zakaznici.Name = "Zakaznici";
			Zakaznici.Size = new Size(59, 15);
			Zakaznici.TabIndex = 1;
			Zakaznici.Text = "Zákazníci:";
			// 
			// Vypujcky
			// 
			Vypujcky.AutoSize = true;
			Vypujcky.Location = new Point(12, 270);
			Vypujcky.Name = "Vypujcky";
			Vypujcky.Size = new Size(154, 15);
			Vypujcky.TabIndex = 2;
			Vypujcky.Text = "Výpůjčky daného zákazníka:";
			// 
			// Prodeje
			// 
			Prodeje.AutoSize = true;
			Prodeje.Location = new Point(448, 270);
			Prodeje.Name = "Prodeje";
			Prodeje.Size = new Size(156, 15);
			Prodeje.TabIndex = 3;
			Prodeje.Text = "Prodeje u daného zákazníka:";
			// 
			// btnVypujcit
			// 
			btnVypujcit.Location = new Point(358, 64);
			btnVypujcit.Name = "btnVypujcit";
			btnVypujcit.Size = new Size(84, 30);
			btnVypujcit.TabIndex = 4;
			btnVypujcit.Text = "Vypůjčit";
			btnVypujcit.UseVisualStyleBackColor = true;
			btnVypujcit.Click += btnVypujcit_Click;
			// 
			// btnVratit
			// 
			btnVratit.Location = new Point(358, 100);
			btnVratit.Name = "btnVratit";
			btnVratit.Size = new Size(84, 30);
			btnVratit.TabIndex = 5;
			btnVratit.Text = "Vrátit";
			btnVratit.UseVisualStyleBackColor = true;
			btnVratit.Click += btnVratit_Click;
			// 
			// dgvVypujcky
			// 
			dgvVypujcky.AllowUserToAddRows = false;
			dgvVypujcky.AllowUserToDeleteRows = false;
			dgvVypujcky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvVypujcky.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvVypujcky.Location = new Point(12, 288);
			dgvVypujcky.MultiSelect = false;
			dgvVypujcky.Name = "dgvVypujcky";
			dgvVypujcky.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvVypujcky.Size = new Size(340, 150);
			dgvVypujcky.TabIndex = 6;
			// 
			// dgvProdeje
			// 
			dgvProdeje.AllowUserToAddRows = false;
			dgvProdeje.AllowUserToDeleteRows = false;
			dgvProdeje.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProdeje.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvProdeje.Location = new Point(448, 288);
			dgvProdeje.MultiSelect = false;
			dgvProdeje.Name = "dgvProdeje";
			dgvProdeje.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProdeje.Size = new Size(340, 150);
			dgvProdeje.TabIndex = 7;
			// 
			// dgvZakaznici
			// 
			dgvZakaznici.AllowUserToAddRows = false;
			dgvZakaznici.AllowUserToDeleteRows = false;
			dgvZakaznici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvZakaznici.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvZakaznici.Location = new Point(448, 28);
			dgvZakaznici.MultiSelect = false;
			dgvZakaznici.Name = "dgvZakaznici";
			dgvZakaznici.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvZakaznici.Size = new Size(340, 162);
			dgvZakaznici.TabIndex = 8;
			dgvZakaznici.SelectionChanged += dgvZakaznici_SelectionChanged;
			// 
			// dgvSklad
			// 
			dgvSklad.AllowUserToAddRows = false;
			dgvSklad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSklad.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvSklad.Location = new Point(12, 28);
			dgvSklad.MultiSelect = false;
			dgvSklad.Name = "dgvSklad";
			dgvSklad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvSklad.Size = new Size(340, 162);
			dgvSklad.TabIndex = 9;
			// 
			// btnProdat
			// 
			btnProdat.Location = new Point(358, 28);
			btnProdat.Name = "btnProdat";
			btnProdat.Size = new Size(84, 30);
			btnProdat.TabIndex = 10;
			btnProdat.Text = "Prodat";
			btnProdat.UseVisualStyleBackColor = true;
			btnProdat.Click += btnProdat_Click;
			// 
			// btnEditace
			// 
			btnEditace.Location = new Point(678, 196);
			btnEditace.Name = "btnEditace";
			btnEditace.Size = new Size(110, 30);
			btnEditace.TabIndex = 11;
			btnEditace.Text = "Editace zákazníka";
			btnEditace.UseVisualStyleBackColor = true;
			btnEditace.Click += btnEditace_Click;
			// 
			// btnNovyZakaznik
			// 
			btnNovyZakaznik.Location = new Point(562, 196);
			btnNovyZakaznik.Name = "btnNovyZakaznik";
			btnNovyZakaznik.Size = new Size(110, 30);
			btnNovyZakaznik.TabIndex = 12;
			btnNovyZakaznik.Text = "Nový zákazník";
			btnNovyZakaznik.UseVisualStyleBackColor = true;
			btnNovyZakaznik.Click += btnNovyZakaznik_Click;
			// 
			// btnOdkup
			// 
			btnOdkup.Location = new Point(358, 136);
			btnOdkup.Name = "btnOdkup";
			btnOdkup.Size = new Size(84, 30);
			btnOdkup.TabIndex = 13;
			btnOdkup.Text = "Odkoupit";
			btnOdkup.UseVisualStyleBackColor = true;
			btnOdkup.Click += btnOdkup_Click;
			// 
			// PujcovnaProdejna
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnOdkup);
			Controls.Add(btnNovyZakaznik);
			Controls.Add(btnEditace);
			Controls.Add(btnProdat);
			Controls.Add(dgvSklad);
			Controls.Add(dgvZakaznici);
			Controls.Add(dgvProdeje);
			Controls.Add(dgvVypujcky);
			Controls.Add(btnVratit);
			Controls.Add(btnVypujcit);
			Controls.Add(Prodeje);
			Controls.Add(Vypujcky);
			Controls.Add(Zakaznici);
			Controls.Add(Sklad);
			Name = "PujcovnaProdejna";
			Text = "Auto-Moto pujcovna a prodejna";
			FormClosed += PujcovnaProdejna_FormClosed;
			((System.ComponentModel.ISupportInitialize)dgvVypujcky).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvProdeje).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvZakaznici).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvSklad).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Sklad;
		private Label Zakaznici;
		private Label Vypujcky;
		private Label Prodeje;
		private Button btnVypujcit;
		private Button btnVratit;
		private DataGridView dgvVypujcky;
		private DataGridView dgvProdeje;
		private DataGridView dgvZakaznici;
		private DataGridView dgvSklad;
		private Button btnProdat;
		private Button btnEditace;
		private Button btnNovyZakaznik;
		private Button btnOdkup;
	}
}
