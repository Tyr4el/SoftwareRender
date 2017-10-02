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
					var w0 = OrientEdge(a, b, p);
					var w1 = OrientEdge(b, c, p);
					var w2 = OrientEdge(c, a, p);

					if (w0 >= 0 && w1 >= 0 && w2 >= 0)
					{
						targetImage.SetPixel((int)p.x, (int)p.y, Color.Red);
					}
				}
			}
		}

		float OrientEdge(Vector2 a, Vector2 b, Vector2 c)
		{
			return (b.x - a.x) * (c.y - a.y) - (b.y - a.y) * (c.x - a.x);
		}
	}
}
