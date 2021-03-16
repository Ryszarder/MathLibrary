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

		//V = V – V (point translated by a vector)
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

		//f = V.Dot( V )
		public float Dot(Vector2 rhs)
		{
			return (x * rhs.x) + (y * rhs.y);
		}

		//Angle Direction
		public Vector2 GetRigthAngle()
		{
			Vector2 result;
			result.x = -y;
			result.y = x;

			return result;
		}

		//angle Direction
		public static float GetRightBetween(Vector2 lhs, Vector2 rhs)
		{
			//Get the dot product of our two vectors
			lhs.Normalise();
			rhs.Normalise();
			float fDot = lhs.Dot(rhs);

			//Get angle
			float angle = (float)Math.Acos(fDot);

			//Check which angle is clockwise or anticlockwise
			Vector2 rightangle = lhs.GetRigthAngle();
			float fRightDot = rhs.Dot(rightangle);
			if (fRightDot < 0)
				angle = angle * -1.0f;

			return angle;
		}
	}

	
}
