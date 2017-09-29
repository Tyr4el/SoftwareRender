using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRenderer
{
	class GraphicsPipeline
	{
		public void RasterizeTriangle(Vector2 a, Vector2 b, Vector2 c, Bitmap targetImage)
		{
			var min = Vector2.Min(a, Vector2.Min(b, c));
			var max = Vector2.Max(a, Vector2.Max(b, c));

			Vector2 p;
			for (p.y = min.y; p.y <= max.y; p.y += 1)
			{
				for (p.x = min.x; p.x <= max.x; p.x += 1)
				{

				}
			}
		}
	}
}
