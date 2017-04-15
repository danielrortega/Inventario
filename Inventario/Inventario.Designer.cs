namespace Inventario
{
    partial class Inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.txtInputCodigo = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblMedidas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrontal = new System.Windows.Forms.TextBox();
            this.txtAdesivo = new System.Windows.Forms.TextBox();
            this.txtLiner = new System.Windows.Forms.TextBox();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.txtEspecificacao = new System.Windows.Forms.TextBox();
            this.txtFabricacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem2);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            this.menuItem1.Text = "Opções";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Visualização em Grade";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Produtos não lançados";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Sair";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // txtInputCodigo
            // 
            this.txtInputCodigo.Location = new System.Drawing.Point(13, 246);
            this.txtInputCodigo.Name = "txtInputCodigo";
            this.txtInputCodigo.Size = new System.Drawing.Size(178, 23);
            this.txtInputCodigo.TabIndex = 2;
            this.txtInputCodigo.Text = "1710";
            this.txtInputCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputCodigo_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(200, 247);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(24, 20);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.BackColor = System.Drawing.Color.Black;
            this.lblNumero.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(13, 29);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(211, 31);
            this.lblNumero.Text = "1125";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMedidas
            // 
            this.lblMedidas.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblMedidas.Location = new System.Drawing.Point(3, 60);
            this.lblMedidas.Name = "lblMedidas";
            this.lblMedidas.Size = new System.Drawing.Size(232, 20);
            this.lblMedidas.Text = "1000 mm x 1000 m";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.Text = "Dt:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 42);
            this.label2.Text = "Espec:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.Text = "Fab:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.Text = "Li:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.Text = "Fr:";
            // 
            // txtFrontal
            // 
            this.txtFrontal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFrontal.Location = new System.Drawing.Point(28, 83);
            this.txtFrontal.Name = "txtFrontal";
            this.txtFrontal.ReadOnly = true;
            this.txtFrontal.Size = new System.Drawing.Size(209, 22);
            this.txtFrontal.TabIndex = 20;
            this.txtFrontal.Text = "BOPP Branco Fosco 55g/m²";
            // 
            // txtAdesivo
            // 
            this.txtAdesivo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdesivo.Location = new System.Drawing.Point(28, 106);
            this.txtAdesivo.Name = "txtAdesivo";
            this.txtAdesivo.ReadOnly = true;
            this.txtAdesivo.Size = new System.Drawing.Size(209, 22);
            this.txtAdesivo.TabIndex = 35;
            this.txtAdesivo.Text = "Borracha Permanente 30 g/m²";
            // 
            // txtLiner
            // 
            this.txtLiner.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtLiner.Location = new System.Drawing.Point(28, 129);
            this.txtLiner.Name = "txtLiner";
            this.txtLiner.ReadOnly = true;
            this.txtLiner.Size = new System.Drawing.Size(209, 22);
            this.txtLiner.TabIndex = 36;
            this.txtLiner.Text = "Glassine Translúcido 60 g/m²";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFabricante.Location = new System.Drawing.Point(28, 152);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.ReadOnly = true;
            this.txtFabricante.Size = new System.Drawing.Size(209, 22);
            this.txtFabricante.TabIndex = 37;
            this.txtFabricante.Text = "Fasson";
            // 
            // txtEspecificacao
            // 
            this.txtEspecificacao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtEspecificacao.Location = new System.Drawing.Point(28, 175);
            this.txtEspecificacao.Multiline = true;
            this.txtEspecificacao.Name = "txtEspecificacao";
            this.txtEspecificacao.ReadOnly = true;
            this.txtEspecificacao.Size = new System.Drawing.Size(209, 41);
            this.txtEspecificacao.TabIndex = 38;
            this.txtEspecificacao.Text = "Térmico 3 barreiras Fibria 22gs acrílico glassine 60(Liner Fino)";
            // 
            // txtFabricacao
            // 
            this.txtFabricacao.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtFabricacao.Location = new System.Drawing.Point(28, 217);
            this.txtFabricacao.Name = "txtFabricacao";
            this.txtFabricacao.ReadOnly = true;
            this.txtFabricacao.Size = new System.Drawing.Size(209, 22);
            this.txtFabricacao.TabIndex = 39;
            this.txtFabricacao.Text = "Fabricado em 22/06/2012";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.txtFabricacao);
            this.Controls.Add(this.txtEspecificacao);
            this.Controls.Add(this.txtFabricante);
            this.Controls.Add(this.txtLiner);
            this.Controls.Add(this.txtAdesivo);
            this.Controls.Add(this.txtFrontal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMedidas);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtInputCodigo);
            this.Menu = this.mainMenu1;
            this.Name = "Inventario";
            this.Text = "Inventário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputCodigo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblMedidas;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrontal;
        private System.Windows.Forms.TextBox txtAdesivo;
        private System.Windows.Forms.TextBox txtLiner;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.TextBox txtEspecificacao;
        private System.Windows.Forms.TextBox txtFabricacao;
    }
}

