
namespace Estudiantes.Vista
{
    partial class MenuAplicacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEstudianteToolStripMenuItem,
            this.formularioProfesorToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formularioEstudianteToolStripMenuItem
            // 
            this.formularioEstudianteToolStripMenuItem.Name = "formularioEstudianteToolStripMenuItem";
            this.formularioEstudianteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioEstudianteToolStripMenuItem.Text = "Formulario Estudiante";
            this.formularioEstudianteToolStripMenuItem.Click += new System.EventHandler(this.formularioEstudianteToolStripMenuItem_Click);
            // 
            // formularioProfesorToolStripMenuItem
            // 
            this.formularioProfesorToolStripMenuItem.Name = "formularioProfesorToolStripMenuItem";
            this.formularioProfesorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioProfesorToolStripMenuItem.Text = "Formulario Materia";
            this.formularioProfesorToolStripMenuItem.Click += new System.EventHandler(this.formularioProfesorToolStripMenuItem_Click);
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.vistaToolStripMenuItem.Text = "Vista";
            this.vistaToolStripMenuItem.Click += new System.EventHandler(this.vistaToolStripMenuItem_Click);
            // 
            // MenuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 484);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MenuAplicacion";
            this.Text = "MenuAplicacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
    }
}