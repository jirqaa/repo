namespace kalkulackaLepsi
{
    partial class kalkulackaLepsi
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
            textHodnotaA = new TextBox();
            labelVysledek = new Label();
            textVysledek = new TextBox();
            labelHodnotaB = new Label();
            textHodnotaB = new TextBox();
            labelHodnotaA = new Label();
            btnDeleni = new Button();
            btnNasobeni = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            SuspendLayout();
            // 
            // textHodnotaA
            // 
            textHodnotaA.Font = new Font("Arial Narrow", 27.75F);
            textHodnotaA.Location = new Point(285, 54);
            textHodnotaA.Name = "textHodnotaA";
            textHodnotaA.Size = new Size(201, 50);
            textHodnotaA.TabIndex = 21;
            // 
            // labelVysledek
            // 
            labelVysledek.AutoSize = true;
            labelVysledek.Font = new Font("Arial Narrow", 27.75F);
            labelVysledek.Location = new Point(117, 169);
            labelVysledek.Name = "labelVysledek";
            labelVysledek.Size = new Size(142, 43);
            labelVysledek.TabIndex = 20;
            labelVysledek.Text = "Vysledek";
            // 
            // textVysledek
            // 
            textVysledek.Font = new Font("Arial Narrow", 27.75F);
            textVysledek.Location = new Point(285, 166);
            textVysledek.Name = "textVysledek";
            textVysledek.Size = new Size(201, 50);
            textVysledek.TabIndex = 19;
            // 
            // labelHodnotaB
            // 
            labelHodnotaB.AutoSize = true;
            labelHodnotaB.Font = new Font("Arial Narrow", 27.75F);
            labelHodnotaB.Location = new Point(117, 113);
            labelHodnotaB.Name = "labelHodnotaB";
            labelHodnotaB.Size = new Size(162, 43);
            labelHodnotaB.TabIndex = 18;
            labelHodnotaB.Text = "Hodnota B";
            // 
            // textHodnotaB
            // 
            textHodnotaB.Font = new Font("Arial Narrow", 27.75F);
            textHodnotaB.Location = new Point(285, 110);
            textHodnotaB.Name = "textHodnotaB";
            textHodnotaB.Size = new Size(201, 50);
            textHodnotaB.TabIndex = 17;
            // 
            // labelHodnotaA
            // 
            labelHodnotaA.AutoSize = true;
            labelHodnotaA.Font = new Font("Arial Narrow", 27.75F);
            labelHodnotaA.Location = new Point(117, 57);
            labelHodnotaA.Name = "labelHodnotaA";
            labelHodnotaA.Size = new Size(162, 43);
            labelHodnotaA.TabIndex = 16;
            labelHodnotaA.Text = "Hodnota A";
            // 
            // btnDeleni
            // 
            btnDeleni.Font = new Font("Arial Narrow", 27.75F);
            btnDeleni.Location = new Point(436, 260);
            btnDeleni.Name = "btnDeleni";
            btnDeleni.Size = new Size(50, 50);
            btnDeleni.TabIndex = 15;
            btnDeleni.Text = "/";
            btnDeleni.UseVisualStyleBackColor = true;
            // 
            // btnNasobeni
            // 
            btnNasobeni.Font = new Font("Arial Narrow", 27.75F);
            btnNasobeni.Location = new Point(332, 260);
            btnNasobeni.Name = "btnNasobeni";
            btnNasobeni.Size = new Size(50, 50);
            btnNasobeni.TabIndex = 14;
            btnNasobeni.Text = "x";
            btnNasobeni.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Narrow", 27.75F);
            btnMinus.Location = new Point(229, 260);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(50, 50);
            btnMinus.TabIndex = 13;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Narrow", 27.75F);
            btnPlus.Location = new Point(117, 260);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(50, 50);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // kalkulackaLepsi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "kalkulackaLepsi";
            Text = "kalkulackaLepsi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textHodnotaA;
        private Label labelVysledek;
        private TextBox textVysledek;
        private Label labelHodnotaB;
        private TextBox textHodnotaB;
        private Label labelHodnotaA;
        private Button btnDeleni;
        private Button btnNasobeni;
        private Button btnMinus;
        private Button btnPlus;
    }
}
