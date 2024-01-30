namespace Tugas_Besar_PBO.View
{
    partial class Data_transaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataTraJoki = new System.Windows.Forms.DataGridView();
            this.dataTraDiamond = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datatradija = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraJoki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatradija)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.datatradija);
            this.groupBox1.Controls.Add(this.dataTraJoki);
            this.groupBox1.Controls.Add(this.dataTraDiamond);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 588);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Transaksi";
            // 
            // dataTraJoki
            // 
            this.dataTraJoki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTraJoki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTraJoki.Location = new System.Drawing.Point(19, 238);
            this.dataTraJoki.Name = "dataTraJoki";
            this.dataTraJoki.RowHeadersWidth = 62;
            this.dataTraJoki.RowTemplate.Height = 28;
            this.dataTraJoki.Size = new System.Drawing.Size(731, 145);
            this.dataTraJoki.TabIndex = 6;
            // 
            // dataTraDiamond
            // 
            this.dataTraDiamond.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTraDiamond.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTraDiamond.Location = new System.Drawing.Point(19, 58);
            this.dataTraDiamond.Name = "dataTraDiamond";
            this.dataTraDiamond.RowHeadersWidth = 62;
            this.dataTraDiamond.RowTemplate.Height = 28;
            this.dataTraDiamond.Size = new System.Drawing.Size(731, 145);
            this.dataTraDiamond.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "JOKI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "DIAMOND";
            // 
            // datatradija
            // 
            this.datatradija.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datatradija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatradija.Location = new System.Drawing.Point(19, 421);
            this.datatradija.Name = "datatradija";
            this.datatradija.RowHeadersWidth = 62;
            this.datatradija.RowTemplate.Height = 28;
            this.datatradija.Size = new System.Drawing.Size(731, 145);
            this.datatradija.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Diamond dan Jasa Joki";
            // 
            // Data_transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(815, 612);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Data_transaksi";
            this.Text = "Data_transaksi";
            this.Load += new System.EventHandler(this.Data_transaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraJoki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTraDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatradija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataTraJoki;
        private System.Windows.Forms.DataGridView dataTraDiamond;
        private System.Windows.Forms.DataGridView datatradija;
        private System.Windows.Forms.Label label3;
    }
}