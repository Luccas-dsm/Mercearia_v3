namespace Mercearia_v3
{
    partial class Quantidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quantidade));
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.tbdes = new System.Windows.Forms.RichTextBox();
            this.tbpreco = new System.Windows.Forms.TextBox();
            this.tbquant = new System.Windows.Forms.TextBox();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbimagem = new System.Windows.Forms.PictureBox();
            this.bcancela = new System.Windows.Forms.Button();
            this.bfinaliza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbcat
            // 
            this.cbcat.Enabled = false;
            this.cbcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Items.AddRange(new object[] {
            "Alimento",
            "Higiene",
            "Limpeza",
            "Diversos"});
            this.cbcat.Location = new System.Drawing.Point(273, 80);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(194, 32);
            this.cbcat.TabIndex = 30;
            // 
            // tbdes
            // 
            this.tbdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbdes.Location = new System.Drawing.Point(273, 292);
            this.tbdes.Name = "tbdes";
            this.tbdes.ReadOnly = true;
            this.tbdes.Size = new System.Drawing.Size(193, 54);
            this.tbdes.TabIndex = 29;
            this.tbdes.Text = "";
            // 
            // tbpreco
            // 
            this.tbpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbpreco.Location = new System.Drawing.Point(274, 187);
            this.tbpreco.Name = "tbpreco";
            this.tbpreco.ReadOnly = true;
            this.tbpreco.Size = new System.Drawing.Size(193, 29);
            this.tbpreco.TabIndex = 28;
            // 
            // tbquant
            // 
            this.tbquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbquant.Location = new System.Drawing.Point(273, 239);
            this.tbquant.Name = "tbquant";
            this.tbquant.Size = new System.Drawing.Size(193, 29);
            this.tbquant.TabIndex = 27;
            this.tbquant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbquant_KeyPress);
            // 
            // tbcod
            // 
            this.tbcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbcod.Location = new System.Drawing.Point(274, 133);
            this.tbcod.Name = "tbcod";
            this.tbcod.ReadOnly = true;
            this.tbcod.Size = new System.Drawing.Size(193, 29);
            this.tbcod.TabIndex = 26;
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnome.Location = new System.Drawing.Point(274, 33);
            this.tbnome.Name = "tbnome";
            this.tbnome.ReadOnly = true;
            this.tbnome.Size = new System.Drawing.Size(193, 29);
            this.tbnome.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label6.Location = new System.Drawing.Point(101, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label5.Location = new System.Drawing.Point(86, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label4.Location = new System.Drawing.Point(37, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Preço da UN/Kg:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cod do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label2.Location = new System.Drawing.Point(104, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F);
            this.label1.Location = new System.Drawing.Point(148, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome:";
            // 
            // pbimagem
            // 
            this.pbimagem.BackColor = System.Drawing.Color.Transparent;
            this.pbimagem.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbimagem.Location = new System.Drawing.Point(498, 15);
            this.pbimagem.Name = "pbimagem";
            this.pbimagem.Size = new System.Drawing.Size(163, 206);
            this.pbimagem.TabIndex = 18;
            this.pbimagem.TabStop = false;
            // 
            // bcancela
            // 
            this.bcancela.BackColor = System.Drawing.Color.Transparent;
            this.bcancela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancela.BackgroundImage")));
            this.bcancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancela.FlatAppearance.BorderSize = 0;
            this.bcancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancela.Location = new System.Drawing.Point(500, 310);
            this.bcancela.Name = "bcancela";
            this.bcancela.Size = new System.Drawing.Size(161, 48);
            this.bcancela.TabIndex = 17;
            this.bcancela.UseVisualStyleBackColor = false;
            this.bcancela.Click += new System.EventHandler(this.bcancela_Click);
            // 
            // bfinaliza
            // 
            this.bfinaliza.BackColor = System.Drawing.Color.Transparent;
            this.bfinaliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfinaliza.BackgroundImage")));
            this.bfinaliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfinaliza.FlatAppearance.BorderSize = 0;
            this.bfinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfinaliza.Location = new System.Drawing.Point(498, 240);
            this.bfinaliza.Name = "bfinaliza";
            this.bfinaliza.Size = new System.Drawing.Size(163, 48);
            this.bfinaliza.TabIndex = 16;
            this.bfinaliza.UseVisualStyleBackColor = false;
            this.bfinaliza.Click += new System.EventHandler(this.bfinaliza_Click);
            // 
            // Quantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.tbdes);
            this.Controls.Add(this.tbpreco);
            this.Controls.Add(this.tbquant);
            this.Controls.Add(this.tbcod);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbimagem);
            this.Controls.Add(this.bcancela);
            this.Controls.Add(this.bfinaliza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Quantidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantidade";
            this.Load += new System.EventHandler(this.Quantidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.RichTextBox tbdes;
        private System.Windows.Forms.TextBox tbpreco;
        private System.Windows.Forms.TextBox tbquant;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbimagem;
        private System.Windows.Forms.Button bcancela;
        private System.Windows.Forms.Button bfinaliza;
    }
}