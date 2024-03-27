using System.Drawing;

namespace SnakeGame {
    public partial class Form1 : Form {

        List<Point> snakeElements;
        Point food;

        int directionX;
        int directionY;

        int speed;


        public Form1() {
            InitializeComponent();
            
            snakeElements = new List<Point>();
            snakeElements.Add(new Point(ClientSize.Width / 2, ClientSize.Height / 2));

            food = new Point();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            Pen penSnake = new Pen(Color.Blue);
            SolidBrush snakeBrush = new SolidBrush(Color.Blue);

            Pen penFood = new Pen(Color.Red);
            SolidBrush foodBrush = new SolidBrush(Color.Red);

            for (int i = 0; i < snakeElements.Count; i++) { 
                
            }


            DrawSnakeELement(g, penSnake, snakeBrush, 0, 0, 100, 100);
            DrawFoodELement(g, penFood, foodBrush, 50, 50, 10, 10);


        }


        private void DrawSnakeELement(Graphics g, Pen pen, SolidBrush solidBrush, int px, int py, int dx, int dy) {
            g.DrawRectangle(pen, px, py, dx, dy);
            g.FillRectangle(solidBrush, px, py, dx, dy);
        }

        private void DrawFoodELement(Graphics g, Pen pen, SolidBrush solidBrush, int px, int py, int dx, int dy) {
            g.DrawEllipse(pen, px, py, dx, dy);
            g.FillEllipse(solidBrush, px, py, dx, dy);
        }



        private void Form1_Load(object sender, EventArgs e) {
        }

    }
}
