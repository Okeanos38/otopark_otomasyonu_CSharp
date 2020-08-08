namespace Otopark_otomasyonu
{
    partial class otoparkyeri_sec
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
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.otoparkDataSet = new Otopark_otomasyonu.otoparkDataSet();
            this.otoparkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aracdurumuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_durumuTableAdapter = new Otopark_otomasyonu.otoparkDataSetTableAdapters.arac_durumuTableAdapter();
            this.aracsahibiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arac_sahibiTableAdapter = new Otopark_otomasyonu.otoparkDataSetTableAdapters.arac_sahibiTableAdapter();
            this.otoparkDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aracdurumuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aracsahibiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aracdurumuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aracdurumuBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.otoparkDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboplaka = new System.Windows.Forms.ComboBox();
            this.textparkyeri1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textplaka = new System.Windows.Forms.TextBox();
            this.textmarka = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboparkyeri = new System.Windows.Forms.ComboBox();
            this.textparkyeri2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aracdurumuBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.aracdurumuBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsahibiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsahibiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Indigo;
            this.button12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(647, 333);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(108, 45);
            this.button12.TabIndex = 15;
            this.button12.Text = "Çıkış";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Indigo;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(12, 333);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(108, 45);
            this.button11.TabIndex = 14;
            this.button11.Text = "Geri";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // otoparkDataSet
            // 
            this.otoparkDataSet.DataSetName = "otoparkDataSet";
            this.otoparkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // otoparkDataSetBindingSource
            // 
            this.otoparkDataSetBindingSource.DataSource = this.otoparkDataSet;
            this.otoparkDataSetBindingSource.Position = 0;
            // 
            // aracdurumuBindingSource
            // 
            this.aracdurumuBindingSource.DataMember = "arac_durumu";
            this.aracdurumuBindingSource.DataSource = this.otoparkDataSetBindingSource;
            // 
            // arac_durumuTableAdapter
            // 
            this.arac_durumuTableAdapter.ClearBeforeFill = true;
            // 
            // aracsahibiBindingSource
            // 
            this.aracsahibiBindingSource.DataMember = "arac_sahibi";
            this.aracsahibiBindingSource.DataSource = this.otoparkDataSetBindingSource;
            // 
            // arac_sahibiTableAdapter
            // 
            this.arac_sahibiTableAdapter.ClearBeforeFill = true;
            // 
            // otoparkDataSetBindingSource1
            // 
            this.otoparkDataSetBindingSource1.DataSource = this.otoparkDataSet;
            this.otoparkDataSetBindingSource1.Position = 0;
            // 
            // aracdurumuBindingSource1
            // 
            this.aracdurumuBindingSource1.DataMember = "arac_durumu";
            this.aracdurumuBindingSource1.DataSource = this.otoparkDataSetBindingSource;
            // 
            // aracsahibiBindingSource1
            // 
            this.aracsahibiBindingSource1.DataMember = "arac_sahibi";
            this.aracsahibiBindingSource1.DataSource = this.otoparkDataSetBindingSource;
            // 
            // aracdurumuBindingSource2
            // 
            this.aracdurumuBindingSource2.DataMember = "arac_durumu";
            this.aracdurumuBindingSource2.DataSource = this.otoparkDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 164);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aracdurumuBindingSource3
            // 
            this.aracdurumuBindingSource3.DataMember = "arac_durumu";
            this.aracdurumuBindingSource3.DataSource = this.otoparkDataSetBindingSource1;
            // 
            // otoparkDataSetBindingSource2
            // 
            this.otoparkDataSetBindingSource2.DataSource = this.otoparkDataSet;
            this.otoparkDataSetBindingSource2.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboplaka);
            this.groupBox1.Controls.Add(this.textparkyeri1);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 99);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plaka ve Park yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Park yeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka Ara";
            // 
            // comboplaka
            // 
            this.comboplaka.FormattingEnabled = true;
            this.comboplaka.Location = new System.Drawing.Point(97, 19);
            this.comboplaka.Name = "comboplaka";
            this.comboplaka.Size = new System.Drawing.Size(121, 21);
            this.comboplaka.TabIndex = 1;
            this.comboplaka.SelectedIndexChanged += new System.EventHandler(this.comboplaka_SelectedIndexChanged);
            // 
            // textparkyeri1
            // 
            this.textparkyeri1.Location = new System.Drawing.Point(97, 57);
            this.textparkyeri1.Name = "textparkyeri1";
            this.textparkyeri1.Size = new System.Drawing.Size(121, 20);
            this.textparkyeri1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textplaka);
            this.groupBox2.Controls.Add(this.textmarka);
            this.groupBox2.Controls.Add(this.textsoyad);
            this.groupBox2.Controls.Add(this.textad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboparkyeri);
            this.groupBox2.Controls.Add(this.textparkyeri2);
            this.groupBox2.Location = new System.Drawing.Point(284, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 99);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç";
            // 
            // textplaka
            // 
            this.textplaka.Location = new System.Drawing.Point(363, 57);
            this.textplaka.Name = "textplaka";
            this.textplaka.Size = new System.Drawing.Size(98, 20);
            this.textplaka.TabIndex = 7;
            // 
            // textmarka
            // 
            this.textmarka.Location = new System.Drawing.Point(363, 19);
            this.textmarka.Name = "textmarka";
            this.textmarka.Size = new System.Drawing.Size(98, 20);
            this.textmarka.TabIndex = 6;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(239, 57);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(98, 20);
            this.textsoyad.TabIndex = 5;
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(239, 19);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(98, 20);
            this.textad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Park yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Park Yeri";
            // 
            // comboparkyeri
            // 
            this.comboparkyeri.FormattingEnabled = true;
            this.comboparkyeri.Location = new System.Drawing.Point(85, 19);
            this.comboparkyeri.Name = "comboparkyeri";
            this.comboparkyeri.Size = new System.Drawing.Size(121, 21);
            this.comboparkyeri.TabIndex = 1;
            this.comboparkyeri.SelectedIndexChanged += new System.EventHandler(this.comboparkyeri_SelectedIndexChanged);
            // 
            // textparkyeri2
            // 
            this.textparkyeri2.Location = new System.Drawing.Point(85, 57);
            this.textparkyeri2.Name = "textparkyeri2";
            this.textparkyeri2.Size = new System.Drawing.Size(121, 20);
            this.textparkyeri2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(298, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Otoparktan Ayrıl !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aracdurumuBindingSource4
            // 
            this.aracdurumuBindingSource4.DataMember = "arac_durumu";
            this.aracdurumuBindingSource4.DataSource = this.otoparkDataSetBindingSource;
            // 
            // aracdurumuBindingSource5
            // 
            this.aracdurumuBindingSource5.DataMember = "arac_durumu";
            this.aracdurumuBindingSource5.DataSource = this.otoparkDataSetBindingSource;
            // 
            // otoparkyeri_sec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 386);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Name = "otoparkyeri_sec";
            this.Text = "Otopark dan Çıkış";
            this.Load += new System.EventHandler(this.otoparkyeri_sec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsahibiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracsahibiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otoparkDataSetBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumuBindingSource5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.BindingSource otoparkDataSetBindingSource;
        private otoparkDataSet otoparkDataSet;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource;
        private otoparkDataSetTableAdapters.arac_durumuTableAdapter arac_durumuTableAdapter;
        private System.Windows.Forms.BindingSource aracsahibiBindingSource;
        private otoparkDataSetTableAdapters.arac_sahibiTableAdapter arac_sahibiTableAdapter;
        private System.Windows.Forms.BindingSource aracsahibiBindingSource1;
        private System.Windows.Forms.BindingSource otoparkDataSetBindingSource1;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource1;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource3;
        private System.Windows.Forms.BindingSource otoparkDataSetBindingSource2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboplaka;
        private System.Windows.Forms.TextBox textparkyeri1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textplaka;
        private System.Windows.Forms.TextBox textmarka;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboparkyeri;
        private System.Windows.Forms.TextBox textparkyeri2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource4;
        private System.Windows.Forms.BindingSource aracdurumuBindingSource5;
    }
}