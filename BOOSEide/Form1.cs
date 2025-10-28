using BOOSE;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace BOOSEide
{
    public partial class Form1 : Form
    {
        AppCanvas canvas;
        CommandFactory Factory;
        StoredProgram Program;
        IParser Parser;

        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(AboutBOOSE.about());
            canvas = new AppCanvas(pictureBoxCanvas);
            canvas.Circle(100, true);
            Factory = new CommandFactory();
            Program = new StoredProgram(canvas);
            Parser = new Parser(Factory, Program);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = (Bitmap)canvas.getBitmap();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string userInputBlock = booseInput.Text.Trim().ToLower();
            string[] commandLines = userInputBlock
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in commandLines)
            {
                canvas.ProcessCommand(line);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
