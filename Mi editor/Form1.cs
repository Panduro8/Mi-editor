namespace MI_EDITOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); // Limpia el contenido del RichTextBox
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Open = new OpenFileDialog();
            System.IO.StreamReader myStreamReader = null;
            //configurar el filtro para archivos de texto
            Open.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            Open.CheckFileExists = true;
            Open.Title = "Abrir archivo";
            Open.ShowDialog(this);
            try
            {
                //Este códdigo para mostrar la info en el richtextbox
                Open.OpenFile();
                myStreamReader = System.IO.File.OpenText(Open.FileName);
                richTextBox1.Text = myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SE CREA EL OBJETO SaveFileDialog para guardar el archivo
            SaveFileDialog save = new SaveFileDialog();
            System.IO.StreamWriter myStreamWriter = null;
            //AL IGUAL QUE PARA ABRIR PONEMOS FILTROS PARA GUARDAR EL ARCHIVO
            save.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            save.Title = "Guardar archivo";
            save.CheckPathExists = true;
            save.Title = "Guardar archivo";
            save.ShowDialog(this);
            try
            {
                //Este códdigo para mostrar la info en el richtextbox
                myStreamWriter = System.IO.File.AppendText(save.FileName);
                myStreamWriter.Write(richTextBox1.Text);
                myStreamWriter.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fuenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //creamos el objeto FontDialog para cambiar la fuente del texto
            FontDialog font = new FontDialog();
            //aplicamos el tipo de fuente al richtextbox
            font.Font = richTextBox1.Font;
            //se hace la validacion para que el usuario pueda cambiar la fuente
            if (font.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font.Font;
            }
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            
            if (color.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = color.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fondo = new ColorDialog();
            if (fondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = fondo.Color;
            }
        }
    }
}
