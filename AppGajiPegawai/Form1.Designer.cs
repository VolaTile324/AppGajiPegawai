namespace AppGajiPegawai
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textNIK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTunjangan = new System.Windows.Forms.TextBox();
            this.textPotongan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GenderPegawai = new System.Windows.Forms.ComboBox();
            this.GolPegawai = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.tampilanPegawai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tampilanGolongan = new System.Windows.Forms.DataGridView();
            this.ColGolongan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGaji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingGolPegawai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textSetGaji = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSetGaji = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dBGajiPegawaiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_GajiPegawaiDataSet = new AppGajiPegawai.DB_GajiPegawaiDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tampilanPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilanGolongan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGajiPegawaiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GajiPegawaiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAJI PEGAWAI";
            // 
            // textNIK
            // 
            this.textNIK.Location = new System.Drawing.Point(165, 118);
            this.textNIK.MaxLength = 16;
            this.textNIK.Name = "textNIK";
            this.textNIK.ShortcutsEnabled = false;
            this.textNIK.Size = new System.Drawing.Size(224, 22);
            this.textNIK.TabIndex = 1;
            this.textNIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIK*";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(165, 161);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(224, 22);
            this.textNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nama*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Golongan";
            // 
            // textTunjangan
            // 
            this.textTunjangan.Location = new System.Drawing.Point(165, 290);
            this.textTunjangan.Name = "textTunjangan";
            this.textTunjangan.ShortcutsEnabled = false;
            this.textTunjangan.Size = new System.Drawing.Size(224, 22);
            this.textTunjangan.TabIndex = 9;
            this.textTunjangan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textPotongan
            // 
            this.textPotongan.Location = new System.Drawing.Point(165, 330);
            this.textPotongan.Name = "textPotongan";
            this.textPotongan.ShortcutsEnabled = false;
            this.textPotongan.Size = new System.Drawing.Size(224, 22);
            this.textPotongan.TabIndex = 10;
            this.textPotongan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tunjangan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Potongan";
            // 
            // GenderPegawai
            // 
            this.GenderPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderPegawai.FormattingEnabled = true;
            this.GenderPegawai.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.GenderPegawai.Location = new System.Drawing.Point(165, 203);
            this.GenderPegawai.Name = "GenderPegawai";
            this.GenderPegawai.Size = new System.Drawing.Size(224, 24);
            this.GenderPegawai.TabIndex = 13;
            // 
            // GolPegawai
            // 
            this.GolPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GolPegawai.FormattingEnabled = true;
            this.GolPegawai.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "1D",
            "2A",
            "2B",
            "2C",
            "2D",
            "3A",
            "3B",
            "3C",
            "3D",
            "4A",
            "4B",
            "4C",
            "4D",
            "4E"});
            this.GolPegawai.Location = new System.Drawing.Point(165, 246);
            this.GolPegawai.Name = "GolPegawai";
            this.GolPegawai.Size = new System.Drawing.Size(224, 24);
            this.GolPegawai.TabIndex = 14;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(41, 391);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 31);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Tambah";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(165, 391);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(99, 31);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(290, 391);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(99, 31);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Hapus";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // tampilanPegawai
            // 
            this.tampilanPegawai.AllowUserToAddRows = false;
            this.tampilanPegawai.AllowUserToDeleteRows = false;
            this.tampilanPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampilanPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.tampilanPegawai.Location = new System.Drawing.Point(449, 28);
            this.tampilanPegawai.Name = "tampilanPegawai";
            this.tampilanPegawai.ReadOnly = true;
            this.tampilanPegawai.RowHeadersWidth = 51;
            this.tampilanPegawai.RowTemplate.Height = 24;
            this.tampilanPegawai.Size = new System.Drawing.Size(985, 394);
            this.tampilanPegawai.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NIK";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Pegawai";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jenis Kelamin";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Golongan";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Gaji Pokok";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tunjangan";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Potongan";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Total Gaji";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // tampilanGolongan
            // 
            this.tampilanGolongan.AllowUserToAddRows = false;
            this.tampilanGolongan.AllowUserToDeleteRows = false;
            this.tampilanGolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tampilanGolongan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGolongan,
            this.ColGaji});
            this.tampilanGolongan.Location = new System.Drawing.Point(750, 473);
            this.tampilanGolongan.Name = "tampilanGolongan";
            this.tampilanGolongan.ReadOnly = true;
            this.tampilanGolongan.RowHeadersWidth = 51;
            this.tampilanGolongan.RowTemplate.Height = 24;
            this.tampilanGolongan.Size = new System.Drawing.Size(432, 236);
            this.tampilanGolongan.TabIndex = 20;
            // 
            // ColGolongan
            // 
            this.ColGolongan.HeaderText = "Golongan";
            this.ColGolongan.MinimumWidth = 6;
            this.ColGolongan.Name = "ColGolongan";
            this.ColGolongan.ReadOnly = true;
            this.ColGolongan.Width = 125;
            // 
            // ColGaji
            // 
            this.ColGaji.HeaderText = "Gaji Pokok";
            this.ColGaji.MinimumWidth = 6;
            this.ColGaji.Name = "ColGaji";
            this.ColGaji.ReadOnly = true;
            this.ColGaji.Width = 125;
            // 
            // SettingGolPegawai
            // 
            this.SettingGolPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SettingGolPegawai.FormattingEnabled = true;
            this.SettingGolPegawai.Items.AddRange(new object[] {
            "1A",
            "1B",
            "1C",
            "1D",
            "2A",
            "2B",
            "2C",
            "2D",
            "3A",
            "3B",
            "3C",
            "3D",
            "4A",
            "4B",
            "4C",
            "4D",
            "4E"});
            this.SettingGolPegawai.Location = new System.Drawing.Point(466, 535);
            this.SettingGolPegawai.Name = "SettingGolPegawai";
            this.SettingGolPegawai.Size = new System.Drawing.Size(224, 24);
            this.SettingGolPegawai.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(338, 533);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Golongan";
            // 
            // textSetGaji
            // 
            this.textSetGaji.Location = new System.Drawing.Point(466, 581);
            this.textSetGaji.Name = "textSetGaji";
            this.textSetGaji.ShortcutsEnabled = false;
            this.textSetGaji.Size = new System.Drawing.Size(224, 22);
            this.textSetGaji.TabIndex = 23;
            this.textSetGaji.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSetGaji_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 579);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gaji Pokok";
            // 
            // buttonSetGaji
            // 
            this.buttonSetGaji.Location = new System.Drawing.Point(342, 673);
            this.buttonSetGaji.Name = "buttonSetGaji";
            this.buttonSetGaji.Size = new System.Drawing.Size(348, 36);
            this.buttonSetGaji.TabIndex = 25;
            this.buttonSetGaji.Text = "Update Gaji Pokok Pegawai";
            this.buttonSetGaji.UseVisualStyleBackColor = true;
            this.buttonSetGaji.Click += new System.EventHandler(this.buttonSetGaji_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(326, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(377, 38);
            this.label10.TabIndex = 26;
            this.label10.Text = "PENGATURAN GAJI POKOK";
            // 
            // dBGajiPegawaiDataSetBindingSource
            // 
            this.dBGajiPegawaiDataSetBindingSource.DataSource = this.dB_GajiPegawaiDataSet;
            this.dBGajiPegawaiDataSetBindingSource.Position = 0;
            // 
            // dB_GajiPegawaiDataSet
            // 
            this.dB_GajiPegawaiDataSet.DataSetName = "DB_GajiPegawaiDataSet";
            this.dB_GajiPegawaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonSetGaji);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textSetGaji);
            this.Controls.Add(this.SettingGolPegawai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tampilanGolongan);
            this.Controls.Add(this.tampilanPegawai);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.GolPegawai);
            this.Controls.Add(this.GenderPegawai);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPotongan);
            this.Controls.Add(this.textTunjangan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNIK);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Pendataan Gaji Pegawai (v0.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tampilanPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilanGolongan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBGajiPegawaiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_GajiPegawaiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNIK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textTunjangan;
        private System.Windows.Forms.TextBox textPotongan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GenderPegawai;
        private System.Windows.Forms.ComboBox GolPegawai;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.BindingSource dBGajiPegawaiDataSetBindingSource;
        private DB_GajiPegawaiDataSet dB_GajiPegawaiDataSet;
        private System.Windows.Forms.DataGridView tampilanPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView tampilanGolongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGolongan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGaji;
        private System.Windows.Forms.ComboBox SettingGolPegawai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSetGaji;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSetGaji;
        private System.Windows.Forms.Label label10;
    }
}

