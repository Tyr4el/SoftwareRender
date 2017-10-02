using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareRenderer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var bitmap = new Bitmap(renderFrame.Width, renderFrame.Height);

			var graphics = new GraphicsPipeline();
			graphics.RasterizeTriangle(new Vector2 { x = 25, y = 35 }, new Vector2 { x = 45, y = 20 }, new Vector2 { x = 55, y = 35 }, bitmap);

			renderFrame.Image = bitmap;
		}
	}
}
