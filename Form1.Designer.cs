namespace Esercizio_AS2324._3G.SpadiniLorenzo.PSDBPCTO
{
    partial class Form1
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
            btnElencoPiloti = new Button();
            btnElencoGare = new Button();
            cmbScelta = new ComboBox();
            dgwRIsultati = new DataGridView();
            btnEstrai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwRIsultati).BeginInit();
            SuspendLayout();
            // 
            // btnElencoPiloti
            // 
            btnElencoPiloti.Location = new Point(47, 32);
            btnElencoPiloti.Name = "btnElencoPiloti";
            btnElencoPiloti.Size = new Size(160, 29);
            btnElencoPiloti.TabIndex = 0;
            btnElencoPiloti.Text = "elenco piloti";
            btnElencoPiloti.UseVisualStyleBackColor = true;
            // 
            // btnElencoGare
            // 
            btnElencoGare.Location = new Point(47, 81);
            btnElencoGare.Name = "btnElencoGare";
            btnElencoGare.Size = new Size(160, 29);
            btnElencoGare.TabIndex = 1;
            btnElencoGare.Text = "elenco gare";
            btnElencoGare.UseVisualStyleBackColor = true;
            // 
            // cmbScelta
            // 
            cmbScelta.FormattingEnabled = true;
            cmbScelta.Items.AddRange(new object[] { " Elenco squadre non italiane ordinate per nome", " Elenco piloti Ducati ordinati per cognome e nome", " Elenco circuiti ordinati per nome" });
            cmbScelta.Location = new Point(315, 34);
            cmbScelta.Name = "cmbScelta";
            cmbScelta.Size = new Size(282, 28);
            cmbScelta.TabIndex = 2;
            // 
            // dgwRIsultati
            // 
            dgwRIsultati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwRIsultati.Location = new Point(47, 140);
            dgwRIsultati.Name = "dgwRIsultati";
            dgwRIsultati.RowHeadersWidth = 51;
            dgwRIsultati.Size = new Size(741, 298);
            dgwRIsultati.TabIndex = 3;
            // 
            // btnEstrai
            // 
            btnEstrai.Location = new Point(641, 33);
            btnEstrai.Name = "btnEstrai";
            btnEstrai.Size = new Size(94, 29);
            btnEstrai.TabIndex = 4;
            btnEstrai.Text = "estrai";
            btnEstrai.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEstrai);
            Controls.Add(dgwRIsultati);
            Controls.Add(cmbScelta);
            Controls.Add(btnElencoGare);
            Controls.Add(btnElencoPiloti);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgwRIsultati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnElencoPiloti;
        private Button btnElencoGare;
        private ComboBox cmbScelta;
        private DataGridView dgwRIsultati;
        private Button btnEstrai;
    }
}
