namespace client
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.movieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoyPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SadnessPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisgustPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FearPrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurprisePrecentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieName,
            this.MovieTags,
            this.MovieLength,
            this.JoyPrecentage,
            this.SadnessPrecentage,
            this.DisgustPrecentage,
            this.FearPrecentage,
            this.SurprisePrecentage});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(701, 299);
            this.dataGridView1.TabIndex = 0;
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
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 323);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MoviesList";
            this.Text = "MoviesList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTags;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoyPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SadnessPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisgustPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FearPrecentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurprisePrecentage;
    }
}