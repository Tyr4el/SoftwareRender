using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRenderer
{
	struct Vector2
	{
		public float x, y;

		public static Vector2 Min(Vector2 a, Vector2 b)
		{
			return new Vector2 { x = Math.Min(a.x, b.x), y = Math.Min(a.y, b.y) };
		}

		public static Vector2 Max(Vector2 a, Vector2 b)
		{
			return new Vector2 { x = Math.Max(a.x, b.x), y = Math.Max(a.y, b.y) };
		}

	}
}
