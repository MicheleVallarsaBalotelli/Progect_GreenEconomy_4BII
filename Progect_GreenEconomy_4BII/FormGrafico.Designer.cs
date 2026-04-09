namespace Progect_GreenEconomy_4BII
{
    partial class FormGrafico
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btn_indietro = new Button();
            lblAnalisi = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(248, 40);
            label1.Name = "label1";
            label1.Size = new Size(304, 37);
            label1.TabIndex = 2;
            label1.Text = "ANALISI E GRAFICO";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(101, 102);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(599, 300);
            chart1.TabIndex = 3;
            chart1.Text = "chart1";
            // 
            // btn_indietro
            // 
            btn_indietro.BackColor = Color.LightGreen;
            btn_indietro.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_indietro.ForeColor = SystemColors.ControlText;
            btn_indietro.Location = new Point(346, 416);
            btn_indietro.Name = "btn_indietro";
            btn_indietro.Size = new Size(108, 49);
            btn_indietro.TabIndex = 4;
            btn_indietro.Text = "INDIETRO";
            btn_indietro.UseVisualStyleBackColor = false;
            btn_indietro.Click += btn_indietro_Click;
            // 
            // lblAnalisi
            // 
            lblAnalisi.AutoSize = true;
            lblAnalisi.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAnalisi.Location = new Point(64, 427);
            lblAnalisi.Name = "lblAnalisi";
            lblAnalisi.Size = new Size(72, 24);
            lblAnalisi.TabIndex = 7;
            lblAnalisi.Text = "Analisi";
            // 
            // FormGrafico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 477);
            Controls.Add(lblAnalisi);
            Controls.Add(btn_indietro);
            Controls.Add(chart1);
            Controls.Add(label1);
            Name = "FormGrafico";
            Text = "FormGrafico";
            Load += FormGrafico_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btn_indietro;
        private Label lblAnalisi;
    }
}