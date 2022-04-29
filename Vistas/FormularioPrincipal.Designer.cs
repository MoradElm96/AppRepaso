
namespace AppRepaso.Vistas
{
    partial class FormularioPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripSplitButton();
            this.gestionarJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripSplitButton();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "Archivo";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel2.Text = "Edicion";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarJugadoresToolStripMenuItem,
            this.nuevoJugadorToolStripMenuItem});
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(76, 22);
            this.toolStripLabel3.Text = "Jugadores";
            this.toolStripLabel3.ButtonClick += new System.EventHandler(this.toolStripLabel3_ButtonClick);
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // gestionarJugadoresToolStripMenuItem
            // 
            this.gestionarJugadoresToolStripMenuItem.Name = "gestionarJugadoresToolStripMenuItem";
            this.gestionarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionarJugadoresToolStripMenuItem.Text = "Gestionar Jugadores";
            this.gestionarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.gestionarJugadoresToolStripMenuItem_Click);
            // 
            // nuevoJugadorToolStripMenuItem
            // 
            this.nuevoJugadorToolStripMenuItem.Name = "nuevoJugadorToolStripMenuItem";
            this.nuevoJugadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoJugadorToolStripMenuItem.Text = "Nuevo Jugador";
            this.nuevoJugadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoJugadorToolStripMenuItem_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem,
            this.importarToolStripMenuItem,
            this.gestionarToolStripMenuItem});
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(65, 22);
            this.toolStripLabel4.Text = "Equipos";
            this.toolStripLabel4.ButtonClick += new System.EventHandler(this.toolStripLabel4_ButtonClick);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            this.importarToolStripMenuItem.Click += new System.EventHandler(this.importarToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(29, 22);
            this.toolStripLabel5.Text = "Salir";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 466);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormularioPrincipal";
            this.Text = "FormularioPrincipal";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel4;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripLabel3;
        private System.Windows.Forms.ToolStripMenuItem gestionarJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJugadorToolStripMenuItem;
    }
}