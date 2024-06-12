
namespace Trabalho___PIM
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroFrutas = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasFrutas = new System.Windows.Forms.ToolStripMenuItem();
            this.verdurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroVerduras = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasVerduras = new System.Windows.Forms.ToolStripMenuItem();
            this.legumesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroLegumes = new System.Windows.Forms.ToolStripMenuItem();
            this.VendasLegumes = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(665, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frutasToolStripMenuItem,
            this.verdurasToolStripMenuItem,
            this.legumesToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.arquivoToolStripMenuItem.Text = "Produção";
            // 
            // frutasToolStripMenuItem
            // 
            this.frutasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroFrutas,
            this.VendasFrutas});
            this.frutasToolStripMenuItem.Name = "frutasToolStripMenuItem";
            this.frutasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.frutasToolStripMenuItem.Text = "Frutas";
            // 
            // RegistroFrutas
            // 
            this.RegistroFrutas.Name = "RegistroFrutas";
            this.RegistroFrutas.Size = new System.Drawing.Size(117, 22);
            this.RegistroFrutas.Text = "Registro";
            this.RegistroFrutas.Click += new System.EventHandler(this.RegistroFrutas_Click);
            // 
            // VendasFrutas
            // 
            this.VendasFrutas.Name = "VendasFrutas";
            this.VendasFrutas.Size = new System.Drawing.Size(117, 22);
            this.VendasFrutas.Text = "Vendas";
            this.VendasFrutas.Click += new System.EventHandler(this.VendasFrutas_Click);
            // 
            // verdurasToolStripMenuItem
            // 
            this.verdurasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroVerduras,
            this.VendasVerduras});
            this.verdurasToolStripMenuItem.Name = "verdurasToolStripMenuItem";
            this.verdurasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.verdurasToolStripMenuItem.Text = "Verduras";
            // 
            // RegistroVerduras
            // 
            this.RegistroVerduras.Name = "RegistroVerduras";
            this.RegistroVerduras.Size = new System.Drawing.Size(117, 22);
            this.RegistroVerduras.Text = "Registro";
            this.RegistroVerduras.Click += new System.EventHandler(this.RegistroVerduras_Click);
            // 
            // VendasVerduras
            // 
            this.VendasVerduras.Name = "VendasVerduras";
            this.VendasVerduras.Size = new System.Drawing.Size(117, 22);
            this.VendasVerduras.Text = "Vendas";
            this.VendasVerduras.Click += new System.EventHandler(this.VendasVerduras_Click);
            // 
            // legumesToolStripMenuItem
            // 
            this.legumesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroLegumes,
            this.VendasLegumes});
            this.legumesToolStripMenuItem.Name = "legumesToolStripMenuItem";
            this.legumesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.legumesToolStripMenuItem.Text = "Legumes";
            // 
            // RegistroLegumes
            // 
            this.RegistroLegumes.Name = "RegistroLegumes";
            this.RegistroLegumes.Size = new System.Drawing.Size(117, 22);
            this.RegistroLegumes.Text = "Registro";
            this.RegistroLegumes.Click += new System.EventHandler(this.RegistroLegumes_Click);
            // 
            // VendasLegumes
            // 
            this.VendasLegumes.Name = "VendasLegumes";
            this.VendasLegumes.Size = new System.Drawing.Size(117, 22);
            this.VendasLegumes.Text = "Vendas";
            this.VendasLegumes.Click += new System.EventHandler(this.VendasLegumes_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Trabalho___PIM.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(665, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Green";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem legumesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegistroFrutas;
        private System.Windows.Forms.ToolStripMenuItem VendasFrutas;
        private System.Windows.Forms.ToolStripMenuItem RegistroVerduras;
        private System.Windows.Forms.ToolStripMenuItem RegistroLegumes;
        private System.Windows.Forms.ToolStripMenuItem VendasVerduras;
        private System.Windows.Forms.ToolStripMenuItem VendasLegumes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}