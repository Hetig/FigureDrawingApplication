using System.Reflection;

namespace FigureDrawingApplication
{
	public partial class MainForm : Form
	{
		private Graphics formGraphics;
		private PropertyInfo[] colorsList = typeof(Brushes).GetProperties();
		public MainForm()
		{
			InitializeComponent();
			MainFormInit();
		}

		private void MainForm_MouseDown(object sender, MouseEventArgs e)
		{
			if (!ValuesIsValid()) return;

			var selectedFigure = (string)selectComboBox.SelectedItem;
			var selectedWidth = int.Parse((string)widthComboBox.SelectedItem);
			var selectedHeight = int.Parse((string)heightComboBox.SelectedItem);

			var brush = typeof(Brushes).GetProperty((string)colorComboBox.SelectedItem);
			var selectedBrush = (Brush)brush.GetValue(brush);

			var xPosition = e.X - selectedWidth / 2;
			var yPosition = e.Y - selectedHeight / 2;

			Region region = new Region();
			switch (selectedFigure)
			{
				case "Ellipse":
					{
						var ellipse = new Models.Ellipse(selectedWidth, selectedHeight, xPosition, yPosition);
						region = new Region(ellipse.GraphicsPath);
						break;
					}
				case "Rectangle":
					{
						var rectangle = new Models.Rectangle(selectedWidth, selectedHeight, xPosition, yPosition);
						region = new Region(rectangle.GraphicsPath);
						break;
					}
				case "Triangle":
					{
						var triangle = new Models.Triangle(selectedWidth, selectedHeight, xPosition, yPosition);
						region = new Region(triangle.GraphicsPath);
						break;
					}
			}

			formGraphics.FillRegion(selectedBrush, region);
		}

		private bool ValuesIsValid()
		{
			if (selectComboBox.SelectedItem is null || widthComboBox.SelectedItem is null || heightComboBox.SelectedItem is null || colorComboBox.SelectedItem is null)
			{
				MessageBox.Show("Выберите значение из списка");
				return false;
			}

			return true;
		}

		private void MainFormInit()
		{
			selectComboBox.Items.AddRange(
							new string[]
							{
					"Ellipse",
					"Rectangle",
					"Triangle",
							});
			selectComboBox.SelectedIndex = 0;

			heightComboBox.Items.AddRange(
				new string[]
				{
					"10",
					"20",
					"30",
					"40",
					"50",
				});
			heightComboBox.SelectedIndex = 4;

			widthComboBox.Items.AddRange(
				new string[]
				{
					"10",
					"20",
					"30",
					"40",
					"50",
				});
			widthComboBox.SelectedIndex = 4;

			var types = typeof(Brushes).GetProperties().Select(x => x.Name).ToArray();
			colorComboBox.Items.AddRange(types);
			colorComboBox.SelectedIndex = 1;

			formGraphics = this.CreateGraphics();
		}
	}
}
