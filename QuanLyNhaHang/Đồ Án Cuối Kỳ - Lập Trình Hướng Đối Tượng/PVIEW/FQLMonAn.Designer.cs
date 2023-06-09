namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    partial class FQLMonAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgMonAn = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnClearMA = new System.Windows.Forms.Button();
            this.btnThemMA = new System.Windows.Forms.Button();
            this.btnSuaMA = new System.Windows.Forms.Button();
            this.btnXoaMA = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.cmbDMMon = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel30 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMonAn = new System.Windows.Forms.TextBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtbTimMA = new System.Windows.Forms.TextBox();
            this.btnTimMA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonAn)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgMonAn);
            this.panel1.Location = new System.Drawing.Point(8, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 467);
            this.panel1.TabIndex = 0;
            // 
            // dtgMonAn
            // 
            this.dtgMonAn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMonAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column21});
            this.dtgMonAn.Location = new System.Drawing.Point(17, 20);
            this.dtgMonAn.Name = "dtgMonAn";
            this.dtgMonAn.RowHeadersWidth = 51;
            this.dtgMonAn.RowTemplate.Height = 24;
            this.dtgMonAn.Size = new System.Drawing.Size(601, 444);
            this.dtgMonAn.TabIndex = 37;
            this.dtgMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMonAn_CellClick);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "id";
            this.Column10.HeaderText = "Mã món ăn";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 55;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "ten";
            this.Column11.FillWeight = 22.5F;
            this.Column11.HeaderText = "Tên món ăn";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "gia";
            this.Column12.FillWeight = 255F;
            this.Column12.HeaderText = "Giá món ăn";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 70;
            // 
            // Column21
            // 
            this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column21.DataPropertyName = "TenDanhMuc";
            this.Column21.FillWeight = 22.5F;
            this.Column21.HeaderText = "Tên danh mục";
            this.Column21.MinimumWidth = 6;
            this.Column21.Name = "Column21";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnClearMA);
            this.panel27.Controls.Add(this.btnThemMA);
            this.panel27.Controls.Add(this.btnSuaMA);
            this.panel27.Controls.Add(this.btnXoaMA);
            this.panel27.Location = new System.Drawing.Point(742, 124);
            this.panel27.Margin = new System.Windows.Forms.Padding(4);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(437, 50);
            this.panel27.TabIndex = 38;
            // 
            // btnClearMA
            // 
            this.btnClearMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnClearMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClearMA.ForeColor = System.Drawing.Color.White;
            this.btnClearMA.Location = new System.Drawing.Point(325, 5);
            this.btnClearMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearMA.Name = "btnClearMA";
            this.btnClearMA.Size = new System.Drawing.Size(105, 43);
            this.btnClearMA.TabIndex = 2;
            this.btnClearMA.Text = "Làm mới";
            this.btnClearMA.UseVisualStyleBackColor = false;
            this.btnClearMA.Click += new System.EventHandler(this.btnClearMA_Click);
            // 
            // btnThemMA
            // 
            this.btnThemMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnThemMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemMA.ForeColor = System.Drawing.Color.White;
            this.btnThemMA.Location = new System.Drawing.Point(4, 5);
            this.btnThemMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Size = new System.Drawing.Size(105, 43);
            this.btnThemMA.TabIndex = 0;
            this.btnThemMA.Text = "Thêm";
            this.btnThemMA.UseVisualStyleBackColor = false;
            this.btnThemMA.Click += new System.EventHandler(this.btnThemMA_Click);
            // 
            // btnSuaMA
            // 
            this.btnSuaMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnSuaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaMA.ForeColor = System.Drawing.Color.White;
            this.btnSuaMA.Location = new System.Drawing.Point(111, 5);
            this.btnSuaMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaMA.Name = "btnSuaMA";
            this.btnSuaMA.Size = new System.Drawing.Size(105, 43);
            this.btnSuaMA.TabIndex = 0;
            this.btnSuaMA.Text = "Sửa";
            this.btnSuaMA.UseVisualStyleBackColor = false;
            this.btnSuaMA.Click += new System.EventHandler(this.btnSuaMA_Click);
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnXoaMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaMA.ForeColor = System.Drawing.Color.White;
            this.btnXoaMA.Location = new System.Drawing.Point(218, 5);
            this.btnXoaMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Size = new System.Drawing.Size(105, 43);
            this.btnXoaMA.TabIndex = 0;
            this.btnXoaMA.Text = "Xóa";
            this.btnXoaMA.UseVisualStyleBackColor = false;
            this.btnXoaMA.Click += new System.EventHandler(this.btnXoaMA_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel31);
            this.panel2.Controls.Add(this.panel30);
            this.panel2.Controls.Add(this.panel29);
            this.panel2.Controls.Add(this.panel28);
            this.panel2.Location = new System.Drawing.Point(647, 209);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 406);
            this.panel2.TabIndex = 1;
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.cmbDMMon);
            this.panel31.Controls.Add(this.label14);
            this.panel31.Location = new System.Drawing.Point(4, 150);
            this.panel31.Margin = new System.Windows.Forms.Padding(4);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(574, 46);
            this.panel31.TabIndex = 39;
            // 
            // cmbDMMon
            // 
            this.cmbDMMon.FormattingEnabled = true;
            this.cmbDMMon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDMMon.Location = new System.Drawing.Point(220, 14);
            this.cmbDMMon.Name = "cmbDMMon";
            this.cmbDMMon.Size = new System.Drawing.Size(328, 24);
            this.cmbDMMon.TabIndex = 1;
            this.cmbDMMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDMMon_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.Location = new System.Drawing.Point(5, 14);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Danh mục món ăn: ";
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.label13);
            this.panel30.Controls.Add(this.txtGia);
            this.panel30.Location = new System.Drawing.Point(4, 204);
            this.panel30.Margin = new System.Windows.Forms.Padding(4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(574, 46);
            this.panel30.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(5, 12);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Giá tiền:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(220, 14);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(328, 22);
            this.txtGia.TabIndex = 21;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.label15);
            this.panel29.Controls.Add(this.txtMonAn);
            this.panel29.Location = new System.Drawing.Point(4, 78);
            this.panel29.Margin = new System.Windows.Forms.Padding(4);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(574, 64);
            this.panel29.TabIndex = 43;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(4, 22);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tên món ăn: ";
            // 
            // txtMonAn
            // 
            this.txtMonAn.Location = new System.Drawing.Point(220, 24);
            this.txtMonAn.Multiline = true;
            this.txtMonAn.Name = "txtMonAn";
            this.txtMonAn.Size = new System.Drawing.Size(328, 24);
            this.txtMonAn.TabIndex = 19;
            this.txtMonAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonAn_KeyPress);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.label18);
            this.panel28.Controls.Add(this.txtID);
            this.panel28.Location = new System.Drawing.Point(4, 24);
            this.panel28.Margin = new System.Windows.Forms.Padding(4);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(574, 46);
            this.panel28.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(5, 14);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(220, 8);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(328, 22);
            this.txtID.TabIndex = 18;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txtbTimMA);
            this.panel26.Controls.Add(this.btnTimMA);
            this.panel26.Location = new System.Drawing.Point(40, 107);
            this.panel26.Margin = new System.Windows.Forms.Padding(4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(586, 50);
            this.panel26.TabIndex = 41;
            // 
            // txtbTimMA
            // 
            this.txtbTimMA.Location = new System.Drawing.Point(26, 13);
            this.txtbTimMA.Margin = new System.Windows.Forms.Padding(4);
            this.txtbTimMA.Name = "txtbTimMA";
            this.txtbTimMA.Size = new System.Drawing.Size(328, 22);
            this.txtbTimMA.TabIndex = 1;
            this.txtbTimMA.TextChanged += new System.EventHandler(this.txtbTimMA_TextChanged);
            this.txtbTimMA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbTimMA_KeyPress);
            // 
            // btnTimMA
            // 
            this.btnTimMA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnTimMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimMA.ForeColor = System.Drawing.Color.White;
            this.btnTimMA.Location = new System.Drawing.Point(415, 2);
            this.btnTimMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimMA.Name = "btnTimMA";
            this.btnTimMA.Size = new System.Drawing.Size(105, 43);
            this.btnTimMA.TabIndex = 0;
            this.btnTimMA.Text = "Tìm";
            this.btnTimMA.UseVisualStyleBackColor = false;
            this.btnTimMA.Click += new System.EventHandler(this.btnTimMA_Click);
            // 
            // FQLMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 677);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel26);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FQLMonAn";
            this.Text = "MÓN ĂN";
            this.Load += new System.EventHandler(this.FQLMonAn_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMonAn)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel31.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnClearMA;
        private System.Windows.Forms.Button btnXoaMA;
        private System.Windows.Forms.Button btnSuaMA;
        private System.Windows.Forms.Button btnThemMA;
        private System.Windows.Forms.DataGridView dtgMonAn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txtbTimMA;
        private System.Windows.Forms.Button btnTimMA;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.ComboBox cmbDMMon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMonAn;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
    }
}