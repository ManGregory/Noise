using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoiseWin.Helper
{
	class ControlMover
	{
		public enum Direction
		{
			Any,
			Horizontal,
			Vertical
		}

		public static void Init(Control control)
		{
			Init(control, Direction.Any);
		}

	    public static void Init(Control control, MapElement mapElement)
	    {
	        Init(control, control, Direction.Any, mapElement);
	    }

		public static void Init(Control control, Direction direction)
		{
			Init(control, control, direction);
		}

		public static void Init(Control control, Control container, Direction direction, MapElement mapElement = null)
		{
			bool dragging = false;
			Point dragStart = Point.Empty;
			control.MouseDown += delegate(object sender, MouseEventArgs e)
			{
				dragging = true;
				dragStart = new Point(e.X, e.Y);
			    if (mapElement != null)
			    {
			        mapElement.Location = dragStart;
			    }
				control.Capture = true;
			};
			control.MouseUp += delegate
			{
				dragging = false;
				control.Capture = false;
			};
			control.MouseMove += delegate(object sender, MouseEventArgs e)
			{
				if (dragging)
				{
					if (direction != Direction.Vertical)
						container.Left = Math.Max(0, e.X + container.Left - dragStart.X);
					if (direction != Direction.Horizontal)
						container.Top = Math.Max(0, e.Y + container.Top - dragStart.Y);
                    if (mapElement != null)
                    {
                        mapElement.Location = new Point(container.Left, container.Top);
                    }
				}
			};
		}
	}
}
