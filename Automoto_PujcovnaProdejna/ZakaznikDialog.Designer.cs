namespace Automoto_PujcovnaProdejna
{
	partial class ZakaznikDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			btnOk = new Button();
			btnStorno = new Button();
			txtPrijmeni = new TextBox();
			txtJmeno = new TextBox();
			txtAdresa = new TextBox();
			txtBankovniUcet = new TextBox();
			numRok = new NumericUpDown();
			numCisloOp = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numRok).BeginInit();
			((System.ComponentModel.ISupportInitialize)numCisloOp).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 36);
			label1.Name = "label1";
			label1.Size = new Size(45, 15);
			label1.TabIndex = 0;
			label1.Text = "Jméno:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(36, 72);
			label2.Name = "label2";
			label2.Size = new Size(54, 15);
			label2.TabIndex = 1;
			label2.Text = "Příjmení:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(36, 108);
			label3.Name = "label3";
			label3.Size = new Size(46, 15);
			label3.TabIndex = 2;
			label3.Text = "Adresa:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(36, 143);
			label4.Name = "label4";
			label4.Size = new Size(78, 15);
			label4.TabIndex = 3;
			label4.Text = "Rok narození:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(36, 179);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 4;
			label5.Text = "Číslo OP:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(36, 216);
			label6.Name = "label6";
			label6.Size = new Size(85, 15);
			label6.TabIndex = 5;
			label6.Text = "Bankovní účet:";
			// 
			// btnOk
			// 
			btnOk.DialogResult = DialogResult.OK;
			btnOk.Location = new Point(36, 270);
			btnOk.Name = "btnOk";
			btnOk.Size = new Size(75, 23);
			btnOk.TabIndex = 6;
			btnOk.Text = "OK";
			btnOk.UseVisualStyleBackColor = true;
			btnOk.Click += btnOk_Click;
			// 
			// btnStorno
			// 
			btnStorno.DialogResult = DialogResult.Cancel;
			btnStorno.Location = new Point(300, 270);
			btnStorno.Name = "btnStorno";
			btnStorno.Size = new Size(75, 23);
			btnStorno.TabIndex = 7;
			btnStorno.Text = "Storno";
			btnStorno.UseVisualStyleBackColor = true;
			// 
			// txtPrijmeni
			// 
			txtPrijmeni.Location = new Point(169, 69);
			txtPrijmeni.Name = "txtPrijmeni";
			txtPrijmeni.Size = new Size(206, 23);
			txtPrijmeni.TabIndex = 8;
			// 
			// txtJmeno
			// 
			txtJmeno.Location = new Point(169, 33);
			txtJmeno.Name = "txtJmeno";
			txtJmeno.Size = new Size(206, 23);
			txtJmeno.TabIndex = 8;
			// 
			// txtAdresa
			// 
			txtAdresa.Location = new Point(169, 105);
			txtAdresa.Name = "txtAdresa";
			txtAdresa.Size = new Size(206, 23);
			txtAdresa.TabIndex = 8;
			// 
			// txtBankovniUcet
			// 
			txtBankovniUcet.Location = new Point(169, 213);
			txtBankovniUcet.Name = "txtBankovniUcet";
			txtBankovniUcet.Size = new Size(206, 23);
			txtBankovniUcet.TabIndex = 8;
			// 
			// numRok
			// 
			numRok.Location = new Point(169, 141);
			numRok.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
			numRok.Minimum = new decimal(new int[] { 1910, 0, 0, 0 });
			numRok.Name = "numRok";
			numRok.Size = new Size(206, 23);
			numRok.TabIndex = 9;
			numRok.Value = new decimal(new int[] { 1910, 0, 0, 0 });
			// 
			// numCisloOp
			// 
			numCisloOp.Location = new Point(169, 177);
			numCisloOp.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
			numCisloOp.Minimum = new decimal(new int[] { 100000000, 0, 0, 0 });
			numCisloOp.Name = "numCisloOp";
			numCisloOp.Size = new Size(206, 23);
			numCisloOp.TabIndex = 9;
			numCisloOp.Value = new decimal(new int[] { 100000000, 0, 0, 0 });
			// 
			// ZakaznikDialog
			// 
			AcceptButton = btnOk;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(429, 323);
			Controls.Add(numCisloOp);
			Controls.Add(numRok);
			Controls.Add(txtBankovniUcet);
			Controls.Add(txtAdresa);
			Controls.Add(txtJmeno);
			Controls.Add(txtPrijmeni);
			Controls.Add(btnStorno);
			Controls.Add(btnOk);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "ZakaznikDialog";
			Text = "Zákazník";
			VisibleChanged += ZakaznikDialog_VisibleChanged;
			((System.ComponentModel.ISupportInitialize)numRok).EndInit();
			((System.ComponentModel.ISupportInitialize)numCisloOp).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Button btnOk;
		private Button btnStorno;
		private TextBox txtPrijmeni;
		private TextBox txtJmeno;
		private TextBox txtAdresa;
		private TextBox txtBankovniUcet;
		private NumericUpDown numRok;
		private NumericUpDown numCisloOp;
	}
}