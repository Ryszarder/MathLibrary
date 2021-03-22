using System;
using System.Collections.Generic;
using System.Text;

namespace MathClasses
{
	public class Colour
	{
		private uint colour = 0;

		public Colour()
		{

		}

		public Colour(byte red, byte green, byte blue, byte alpha)
		{
			//0x00000000
			//00 00 00 00
			//r  g  b  a
			colour = (uint)((red << 24) + (green << 16) + (blue << 8) + alpha);
		}

		//Red
		public void SetRed(byte red)
		{
			colour = colour & 0x00FFFFFF;
			colour = colour | (uint)(red << 24);
		}

		public byte GetRed()
		{
			return (byte)(colour >> 24);
		}

		//Green
		public void SetGreen(byte green)
		{
			colour = colour & 0xFF00FFFF;
			colour = colour | (uint)(green << 16);
		}

		public byte GetGreen()
		{
			return (byte)((colour << 8) >> 24);
		}

		//Blue
		public void SetBlue(byte blue)
		{
			colour = colour & 0xFFFF00FF;
			colour = colour | (uint)(blue << 8);
		}

		public byte GetBlue()
		{
			return (byte)(colour >> 8);
		}

		//Alpha
		public void SetAlpha(byte Alpha)
		{
			colour = colour & 0xFFFFFF00;
			colour = colour | (uint)(Alpha);
		}

		public byte GetAlpha()
		{
			return (byte)((colour << 24) >> 24);
		}
	}
}
