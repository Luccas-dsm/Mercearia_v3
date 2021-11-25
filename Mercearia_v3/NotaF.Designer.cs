namespace Mercearia_v3
{
    partial class NotaF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaF));
            this.tbnomearq = new System.Windows.Forms.TextBox();
            this.lbnotas = new System.Windows.Forms.ListBox();
            this.bconfirma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvlista = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Un = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.bsair = new System.Windows.Forms.Button();
            this.lbcliente = new System.Windows.Forms.Label();
            this.lbend = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbnomearq
            // 
            this.tbnomearq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnomearq.Location = new System.Drawing.Point(12, 27);
            this.tbnomearq.Name = "tbnomearq";
            this.tbnomearq.Size = new System.Drawing.Size(330, 29);
            this.tbnomearq.TabIndex = 2;
            this.tbnomearq.Click += new System.EventHandler(this.tbnomearq_Click);
            // 
            // lbnotas
            // 
            this.lbnotas.FormattingEnabled = true;
            this.lbnotas.Location = new System.Drawing.Point(12, 62);
            this.lbnotas.Name = "lbnotas";
            this.lbnotas.Size = new System.Drawing.Size(330, 121);
            this.lbnotas.TabIndex = 3;
            this.lbnotas.Click += new System.EventHandler(this.lbnotas_Click);
            // 
            // bconfirma
            // 
            this.bconfirma.BackColor = System.Drawing.Color.Transparent;
            this.bconfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconfirma.BackgroundImage")));
            this.bconfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconfirma.FlatAppearance.BorderSize = 0;
            this.bconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bconfirma.Location = new System.Drawing.Point(3, 203);
            this.bconfirma.Name = "bconfirma";
            this.bconfirma.Size = new System.Drawing.Size(162, 37);
            this.bconfirma.TabIndex = 4;
            this.bconfirma.UseVisualStyleBackColor = false;
            this.bconfirma.Click += new System.EventHandler(this.bconfirma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cupom Fiscal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label3.Location = new System.Drawing.Point(392, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label1.Location = new System.Drawing.Point(392, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "End:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label4.Location = new System.Drawing.Point(392, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // lvlista
            // 
            this.lvlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(156)))));
            this.lvlista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvlista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Produto,
            this.Un,
            this.Valor});
            this.lvlista.HideSelection = false;
            this.lvlista.Location = new System.Drawing.Point(396, 116);
            this.lvlista.Name = "lvlista";
            this.lvlista.Size = new System.Drawing.Size(245, 185);
            this.lvlista.TabIndex = 10;
            this.lvlista.UseCompatibleStateImageBehavior = false;
            this.lvlista.View = System.Windows.Forms.View.Details;
            // 
            // Produto
            // 
            this.Produto.Text = "Produto";
            this.Produto.Width = 123;
            // 
            // Un
            // 
            this.Un.Text = "Un";
            this.Un.Width = 49;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label5.Location = new System.Drawing.Point(517, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total R$:";
            // 
            // bsair
            // 
            this.bsair.BackColor = System.Drawing.Color.Transparent;
            this.bsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsair.BackgroundImage")));
            this.bsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsair.FlatAppearance.BorderSize = 0;
            this.bsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsair.Location = new System.Drawing.Point(186, 203);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(162, 37);
            this.bsair.TabIndex = 12;
            this.bsair.UseVisualStyleBackColor = false;
            this.bsair.Click += new System.EventHandler(this.bsair_Click);
            // 
            // lbcliente
            // 
            this.lbcliente.AutoSize = true;
            this.lbcliente.BackColor = System.Drawing.Color.Transparent;
            this.lbcliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbcliente.Location = new System.Drawing.Point(445, 62);
            this.lbcliente.Name = "lbcliente";
            this.lbcliente.Size = new System.Drawing.Size(59, 21);
            this.lbcliente.TabIndex = 13;
            this.lbcliente.Text = "Cliente:";
            // 
            // lbend
            // 
            this.lbend.AutoSize = true;
            this.lbend.BackColor = System.Drawing.Color.Transparent;
            this.lbend.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbend.Location = new System.Drawing.Point(425, 92);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(59, 21);
            this.lbend.TabIndex = 14;
            this.lbend.Text = "Cliente:";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.BackColor = System.Drawing.Color.Transparent;
            this.lbdata.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbdata.Location = new System.Drawing.Point(432, 305);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(87, 21);
            this.lbdata.TabIndex = 15;
            this.lbdata.Text = "25/05/2020";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbtotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbtotal.Location = new System.Drawing.Point(581, 304);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(47, 21);
            this.lbtotal.TabIndex = 16;
            this.lbtotal.Text = "XX,XX";
            // 
            // NotaF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lbend);
            this.Controls.Add(this.lbcliente);
            this.Controls.Add(this.bsair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bconfirma);
            this.Controls.Add(this.lbnotas);
            this.Controls.Add(this.tbnomearq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotaF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotaF";
            this.Load += new System.EventHandler(this.NotaF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnomearq;
        private System.Windows.Forms.ListBox lbnotas;
        private System.Windows.Forms.Button bconfirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvlista;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Un;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bsair;
        private System.Windows.Forms.Label lbcliente;
        private System.Windows.Forms.Label lbend;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label lbtotal;
    }
}