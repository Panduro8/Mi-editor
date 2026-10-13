namespace MI_EDITOR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            acercadeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripSeparator();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem2 = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripSeparator();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            seleccionarTodoToolStripMenuItem1 = new ToolStripMenuItem();
            borrarTodoToolStripMenuItem = new ToolStripMenuItem();
            fuenteToolStripMenuItem1 = new ToolStripMenuItem();
            fuenteToolStripMenuItem2 = new ToolStripMenuItem();
            colorFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, formatoToolStripMenuItem, fuenteToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercadeToolStripMenuItem, salirToolStripMenuItem, guardarComoToolStripMenuItem, salirToolStripMenuItem1, salirToolStripMenuItem2 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // acercadeToolStripMenuItem
            // 
            acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            acercadeToolStripMenuItem.Size = new Size(159, 22);
            acercadeToolStripMenuItem.Text = "Nuevo";
            acercadeToolStripMenuItem.Click += acercadeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(156, 6);
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(159, 22);
            guardarComoToolStripMenuItem.Text = "Abrir...";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(159, 22);
            salirToolStripMenuItem1.Text = "Guardar como...";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // salirToolStripMenuItem2
            // 
            salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            salirToolStripMenuItem2.Size = new Size(159, 22);
            salirToolStripMenuItem2.Text = "&Salir";
            salirToolStripMenuItem2.Click += salirToolStripMenuItem2_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorToolStripMenuItem, fuenteToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, seleccionarTodoToolStripMenuItem, cortarToolStripMenuItem, toolStripMenuItem1, seleccionarTodoToolStripMenuItem1, borrarTodoToolStripMenuItem });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(49, 20);
            formatoToolStripMenuItem.Text = "&Editar";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(162, 22);
            colorToolStripMenuItem.Text = "Atras";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem
            // 
            fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            fuenteToolStripMenuItem.Size = new Size(162, 22);
            fuenteToolStripMenuItem.Text = "Adelante";
            fuenteToolStripMenuItem.Click += fuenteToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(159, 6);
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(162, 22);
            pegarToolStripMenuItem.Text = "Copiarr";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(162, 22);
            seleccionarTodoToolStripMenuItem.Text = "Pegar";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(162, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 6);
            // 
            // seleccionarTodoToolStripMenuItem1
            // 
            seleccionarTodoToolStripMenuItem1.Name = "seleccionarTodoToolStripMenuItem1";
            seleccionarTodoToolStripMenuItem1.Size = new Size(162, 22);
            seleccionarTodoToolStripMenuItem1.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem1.Click += seleccionarTodoToolStripMenuItem1_Click;
            // 
            // borrarTodoToolStripMenuItem
            // 
            borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            borrarTodoToolStripMenuItem.Size = new Size(162, 22);
            borrarTodoToolStripMenuItem.Text = "Borrar todo";
            borrarTodoToolStripMenuItem.Click += borrarTodoToolStripMenuItem_Click;
            // 
            // fuenteToolStripMenuItem1
            // 
            fuenteToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fuenteToolStripMenuItem2, colorFuenteToolStripMenuItem, colorDeFondoToolStripMenuItem });
            fuenteToolStripMenuItem1.Name = "fuenteToolStripMenuItem1";
            fuenteToolStripMenuItem1.Size = new Size(55, 20);
            fuenteToolStripMenuItem1.Text = "&Fuente";
            fuenteToolStripMenuItem1.Click += fuenteToolStripMenuItem1_Click;
            // 
            // fuenteToolStripMenuItem2
            // 
            fuenteToolStripMenuItem2.Name = "fuenteToolStripMenuItem2";
            fuenteToolStripMenuItem2.Size = new Size(180, 22);
            fuenteToolStripMenuItem2.Text = "Fuente";
            fuenteToolStripMenuItem2.Click += fuenteToolStripMenuItem2_Click;
            // 
            // colorFuenteToolStripMenuItem
            // 
            colorFuenteToolStripMenuItem.Name = "colorFuenteToolStripMenuItem";
            colorFuenteToolStripMenuItem.Size = new Size(180, 22);
            colorFuenteToolStripMenuItem.Text = "Color fuente";
            colorFuenteToolStripMenuItem.Click += colorFuenteToolStripMenuItem_Click;
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(180, 22);
            colorDeFondoToolStripMenuItem.Text = "Color de fondo";
            colorDeFondoToolStripMenuItem.Click += colorDeFondoToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 428);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "EDI-TOR";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem acercadeToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private ToolStripSeparator copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator salirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem2;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem1;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private ToolStripMenuItem fuenteToolStripMenuItem1;
        private ToolStripMenuItem fuenteToolStripMenuItem2;
        private ToolStripMenuItem colorFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
    }
}
