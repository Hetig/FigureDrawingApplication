using System.Drawing.Drawing2D;

namespace FigureDrawingApplication.Models
{
	public class Ellipse : Figure
	{
		public Ellipse(float width, float height, float x, float y) : base(width, height)
		{
			GraphicsPath = new GraphicsPath();
			GraphicsPath.AddEllipse(x, y, width, height);
		}
	}
}
