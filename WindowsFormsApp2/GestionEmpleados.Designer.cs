﻿
namespace WindowsFormsApp2
{
    partial class formInicioGT
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
            this.agregarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEmpleadosToolStripMenuItem,
            this.borrarEmpleadosToolStripMenuItem,
            this.editarEmpleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEmpleadosToolStripMenuItem
            // 
            this.agregarEmpleadosToolStripMenuItem.Name = "agregarEmpleadosToolStripMenuItem";
            this.agregarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.agregarEmpleadosToolStripMenuItem.Text = "Agregar empleados";
            this.agregarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadosToolStripMenuItem_Click);
            // 
            // borrarEmpleadosToolStripMenuItem
            // 
            this.borrarEmpleadosToolStripMenuItem.Name = "borrarEmpleadosToolStripMenuItem";
            this.borrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.borrarEmpleadosToolStripMenuItem.Text = "Borrar empleados";
            this.borrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.borrarEmpleadosToolStripMenuItem_Click);
            // 
            // editarEmpleadoToolStripMenuItem
            // 
            this.editarEmpleadoToolStripMenuItem.Name = "editarEmpleadoToolStripMenuItem";
            this.editarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.editarEmpleadoToolStripMenuItem.Text = "Editar empleado";
            this.editarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.editarEmpleadoToolStripMenuItem_Click);
            // 
            // formInicioGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formInicioGT";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEmpleadoToolStripMenuItem;
    }
}