using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
	public struct Matrix4
	{
		public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

		public Matrix4(bool bDefault = true)
		{
			m1 = 1; m2 = 0; m3 = 0; m4 = 0;
			m5 = 0; m6 = 1; m7 = 0; m8 = 0;
			m9 = 0; m10 = 0; m11 = 1; m12 = 0;
			m13 = 0; m14 = 0; m15 = 0; m16 = 1;
		}

		public Matrix4(float m1, float m2, float m3, float m4,
						float m5, float m6, float m7, float m8,
						float m9, float m10, float m11, float m12,
						float m13, float m14, float m15, float m16)
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
			this.m10 = m10;
			this.m11 = m11;
			this.m12 = m12;
			this.m13 = m13;
			this.m14 = m14;
			this.m15 = m15;
			this.m16 = m16;
		}

		//V = M x V (vector transformation)
		public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
		{
			Vector4 result;

			result.x = (lhs.m1 * rhs.x) + (lhs.m5 * rhs.y) + (lhs.m9 * rhs.z) + (lhs.m13 * rhs.w);
			result.y = (lhs.m2 * rhs.x) + (lhs.m6 * rhs.y) + (lhs.m10 * rhs.z) + (lhs.m14 * rhs.w);
			result.z = (lhs.m3 * rhs.x) + (lhs.m7 * rhs.y) + (lhs.m11 * rhs.z) + (lhs.m15 * rhs.w);
			result.w = (lhs.m4 * rhs.x) + (lhs.m8 * rhs.y) + (lhs.m12 * rhs.z) + (lhs.m16 * rhs.w);

			return result;
		}

		//M = M x M (matrix concatenation)
		public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
		{
			Matrix4 result = new Matrix4();

			result.m1 = (lhs.m1 * rhs.m1) + (lhs.m5 * rhs.m2) + (lhs.m9 * rhs.m3) + (lhs.m13 * rhs.m4);
			result.m2 = (lhs.m2 * rhs.m1) + (lhs.m6 * rhs.m2) + (lhs.m10 * rhs.m3) + (lhs.m14 * rhs.m4);
			result.m3 = (lhs.m3 * rhs.m1) + (lhs.m7 * rhs.m2) + (lhs.m11 * rhs.m3) + (lhs.m15 * rhs.m4);
			result.m4 = (lhs.m4 * rhs.m1) + (lhs.m8 * rhs.m2) + (lhs.m12 * rhs.m3) + (lhs.m16 * rhs.m4);

			result.m5 = (lhs.m1 * rhs.m5) + (lhs.m5 * rhs.m6) + (lhs.m9 * rhs.m7) + (lhs.m13 * rhs.m8);
			result.m6 = (lhs.m2 * rhs.m5) + (lhs.m6 * rhs.m6) + (lhs.m10 * rhs.m7) + (lhs.m14 * rhs.m8);
			result.m7 = (lhs.m3 * rhs.m5) + (lhs.m7 * rhs.m6) + (lhs.m11 * rhs.m7) + (lhs.m15 * rhs.m8);
			result.m8 = (lhs.m4 * rhs.m5) + (lhs.m8 * rhs.m6) + (lhs.m12 * rhs.m7) + (lhs.m16 * rhs.m8);

			result.m9 = (lhs.m1 * rhs.m9) + (lhs.m5 * rhs.m10) + (lhs.m9 * rhs.m11) + (lhs.m13 * rhs.m12);
			result.m10 = (lhs.m2 * rhs.m9) + (lhs.m6 * rhs.m10) + (lhs.m10 * rhs.m11) + (lhs.m14 * rhs.m12);
			result.m11 = (lhs.m3 * rhs.m9) + (lhs.m7 * rhs.m10) + (lhs.m11 * rhs.m11) + (lhs.m15 * rhs.m12);
			result.m12 = (lhs.m4 * rhs.m9) + (lhs.m8 * rhs.m10) + (lhs.m12 * rhs.m11) + (lhs.m16 * rhs.m12);

			result.m13 = (lhs.m1 * rhs.m13) + (lhs.m5 * rhs.m14) + (lhs.m9 * rhs.m15) + (lhs.m13 * rhs.m16);
			result.m14 = (lhs.m2 * rhs.m13) + (lhs.m6 * rhs.m14) + (lhs.m10 * rhs.m15) + (lhs.m14 * rhs.m16);
			result.m15 = (lhs.m3 * rhs.m13) + (lhs.m7 * rhs.m14) + (lhs.m11 * rhs.m15) + (lhs.m15 * rhs.m16);
			result.m16 = (lhs.m4 * rhs.m13) + (lhs.m8 * rhs.m14) + (lhs.m12 * rhs.m15) + (lhs.m16 * rhs.m16);

			return result;
		}

		//set the vaule of the floats
		public void Identity()
		{
			m1 = 1; m2 = 0; m3 = 0; m4 = 0;
			m5 = 0; m6 = 1; m7 = 0; m8 = 0;
			m9 = 0; m10 = 0; m11 = 1; m12 = 0;
			m13 = 0; m14 = 0; m15 = 0; m16 = 1;
		}

		//SetRotateX( f )
		public void SetRotateX(float fRadians)
		{
			Identity();

			m6 = (float)Math.Cos(fRadians);
			m7 = (float)Math.Sin(fRadians);
			m10 = (float)-Math.Sin(fRadians);
			m11 = (float)Math.Cos(fRadians);
		}
		//SetRotateY( f )
		public void SetRotateY(float fRadians)
		{
			Identity();

			m1 = (float)Math.Cos(fRadians);
			m3 = (float)-Math.Sin(fRadians);
			m9 = (float)Math.Sin(fRadians);
			m11 = (float)Math.Cos(fRadians);
		}

		//SetRotateZ( f )
		public void SetRotateZ(float fRadians)
		{
			Identity();

			m1 = (float)Math.Cos(fRadians);
			m2 = (float)Math.Sin(fRadians);
			m5 = (float)-Math.Sin(fRadians);
			m6 = (float)Math.Cos(fRadians);
		}

		//SetTranslation( f )
		public void SetTranslation(float x, float y, float z)
		{
			m13 = x;
			m14 = y;
			m15 = z;
		}

		//SetTranslation( V )
		public void SetTranslation(Vector4 pos)
		{
			m13 = pos.x;
			m14 = pos.y;
			m15 = pos.z;
		}

		//SetScale( f )
		public void SetScale(float x, float y, float z)
		{
			m1 = x;
			m6 = y;
			m11 = z;
		}

		//SetScale( V )
		public void SetScale(Vector4 scale)
		{
			m1 = scale.x;
			m6 = scale.y;
			m11 = scale.z;
		}

	}
}
