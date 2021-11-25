namespace Mercearia_v3
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            this.bfinaliza = new System.Windows.Forms.Button();
            this.bcancela = new System.Windows.Forms.Button();
            this.pbimagem = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbcod = new System.Windows.Forms.TextBox();
            this.tbpreco = new System.Windows.Forms.TextBox();
            this.tbdes = new System.Windows.Forms.RichTextBox();
            this.cbcat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).BeginInit();
            this.SuspendLayout();
            // 
            // bfinaliza
            // 
            this.bfinaliza.BackColor = System.Drawing.Color.Transparent;
            this.bfinaliza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bfinaliza.BackgroundImage")));
            this.bfinaliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bfinaliza.FlatAppearance.BorderSize = 0;
            this.bfinaliza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfinaliza.Location = new System.Drawing.Point(499, 237);
            this.bfinaliza.Name = "bfinaliza";
            this.bfinaliza.Size = new System.Drawing.Size(163, 48);
            this.bfinaliza.TabIndex = 0;
            this.bfinaliza.UseVisualStyleBackColor = false;
            this.bfinaliza.Click += new System.EventHandler(this.bfinaliza_Click);
            // 
            // bcancela
            // 
            this.bcancela.BackColor = System.Drawing.Color.Transparent;
            this.bcancela.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcancela.BackgroundImage")));
            this.bcancela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcancela.FlatAppearance.BorderSize = 0;
            this.bcancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcancela.Location = new System.Drawing.Point(501, 307);
            this.bcancela.Name = "bcancela";
            this.bcancela.Size = new System.Drawing.Size(161, 48);
            this.bcancela.TabIndex = 1;
            this.bcancela.UseVisualStyleBackColor = false;
            this.bcancela.Click += new System.EventHandler(this.bcancela_Click);
            // 
            // pbimagem
            // 
            this.pbimagem.BackColor = System.Drawing.Color.Transparent;
            this.pbimagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbimagem.Location = new System.Drawing.Point(499, 12);
            this.pbimagem.Name = "pbimagem";
            this.pbimagem.Size = new System.Drawing.Size(163, 206);
            this.pbimagem.TabIndex = 2;
            this.pbimagem.TabStop = false;
            this.pbimagem.Click += new System.EventHandler(this.pbimagem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label1.Location = new System.Drawing.Point(146, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label2.Location = new System.Drawing.Point(98, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label4.Location = new System.Drawing.Point(31, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço da Un/Kg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.label6.Location = new System.Drawing.Point(94, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição:";
            // 
            // tbnome
            // 
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnome.Location = new System.Drawing.Point(275, 30);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(193, 29);
            this.tbnome.TabIndex = 9;
            this.tbnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnome_KeyPress);
            // 
            // tbcod
            // 
            this.tbcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbcod.Location = new System.Drawing.Point(275, 130);
            this.tbcod.Name = "tbcod";
            this.tbcod.ReadOnly = true;
            this.tbcod.Size = new System.Drawing.Size(193, 29);
            this.tbcod.TabIndex = 11;
            // 
            // tbpreco
            // 
            this.tbpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbpreco.Location = new System.Drawing.Point(275, 189);
            this.tbpreco.Name = "tbpreco";
            this.tbpreco.Size = new System.Drawing.Size(193, 29);
            this.tbpreco.TabIndex = 13;
            this.tbpreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpreco_KeyPress);
            // 
            // tbdes
            // 
            this.tbdes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbdes.Location = new System.Drawing.Point(274, 253);
            this.tbdes.Name = "tbdes";
            this.tbdes.Size = new System.Drawing.Size(193, 90);
            this.tbdes.TabIndex = 14;
            this.tbdes.Text = "";
            this.tbdes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdes_KeyPress);
            // 
            // cbcat
            // 
            this.cbcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Items.AddRange(new object[] {
            "Alimento",
            "Higiene",
            "Limpeza",
            "Diversos"});
            this.cbcat.Location = new System.Drawing.Point(274, 77);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(194, 32);
            this.cbcat.TabIndex = 15;
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(677, 383);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.tbdes);
            this.Controls.Add(this.tbpreco);
            this.Controls.Add(this.tbcod);
            this.Controls.Add(this.tbnome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbimagem);
            this.Controls.Add(this.bcancela);
            this.Controls.Add(this.bfinaliza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bfinaliza;
        private System.Windows.Forms.Button bcancela;
        private System.Windows.Forms.PictureBox pbimagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbcod;
        private System.Windows.Forms.TextBox tbpreco;
        private System.Windows.Forms.RichTextBox tbdes;
        private System.Windows.Forms.ComboBox cbcat;
    }
}