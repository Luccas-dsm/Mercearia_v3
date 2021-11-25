namespace Mercearia_v3
{
    partial class Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compra));
            this.pnadd = new System.Windows.Forms.Panel();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.tbdado = new System.Windows.Forms.RichTextBox();
            this.lbprod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigodeBarra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Validade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bcarrinho = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.pncarrinho = new System.Windows.Forms.Panel();
            this.pbcarrinho = new System.Windows.Forms.PictureBox();
            this.lbPagar = new System.Windows.Forms.Label();
            this.bremov = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.blimpar = new System.Windows.Forms.Button();
            this.lvCarrinho = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bfinaliza = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnadd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            this.pncarrinho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // pnadd
            // 
            this.pnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnadd.BackgroundImage")));
            this.pnadd.Controls.Add(this.pbimage);
            this.pnadd.Controls.Add(this.tbdado);
            this.pnadd.Controls.Add(this.lbprod);
            this.pnadd.Controls.Add(this.label3);
            this.pnadd.Controls.Add(this.label2);
            this.pnadd.Controls.Add(this.label1);
            this.pnadd.Controls.Add(this.listView);
            this.pnadd.Location = new System.Drawing.Point(199, 0);
            this.pnadd.Name = "pnadd";
            this.pnadd.Size = new System.Drawing.Size(661, 450);
            this.pnadd.TabIndex = 0;
            // 
            // pbimage
            // 
            this.pbimage.BackColor = System.Drawing.Color.Transparent;
            this.pbimage.Location = new System.Drawing.Point(16, 224);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(179, 227);
            this.pbimage.TabIndex = 21;
            this.pbimage.TabStop = false;
            // 
            // tbdado
            // 
            this.tbdado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbdado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbdado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.tbdado.Location = new System.Drawing.Point(35, 138);
            this.tbdado.Name = "tbdado";
            this.tbdado.ReadOnly = true;
            this.tbdado.Size = new System.Drawing.Size(150, 59);
            this.tbdado.TabIndex = 20;
            this.tbdado.Text = "";
            // 
            // lbprod
            // 
            this.lbprod.AutoSize = true;
            this.lbprod.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbprod.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lbprod.ForeColor = System.Drawing.Color.Black;
            this.lbprod.Location = new System.Drawing.Point(29, 73);
            this.lbprod.Name = "lbprod";
            this.lbprod.Size = new System.Drawing.Size(0, 22);
            this.lbprod.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Dados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Produto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Informações";
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
            this.Validade});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(214, 1);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(449, 450);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.Click += new System.EventHandler(this.listView_Click);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 68;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 83;
            // 
            // CodigodeBarra
            // 
            this.CodigodeBarra.Text = "Codigo de Barras";
            this.CodigodeBarra.Width = 100;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 68;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            this.Preço.Width = 41;
            // 
            // Validade
            // 
            this.Validade.Text = "Validade";
            this.Validade.Width = 87;
            // 
            // bcarrinho
            // 
            this.bcarrinho.BackColor = System.Drawing.Color.Transparent;
            this.bcarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcarrinho.BackgroundImage")));
            this.bcarrinho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcarrinho.FlatAppearance.BorderSize = 0;
            this.bcarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcarrinho.Location = new System.Drawing.Point(1, 205);
            this.bcarrinho.Name = "bcarrinho";
            this.bcarrinho.Size = new System.Drawing.Size(200, 40);
            this.bcarrinho.TabIndex = 3;
            this.bcarrinho.UseVisualStyleBackColor = false;
            this.bcarrinho.Click += new System.EventHandler(this.bcarrinho_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Transparent;
            this.badd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("badd.BackgroundImage")));
            this.badd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badd.FlatAppearance.BorderSize = 0;
            this.badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badd.Location = new System.Drawing.Point(1, 147);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(200, 40);
            this.badd.TabIndex = 2;
            this.badd.UseVisualStyleBackColor = false;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // pncarrinho
            // 
            this.pncarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pncarrinho.BackgroundImage")));
            this.pncarrinho.Controls.Add(this.pbcarrinho);
            this.pncarrinho.Controls.Add(this.lbPagar);
            this.pncarrinho.Controls.Add(this.bremov);
            this.pncarrinho.Controls.Add(this.lb);
            this.pncarrinho.Controls.Add(this.blimpar);
            this.pncarrinho.Controls.Add(this.lvCarrinho);
            this.pncarrinho.Controls.Add(this.bfinaliza);
            this.pncarrinho.Controls.Add(this.bcancel);
            this.pncarrinho.Location = new System.Drawing.Point(199, 0);
            this.pncarrinho.Name = "pncarrinho";
            this.pncarrinho.Size = new System.Drawing.Size(661, 450);
            this.pncarrinho.TabIndex = 20;
            // 
            // pbcarrinho
            // 
            this.pbcarrinho.BackColor = System.Drawing.Color.Transparent;
            this.pbcarrinho.Location = new System.Drawing.Point(16, 195);
            this.pbcarrinho.Name = "pbcarrinho";
            this.pbcarrinho.Size = new System.Drawing.Size(214, 256);
            this.pbcarrinho.TabIndex = 29;
            this.pbcarrinho.TabStop = false;
            // 
            // lbPagar
            // 
            this.lbPagar.AutoSize = true;
            this.lbPagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.lbPagar.ForeColor = System.Drawing.Color.Black;
            this.lbPagar.Location = new System.Drawing.Point(467, 288);
            this.lbPagar.Name = "lbPagar";
            this.lbPagar.Size = new System.Drawing.Size(0, 28);
            this.lbPagar.TabIndex = 28;
            // 
            // bremov
            // 
            this.bremov.BackColor = System.Drawing.Color.Transparent;
            this.bremov.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bremov.BackgroundImage")));
            this.bremov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bremov.FlatAppearance.BorderSize = 0;
            this.bremov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bremov.Location = new System.Drawing.Point(469, 349);
            this.bremov.Name = "bremov";
            this.bremov.Size = new System.Drawing.Size(192, 40);
            this.bremov.TabIndex = 23;
            this.bremov.UseVisualStyleBackColor = false;
            this.bremov.Click += new System.EventHandler(this.bremov_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.lb.ForeColor = System.Drawing.Color.Black;
            this.lb.Location = new System.Drawing.Point(258, 288);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(210, 28);
            this.lb.TabIndex = 27;
            this.lb.Text = "Total a pagar R$:";
            // 
            // blimpar
            // 
            this.blimpar.BackColor = System.Drawing.Color.Transparent;
            this.blimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blimpar.BackgroundImage")));
            this.blimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.blimpar.FlatAppearance.BorderSize = 0;
            this.blimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blimpar.Location = new System.Drawing.Point(251, 349);
            this.blimpar.Name = "blimpar";
            this.blimpar.Size = new System.Drawing.Size(197, 40);
            this.blimpar.TabIndex = 21;
            this.blimpar.UseVisualStyleBackColor = false;
            this.blimpar.Click += new System.EventHandler(this.blimpar_Click);
            // 
            // lvCarrinho
            // 
            this.lvCarrinho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCarrinho.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Preco,
            this.Quant});
            this.lvCarrinho.HideSelection = false;
            this.lvCarrinho.Location = new System.Drawing.Point(252, -2);
            this.lvCarrinho.Name = "lvCarrinho";
            this.lvCarrinho.Size = new System.Drawing.Size(409, 258);
            this.lvCarrinho.TabIndex = 26;
            this.lvCarrinho.UseCompatibleStateImageBehavior = false;
            this.lvCarrinho.View = System.Windows.Forms.View.Details;
            this.lvCarrinho.Click += new System.EventHandler(this.lvCarrinho_Click);
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 107;
            // 
            // Preco
            // 
            this.Preco.Text = "Preço";
            this.Preco.Width = 120;
            // 
            // Quant
            // 
            this.Quant.Text = "Quantidade";
            this.Quant.Width = 182;
            // 
            // bfinaliza
            // 
            this.bfinaliza.BackColor = System.Drawing.Color.Transparent;
            this.bfinaliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfinaliza.BackgroundImage")));
            this.bfinaliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfinaliza.FlatAppearance.BorderSize = 0;
            this.bfinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfinaliza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bfinaliza.Location = new System.Drawing.Point(250, 411);
            this.bfinaliza.Name = "bfinaliza";
            this.bfinaliza.Size = new System.Drawing.Size(197, 40);
            this.bfinaliza.TabIndex = 22;
            this.bfinaliza.UseVisualStyleBackColor = false;
            this.bfinaliza.Click += new System.EventHandler(this.bfinaliza_Click);
            // 
            // bcancel
            // 
            this.bcancel.BackColor = System.Drawing.Color.Transparent;
            this.bcancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancel.BackgroundImage")));
            this.bcancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancel.FlatAppearance.BorderSize = 0;
            this.bcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancel.Location = new System.Drawing.Point(469, 408);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(192, 40);
            this.bcancel.TabIndex = 24;
            this.bcancel.UseVisualStyleBackColor = false;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fornecedores";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bcarrinho);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.pnadd);
            this.Controls.Add(this.pncarrinho);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.pnadd.ResumeLayout(false);
            this.pnadd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            this.pncarrinho.ResumeLayout(false);
            this.pncarrinho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnadd;
        private System.Windows.Forms.Button bcarrinho;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Label lbprod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader CodigodeBarra;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.ColumnHeader Validade;
        private System.Windows.Forms.Panel pncarrinho;
        private System.Windows.Forms.Label lbPagar;
        private System.Windows.Forms.Button bremov;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button blimpar;
        private System.Windows.Forms.ListView lvCarrinho;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Preco;
        private System.Windows.Forms.ColumnHeader Quant;
        private System.Windows.Forms.Button bfinaliza;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbdado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.PictureBox pbcarrinho;
    }
}