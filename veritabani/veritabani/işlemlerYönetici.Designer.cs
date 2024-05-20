namespace veritabani
{
    partial class işlemlerYönetici
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.denemeDataSet = new veritabani.denemeDataSet();
            this.denemeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.denemeDataSet1 = new veritabani.denemeDataSet1();
            this.tblurunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_urunlerTableAdapter = new veritabani.denemeDataSet1TableAdapters.tbl_urunlerTableAdapter();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uStokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uKatogoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 402);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 130);
            this.panel2.TabIndex = 0;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(507, 9);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 20);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Fiyata Göre ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(292, 9);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(195, 20);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Son Kullanma Tarihine Göre";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(124, 9);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 20);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Stok Miktarına Göre ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 20);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsme Göre ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arama Metin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(364, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(364, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başlangıç tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bitiş Tarihi";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton6);
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Location = new System.Drawing.Point(8, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 38);
            this.panel3.TabIndex = 1;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(29, 12);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 20);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Artan";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(116, 12);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(69, 20);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Azalan";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uIDDataGridViewTextBoxColumn,
            this.uAdDataGridViewTextBoxColumn,
            this.uFiyatDataGridViewTextBoxColumn,
            this.uStokDataGridViewTextBoxColumn,
            this.uKatogoriDataGridViewTextBoxColumn,
            this.uSTTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblurunlerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 61);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // denemeDataSet
            // 
            this.denemeDataSet.DataSetName = "denemeDataSet";
            this.denemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // denemeDataSetBindingSource
            // 
            this.denemeDataSetBindingSource.DataSource = this.denemeDataSet;
            this.denemeDataSetBindingSource.Position = 0;
            // 
            // denemeDataSet1
            // 
            this.denemeDataSet1.DataSetName = "denemeDataSet1";
            this.denemeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblurunlerBindingSource
            // 
            this.tblurunlerBindingSource.DataMember = "tbl_urunler";
            this.tblurunlerBindingSource.DataSource = this.denemeDataSet1;
            // 
            // tbl_urunlerTableAdapter
            // 
            this.tbl_urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "uID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "uID";
            this.uIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.uIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uAdDataGridViewTextBoxColumn
            // 
            this.uAdDataGridViewTextBoxColumn.DataPropertyName = "uAd";
            this.uAdDataGridViewTextBoxColumn.HeaderText = "uAd";
            this.uAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uAdDataGridViewTextBoxColumn.Name = "uAdDataGridViewTextBoxColumn";
            this.uAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // uFiyatDataGridViewTextBoxColumn
            // 
            this.uFiyatDataGridViewTextBoxColumn.DataPropertyName = "uFiyat";
            this.uFiyatDataGridViewTextBoxColumn.HeaderText = "uFiyat";
            this.uFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uFiyatDataGridViewTextBoxColumn.Name = "uFiyatDataGridViewTextBoxColumn";
            this.uFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // uStokDataGridViewTextBoxColumn
            // 
            this.uStokDataGridViewTextBoxColumn.DataPropertyName = "uStok";
            this.uStokDataGridViewTextBoxColumn.HeaderText = "uStok";
            this.uStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uStokDataGridViewTextBoxColumn.Name = "uStokDataGridViewTextBoxColumn";
            this.uStokDataGridViewTextBoxColumn.Width = 125;
            // 
            // uKatogoriDataGridViewTextBoxColumn
            // 
            this.uKatogoriDataGridViewTextBoxColumn.DataPropertyName = "uKatogori";
            this.uKatogoriDataGridViewTextBoxColumn.HeaderText = "uKatogori";
            this.uKatogoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uKatogoriDataGridViewTextBoxColumn.Name = "uKatogoriDataGridViewTextBoxColumn";
            this.uKatogoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // uSTTDataGridViewTextBoxColumn
            // 
            this.uSTTDataGridViewTextBoxColumn.DataPropertyName = "uSTT";
            this.uSTTDataGridViewTextBoxColumn.HeaderText = "uSTT";
            this.uSTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSTTDataGridViewTextBoxColumn.Name = "uSTTDataGridViewTextBoxColumn";
            this.uSTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // işlemlerYönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 402);
            this.Controls.Add(this.panel1);
            this.Name = "işlemlerYönetici";
            this.Text = "Yönetici Arama";
            this.Load += new System.EventHandler(this.işlemlerYönetici_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.denemeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblurunlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource denemeDataSetBindingSource;
        private denemeDataSet denemeDataSet;
        private denemeDataSet1 denemeDataSet1;
        private System.Windows.Forms.BindingSource tblurunlerBindingSource;
        private denemeDataSet1TableAdapters.tbl_urunlerTableAdapter tbl_urunlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uStokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uKatogoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSTTDataGridViewTextBoxColumn;
    }
}