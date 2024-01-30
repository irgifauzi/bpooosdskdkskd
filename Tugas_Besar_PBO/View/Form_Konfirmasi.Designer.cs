namespace Tugas_Besar_PBO.View
{
    partial class Form_Konfirmasi
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
            this.Konfirmasi = new System.Windows.Forms.GroupBox();
            this.cetakjoki = new System.Windows.Forms.Button();
            this.cetak = new System.Windows.Forms.Button();
            this.cdproses = new System.Windows.Forms.ComboBox();
            this.cjproses = new System.Windows.Forms.ComboBox();
            this.datatranjok = new System.Windows.Forms.DataGridView();
            this.datatrandi = new System.Windows.Forms.DataGridView();
            this.bdproses = new System.Windows.Forms.Button();
            this.bjproses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcaridiamond = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcarijoki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Konfirmasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatranjok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatrandi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Konfirmasi
            // 
            this.Konfirmasi.Controls.Add(this.groupBox2);
            this.Konfirmasi.Controls.Add(this.groupBox1);
            this.Konfirmasi.Controls.Add(this.cetakjoki);
            this.Konfirmasi.Controls.Add(this.cetak);
            this.Konfirmasi.Controls.Add(this.cdproses);
            this.Konfirmasi.Controls.Add(this.cjproses);
            this.Konfirmasi.Controls.Add(this.datatranjok);
            this.Konfirmasi.Controls.Add(this.datatrandi);
            this.Konfirmasi.Controls.Add(this.bdproses);
            this.Konfirmasi.Controls.Add(this.bjproses);
            this.Konfirmasi.Location = new System.Drawing.Point(12, 16);
            this.Konfirmasi.Name = "Konfirmasi";
            this.Konfirmasi.Size = new System.Drawing.Size(945, 419);
            this.Konfirmasi.TabIndex = 11;
            this.Konfirmasi.TabStop = false;
            this.Konfirmasi.Text = "Data Transaksi";
            // 
            // cetakjoki
            // 
            this.cetakjoki.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetakjoki.Location = new System.Drawing.Point(610, 305);
            this.cetakjoki.Name = "cetakjoki";
            this.cetakjoki.Size = new System.Drawing.Size(121, 56);
            this.cetakjoki.TabIndex = 16;
            this.cetakjoki.Text = "Cetak";
            this.cetakjoki.UseVisualStyleBackColor = true;
            this.cetakjoki.Click += new System.EventHandler(this.cetakjoki_Click);
            // 
            // cetak
            // 
            this.cetak.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak.Location = new System.Drawing.Point(610, 121);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(121, 56);
            this.cetak.TabIndex = 15;
            this.cetak.Text = "Cetak";
            this.cetak.UseVisualStyleBackColor = true;
            this.cetak.Click += new System.EventHandler(this.cetak_Click);
            // 
            // cdproses
            // 
            this.cdproses.FormattingEnabled = true;
            this.cdproses.Items.AddRange(new object[] {
            "Transaksi Berhasil"});
            this.cdproses.Location = new System.Drawing.Point(610, 87);
            this.cdproses.Name = "cdproses";
            this.cdproses.Size = new System.Drawing.Size(121, 28);
            this.cdproses.TabIndex = 14;
            // 
            // cjproses
            // 
            this.cjproses.FormattingEnabled = true;
            this.cjproses.Items.AddRange(new object[] {
            "Transaksi Berhasil"});
            this.cjproses.Location = new System.Drawing.Point(610, 271);
            this.cjproses.Name = "cjproses";
            this.cjproses.Size = new System.Drawing.Size(121, 28);
            this.cjproses.TabIndex = 13;
            // 
            // datatranjok
            // 
            this.datatranjok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datatranjok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatranjok.Location = new System.Drawing.Point(6, 209);
            this.datatranjok.Name = "datatranjok";
            this.datatranjok.RowHeadersWidth = 62;
            this.datatranjok.RowTemplate.Height = 28;
            this.datatranjok.Size = new System.Drawing.Size(551, 145);
            this.datatranjok.TabIndex = 12;
            this.datatranjok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatranjok_CellClick);
            // 
            // datatrandi
            // 
            this.datatrandi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datatrandi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatrandi.Location = new System.Drawing.Point(6, 25);
            this.datatrandi.Name = "datatrandi";
            this.datatrandi.RowHeadersWidth = 62;
            this.datatrandi.RowTemplate.Height = 28;
            this.datatrandi.Size = new System.Drawing.Size(551, 145);
            this.datatrandi.TabIndex = 11;
            this.datatrandi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatrandi_CellClick);
            // 
            // bdproses
            // 
            this.bdproses.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdproses.Location = new System.Drawing.Point(610, 25);
            this.bdproses.Name = "bdproses";
            this.bdproses.Size = new System.Drawing.Size(121, 56);
            this.bdproses.TabIndex = 9;
            this.bdproses.Text = "Proses";
            this.bdproses.UseVisualStyleBackColor = true;
            this.bdproses.Click += new System.EventHandler(this.bdproses_Click);
            // 
            // bjproses
            // 
            this.bjproses.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bjproses.Location = new System.Drawing.Point(610, 209);
            this.bjproses.Name = "bjproses";
            this.bjproses.Size = new System.Drawing.Size(121, 56);
            this.bjproses.TabIndex = 8;
            this.bjproses.Text = "Proses";
            this.bjproses.UseVisualStyleBackColor = true;
            this.bjproses.Click += new System.EventHandler(this.bjproses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cari Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcaridiamond);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(737, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data";
            // 
            // tbcaridiamond
            // 
            this.tbcaridiamond.Location = new System.Drawing.Point(20, 62);
            this.tbcaridiamond.Name = "tbcaridiamond";
            this.tbcaridiamond.Size = new System.Drawing.Size(165, 31);
            this.tbcaridiamond.TabIndex = 19;
            this.tbcaridiamond.TextChanged += new System.EventHandler(this.tbcaridiamond_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcarijoki);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(743, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cari Data";
            // 
            // tbcarijoki
            // 
            this.tbcarijoki.Location = new System.Drawing.Point(20, 62);
            this.tbcarijoki.Name = "tbcarijoki";
            this.tbcarijoki.Size = new System.Drawing.Size(165, 31);
            this.tbcarijoki.TabIndex = 19;
            this.tbcarijoki.TextChanged += new System.EventHandler(this.tbcarijoki_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 26);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cari Data";
            // 
            // Form_Konfirmasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.Konfirmasi);
            this.Name = "Form_Konfirmasi";
            this.Text = "Form_Konfirmasi";
            this.Load += new System.EventHandler(this.Form_Konfirmasi_Load);
            this.Konfirmasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datatranjok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatrandi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Konfirmasi;
        private System.Windows.Forms.ComboBox cdproses;
        private System.Windows.Forms.ComboBox cjproses;
        private System.Windows.Forms.DataGridView datatranjok;
        private System.Windows.Forms.DataGridView datatrandi;
        private System.Windows.Forms.Button bdproses;
        private System.Windows.Forms.Button bjproses;
        private System.Windows.Forms.Button cetakjoki;
        private System.Windows.Forms.Button cetak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbcaridiamond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbcarijoki;
        private System.Windows.Forms.Label label2;
    }
}