namespace kalkulacka
{
    partial class Kalkulacka
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
            btnPlus = new Button();
            btnMinus = new Button();
            btnNasobeni = new Button();
            btnDeleni = new Button();
            labelHodnotaA = new Label();
            labelHodnotaB = new Label();
            textHodnotaB = new TextBox();
            textVysledek = new TextBox();
            labelVysledek = new Label();
            textHodnotaA = new TextBox();
            SuspendLayout();
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Narrow", 27.75F);
            btnPlus.Location = new Point(41, 236);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 0;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Narrow", 27.75F);
            btnMinus.Location = new Point(153, 236);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 1;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnNasobeni
            // 
            btnNasobeni.Font = new Font("Arial Narrow", 27.75F);
            btnNasobeni.Location = new Point(256, 236);
            btnNasobeni.Name = "btnNasobeni";
            btnNasobeni.Size = new Size(50, 50);
            btnNasobeni.TabIndex = 2;
            btnNasobeni.Text = "x";
            btnNasobeni.UseVisualStyleBackColor = true;
            btnNasobeni.Click += btnNasobeni_Click;
            // 
            // btnDeleni
            // 
            btnDeleni.Font = new Font("Arial Narrow", 27.75F);
            btnDeleni.Location = new Point(360, 236);
            btnDeleni.Name = "btnDeleni";
            btnDeleni.Size = new Size(50, 50);
            btnDeleni.TabIndex = 3;
            btnDeleni.Text = "/";
            btnDeleni.UseVisualStyleBackColor = true;
            btnDeleni.Click += btnDeleni_Click;
            // 
            // labelHodnotaA
            // 
            labelHodnotaA.AutoSize = true;
            labelHodnotaA.Font = new Font("Arial Narrow", 27.75F);
            labelHodnotaA.Location = new Point(41, 33);
            labelHodnotaA.Name = "labelHodnotaA";
            labelHodnotaA.Size = new Size(162, 43);
            labelHodnotaA.TabIndex = 6;
            labelHodnotaA.Text = "Hodnota A";
            // 
            // labelHodnotaB
            // 
            labelHodnotaB.AutoSize = true;
            labelHodnotaB.Font = new Font("Arial Narrow", 27.75F);
            labelHodnotaB.Location = new Point(41, 89);
            labelHodnotaB.Name = "labelHodnotaB";
            labelHodnotaB.Size = new Size(162, 43);
            labelHodnotaB.TabIndex = 8;
            labelHodnotaB.Text = "Hodnota B";
            // 
            // textHodnotaB
            // 
            textHodnotaB.Font = new Font("Arial Narrow", 27.75F);
            textHodnotaB.Location = new Point(209, 86);
            textHodnotaB.Name = "textHodnotaB";
            textHodnotaB.Size = new Size(201, 50);
            textHodnotaB.TabIndex = 7;
            textHodnotaB.TextChanged += textHodnotaB_TextChanged;
            // 
            // textVysledek
            // 
            textVysledek.Font = new Font("Arial Narrow", 27.75F);
            textVysledek.Location = new Point(209, 142);
            textVysledek.Name = "textVysledek";
            textVysledek.Size = new Size(201, 50);
            textVysledek.TabIndex = 9;
            textVysledek.TextChanged += textVysledek_TextChanged;
            // 
            // labelVysledek
            // 
            labelVysledek.AutoSize = true;
            labelVysledek.Font = new Font("Arial Narrow", 27.75F);
            labelVysledek.Location = new Point(41, 145);
            labelVysledek.Name = "labelVysledek";
            labelVysledek.Size = new Size(142, 43);
            labelVysledek.TabIndex = 10;
            labelVysledek.Text = "Vysledek";
            // 
            // textHodnotaA
            // 
            textHodnotaA.Font = new Font("Arial Narrow", 27.75F);
            textHodnotaA.Location = new Point(209, 30);
            textHodnotaA.Name = "textHodnotaA";
            textHodnotaA.Size = new Size(201, 50);
            textHodnotaA.TabIndex = 11;
            textHodnotaA.TextChanged += textHodnotaA_TextChanged;
            // 
            // Kalkulacka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 331);
            Controls.Add(textHodnotaA);
            Controls.Add(labelVysledek);
            Controls.Add(textVysledek);
            Controls.Add(labelHodnotaB);
            Controls.Add(textHodnotaB);
            Controls.Add(labelHodnotaA);
            Controls.Add(btnDeleni);
            Controls.Add(btnNasobeni);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Name = "Kalkulacka";
            Text = "Kalkulacka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPlus;
        private Button btnMinus;
        private Button btnNasobeni;
        private Button btnDeleni;
        private Label labelHodnotaA;
        private Label labelHodnotaB;
        private TextBox textHodnotaB;
        private TextBox textVysledek;
        private Label labelVysledek;
        private TextBox textHodnotaA;
    }
}
