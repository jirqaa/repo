namespace pujcovna
{
    partial class Pujcovna
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
            btnVypujcit = new Button();
            btnVratit = new Button();
            label1 = new Label();
            Sklad = new Label();
            Label3 = new Label();
            dgvZakaznici = new DataGridView();
            dgvSklad = new DataGridView();
            dgvVypujcky = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvZakaznici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSklad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVypujcky).BeginInit();
            SuspendLayout();
            // 
            // btnVypujcit
            // 
            btnVypujcit.Location = new Point(383, 27);
            btnVypujcit.Name = "btnVypujcit";
            btnVypujcit.Size = new Size(100, 41);
            btnVypujcit.TabIndex = 0;
            btnVypujcit.Text = "Vypujcit";
            btnVypujcit.UseVisualStyleBackColor = true;
            btnVypujcit.Click += btnVypujcit_Click;
            // 
            // btnVratit
            // 
            btnVratit.Location = new Point(383, 74);
            btnVratit.Name = "btnVratit";
            btnVratit.Size = new Size(100, 41);
            btnVratit.TabIndex = 1;
            btnVratit.Text = "Vratit";
            btnVratit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Zakaznici";
            // 
            // Sklad
            // 
            Sklad.AutoSize = true;
            Sklad.Location = new Point(489, 9);
            Sklad.Name = "Sklad";
            Sklad.Size = new Size(35, 15);
            Sklad.TabIndex = 3;
            Sklad.Text = "Sklad";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(12, 248);
            Label3.Name = "Label3";
            Label3.Size = new Size(218, 15);
            Label3.TabIndex = 4;
            Label3.Text = "Vypujcene polozky vybraneho zakaznika";
            // 
            // dgvZakaznici
            // 
            dgvZakaznici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZakaznici.Location = new Point(12, 27);
            dgvZakaznici.Name = "dgvZakaznici";
            dgvZakaznici.Size = new Size(365, 187);
            dgvZakaznici.TabIndex = 5;
            // 
            // dgvSklad
            // 
            dgvSklad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSklad.Location = new Point(489, 27);
            dgvSklad.Name = "dgvSklad";
            dgvSklad.Size = new Size(299, 187);
            dgvSklad.TabIndex = 6;
            // 
            // dgvVypujcky
            // 
            dgvVypujcky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVypujcky.Location = new Point(12, 266);
            dgvVypujcky.Name = "dgvVypujcky";
            dgvVypujcky.Size = new Size(540, 172);
            dgvVypujcky.TabIndex = 7;
            // 
            // Pujcovna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVypujcky);
            Controls.Add(dgvSklad);
            Controls.Add(dgvZakaznici);
            Controls.Add(Label3);
            Controls.Add(Sklad);
            Controls.Add(label1);
            Controls.Add(btnVratit);
            Controls.Add(btnVypujcit);
            Name = "Pujcovna";
            Text = "Pujcovna";
            ((System.ComponentModel.ISupportInitialize)dgvZakaznici).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSklad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVypujcky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVypujcit;
        private Button btnVratit;
        private Label label1;
        private Label Sklad;
        private Label Label3;
        private DataGridView dgvZakaznici;
        private DataGridView dgvSklad;
        private DataGridView dgvVypujcky;
    }
}
