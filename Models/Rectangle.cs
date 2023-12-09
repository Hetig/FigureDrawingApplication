using System.Drawing.Drawing2D;

namespace FigureDrawingApplication.Models
{
	public class Rectangle : Figure
	{
		public Rectangle(float width, float height, float x, float y) : base(width, height)
		{
			RectangleF rect = new RectangleF(x, y, width, height);

			GraphicsPath = new GraphicsPath();
			GraphicsPath.AddRectangle(rect);
		}
	}
}
