﻿namespace client
{
    partial class MoviesList
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
            this.dgvMovieDiagnosis = new System.Windows.Forms.DataGridView();
            this.movieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoyPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SadnessPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisgustPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FearPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurprisePrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovieDiagnosis
            // 
            this.dgvMovieDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieName,
            this.MovieTags,
            this.MovieLength,
            this.JoyPrecentage,
            this.SadnessPrecentage,
            this.DisgustPrecentage,
            this.FearPrecentage,
            this.SurprisePrecentage});
            this.dgvMovieDiagnosis.Location = new System.Drawing.Point(16, 12);
            this.dgvMovieDiagnosis.Name = "dgvMovieDiagnosis";
            this.dgvMovieDiagnosis.Size = new System.Drawing.Size(871, 299);
            this.dgvMovieDiagnosis.TabIndex = 0;
            this.dgvMovieDiagnosis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieDiagnosis_CellContentClick);
            // 
            // movieName
            // 
            this.movieName.HeaderText = "Movie Name";
            this.movieName.Name = "movieName";
            // 
            // MovieTags
            // 
            this.MovieTags.HeaderText = "Movie Tags";
            this.MovieTags.Name = "MovieTags";
            // 
            // MovieLength
            // 
            this.MovieLength.HeaderText = "Movie Length";
            this.MovieLength.Name = "MovieLength";
            // 
            // JoyPrecentage
            // 
            this.JoyPrecentage.HeaderText = "Joy Precentage";
            this.JoyPrecentage.Name = "JoyPrecentage";
            // 
            // SadnessPrecentage
            // 
            this.SadnessPrecentage.HeaderText = "Sadness Precentage";
            this.SadnessPrecentage.Name = "SadnessPrecentage";
            // 
            // DisgustPrecentage
            // 
            this.DisgustPrecentage.HeaderText = "Disgust Precentage";
            this.DisgustPrecentage.Name = "DisgustPrecentage";
            // 
            // FearPrecentage
            // 
            this.FearPrecentage.HeaderText = "Fear Precentage";
            this.FearPrecentage.Name = "FearPrecentage";
            // 
            // SurprisePrecentage
            // 
            this.SurprisePrecentage.HeaderText = "Surprise Precentage";
            this.SurprisePrecentage.Name = "SurprisePrecentage";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(968, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 323);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvMovieDiagnosis);
            this.Name = "MoviesList";
            this.Text = "MoviesList";
            this.Load += new System.EventHandler(this.MoviesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovieDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoyPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SadnessPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisgustPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FearPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurprisePrecentage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}