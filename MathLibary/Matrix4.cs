using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibary
{
	struct Matrix4
	{
		public float[] m;

		public Matrix4(bool bDefault = true)
		{
			m = new float[16];
			m[0] = 1;
			m[1] = 0;
			m[2] = 0;
			m[3] = 0;
			m[4] = 0;
			m[5] = 1;
			m[6] = 0;
			m[7] = 0;
			m[8] = 0;
			m[9] = 0;
			m[10] = 1;
			m[11] = 0;
			m[12] = 0;
			m[13] = 0;
			m[14] = 0;
			m[15] = 1;
		}

		public Matrix4(float m0, float m1, float m2,
						float m3, float m4, float m5,
						float m6, float m7, float m8,
						float m9, float m10, float m11,
						float m12, float m13, float m14,
						float m15)
		{
			m = new float[9];
			m[0] = m0;
			m[1] = m1;
			m[2] = m2;
			m[3] = m3;
			m[4] = m4;
			m[5] = m5;
			m[6] = m6;
			m[7] = m7;
			m[8] = m8;
			m[9] = m9;
			m[10] = m10;
			m[11] = m11;
			m[12] = m12;
			m[13] = m13;
			m[14] = m14;
			m[15] = m15;
		}

		//V = M x V (vector transformation)
		public static Vector4 operator *(Matrix4 lhs, Vector4 rhs)
		{
			Vector4 result;

			result.x = (lhs.m[0] * rhs.x) + (lhs.m[4] * rhs.y) + (lhs.m[8] * rhs.z) + (lhs.m[12] * rhs.w);
			result.y = (lhs.m[1] * rhs.x) + (lhs.m[5] * rhs.y) + (lhs.m[9] * rhs.z) + (lhs.m[13] * rhs.w);
			result.z = (lhs.m[2] * rhs.x) + (lhs.m[6] * rhs.y) + (lhs.m[10] * rhs.z) + (lhs.m[14] * rhs.w);
			result.w = (lhs.m[3] * rhs.x) + (lhs.m[7] * rhs.y) + (lhs.m[11] * rhs.z) + (lhs.m[15] * rhs.w);

			return result;
		}

		//M = M x M (matrix concatenation)
		public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
		{
			Matrix4 result = new Matrix4();

			result.m[0] = (lhs.m[0] * rhs.m[0]) + (lhs.m[4] * rhs.m[1]) + (lhs.m[8] * rhs.m[2]) + (lhs.m[12] * rhs.m[3]);
			result.m[1] = (lhs.m[1] * rhs.m[0]) + (lhs.m[5] * rhs.m[1]) + (lhs.m[9] * rhs.m[2]) + (lhs.m[13] * rhs.m[3]);
			result.m[2] = (lhs.m[2] * rhs.m[0]) + (lhs.m[6] * rhs.m[1]) + (lhs.m[10] * rhs.m[2]) + (lhs.m[14] * rhs.m[3]);
			result.m[3] = (lhs.m[3] * rhs.m[0]) + (lhs.m[7] * rhs.m[1]) + (lhs.m[11] * rhs.m[2]) + (lhs.m[15] * rhs.m[3]);

			result.m[4] = (lhs.m[0] * rhs.m[4]) + (lhs.m[4] * rhs.m[5]) + (lhs.m[8] * rhs.m[6]) + (lhs.m[12] * rhs.m[7]);
			result.m[5] = (lhs.m[1] * rhs.m[4]) + (lhs.m[5] * rhs.m[5]) + (lhs.m[9] * rhs.m[6]) + (lhs.m[13] * rhs.m[7]);
			result.m[6] = (lhs.m[2] * rhs.m[4]) + (lhs.m[6] * rhs.m[5]) + (lhs.m[10] * rhs.m[6]) + (lhs.m[14] * rhs.m[7]);
			result.m[7] = (lhs.m[3] * rhs.m[4]) + (lhs.m[7] * rhs.m[5]) + (lhs.m[11] * rhs.m[6]) + (lhs.m[15] * rhs.m[7]);

			result.m[8] = (lhs.m[0] * rhs.m[8]) + (lhs.m[4] * rhs.m[9]) + (lhs.m[8] * rhs.m[10]) + (lhs.m[12] * rhs.m[11]);
			result.m[9] = (lhs.m[1] * rhs.m[8]) + (lhs.m[5] * rhs.m[9]) + (lhs.m[9] * rhs.m[10]) + (lhs.m[13] * rhs.m[11]);
			result.m[10] = (lhs.m[2] * rhs.m[8]) + (lhs.m[6] * rhs.m[9]) + (lhs.m[10] * rhs.m[10]) + (lhs.m[14] * rhs.m[11]);
			result.m[11] = (lhs.m[3] * rhs.m[8]) + (lhs.m[7] * rhs.m[9]) + (lhs.m[11] * rhs.m[10]) + (lhs.m[15] * rhs.m[11]);

			result.m[12] = (lhs.m[0] * rhs.m[12]) + (lhs.m[4] * rhs.m[13]) + (lhs.m[8] * rhs.m[14]) + (lhs.m[12] * rhs.m[15]);
			result.m[13] = (lhs.m[1] * rhs.m[12]) + (lhs.m[5] * rhs.m[13]) + (lhs.m[9] * rhs.m[14]) + (lhs.m[13] * rhs.m[15]);
			result.m[14] = (lhs.m[2] * rhs.m[12]) + (lhs.m[6] * rhs.m[13]) + (lhs.m[10] * rhs.m[14]) + (lhs.m[14] * rhs.m[15]);
			result.m[15] = (lhs.m[3] * rhs.m[12]) + (lhs.m[7] * rhs.m[13]) + (lhs.m[11] * rhs.m[14]) + (lhs.m[15] * rhs.m[15]);

			return result;
		}
	}
}
