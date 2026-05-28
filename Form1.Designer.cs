namespace KonyvtarApp
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
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCim = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSzerzo = new System.Windows.Forms.TextBox();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.dgvKonyvek = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox0
            // 
            this.textBox0.BackColor = System.Drawing.SystemColors.Window;
            this.textBox0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox0.Location = new System.Drawing.Point(12, 12);
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(90, 20);
            this.textBox0.TabIndex = 0;
            this.textBox0.Text = "Könyvnyilvántartó";
            this.textBox0.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Könyv Címe:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtCim
            // 
            this.txtCim.Location = new System.Drawing.Point(118, 50);
            this.txtCim.Name = "txtCim";
            this.txtCim.Size = new System.Drawing.Size(100, 20);
            this.txtCim.TabIndex = 2;
            this.txtCim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Szerző:";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // txtSzerzo
            // 
            this.txtSzerzo.Location = new System.Drawing.Point(118, 76);
            this.txtSzerzo.Name = "txtSzerzo";
            this.txtSzerzo.Size = new System.Drawing.Size(100, 20);
            this.txtSzerzo.TabIndex = 4;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(78, 115);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 5;
            this.btnHozzaad.Text = "Hozzáadás gomb";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvKonyvek
            // 
            this.dgvKonyvek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKonyvek.Location = new System.Drawing.Point(12, 155);
            this.dgvKonyvek.Name = "dgvKonyvek";
            this.dgvKonyvek.Size = new System.Drawing.Size(776, 283);
            this.dgvKonyvek.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKonyvek);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.txtSzerzo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCim);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKonyvek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSzerzo;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.DataGridView dgvKonyvek;
    }
}

