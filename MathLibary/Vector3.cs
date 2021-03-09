using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibary
{
	public struct Vector3
	{
		public float x;
		public float y;
		public float z;

		//Constructors
		public Vector3(float x = 0.0f, float y = 0.0f, float z = 0.0f)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		//Operator overloading
		//V = V + V (point translated by a vector)
		public static Vector3 operator + (Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x + rhs.x;
			result.y = lhs.y + rhs.y;
			result.z = lhs.z + rhs.z;

			return result;
		}

		//V = V – V(point translated by a vector)
		public static Vector3 operator - (Vector3 lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs.x - rhs.x;
			result.y = lhs.y - rhs.y;
			result.z = lhs.z - rhs.z;

			return result;
		}

		//V = V x f (vector scale)
		public static Vector3 operator * (Vector3 lhs, float rhs)
		{
			Vector3 result;
			result.x = lhs.x * rhs;
			result.y = lhs.y * rhs;
			result.z = lhs.z * rhs;

			return result;
		}

		//V = f x V (vector scale)
		public static Vector3 operator * (float lhs, Vector3 rhs)
		{
			Vector3 result;
			result.x = lhs * rhs.x;
			result.y = lhs * rhs.y;
			result.z = lhs * rhs.z;

			return result;
		}

		//f = V.Magnitude()
		public float Magnitude()
		{
			//c^2 = sqrt(a^2 + b^2)
			return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
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
			}

		}
	}
}
