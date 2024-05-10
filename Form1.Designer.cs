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
            dgvDati = new DataGridView();
            cmbScelta = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDati).BeginInit();
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
            btnElencoPiloti.Click += btnElencoPiloti_Click;
            // 
            // btnElencoGare
            // 
            btnElencoGare.Location = new Point(47, 81);
            btnElencoGare.Name = "btnElencoGare";
            btnElencoGare.Size = new Size(160, 29);
            btnElencoGare.TabIndex = 1;
            btnElencoGare.Text = "elenco gare";
            btnElencoGare.UseVisualStyleBackColor = true;
            btnElencoGare.Click += btnElencoGare_Click;
            // 
            // dgvDati
            // 
            dgvDati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDati.Location = new Point(47, 140);
            dgvDati.Name = "dgvDati";
            dgvDati.RowHeadersWidth = 51;
            dgvDati.Size = new Size(741, 298);
            dgvDati.TabIndex = 3;
            // 
            // cmbScelta
            // 
            cmbScelta.FormattingEnabled = true;
            cmbScelta.Items.AddRange(new object[] { "Elenco squadre non italiane ordinate per nome", "Elenco piloti Ducati ordinati per cognome e nome", "Elenco circuiti ordinati per nome" });
            cmbScelta.Location = new Point(282, 33);
            cmbScelta.Name = "cmbScelta";
            cmbScelta.Size = new Size(284, 28);
            cmbScelta.TabIndex = 4;
            cmbScelta.SelectedIndexChanged += cmbScelta_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbScelta);
            Controls.Add(dgvDati);
            Controls.Add(btnElencoGare);
            Controls.Add(btnElencoPiloti);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDati).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnElencoPiloti;
        private Button btnElencoGare;
        private DataGridView dgvDati;
        private ComboBox cmbScelta;
    }
}
