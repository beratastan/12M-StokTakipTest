namespace StokTakip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnTumliste = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnAraMalKodu = new System.Windows.Forms.Button();
            this.dtTarih1 = new System.Windows.Forms.DateTimePicker();
            this.dtTarih2 = new System.Windows.Forms.DateTimePicker();
            this.btnTarih = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvList.Location = new System.Drawing.Point(12, 85);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.Size = new System.Drawing.Size(780, 496);
            this.dgvList.TabIndex = 0;
            // 
            // btnTumliste
            // 
            this.btnTumliste.Location = new System.Drawing.Point(12, 41);
            this.btnTumliste.Name = "btnTumliste";
            this.btnTumliste.Size = new System.Drawing.Size(324, 38);
            this.btnTumliste.TabIndex = 1;
            this.btnTumliste.Text = "Tüm Liste";
            this.btnTumliste.UseVisualStyleBackColor = true;
            this.btnTumliste.Click += new System.EventHandler(this.btnTumliste_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(80, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(175, 20);
            this.txtCode.TabIndex = 2;
            // 
            // btnAraMalKodu
            // 
            this.btnAraMalKodu.Location = new System.Drawing.Point(261, 12);
            this.btnAraMalKodu.Name = "btnAraMalKodu";
            this.btnAraMalKodu.Size = new System.Drawing.Size(75, 20);
            this.btnAraMalKodu.TabIndex = 3;
            this.btnAraMalKodu.Text = "Ara";
            this.btnAraMalKodu.UseVisualStyleBackColor = true;
            this.btnAraMalKodu.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dtTarih1
            // 
            this.dtTarih1.Location = new System.Drawing.Point(388, 12);
            this.dtTarih1.Name = "dtTarih1";
            this.dtTarih1.Size = new System.Drawing.Size(175, 20);
            this.dtTarih1.TabIndex = 4;
            // 
            // dtTarih2
            // 
            this.dtTarih2.Location = new System.Drawing.Point(615, 11);
            this.dtTarih2.Name = "dtTarih2";
            this.dtTarih2.Size = new System.Drawing.Size(175, 20);
            this.dtTarih2.TabIndex = 5;
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(345, 41);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(445, 38);
            this.btnTarih.TabIndex = 6;
            this.btnTarih.Text = "Tarihe Göre Filtrele";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(569, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarih2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model Kodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tarih1:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(12, 587);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(778, 38);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Dışa Aktar";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 630);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.dtTarih2);
            this.Controls.Add(this.dtTarih1);
            this.Controls.Add(this.btnAraMalKodu);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnTumliste);
            this.Controls.Add(this.dgvList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnTumliste;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAraMalKodu;
        private System.Windows.Forms.DateTimePicker dtTarih1;
        private System.Windows.Forms.DateTimePicker dtTarih2;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportExcel;
    }
}

