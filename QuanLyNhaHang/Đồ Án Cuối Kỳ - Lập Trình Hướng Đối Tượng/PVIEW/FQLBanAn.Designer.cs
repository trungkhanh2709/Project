namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    partial class FQLBanAn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dtgvBanAn = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel44 = new System.Windows.Forms.Panel();
            this.txtbTimBanAn = new System.Windows.Forms.TextBox();
            this.btnTimBanAn = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnLamMoiBanAn = new System.Windows.Forms.Button();
            this.btnXoaBanAn = new System.Windows.Forms.Button();
            this.btnSuaBanAn = new System.Windows.Forms.Button();
            this.btnThemBanAn = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioTrong = new System.Windows.Forms.RadioButton();
            this.radioCoNguoi = new System.Windows.Forms.RadioButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtbIDBanAn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txtbTenBanAn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).BeginInit();
            this.panel44.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.dtgvBanAn);
            this.panel23.Controls.Add(this.panel44);
            this.panel23.Location = new System.Drawing.Point(3, 2);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(681, 806);
            this.panel23.TabIndex = 15;
            // 
            // dtgvBanAn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvBanAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.dtgvBanAn.Location = new System.Drawing.Point(107, 246);
            this.dtgvBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvBanAn.Name = "dtgvBanAn";
            this.dtgvBanAn.RowHeadersWidth = 62;
            this.dtgvBanAn.Size = new System.Drawing.Size(534, 538);
            this.dtgvBanAn.TabIndex = 5;
            this.dtgvBanAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBanAn_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "id";
            this.Column7.HeaderText = "Mã bàn ăn";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "Ten";
            this.Column8.HeaderText = "Tên bàn";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "TinhTrang";
            this.Column9.HeaderText = "Tình trạng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.txtbTimBanAn);
            this.panel44.Controls.Add(this.btnTimBanAn);
            this.panel44.Location = new System.Drawing.Point(96, 141);
            this.panel44.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(580, 62);
            this.panel44.TabIndex = 17;
            // 
            // txtbTimBanAn
            // 
            this.txtbTimBanAn.Location = new System.Drawing.Point(6, 18);
            this.txtbTimBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbTimBanAn.Name = "txtbTimBanAn";
            this.txtbTimBanAn.Size = new System.Drawing.Size(368, 26);
            this.txtbTimBanAn.TabIndex = 1;
            // 
            // btnTimBanAn
            // 
            this.btnTimBanAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnTimBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimBanAn.ForeColor = System.Drawing.Color.White;
            this.btnTimBanAn.Location = new System.Drawing.Point(428, 6);
            this.btnTimBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimBanAn.Name = "btnTimBanAn";
            this.btnTimBanAn.Size = new System.Drawing.Size(118, 54);
            this.btnTimBanAn.TabIndex = 0;
            this.btnTimBanAn.Text = "Tìm";
            this.btnTimBanAn.UseVisualStyleBackColor = false;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.btnLamMoiBanAn);
            this.panel24.Controls.Add(this.btnXoaBanAn);
            this.panel24.Controls.Add(this.btnSuaBanAn);
            this.panel24.Controls.Add(this.btnThemBanAn);
            this.panel24.Location = new System.Drawing.Point(754, 144);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(519, 62);
            this.panel24.TabIndex = 4;
            // 
            // btnLamMoiBanAn
            // 
            this.btnLamMoiBanAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnLamMoiBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiBanAn.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiBanAn.Location = new System.Drawing.Point(384, 5);
            this.btnLamMoiBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoiBanAn.Name = "btnLamMoiBanAn";
            this.btnLamMoiBanAn.Size = new System.Drawing.Size(112, 54);
            this.btnLamMoiBanAn.TabIndex = 2;
            this.btnLamMoiBanAn.Text = "Làm mới";
            this.btnLamMoiBanAn.UseVisualStyleBackColor = false;
            this.btnLamMoiBanAn.Click += new System.EventHandler(this.btnLamMoiBanAn_Click);
            // 
            // btnXoaBanAn
            // 
            this.btnXoaBanAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnXoaBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBanAn.ForeColor = System.Drawing.Color.White;
            this.btnXoaBanAn.Location = new System.Drawing.Point(263, 5);
            this.btnXoaBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaBanAn.Name = "btnXoaBanAn";
            this.btnXoaBanAn.Size = new System.Drawing.Size(112, 54);
            this.btnXoaBanAn.TabIndex = 0;
            this.btnXoaBanAn.Text = "Xóa";
            this.btnXoaBanAn.UseVisualStyleBackColor = false;
            this.btnXoaBanAn.Click += new System.EventHandler(this.btnXoaBanAn_Click);
            // 
            // btnSuaBanAn
            // 
            this.btnSuaBanAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnSuaBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaBanAn.ForeColor = System.Drawing.Color.White;
            this.btnSuaBanAn.Location = new System.Drawing.Point(143, 5);
            this.btnSuaBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaBanAn.Name = "btnSuaBanAn";
            this.btnSuaBanAn.Size = new System.Drawing.Size(112, 54);
            this.btnSuaBanAn.TabIndex = 0;
            this.btnSuaBanAn.Text = "Sửa";
            this.btnSuaBanAn.UseVisualStyleBackColor = false;
            this.btnSuaBanAn.Click += new System.EventHandler(this.btnSuaBanAn_Click);
            // 
            // btnThemBanAn
            // 
            this.btnThemBanAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(96)))), ((int)(((byte)(120)))));
            this.btnThemBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBanAn.ForeColor = System.Drawing.Color.White;
            this.btnThemBanAn.Location = new System.Drawing.Point(22, 4);
            this.btnThemBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemBanAn.Name = "btnThemBanAn";
            this.btnThemBanAn.Size = new System.Drawing.Size(112, 54);
            this.btnThemBanAn.TabIndex = 0;
            this.btnThemBanAn.Text = "Thêm";
            this.btnThemBanAn.UseVisualStyleBackColor = false;
            this.btnThemBanAn.Click += new System.EventHandler(this.btnThemBanAn_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Location = new System.Drawing.Point(691, 270);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(718, 362);
            this.panel16.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.groupBox3);
            this.panel18.Controls.Add(this.panel21);
            this.panel18.Controls.Add(this.panel22);
            this.panel18.Location = new System.Drawing.Point(39, 55);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(656, 242);
            this.panel18.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioTrong);
            this.groupBox3.Controls.Add(this.radioCoNguoi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(14, 139);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(576, 89);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tình trạng";
            // 
            // radioTrong
            // 
            this.radioTrong.AutoSize = true;
            this.radioTrong.Enabled = false;
            this.radioTrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioTrong.Location = new System.Drawing.Point(400, 35);
            this.radioTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioTrong.Name = "radioTrong";
            this.radioTrong.Size = new System.Drawing.Size(98, 29);
            this.radioTrong.TabIndex = 1;
            this.radioTrong.TabStop = true;
            this.radioTrong.Text = "Trống";
            this.radioTrong.UseVisualStyleBackColor = true;
            // 
            // radioCoNguoi
            // 
            this.radioCoNguoi.AutoSize = true;
            this.radioCoNguoi.Enabled = false;
            this.radioCoNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioCoNguoi.Location = new System.Drawing.Point(201, 35);
            this.radioCoNguoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCoNguoi.Name = "radioCoNguoi";
            this.radioCoNguoi.Size = new System.Drawing.Size(131, 29);
            this.radioCoNguoi.TabIndex = 0;
            this.radioCoNguoi.TabStop = true;
            this.radioCoNguoi.Text = "Có người";
            this.radioCoNguoi.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txtbIDBanAn);
            this.panel21.Controls.Add(this.label10);
            this.panel21.Location = new System.Drawing.Point(14, 5);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(565, 58);
            this.panel21.TabIndex = 0;
            // 
            // txtbIDBanAn
            // 
            this.txtbIDBanAn.Location = new System.Drawing.Point(172, 20);
            this.txtbIDBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbIDBanAn.Name = "txtbIDBanAn";
            this.txtbIDBanAn.ReadOnly = true;
            this.txtbIDBanAn.Size = new System.Drawing.Size(368, 26);
            this.txtbIDBanAn.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txtbTenBanAn);
            this.panel22.Controls.Add(this.label11);
            this.panel22.Location = new System.Drawing.Point(14, 72);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(565, 58);
            this.panel22.TabIndex = 0;
            // 
            // txtbTenBanAn
            // 
            this.txtbTenBanAn.Location = new System.Drawing.Point(172, 18);
            this.txtbTenBanAn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbTenBanAn.Name = "txtbTenBanAn";
            this.txtbTenBanAn.Size = new System.Drawing.Size(368, 26);
            this.txtbTenBanAn.TabIndex = 1;
            this.txtbTenBanAn.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên bàn:";
            // 
            // FQLBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 846);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel23);
            this.Controls.Add(this.panel24);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FQLBanAn";
            this.Text = "BÀN ĂN";
            this.Load += new System.EventHandler(this.FQLBanAn_Load);
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).EndInit();
            this.panel44.ResumeLayout(false);
            this.panel44.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.DataGridView dtgvBanAn;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnLamMoiBanAn;
        private System.Windows.Forms.Button btnXoaBanAn;
        private System.Windows.Forms.Button btnSuaBanAn;
        private System.Windows.Forms.Button btnThemBanAn;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioTrong;
        private System.Windows.Forms.RadioButton radioCoNguoi;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtbIDBanAn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txtbTenBanAn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.TextBox txtbTimBanAn;
        private System.Windows.Forms.Button btnTimBanAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}