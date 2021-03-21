using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Matrix3
    {
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;

        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

		//V = M x V (vector transformation)
		public static Vector3 operator *(Matrix3 lhs, Vector3 rhs)
		{
			Vector3 result;

			result.x = (lhs.m[0] * rhs.x) + (lhs.m[3] * rhs.y) + (lhs.m[6] * rhs.z);
			result.y = (lhs.m[1] * rhs.x) + (lhs.m[4] * rhs.y) + (lhs.m[7] * rhs.z);
			result.z = (lhs.m[2] * rhs.x) + (lhs.m[5] * rhs.y) + (lhs.m[8] * rhs.z);

			return result;
		}

		//M = M x M (matrix concatenation)
		public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
		{
			Matrix3 result = new Matrix3();

			result.m[0] = (lhs.m[0] * rhs.m[0]) + (lhs.m[3] * rhs.m[1]) + (lhs.m[6] * rhs.m[2]);
			result.m[1] = (lhs.m[1] * rhs.m[0]) + (lhs.m[4] * rhs.m[1]) + (lhs.m[7] * rhs.m[2]);
			result.m[2] = (lhs.m[2] * rhs.m[0]) + (lhs.m[5] * rhs.m[1]) + (lhs.m[8] * rhs.m[2]);

			result.m[3] = (lhs.m[0] * rhs.m[3]) + (lhs.m[3] * rhs.m[4]) + (lhs.m[6] * rhs.m[5]);
			result.m[4] = (lhs.m[1] * rhs.m[3]) + (lhs.m[4] * rhs.m[4]) + (lhs.m[7] * rhs.m[5]);
			result.m[5] = (lhs.m[2] * rhs.m[3]) + (lhs.m[5] * rhs.m[4]) + (lhs.m[8] * rhs.m[5]);

			result.m[6] = (lhs.m[0] * rhs.m[6]) + (lhs.m[3] * rhs.m[7]) + (lhs.m[6] * rhs.m[8]);
			result.m[7] = (lhs.m[1] * rhs.m[6]) + (lhs.m[4] * rhs.m[7]) + (lhs.m[7] * rhs.m[8]);
			result.m[8] = (lhs.m[2] * rhs.m[6]) + (lhs.m[5] * rhs.m[7]) + (lhs.m[8] * rhs.m[8]);

			return result;
		}

		//SetRotateX( f )
		public void SetRotateX(float fRadians)
		{
			m[4] = (float)Math.Cos(fRadians);
			m[5] = (float)Math.Sin(fRadians);
			m[7] = (float)-Math.Sin(fRadians);
			m[8] = (float)Math.Cos(fRadians);
		}

		//SetRotateY( f )
		public void SetRotateY(float fRadians)
		{
			m[0] = (float)Math.Cos(fRadians);
			m[2] = (float)-Math.Sin(fRadians);
			m[6] = (float)Math.Sin(fRadians);
			m[8] = (float)Math.Cos(fRadians);
		}

		//SetRotateZ( f )
		public void SetRotateZ(float fRadians)
		{
			m[0] = (float)Math.Cos(fRadians);
			m[1] = (float)Math.Sin(fRadians);
			m[3] = (float)-Math.Sin(fRadians);
			m[4] = (float)Math.Cos(fRadians);
		}

		//SetTranslation( f )
		public void SetTranslation(float x, float y)
		{
			m[6] = x;
			m[7] = y;
		}

		//SetTranslation( V )
		public void SetTranslation(Vector3 pos)
		{
			m[6] = pos.x;
			m[7] = pos.y;
		}

		//SetScale( f )
		public void SetScale(float x, float y)
		{
			m[0] = x;
			m[4] = y;
		}

		//SetScale( V )
		public void SetScale(Vector3 scale)
		{
			m[0] = scale.x;
			m[4] = scale.y;
		}
	}

}
}