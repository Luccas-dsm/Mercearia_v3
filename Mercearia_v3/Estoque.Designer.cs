namespace Mercearia_v3
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.badd = new System.Windows.Forms.Button();
            this.bremov = new System.Windows.Forms.Button();
            this.batt = new System.Windows.Forms.Button();
            this.pnestoque = new System.Windows.Forms.Panel();
            this.tbdado = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbprod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigodeBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datacompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnadd = new System.Windows.Forms.Panel();
            this.lbcat = new System.Windows.Forms.ComboBox();
            this.tbdes = new System.Windows.Forms.RichTextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbpreco = new System.Windows.Forms.TextBox();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bcancela = new System.Windows.Forms.Button();
            this.bconfirma = new System.Windows.Forms.Button();
            this.pbcarregafoto = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnestoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.pnadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarregafoto)).BeginInit();
            this.SuspendLayout();
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Transparent;
            this.badd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("badd.BackgroundImage")));
            this.badd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badd.FlatAppearance.BorderSize = 0;
            this.badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badd.Location = new System.Drawing.Point(-1, 145);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(200, 40);
            this.badd.TabIndex = 0;
            this.badd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bremov
            // 
            this.bremov.BackColor = System.Drawing.Color.Transparent;
            this.bremov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bremov.BackgroundImage")));
            this.bremov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bremov.FlatAppearance.BorderSize = 0;
            this.bremov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bremov.Location = new System.Drawing.Point(-1, 205);
            this.bremov.Name = "bremov";
            this.bremov.Size = new System.Drawing.Size(200, 40);
            this.bremov.TabIndex = 1;
            this.bremov.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bremov.UseVisualStyleBackColor = false;
            this.bremov.Click += new System.EventHandler(this.bremov_Click);
            // 
            // batt
            // 
            this.batt.BackColor = System.Drawing.Color.Transparent;
            this.batt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("batt.BackgroundImage")));
            this.batt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batt.FlatAppearance.BorderSize = 0;
            this.batt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batt.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold);
            this.batt.Location = new System.Drawing.Point(-1, 264);
            this.batt.Name = "batt";
            this.batt.Size = new System.Drawing.Size(200, 40);
            this.batt.TabIndex = 2;
            this.batt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.batt.UseVisualStyleBackColor = false;
            this.batt.Click += new System.EventHandler(this.batt_Click);
            // 
            // pnestoque
            // 
            this.pnestoque.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnestoque.BackgroundImage")));
            this.pnestoque.Controls.Add(this.tbdado);
            this.pnestoque.Controls.Add(this.label3);
            this.pnestoque.Controls.Add(this.lbprod);
            this.pnestoque.Controls.Add(this.label2);
            this.pnestoque.Controls.Add(this.label1);
            this.pnestoque.Controls.Add(this.pbfoto);
            this.pnestoque.Controls.Add(this.listView);
            this.pnestoque.Location = new System.Drawing.Point(199, 0);
            this.pnestoque.Name = "pnestoque";
            this.pnestoque.Size = new System.Drawing.Size(661, 450);
            this.pnestoque.TabIndex = 3;
            // 
            // tbdado
            // 
            this.tbdado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbdado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbdado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.tbdado.Location = new System.Drawing.Point(499, 367);
            this.tbdado.Name = "tbdado";
            this.tbdado.ReadOnly = true;
            this.tbdado.Size = new System.Drawing.Size(150, 59);
            this.tbdado.TabIndex = 7;
            this.tbdado.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label3.Location = new System.Drawing.Point(493, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dados:";
            // 
            // lbprod
            // 
            this.lbprod.AutoSize = true;
            this.lbprod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbprod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lbprod.Location = new System.Drawing.Point(494, 307);
            this.lbprod.Name = "lbprod";
            this.lbprod.Size = new System.Drawing.Size(0, 22);
            this.lbprod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label2.Location = new System.Drawing.Point(493, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.Location = new System.Drawing.Point(504, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.Color.Transparent;
            this.pbfoto.Location = new System.Drawing.Point(295, 222);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(174, 225);
            this.pbfoto.TabIndex = 1;
            this.pbfoto.TabStop = false;
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Categoria,
            this.CodigodeBarra,
            this.Quantidade,
            this.Preço,
            this.Datacompra,
            this.Validade});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(21, -3);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(640, 199);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 102;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 105;
            // 
            // CodigodeBarra
            // 
            this.CodigodeBarra.Text = "Codigo de Barras";
            this.CodigodeBarra.Width = 112;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 54;
            // 
            // Datacompra
            // 
            this.Datacompra.Text = "Data da Compra";
            this.Datacompra.Width = 113;
            // 
            // Validade
            // 
            this.Validade.Text = "Validade";
            this.Validade.Width = 82;
            // 
            // pnadd
            // 
            this.pnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnadd.BackgroundImage")));
            this.pnadd.Controls.Add(this.lbcat);
            this.pnadd.Controls.Add(this.tbdes);
            this.pnadd.Controls.Add(this.tbnome);
            this.pnadd.Controls.Add(this.tbpreco);
            this.pnadd.Controls.Add(this.tbcod);
            this.pnadd.Controls.Add(this.label9);
            this.pnadd.Controls.Add(this.label8);
            this.pnadd.Controls.Add(this.label7);
            this.pnadd.Controls.Add(this.label6);
            this.pnadd.Controls.Add(this.label5);
            this.pnadd.Controls.Add(this.bcancela);
            this.pnadd.Controls.Add(this.bconfirma);
            this.pnadd.Controls.Add(this.pbcarregafoto);
            this.pnadd.Enabled = false;
            this.pnadd.Location = new System.Drawing.Point(199, 0);
            this.pnadd.Name = "pnadd";
            this.pnadd.Size = new System.Drawing.Size(661, 450);
            this.pnadd.TabIndex = 4;
            this.pnadd.Visible = false;
            // 
            // lbcat
            // 
            this.lbcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbcat.FormattingEnabled = true;
            this.lbcat.Items.AddRange(new object[] {
            "Alimento",
            "Higiene",
            "Limpeza"});
            this.lbcat.Location = new System.Drawing.Point(428, 64);
            this.lbcat.Name = "lbcat";
            this.lbcat.Size = new System.Drawing.Size(213, 32);
            this.lbcat.TabIndex = 13;
            // 
            // tbdes
            // 
            this.tbdes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbdes.Location = new System.Drawing.Point(428, 249);
            this.tbdes.Name = "tbdes";
            this.tbdes.Size = new System.Drawing.Size(213, 81);
            this.tbdes.TabIndex = 12;
            this.tbdes.Text = "";
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnome.Location = new System.Drawing.Point(428, 14);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(213, 29);
            this.tbnome.TabIndex = 11;
            this.tbnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnome_KeyPress);
            // 
            // tbpreco
            // 
            this.tbpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbpreco.Location = new System.Drawing.Point(428, 179);
            this.tbpreco.Name = "tbpreco";
            this.tbpreco.Size = new System.Drawing.Size(213, 29);
            this.tbpreco.TabIndex = 10;
            this.tbpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpreco_KeyPress);
            // 
            // tbcod
            // 
            this.tbcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbcod.Location = new System.Drawing.Point(428, 123);
            this.tbcod.Name = "tbcod";
            this.tbcod.ReadOnly = true;
            this.tbcod.Size = new System.Drawing.Size(213, 29);
            this.tbcod.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label9.Location = new System.Drawing.Point(310, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descrição:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label8.Location = new System.Drawing.Point(286, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Preço Un/Kg:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label7.Location = new System.Drawing.Point(257, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cod do Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label6.Location = new System.Drawing.Point(313, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label5.Location = new System.Drawing.Point(353, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome:";
            // 
            // bcancela
            // 
            this.bcancela.BackColor = System.Drawing.Color.Transparent;
            this.bcancela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancela.BackgroundImage")));
            this.bcancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancela.FlatAppearance.BorderSize = 0;
            this.bcancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancela.Location = new System.Drawing.Point(469, 367);
            this.bcancela.Name = "bcancela";
            this.bcancela.Size = new System.Drawing.Size(192, 83);
            this.bcancela.TabIndex = 2;
            this.bcancela.UseVisualStyleBackColor = false;
            this.bcancela.Click += new System.EventHandler(this.bcancela_Click);
            // 
            // bconfirma
            // 
            this.bconfirma.BackColor = System.Drawing.Color.Transparent;
            this.bconfirma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconfirma.BackgroundImage")));
            this.bconfirma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconfirma.FlatAppearance.BorderSize = 0;
            this.bconfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bconfirma.Location = new System.Drawing.Point(252, 367);
            this.bconfirma.Name = "bconfirma";
            this.bconfirma.Size = new System.Drawing.Size(192, 83);
            this.bconfirma.TabIndex = 1;
            this.bconfirma.UseVisualStyleBackColor = false;
            this.bconfirma.Click += new System.EventHandler(this.bconfirma_Click);
            // 
            // pbcarregafoto
            // 
            this.pbcarregafoto.BackColor = System.Drawing.Color.Transparent;
            this.pbcarregafoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbcarregafoto.Location = new System.Drawing.Point(21, 202);
            this.pbcarregafoto.Name = "pbcarregafoto";
            this.pbcarregafoto.Size = new System.Drawing.Size(211, 248);
            this.pbcarregafoto.TabIndex = 0;
            this.pbcarregafoto.TabStop = false;
            this.pbcarregafoto.Click += new System.EventHandler(this.pbcarregafoto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(46, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Estoque";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bremov);
            this.Controls.Add(this.batt);
            this.Controls.Add(this.pnadd);
            this.Controls.Add(this.pnestoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.pnestoque.ResumeLayout(false);
            this.pnestoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.pnadd.ResumeLayout(false);
            this.pnadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarregafoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bremov;
        private System.Windows.Forms.Button batt;
        private System.Windows.Forms.Panel pnestoque;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader CodigodeBarra;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.ColumnHeader Datacompra;
        private System.Windows.Forms.ColumnHeader Validade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnadd;
        private System.Windows.Forms.PictureBox pbcarregafoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bcancela;
        private System.Windows.Forms.Button bconfirma;
        private System.Windows.Forms.RichTextBox tbdes;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbpreco;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.ComboBox lbcat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox tbdado;
        private System.Windows.Forms.Label lbprod;
    }
}