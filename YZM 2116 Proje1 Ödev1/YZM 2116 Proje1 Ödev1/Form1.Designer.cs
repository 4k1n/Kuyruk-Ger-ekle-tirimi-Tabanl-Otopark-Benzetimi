using System;

namespace YZM_2116_Proje1_Ödev1
{
    partial class Form1
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSimpleRemove = new System.Windows.Forms.Button();
            this.btnOrtZamanS = new System.Windows.Forms.Button();
            this.btnOrtZamanP = new System.Windows.Forms.Button();
            this.btnPriorityRemove = new System.Windows.Forms.Button();
            this.btnSiralaP = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 36);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(151, 76);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "ARABA EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSimpleRemove
            // 
            this.btnSimpleRemove.Location = new System.Drawing.Point(169, 36);
            this.btnSimpleRemove.Name = "btnSimpleRemove";
            this.btnSimpleRemove.Size = new System.Drawing.Size(151, 76);
            this.btnSimpleRemove.TabIndex = 1;
            this.btnSimpleRemove.Text = "SimpleQueue Remove";
            this.btnSimpleRemove.UseVisualStyleBackColor = true;
            this.btnSimpleRemove.Click += new System.EventHandler(this.btnSimpleRemove_Click);
            // 
            // btnOrtZamanS
            // 
            this.btnOrtZamanS.Location = new System.Drawing.Point(326, 36);
            this.btnOrtZamanS.Name = "btnOrtZamanS";
            this.btnOrtZamanS.Size = new System.Drawing.Size(151, 76);
            this.btnOrtZamanS.TabIndex = 2;
            this.btnOrtZamanS.Text = "Simple Queue İçin Ortalama İşlem Süresi";
            this.btnOrtZamanS.UseVisualStyleBackColor = true;
            this.btnOrtZamanS.Click += new System.EventHandler(this.btnOrtZamanS_Click);
            // 
            // btnOrtZamanP
            // 
            this.btnOrtZamanP.Location = new System.Drawing.Point(803, 36);
            this.btnOrtZamanP.Name = "btnOrtZamanP";
            this.btnOrtZamanP.Size = new System.Drawing.Size(151, 76);
            this.btnOrtZamanP.TabIndex = 3;
            this.btnOrtZamanP.Text = "Priority Queue İçin Ortalama İşlem Süresi";
            this.btnOrtZamanP.UseVisualStyleBackColor = true;
            this.btnOrtZamanP.Click += new System.EventHandler(this.btnOrtZamanP_Click);
            // 
            // btnPriorityRemove
            // 
            this.btnPriorityRemove.Location = new System.Drawing.Point(646, 36);
            this.btnPriorityRemove.Name = "btnPriorityRemove";
            this.btnPriorityRemove.Size = new System.Drawing.Size(151, 76);
            this.btnPriorityRemove.TabIndex = 4;
            this.btnPriorityRemove.Text = "PriorityQueue Remove";
            this.btnPriorityRemove.UseVisualStyleBackColor = true;
            this.btnPriorityRemove.Click += new System.EventHandler(this.btnPriorityRemove_Click);
            // 
            // btnSiralaP
            // 
            this.btnSiralaP.Location = new System.Drawing.Point(489, 36);
            this.btnSiralaP.Name = "btnSiralaP";
            this.btnSiralaP.Size = new System.Drawing.Size(151, 76);
            this.btnSiralaP.TabIndex = 5;
            this.btnSiralaP.Text = "Zamana Göre Sırala";
            this.btnSiralaP.UseVisualStyleBackColor = true;
            this.btnSiralaP.Click += new System.EventHandler(this.btnSiralaP_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(465, 349);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(489, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(465, 349);
            this.dataGridView2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 534);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSiralaP);
            this.Controls.Add(this.btnPriorityRemove);
            this.Controls.Add(this.btnOrtZamanP);
            this.Controls.Add(this.btnOrtZamanS);
            this.Controls.Add(this.btnSimpleRemove);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Ödev 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Araç Numarası";
            dataGridView1.Columns[1].Name = "Kalma Süresi";

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Araç Numarası";
            dataGridView2.Columns[1].Name = "Kalma Süresi";
        }



        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSimpleRemove;
        private System.Windows.Forms.Button btnOrtZamanS;
        private System.Windows.Forms.Button btnOrtZamanP;
        private System.Windows.Forms.Button btnPriorityRemove;
        private System.Windows.Forms.Button btnSiralaP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

