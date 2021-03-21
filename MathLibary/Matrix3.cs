using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
	public struct Matrix3
	{
		public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

		public Matrix3(bool bDefault)
		{
			m1 = 1; m2 = 0; m3 = 0;
			m4 = 0; m5 = 1; m6 = 0;
			m7 = 0; m8 = 0; m9 = 1;
		}

		public Matrix3(float m1, float m2, float m3,
						float m4, float m5, float m6,
						float m7, float m8, float m9)
		{
			this.m1 = m1;
			this.m2 = m2;
			this.m3 = m3;
			this.m4 = m4;
			this.m5 = m5;
			this.m6 = m6;
			this.m7 = m7;
			this.m8 = m8;
			this.m9 = m9;
		}


		//V = M x V (vector transformation)
		public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
		{
			Vector3 result;

			result.x = (lhs.m1 * rhs.x) + (lhs.m4 * rhs.y) + (lhs.m7 * rhs.z);
			result.y = (lhs.m2 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m8 * rhs.z);
			result.z = (lhs.m3 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m9 * rhs.z);

			return result;
		}

		//M = M x M (matrix concatenation)
		public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
		{
			Matrix3 result = new Matrix3();

			result.m1 = (lhs.m1 * rhs.m1) + (lhs.m4 * rhs.m2) + (lhs.m7 * rhs.m3);
			result.m2 = (lhs.m2 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m8 * rhs.m3);
			result.m3 = (lhs.m3 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m9 * rhs.m3);

			result.m4 = (lhs.m1 * rhs.m4) + (lhs.m4 * rhs.m5) + (lhs.m7 * rhs.m6);
			result.m5 = (lhs.m2 * rhs.m4) + (lhs.m5 * rhs.m5) + (lhs.m8 * rhs.m6);
			result.m6 = (lhs.m3 * rhs.m4) + (lhs.m6 * rhs.m5) + (lhs.m9 * rhs.m6);

			result.m7 = (lhs.m1 * rhs.m7) + (lhs.m4 * rhs.m8) + (lhs.m7 * rhs.m9);
			result.m8 = (lhs.m2 * rhs.m7) + (lhs.m5 * rhs.m8) + (lhs.m8 * rhs.m9);
			result.m9 = (lhs.m3 * rhs.m7) + (lhs.m6 * rhs.m8) + (lhs.m9 * rhs.m9);

			return result;
		}

		//set the vaule of the floats
		public void Identity()
		{
			m1 = 1; m2 = 0; m3 = 0;
			m4 = 0; m5 = 1; m6 = 0;
			m7 = 0; m8 = 0; m9 = 1;
		}

		//SetRotateX( f )
		public void SetRotateX(float fRadians)
		{
			Identity();

			m5 = (float)Math.Cos(fRadians);
			m6 = (float)Math.Sin(fRadians);
			m8 = (float)-Math.Sin(fRadians);
			m9 = (float)Math.Cos(fRadians);
		}

		//SetRotateY( f )
		public void SetRotateY(float fRadians)
		{
			Identity();

			m1 = (float)Math.Cos(fRadians);
			m3 = (float)-Math.Sin(fRadians);
			m7 = (float)Math.Sin(fRadians);
			m9 = (float)Math.Cos(fRadians);
		}

		//SetRotateZ( f )
		public void SetRotateZ(float fRadians)
		{
			Identity();

			m1 = (float)Math.Cos(fRadians);
			m2 = (float)Math.Sin(fRadians);
			m4 = (float)-Math.Sin(fRadians);
			m5 = (float)Math.Cos(fRadians);
		}

		//SetTranslation( f )
		public void SetTranslation(float x, float y)
		{
			m7 = x;
			m8 = y;
		}

		//SetTranslation( V )
		public void SetTranslation(Vector3 pos)
		{
			m7 = pos.x;
			m8 = pos.y;
		}

		//SetScale( f )
		public void SetScale(float x, float y)
		{
			m1 = x;
			m5 = y;
		}

		//SetScale( V )
		public void SetScale(Vector3 scale)
		{
			m1 = scale.x;
			m5 = scale.y;
		}
	}
}
