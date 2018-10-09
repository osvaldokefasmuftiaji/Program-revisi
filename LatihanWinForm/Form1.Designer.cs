namespace LatihanWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampil = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.btnTutup = new System.Windows.Forms.Button();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // btnTampil
            // 
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTampil.Location = new System.Drawing.Point(16, 223);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 28);
            this.btnTampil.TabIndex = 3;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNama.Location = new System.Drawing.Point(147, 52);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(234, 26);
            this.txtNama.TabIndex = 5;
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoLakilaki.Location = new System.Drawing.Point(147, 95);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(98, 24);
            this.rdoLakilaki.TabIndex = 6;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki - Laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdoPerempuan.Location = new System.Drawing.Point(251, 95);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(109, 24);
            this.rdoPerempuan.TabIndex = 7;
            this.rdoPerempuan.TabStop = true;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTutup.Location = new System.Drawing.Point(351, 223);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 28);
            this.btnTutup.TabIndex = 8;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // mskNpm
            // 
            this.mskNpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mskNpm.Location = new System.Drawing.Point(147, 15);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(100, 26);
            this.mskNpm.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tempat Lahir";
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTempatLahir.Location = new System.Drawing.Point(147, 131);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(234, 26);
            this.txtTempatLahir.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(147, 174);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalLahir.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 263);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskNpm);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLakilaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
    }
}

