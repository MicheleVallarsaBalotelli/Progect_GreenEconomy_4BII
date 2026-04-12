namespace Progect_GreenEconomy_4BII
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
            label1 = new Label();
            label2 = new Label();
            btn_aggiorna = new Button();
            label3 = new Label();
            btn_visualizzaDati = new Button();
            btn_analisiGrafico = new Button();
            lblStato = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_reset = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 82);
            label1.Name = "label1";
            label1.Size = new Size(469, 37);
            label1.TabIndex = 0;
            label1.Text = " MONITORAGGIO AMBIENTALE ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 9);
            label2.Name = "label2";
            label2.Size = new Size(157, 34);
            label2.TabIndex = 1;
            label2.Text = "📍VICENZA";
            label2.Click += label2_Click;
            // 
            // btn_aggiorna
            // 
            btn_aggiorna.BackColor = Color.ForestGreen;
            btn_aggiorna.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_aggiorna.ForeColor = Color.White;
            btn_aggiorna.Location = new Point(3, 3);
            btn_aggiorna.Name = "btn_aggiorna";
            btn_aggiorna.Size = new Size(185, 49);
            btn_aggiorna.TabIndex = 2;
            btn_aggiorna.Text = " AGGIORNA DATI (API)";
            btn_aggiorna.UseVisualStyleBackColor = false;
            btn_aggiorna.Click += btn_aggiorna_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(320, 45);
            label3.Name = "label3";
            label3.Size = new Size(310, 41);
            label3.TabIndex = 3;
            label3.Text = "GREEN ECONOMY ";
            // 
            // btn_visualizzaDati
            // 
            btn_visualizzaDati.BackColor = Color.LightSkyBlue;
            btn_visualizzaDati.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_visualizzaDati.ForeColor = SystemColors.ControlText;
            btn_visualizzaDati.Location = new Point(217, 275);
            btn_visualizzaDati.Name = "btn_visualizzaDati";
            btn_visualizzaDati.Size = new Size(207, 68);
            btn_visualizzaDati.TabIndex = 4;
            btn_visualizzaDati.Text = " VISUALIZZA STORICO DATI";
            btn_visualizzaDati.UseVisualStyleBackColor = false;
            btn_visualizzaDati.Click += btn_visualizzaDati_Click;
            // 
            // btn_analisiGrafico
            // 
            btn_analisiGrafico.BackColor = Color.Coral;
            btn_analisiGrafico.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_analisiGrafico.ForeColor = SystemColors.ControlText;
            btn_analisiGrafico.Location = new Point(536, 275);
            btn_analisiGrafico.Name = "btn_analisiGrafico";
            btn_analisiGrafico.Size = new Size(207, 68);
            btn_analisiGrafico.TabIndex = 5;
            btn_analisiGrafico.Text = "ANALISI E GRAFICO";
            btn_analisiGrafico.UseVisualStyleBackColor = false;
            btn_analisiGrafico.Click += btn_analisiGrafico_Click;
            // 
            // lblStato
            // 
            lblStato.AutoSize = true;
            lblStato.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStato.Location = new Point(236, 14);
            lblStato.Name = "lblStato";
            lblStato.Size = new Size(64, 24);
            lblStato.TabIndex = 6;
            lblStato.Text = "Stato:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(384, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 52);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(btn_aggiorna);
            panel2.Controls.Add(lblStato);
            panel2.Location = new Point(212, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(526, 57);
            panel2.TabIndex = 8;
            // 
            // btn_reset
            // 
            btn_reset.BackColor = Color.Red;
            btn_reset.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_reset.ForeColor = Color.White;
            btn_reset.Location = new Point(114, 207);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(95, 40);
            btn_reset.TabIndex = 7;
            btn_reset.Text = "RESET";
            btn_reset.UseVisualStyleBackColor = false;
            btn_reset.Click += btn_reset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(951, 430);
            Controls.Add(btn_reset);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_analisiGrafico);
            Controls.Add(btn_visualizzaDati);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_aggiorna;
        private Label label3;
        private Button btn_visualizzaDati;
        private Button btn_analisiGrafico;
        private Label lblStato;
        private Panel panel1;
        private Panel panel2;
        private Button btn_reset;
    }
}
