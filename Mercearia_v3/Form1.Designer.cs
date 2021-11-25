namespace Mercearia_v3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.best = new System.Windows.Forms.Button();
            this.bvenda = new System.Windows.Forms.Button();
            this.bcompra = new System.Windows.Forms.Button();
            this.bsair = new System.Windows.Forms.Button();
            this.binfo = new System.Windows.Forms.Button();
            this.bclient = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.tmAttSaldo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // best
            // 
            this.best.BackColor = System.Drawing.Color.Transparent;
            this.best.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("best.BackgroundImage")));
            this.best.Cursor = System.Windows.Forms.Cursors.Hand;
            this.best.FlatAppearance.BorderSize = 0;
            this.best.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.best.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.best.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.best.Location = new System.Drawing.Point(54, 15);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(64, 64);
            this.best.TabIndex = 0;
            this.best.UseVisualStyleBackColor = false;
            this.best.Click += new System.EventHandler(this.best_Click);
            this.best.MouseEnter += new System.EventHandler(this.best_MouseEnter);
            this.best.MouseLeave += new System.EventHandler(this.best_MouseLeave);
            // 
            // bvenda
            // 
            this.bvenda.BackColor = System.Drawing.Color.Transparent;
            this.bvenda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bvenda.BackgroundImage")));
            this.bvenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bvenda.FlatAppearance.BorderSize = 0;
            this.bvenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bvenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bvenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bvenda.Location = new System.Drawing.Point(165, 15);
            this.bvenda.Name = "bvenda";
            this.bvenda.Size = new System.Drawing.Size(64, 64);
            this.bvenda.TabIndex = 1;
            this.bvenda.UseVisualStyleBackColor = false;
            this.bvenda.Click += new System.EventHandler(this.bvenda_Click);
            this.bvenda.MouseEnter += new System.EventHandler(this.bvenda_MouseEnter);
            this.bvenda.MouseLeave += new System.EventHandler(this.bvenda_MouseLeave);
            // 
            // bcompra
            // 
            this.bcompra.BackColor = System.Drawing.Color.Transparent;
            this.bcompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcompra.BackgroundImage")));
            this.bcompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcompra.FlatAppearance.BorderSize = 0;
            this.bcompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bcompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcompra.Location = new System.Drawing.Point(272, 15);
            this.bcompra.Name = "bcompra";
            this.bcompra.Size = new System.Drawing.Size(64, 64);
            this.bcompra.TabIndex = 2;
            this.bcompra.UseVisualStyleBackColor = false;
            this.bcompra.Click += new System.EventHandler(this.bcompra_Click);
            this.bcompra.MouseEnter += new System.EventHandler(this.bcompra_MouseEnter);
            this.bcompra.MouseLeave += new System.EventHandler(this.bcompra_MouseLeave);
            // 
            // bsair
            // 
            this.bsair.BackColor = System.Drawing.Color.Transparent;
            this.bsair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsair.BackgroundImage")));
            this.bsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsair.FlatAppearance.BorderSize = 0;
            this.bsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsair.Location = new System.Drawing.Point(783, 15);
            this.bsair.Name = "bsair";
            this.bsair.Size = new System.Drawing.Size(64, 64);
            this.bsair.TabIndex = 5;
            this.bsair.UseVisualStyleBackColor = false;
            this.bsair.Click += new System.EventHandler(this.bsair_Click);
            this.bsair.MouseEnter += new System.EventHandler(this.bsair_MouseEnter);
            this.bsair.MouseLeave += new System.EventHandler(this.bsair_MouseLeave);
            // 
            // binfo
            // 
            this.binfo.BackColor = System.Drawing.Color.Transparent;
            this.binfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("binfo.BackgroundImage")));
            this.binfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.binfo.FlatAppearance.BorderSize = 0;
            this.binfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.binfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.binfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binfo.Location = new System.Drawing.Point(676, 15);
            this.binfo.Name = "binfo";
            this.binfo.Size = new System.Drawing.Size(64, 64);
            this.binfo.TabIndex = 4;
            this.binfo.UseVisualStyleBackColor = false;
            this.binfo.Click += new System.EventHandler(this.binfo_Click);
            this.binfo.MouseEnter += new System.EventHandler(this.binfo_MouseEnter);
            this.binfo.MouseLeave += new System.EventHandler(this.binfo_MouseLeave);
            // 
            // bclient
            // 
            this.bclient.BackColor = System.Drawing.Color.Transparent;
            this.bclient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bclient.BackgroundImage")));
            this.bclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bclient.FlatAppearance.BorderSize = 0;
            this.bclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bclient.Location = new System.Drawing.Point(565, 15);
            this.bclient.Name = "bclient";
            this.bclient.Size = new System.Drawing.Size(64, 64);
            this.bclient.TabIndex = 3;
            this.bclient.UseVisualStyleBackColor = false;
            this.bclient.Click += new System.EventHandler(this.bclient_Click);
            this.bclient.MouseEnter += new System.EventHandler(this.bclient_MouseEnter);
            this.bclient.MouseLeave += new System.EventHandler(this.bclient_MouseLeave);
            // 
            // pPrincipal
            // 
            this.pPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pPrincipal.Location = new System.Drawing.Point(20, 145);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(860, 450);
            this.pPrincipal.TabIndex = 6;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.lbSaldo.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.lbSaldo.ForeColor = System.Drawing.Color.White;
            this.lbSaldo.Location = new System.Drawing.Point(303, 628);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(0, 39);
            this.lbSaldo.TabIndex = 7;
            this.lbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmAttSaldo
            // 
            this.tmAttSaldo.Enabled = true;
            this.tmAttSaldo.Tick += new System.EventHandler(this.tmAttSaldo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 675);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.bsair);
            this.Controls.Add(this.binfo);
            this.Controls.Add(this.bclient);
            this.Controls.Add(this.bcompra);
            this.Controls.Add(this.bvenda);
            this.Controls.Add(this.best);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(916, 714);
            this.MinimumSize = new System.Drawing.Size(916, 714);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button best;
        private System.Windows.Forms.Button bvenda;
        private System.Windows.Forms.Button bcompra;
        private System.Windows.Forms.Button bsair;
        private System.Windows.Forms.Button binfo;
        private System.Windows.Forms.Button bclient;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Timer tmAttSaldo;
    }
}

