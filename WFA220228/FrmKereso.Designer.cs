namespace WFA220228
{
    partial class FrmKereso
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
            this.cb = new System.Windows.Forms.ComboBox();
            this.dgvKereso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKereso)).BeginInit();
            this.SuspendLayout();
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(18, 19);
            this.cb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(1004, 33);
            this.cb.TabIndex = 0;
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // dgvKereso
            // 
            this.dgvKereso.AllowUserToAddRows = false;
            this.dgvKereso.AllowUserToDeleteRows = false;
            this.dgvKereso.AllowUserToResizeColumns = false;
            this.dgvKereso.AllowUserToResizeRows = false;
            this.dgvKereso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKereso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKereso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKereso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvKereso.Location = new System.Drawing.Point(18, 62);
            this.dgvKereso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKereso.Name = "dgvKereso";
            this.dgvKereso.ReadOnly = true;
            this.dgvKereso.RowHeadersVisible = false;
            this.dgvKereso.RowHeadersWidth = 51;
            this.dgvKereso.RowTemplate.Height = 24;
            this.dgvKereso.Size = new System.Drawing.Size(1004, 428);
            this.dgvKereso.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Időpont";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nyelv szint";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // FrmKereso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 504);
            this.Controls.Add(this.dgvKereso);
            this.Controls.Add(this.cb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKereso";
            this.Text = "FrmKereso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKereso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.DataGridView dgvKereso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}