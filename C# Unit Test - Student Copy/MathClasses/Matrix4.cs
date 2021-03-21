using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Matrix4
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
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

		//SetRotateX( f )
		public void SetRotateX(float fRadians)
		{
			m[5] = (float)Math.Cos(fRadians);
			m[6] = (float)Math.Sin(fRadians);
			m[9] = (float)-Math.Sin(fRadians);
			m[10] = (float)Math.Cos(fRadians);
		}
		//SetRotateY( f )
		public void SetRotateY(float fRadians)
		{
			m[0] = (float)Math.Cos(fRadians);
			m[2] = (float)-Math.Sin(fRadians);
			m[8] = (float)Math.Sin(fRadians);
			m[10] = (float)Math.Cos(fRadians);
		}

		//SetRotateZ( f )
		public void SetRotateZ(float fRadians)
		{
			m[0] = (float)Math.Cos(fRadians);
			m[1] = (float)Math.Sin(fRadians);
			m[4] = (float)-Math.Sin(fRadians);
			m[5] = (float)Math.Cos(fRadians);
		}

		//SetTranslation( f )
		public void SetTranslation(float x, float y, float z)
		{
			m[12] = x;
			m[13] = y;
			m[14] = z;
		}

		//SetTranslation( V )
		public void SetTranslation(Vector4 pos)
		{
			m[12] = pos.x;
			m[13] = pos.y;
			m[14] = pos.z;
		}

		//SetScale( f )
		public void SetScale(float x, float y, float z)
		{
			m[0] = x;
			m[5] = y;
			m[10] = z;
		}

		//SetScale( V )
		public void SetScale(Vector4 scale)
		{
			m[0] = scale.x;
			m[5] = scale.y;
			m[10] = scale.z;
		}

	}
}
