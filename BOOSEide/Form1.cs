using BOOSE;
using System.Diagnostics;

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
            canvas = new AppCanvas(640, 480);
            canvas.Circle(100, true);
            Factory = new CommandFactory();
            Program = new StoredProgram(canvas);
            Parser = new Parser(Factory, Program);
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Bitmap b = (Bitmap) canvas.getBitmap();
            Parser.ParseProgram("moveto 100,100\ncircle 50\ndrawto 50,50");
            Program.Run();
            g.DrawImage(b, 0, 0);
        }
    }
}
