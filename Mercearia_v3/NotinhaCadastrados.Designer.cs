namespace Mercearia_v3
{
    partial class NotinhaCadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotinhaCadastrados));
            this.lbcli = new System.Windows.Forms.ListBox();
            this.bconfirma = new System.Windows.Forms.Button();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbdata = new System.Windows.Forms.Label();
            this.lbend = new System.Windows.Forms.Label();
            this.lbcliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvlista = new System.Windows.Forms.ListView();
            this.Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Un = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbcli
            // 
            this.lbcli.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbcli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbcli.FormattingEnabled = true;
            this.lbcli.Location = new System.Drawing.Point(14, 17);
            this.lbcli.Name = "lbcli";
            this.lbcli.Size = new System.Drawing.Size(289, 39);
            this.lbcli.TabIndex = 0;
            this.lbcli.Click += new System.EventHandler(this.lbcli_Click);
            // 
            // bconfirma
            // 
            this.bconfirma.BackColor = System.Drawing.Color.Transparent;
            this.bconfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconfirma.BackgroundImage")));
            this.bconfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconfirma.FlatAppearance.BorderSize = 0;
            this.bconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bconfirma.Location = new System.Drawing.Point(17, 381);
            this.bconfirma.Name = "bconfirma";
            this.bconfirma.Size = new System.Drawing.Size(284, 31);
            this.bconfirma.TabIndex = 1;
            this.bconfirma.UseVisualStyleBackColor = false;
            this.bconfirma.Click += new System.EventHandler(this.bconfirma_Click);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbtotal.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbtotal.Location = new System.Drawing.Point(221, 326);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(47, 21);
            this.lbtotal.TabIndex = 36;
            this.lbtotal.Text = "XX,XX";
            // 
            // lbdata
            // 
            this.lbdata.AutoSize = true;
            this.lbdata.BackColor = System.Drawing.Color.Transparent;
            this.lbdata.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbdata.Location = new System.Drawing.Point(72, 327);
            this.lbdata.Name = "lbdata";
            this.lbdata.Size = new System.Drawing.Size(18, 21);
            this.lbdata.TabIndex = 35;
            this.lbdata.Text = "2";
            // 
            // lbend
            // 
            this.lbend.AutoSize = true;
            this.lbend.BackColor = System.Drawing.Color.Transparent;
            this.lbend.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbend.Location = new System.Drawing.Point(65, 140);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(59, 21);
            this.lbend.TabIndex = 34;
            this.lbend.Text = "Cliente:";
            // 
            // lbcliente
            // 
            this.lbcliente.AutoSize = true;
            this.lbcliente.BackColor = System.Drawing.Color.Transparent;
            this.lbcliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.lbcliente.Location = new System.Drawing.Point(85, 110);
            this.lbcliente.Name = "lbcliente";
            this.lbcliente.Size = new System.Drawing.Size(59, 21);
            this.lbcliente.TabIndex = 33;
            this.lbcliente.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label5.Location = new System.Drawing.Point(157, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total R$:";
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
            this.lvlista.Location = new System.Drawing.Point(36, 164);
            this.lvlista.Name = "lvlista";
            this.lvlista.Size = new System.Drawing.Size(245, 153);
            this.lvlista.TabIndex = 31;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label4.Location = new System.Drawing.Point(32, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label1.Location = new System.Drawing.Point(32, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.25F);
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cupom Fiscal";
            // 
            // NotinhaCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(313, 433);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.lbdata);
            this.Controls.Add(this.lbend);
            this.Controls.Add(this.lbcliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvlista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bconfirma);
            this.Controls.Add(this.lbcli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotinhaCadastrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotinhaCadastrados";
            this.Load += new System.EventHandler(this.NotinhaCadastrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbcli;
        private System.Windows.Forms.Button bconfirma;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label lbdata;
        private System.Windows.Forms.Label lbend;
        private System.Windows.Forms.Label lbcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvlista;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader Un;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}