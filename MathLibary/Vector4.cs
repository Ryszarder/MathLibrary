using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibary
{
	public struct Vector4
	{
		public float x;
		public float y;
		public float z;
		public float w;

		//Constructors
		public Vector4(float x = 0.0f, float y = 0.0f, float z = 0.0f, float w = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		//Operator overloading
		//V = V + V (point translated by a vector)
		public static Vector4 operator + (Vector4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;
			result.w = lhs.w + rhs.w;

			return result;
		}

		//V = V – V(point translated by a vector)
		public static Vector4 operator - (Vector4 lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;
			result.w = lhs.w - rhs.w;

			return result;
		}

		//V = V x f (vector scale)
		public static Vector4 operator * (Vector4 lhs, float rhs)
		{
			Vector4 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;
			result.w = lhs.w * rhs;

			return result;
		}


		public static Vector4 operator * (float lhs, Vector4 rhs)
		{
			Vector4 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;
			result.w = lhs * rhs.w;

			return result;
		}

		//f = V.Magnitude()
		public float Magnitude()
		{
			//c^2 = sqrt(a^2 + b^2)
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
		}

		//Normalise()
		public void Normalise()
		{
			float magnitude = Magnitude();
			if (magnitude != 0)
			{
				x /= magnitude;
				y /= magnitude;
				z /= magnitude;
				w /= magnitude;
			}

		}

		//f = V.Dot( V )
		public float Dot(Vector4 rhs)
		{
			return (x * rhs.x) + (y * rhs.y) + (z * rhs.z) + (w * rhs.w);
		}

		//V = V.Cross( V )
		public Vector4 Cross(Vector4 rhs)
		{
			Vector4 result;
			result.x = (y * rhs.z) - (z * rhs.y);
			result.y = (z * rhs.x) - (x * rhs.z);
			result.z = (x * rhs.y) - (y * rhs.x);
			result.w = 0;

			return result;
		}
	}
}
