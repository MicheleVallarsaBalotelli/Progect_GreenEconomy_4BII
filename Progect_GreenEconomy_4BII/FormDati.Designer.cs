namespace Progect_GreenEconomy_4BII
{
    partial class FormDati
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dvg_dati = new DataGridView();
            btn_indietro = new Button();
            ((System.ComponentModel.ISupportInitialize)dvg_dati).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(155, 38);
            label1.Name = "label1";
            label1.Size = new Size(491, 37);
            label1.TabIndex = 1;
            label1.Text = "VISUALIZZAZIONE TABELLA DATI";
            // 
            // dvg_dati
            // 
            dvg_dati.AllowUserToAddRows = false;
            dvg_dati.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dvg_dati.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dvg_dati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvg_dati.BackgroundColor = Color.White;
            dvg_dati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_dati.Location = new Point(115, 114);
            dvg_dati.Name = "dvg_dati";
            dvg_dati.ReadOnly = true;
            dvg_dati.Size = new Size(571, 298);
            dvg_dati.TabIndex = 2;
            // 
            // btn_indietro
            // 
            btn_indietro.BackColor = Color.LightGreen;
            btn_indietro.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_indietro.ForeColor = SystemColors.ControlText;
            btn_indietro.Location = new Point(346, 418);
            btn_indietro.Name = "btn_indietro";
            btn_indietro.Size = new Size(108, 49);
            btn_indietro.TabIndex = 3;
            btn_indietro.Text = "INDIETRO";
            btn_indietro.UseVisualStyleBackColor = false;
            // 
            // FormDati
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 477);
            Controls.Add(btn_indietro);
            Controls.Add(dvg_dati);
            Controls.Add(label1);
            Name = "FormDati";
            Text = "FormDati";
            Load += FormDati_Load;
            ((System.ComponentModel.ISupportInitialize)dvg_dati).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dvg_dati;
        private Button btn_indietro;
    }
}