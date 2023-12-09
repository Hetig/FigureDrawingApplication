using System.Drawing.Drawing2D;

namespace FigureDrawingApplication.Models
{
	public class Figure
	{
		public float Width { get; protected set; }
		public float Height { get; protected set; }
		public GraphicsPath GraphicsPath { get; protected set; }
		public Figure(float width, float height)
		{
			Width = width;
			Height = height;
		}
	}
}
