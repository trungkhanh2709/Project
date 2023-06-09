
namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng.PVIEW
{
    partial class FQLDanhMucMA
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
            this.txtTimDMMon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvDMMon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDDanhMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.btnThemDMMon = new System.Windows.Forms.Button();
            this.btnSuaDMMon = new System.Windows.Forms.Button();
            this.btnXoaDMMon = new System.Windows.Forms.Button();
            this.btnClearDMMon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMMon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimDMMon
            // 
            this.txtTimDMMon.Location = new System.Drawing.Point(19, 22);
            this.txtTimDMMon.Name = "txtTimDMMon";
            this.txtTimDMMon.Size = new System.Drawing.Size(328, 22);
            this.txtTimDMMon.TabIndex = 0;
            this.txtTimDMMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimDMMon_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(396, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgvDMMon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDMMon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDMMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDMMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgvDMMon.Location = new System.Drawing.Point(99, 245);
            this.dtgvDMMon.Name = "dtgvDMMon";
            this.dtgvDMMon.RowHeadersWidth = 51;
            this.dtgvDMMon.RowTemplate.Height = 24;
            this.dtgvDMMon.Size = new System.Drawing.Size(496, 392);
            this.dtgvDMMon.TabIndex = 2;
            this.dtgvDMMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDMMon_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTimDMMon);
            this.panel1.Location = new System.Drawing.Point(99, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 67);
            this.panel1.TabIndex = 3;
            // 
            // txtIDDanhMuc
            // 
            this.txtIDDanhMuc.Enabled = false;
            this.txtIDDanhMuc.Location = new System.Drawing.Point(186, 19);
            this.txtIDDanhMuc.Name = "txtIDDanhMuc";
            this.txtIDDanhMuc.Size = new System.Drawing.Size(328, 22);
            this.txtIDDanhMuc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên danh mục: ";
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(186, 80);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(328, 22);
            this.txtTenDanhMuc.TabIndex = 0;
            this.txtTenDanhMuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDanhMuc_KeyPress);
            // 
            // btnThemDMMon
            // 
            this.btnThemDMMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnThemDMMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemDMMon.ForeColor = System.Drawing.Color.White;
            this.btnThemDMMon.Location = new System.Drawing.Point(12, 12);
            this.btnThemDMMon.Name = "btnThemDMMon";
            this.btnThemDMMon.Size = new System.Drawing.Size(100, 43);
            this.btnThemDMMon.TabIndex = 1;
            this.btnThemDMMon.Text = "Thêm";
            this.btnThemDMMon.UseVisualStyleBackColor = false;
            this.btnThemDMMon.Click += new System.EventHandler(this.btnThemDMMon_Click);
            // 
            // btnSuaDMMon
            // 
            this.btnSuaDMMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnSuaDMMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaDMMon.ForeColor = System.Drawing.Color.White;
            this.btnSuaDMMon.Location = new System.Drawing.Point(118, 12);
            this.btnSuaDMMon.Name = "btnSuaDMMon";
            this.btnSuaDMMon.Size = new System.Drawing.Size(100, 43);
            this.btnSuaDMMon.TabIndex = 1;
            this.btnSuaDMMon.Text = "Sửa";
            this.btnSuaDMMon.UseVisualStyleBackColor = false;
            this.btnSuaDMMon.Click += new System.EventHandler(this.btnSuaDMMon_Click);
            // 
            // btnXoaDMMon
            // 
            this.btnXoaDMMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnXoaDMMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaDMMon.ForeColor = System.Drawing.Color.White;
            this.btnXoaDMMon.Location = new System.Drawing.Point(224, 12);
            this.btnXoaDMMon.Name = "btnXoaDMMon";
            this.btnXoaDMMon.Size = new System.Drawing.Size(100, 43);
            this.btnXoaDMMon.TabIndex = 1;
            this.btnXoaDMMon.Text = "Xóa";
            this.btnXoaDMMon.UseVisualStyleBackColor = false;
            this.btnXoaDMMon.Click += new System.EventHandler(this.btnXoaDMMon_Click);
            // 
            // btnClearDMMon
            // 
            this.btnClearDMMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnClearDMMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClearDMMon.ForeColor = System.Drawing.Color.White;
            this.btnClearDMMon.Location = new System.Drawing.Point(330, 12);
            this.btnClearDMMon.Name = "btnClearDMMon";
            this.btnClearDMMon.Size = new System.Drawing.Size(100, 43);
            this.btnClearDMMon.TabIndex = 1;
            this.btnClearDMMon.Text = "Làm mới";
            this.btnClearDMMon.UseVisualStyleBackColor = false;
            this.btnClearDMMon.Click += new System.EventHandler(this.btnClearDMMon_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearDMMon);
            this.panel2.Controls.Add(this.btnXoaDMMon);
            this.panel2.Controls.Add(this.btnSuaDMMon);
            this.panel2.Controls.Add(this.btnThemDMMon);
            this.panel2.Location = new System.Drawing.Point(714, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenDanhMuc);
            this.panel3.Controls.Add(this.txtIDDanhMuc);
            this.panel3.Location = new System.Drawing.Point(664, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 121);
            this.panel3.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Mã danh mục";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 127;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "ten";
            this.Column2.HeaderText = "Tên danh mục";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // FQLDanhMucMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 686);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvDMMon);
            this.Name = "FQLDanhMucMA";
            this.Text = "DANH MỤC MÓN ĂN";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMMon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimDMMon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgvDMMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDDanhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.Button btnThemDMMon;
        private System.Windows.Forms.Button btnSuaDMMon;
        private System.Windows.Forms.Button btnXoaDMMon;
        private System.Windows.Forms.Button btnClearDMMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}