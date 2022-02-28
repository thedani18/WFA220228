namespace WFA220228
{
    partial class FrmVizsgazo
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTelf = new System.Windows.Forms.TextBox();
            this.tbSzul = new System.Windows.Forms.TextBox();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnModositas = new System.Windows.Forms.Button();
            this.btnUj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(151, 66);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(187, 30);
            this.tbID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefonszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Szuletési év:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(151, 125);
            this.tbNev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(187, 30);
            this.tbNev.TabIndex = 5;
            // 
            // tbTelf
            // 
            this.tbTelf.Location = new System.Drawing.Point(151, 175);
            this.tbTelf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTelf.Name = "tbTelf";
            this.tbTelf.Size = new System.Drawing.Size(187, 30);
            this.tbTelf.TabIndex = 6;
            // 
            // tbSzul
            // 
            this.tbSzul.Location = new System.Drawing.Point(151, 229);
            this.tbSzul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSzul.Name = "tbSzul";
            this.tbSzul.Size = new System.Drawing.Size(187, 30);
            this.tbSzul.TabIndex = 7;
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(359, 29);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 75);
            this.btnTorles.TabIndex = 8;
            this.btnTorles.Text = "T";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnModositas
            // 
            this.btnModositas.Location = new System.Drawing.Point(359, 120);
            this.btnModositas.Name = "btnModositas";
            this.btnModositas.Size = new System.Drawing.Size(75, 75);
            this.btnModositas.TabIndex = 9;
            this.btnModositas.Text = "M";
            this.btnModositas.UseVisualStyleBackColor = true;
            this.btnModositas.Click += new System.EventHandler(this.btnModositas_Click);
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(359, 205);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(75, 75);
            this.btnUj.TabIndex = 10;
            this.btnUj.Text = "Új";
            this.btnUj.UseVisualStyleBackColor = true;
            this.btnUj.Click += new System.EventHandler(this.btnUj_Click);
            // 
            // FrmVizsgazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 312);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.btnModositas);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.tbSzul);
            this.Controls.Add(this.tbTelf);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmVizsgazo";
            this.Text = "FrmVizsgazo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTelf;
        private System.Windows.Forms.TextBox tbSzul;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnModositas;
        private System.Windows.Forms.Button btnUj;
    }
}