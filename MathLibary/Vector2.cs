using System;

namespace MathLibary
{
	public struct Vector2
	{
		public float x;
		public float y;

		//Constructors
		public Vector2(float x = 0.0f, float y = 0.0f)
		{
			this.x = x;
			this.y = y;
		}

		//Operator overloading
		//V = V + V (point translated by a vector)
		public static Vector2 operator + (Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;

			return result;
		}

		//V = V – V(point translated by a vector)
		public static Vector2 operator - (Vector2 lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;

			return result;
		}

		//V = V x f (vector scale)
		public static Vector2 operator * (Vector2 lhs, float rhs)
		{
			Vector2 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;

			return result;
		}

		//V = f x V (vector scale)
		public static Vector2 operator * (float lhs, Vector2 rhs)
		{
			Vector2 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;

			return result;
		}

		public float Magnitude()
		{
			//c^2 = sqrt(a^2 + b^2)
			return (float)Math.Sqrt((x * x) + (y * y));
		}

		//Normalise()
		public void Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
			}

		}
	}

	
}
