namespace Mercearia_v3
{
    partial class Fclientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fclientes));
            this.bdado = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bremov = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tmatt = new System.Windows.Forms.Timer(this.components);
            this.tbpesq = new System.Windows.Forms.TextBox();
            this.lvusuario = new System.Windows.Forms.ListBox();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbend = new System.Windows.Forms.Label();
            this.lbtel = new System.Windows.Forms.Label();
            this.lbmail = new System.Windows.Forms.Label();
            this.lbcep = new System.Windows.Forms.Label();
            this.pndados = new System.Windows.Forms.Panel();
            this.pbimgadd = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.tbend = new System.Windows.Forms.TextBox();
            this.tbcep = new System.Windows.Forms.TextBox();
            this.tbtel = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.bconfAdd = new System.Windows.Forms.Button();
            this.bacancelAdd = new System.Windows.Forms.Button();
            this.pnadd = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.pndados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimgadd)).BeginInit();
            this.pnadd.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdado
            // 
            this.bdado.BackColor = System.Drawing.Color.Transparent;
            this.bdado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bdado.BackgroundImage")));
            this.bdado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdado.FlatAppearance.BorderSize = 0;
            this.bdado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bdado.Location = new System.Drawing.Point(-1, 181);
            this.bdado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bdado.Name = "bdado";
            this.bdado.Size = new System.Drawing.Size(267, 49);
            this.bdado.TabIndex = 3;
            this.bdado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bdado.UseVisualStyleBackColor = false;
            this.bdado.Click += new System.EventHandler(this.bdados_Click);
            // 
            // badd
            // 
            this.badd.BackColor = System.Drawing.Color.Transparent;
            this.badd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("badd.BackgroundImage")));
            this.badd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.badd.FlatAppearance.BorderSize = 0;
            this.badd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badd.Location = new System.Drawing.Point(-1, 255);
            this.badd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(267, 49);
            this.badd.TabIndex = 4;
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
            this.bremov.Font = new System.Drawing.Font("Bebas Neue Bold", 18F, System.Drawing.FontStyle.Bold);
            this.bremov.Location = new System.Drawing.Point(-1, 327);
            this.bremov.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bremov.Name = "bremov";
            this.bremov.Size = new System.Drawing.Size(267, 49);
            this.bremov.TabIndex = 5;
            this.bremov.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bremov.UseVisualStyleBackColor = false;
            this.bremov.Click += new System.EventHandler(this.bremov_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(61, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "Clientes";
            // 
            // tmatt
            // 
            this.tmatt.Enabled = true;
            this.tmatt.Interval = 1;
            this.tmatt.Tick += new System.EventHandler(this.tmatt_Tick);
            // 
            // tbpesq
            // 
            this.tbpesq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbpesq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbpesq.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbpesq.Location = new System.Drawing.Point(101, 17);
            this.tbpesq.Margin = new System.Windows.Forms.Padding(4);
            this.tbpesq.Name = "tbpesq";
            this.tbpesq.Size = new System.Drawing.Size(764, 27);
            this.tbpesq.TabIndex = 0;
            this.tbpesq.Text = "Pesquisar";
            this.tbpesq.Click += new System.EventHandler(this.tbpesq_Click);
            this.tbpesq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbpesq_KeyPress);
            this.tbpesq.Leave += new System.EventHandler(this.tbpesq_Leave);
            // 
            // lvusuario
            // 
            this.lvusuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvusuario.FormattingEnabled = true;
            this.lvusuario.ItemHeight = 16;
            this.lvusuario.Location = new System.Drawing.Point(336, 86);
            this.lvusuario.Margin = new System.Windows.Forms.Padding(4);
            this.lvusuario.Name = "lvusuario";
            this.lvusuario.Size = new System.Drawing.Size(544, 112);
            this.lvusuario.TabIndex = 1;
            this.lvusuario.Click += new System.EventHandler(this.lvusuario_Click);
            this.lvusuario.DoubleClick += new System.EventHandler(this.lvusuario_DoubleClick);
            this.lvusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvusuario_KeyDown);
            // 
            // pbfoto
            // 
            this.pbfoto.BackColor = System.Drawing.Color.Transparent;
            this.pbfoto.Location = new System.Drawing.Point(29, 86);
            this.pbfoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(277, 290);
            this.pbfoto.TabIndex = 2;
            this.pbfoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(345, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(345, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "End:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(345, 346);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(629, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cep:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(345, 404);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email:";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.BackColor = System.Drawing.Color.Transparent;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbnome.Location = new System.Drawing.Point(451, 242);
            this.lbnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(0, 29);
            this.lbnome.TabIndex = 8;
            // 
            // lbend
            // 
            this.lbend.AutoSize = true;
            this.lbend.BackColor = System.Drawing.Color.Transparent;
            this.lbend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbend.Location = new System.Drawing.Point(428, 294);
            this.lbend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbend.Name = "lbend";
            this.lbend.Size = new System.Drawing.Size(0, 29);
            this.lbend.TabIndex = 9;
            // 
            // lbtel
            // 
            this.lbtel.AutoSize = true;
            this.lbtel.BackColor = System.Drawing.Color.Transparent;
            this.lbtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbtel.Location = new System.Drawing.Point(427, 347);
            this.lbtel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(0, 29);
            this.lbtel.TabIndex = 10;
            // 
            // lbmail
            // 
            this.lbmail.AutoSize = true;
            this.lbmail.BackColor = System.Drawing.Color.Transparent;
            this.lbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbmail.Location = new System.Drawing.Point(451, 405);
            this.lbmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmail.Name = "lbmail";
            this.lbmail.Size = new System.Drawing.Size(0, 29);
            this.lbmail.TabIndex = 11;
            // 
            // lbcep
            // 
            this.lbcep.AutoSize = true;
            this.lbcep.BackColor = System.Drawing.Color.Transparent;
            this.lbcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbcep.Location = new System.Drawing.Point(713, 348);
            this.lbcep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcep.Name = "lbcep";
            this.lbcep.Size = new System.Drawing.Size(0, 29);
            this.lbcep.TabIndex = 12;
            // 
            // pndados
            // 
            this.pndados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pndados.BackgroundImage")));
            this.pndados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pndados.Controls.Add(this.lbcep);
            this.pndados.Controls.Add(this.lbmail);
            this.pndados.Controls.Add(this.lbtel);
            this.pndados.Controls.Add(this.lbend);
            this.pndados.Controls.Add(this.lbnome);
            this.pndados.Controls.Add(this.label5);
            this.pndados.Controls.Add(this.label4);
            this.pndados.Controls.Add(this.label3);
            this.pndados.Controls.Add(this.label2);
            this.pndados.Controls.Add(this.label1);
            this.pndados.Controls.Add(this.pbfoto);
            this.pndados.Controls.Add(this.lvusuario);
            this.pndados.Controls.Add(this.tbpesq);
            this.pndados.Location = new System.Drawing.Point(265, 0);
            this.pndados.Margin = new System.Windows.Forms.Padding(4);
            this.pndados.Name = "pndados";
            this.pndados.Size = new System.Drawing.Size(881, 554);
            this.pndados.TabIndex = 6;
            // 
            // pbimgadd
            // 
            this.pbimgadd.BackColor = System.Drawing.Color.Transparent;
            this.pbimgadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbimgadd.Location = new System.Drawing.Point(597, 4);
            this.pbimgadd.Margin = new System.Windows.Forms.Padding(4);
            this.pbimgadd.Name = "pbimgadd";
            this.pbimgadd.Size = new System.Drawing.Size(284, 287);
            this.pbimgadd.TabIndex = 0;
            this.pbimgadd.TabStop = false;
            this.pbimgadd.Click += new System.EventHandler(this.pbimgadd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(29, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nome:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(55, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "End:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(52, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cep:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(65, 244);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(35, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Email:";
            // 
            // tbnome
            // 
            this.tbnome.BackColor = System.Drawing.Color.White;
            this.tbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbnome.Location = new System.Drawing.Point(131, 17);
            this.tbnome.Margin = new System.Windows.Forms.Padding(4);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(420, 34);
            this.tbnome.TabIndex = 6;
            this.tbnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnome_KeyPress);
            // 
            // tbend
            // 
            this.tbend.BackColor = System.Drawing.Color.White;
            this.tbend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbend.Location = new System.Drawing.Point(131, 91);
            this.tbend.Margin = new System.Windows.Forms.Padding(4);
            this.tbend.Name = "tbend";
            this.tbend.Size = new System.Drawing.Size(420, 34);
            this.tbend.TabIndex = 7;
            this.tbend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbend_KeyPress);
            // 
            // tbcep
            // 
            this.tbcep.BackColor = System.Drawing.Color.White;
            this.tbcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbcep.Location = new System.Drawing.Point(131, 167);
            this.tbcep.Margin = new System.Windows.Forms.Padding(4);
            this.tbcep.Name = "tbcep";
            this.tbcep.Size = new System.Drawing.Size(420, 34);
            this.tbcep.TabIndex = 8;
            this.tbcep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcep_KeyPress);
            // 
            // tbtel
            // 
            this.tbtel.BackColor = System.Drawing.Color.White;
            this.tbtel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbtel.Location = new System.Drawing.Point(131, 241);
            this.tbtel.Margin = new System.Windows.Forms.Padding(4);
            this.tbtel.Name = "tbtel";
            this.tbtel.Size = new System.Drawing.Size(420, 34);
            this.tbtel.TabIndex = 9;
            this.tbtel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtel_KeyPress);
            // 
            // tbmail
            // 
            this.tbmail.BackColor = System.Drawing.Color.White;
            this.tbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbmail.Location = new System.Drawing.Point(131, 314);
            this.tbmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(420, 34);
            this.tbmail.TabIndex = 10;
            this.tbmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmail_KeyPress);
            // 
            // bconfAdd
            // 
            this.bconfAdd.BackColor = System.Drawing.Color.Transparent;
            this.bconfAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconfAdd.BackgroundImage")));
            this.bconfAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bconfAdd.FlatAppearance.BorderSize = 0;
            this.bconfAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bconfAdd.Location = new System.Drawing.Point(39, 384);
            this.bconfAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bconfAdd.Name = "bconfAdd";
            this.bconfAdd.Size = new System.Drawing.Size(244, 44);
            this.bconfAdd.TabIndex = 8;
            this.bconfAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bconfAdd.UseVisualStyleBackColor = false;
            this.bconfAdd.Click += new System.EventHandler(this.bconfAdd_Click);
            // 
            // bacancelAdd
            // 
            this.bacancelAdd.BackColor = System.Drawing.Color.Transparent;
            this.bacancelAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bacancelAdd.BackgroundImage")));
            this.bacancelAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bacancelAdd.FlatAppearance.BorderSize = 0;
            this.bacancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bacancelAdd.Location = new System.Drawing.Point(312, 384);
            this.bacancelAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bacancelAdd.Name = "bacancelAdd";
            this.bacancelAdd.Size = new System.Drawing.Size(244, 44);
            this.bacancelAdd.TabIndex = 11;
            this.bacancelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bacancelAdd.UseVisualStyleBackColor = false;
            this.bacancelAdd.Click += new System.EventHandler(this.bacancelAdd_Click);
            // 
            // pnadd
            // 
            this.pnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnadd.BackgroundImage")));
            this.pnadd.Controls.Add(this.bacancelAdd);
            this.pnadd.Controls.Add(this.bconfAdd);
            this.pnadd.Controls.Add(this.tbmail);
            this.pnadd.Controls.Add(this.tbtel);
            this.pnadd.Controls.Add(this.tbcep);
            this.pnadd.Controls.Add(this.tbend);
            this.pnadd.Controls.Add(this.tbnome);
            this.pnadd.Controls.Add(this.label11);
            this.pnadd.Controls.Add(this.label10);
            this.pnadd.Controls.Add(this.label9);
            this.pnadd.Controls.Add(this.label8);
            this.pnadd.Controls.Add(this.label7);
            this.pnadd.Controls.Add(this.pbimgadd);
            this.pnadd.Enabled = false;
            this.pnadd.Location = new System.Drawing.Point(265, 0);
            this.pnadd.Margin = new System.Windows.Forms.Padding(4);
            this.pnadd.Name = "pnadd";
            this.pnadd.Size = new System.Drawing.Size(881, 554);
            this.pnadd.TabIndex = 7;
            this.pnadd.Visible = false;
            // 
            // Fclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1147, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bdado);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bremov);
            this.Controls.Add(this.pnadd);
            this.Controls.Add(this.pndados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Fclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fcliebtes";
            this.Load += new System.EventHandler(this.Fclientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.pndados.ResumeLayout(false);
            this.pndados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbimgadd)).EndInit();
            this.pnadd.ResumeLayout(false);
            this.pnadd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bdado;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bremov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer tmatt;
        private System.Windows.Forms.TextBox tbpesq;
        private System.Windows.Forms.ListBox lvusuario;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbend;
        private System.Windows.Forms.Label lbtel;
        private System.Windows.Forms.Label lbmail;
        private System.Windows.Forms.Label lbcep;
        private System.Windows.Forms.Panel pndados;
        private System.Windows.Forms.PictureBox pbimgadd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.TextBox tbend;
        private System.Windows.Forms.TextBox tbcep;
        private System.Windows.Forms.TextBox tbtel;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.Button bconfAdd;
        private System.Windows.Forms.Button bacancelAdd;
        private System.Windows.Forms.Panel pnadd;
    }
}