using System.Drawing.Drawing2D;

namespace FigureDrawingApplication.Models
{
	public class Triangle : Figure
	{
		public Triangle(float width, float height, float x, float y) : base(width, height)
		{
			PointF[] trianglePoints = new PointF[]
			{
				new PointF(x, y - height / 2),
				new PointF(x - width / 2, y + height / 2),
				new PointF(x + width / 2, y + height / 2),
			};

			GraphicsPath = new GraphicsPath();
			GraphicsPath.AddPolygon(trianglePoints);
		}
	}
}
