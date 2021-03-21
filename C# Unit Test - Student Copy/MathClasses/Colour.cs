using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
	public class Colour
	{
		public uint colour = 0;

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
			colour = colour & 0xFF000000;
			colour = colour | (uint)(red << 24);
		}

		public byte GetRed()
		{
			return (byte)(colour >> 24);
		}

		//Green
		public void SetGreen(byte green)
		{
			colour = colour & 0x00FF0000;
			colour = colour | (uint)(green << 16);
		}

		public byte GetGreen()
		{
			return (byte)((colour << 8) >> 24);
		}

		//Blue
		public void SetBlue(byte blue)
		{
			colour = colour & 0x0000FF00;
			colour = colour | (uint)(blue << 8);
		}

		public byte GetBlue()
		{
			return (byte)(colour >> 8);
		}

		//Alpha
		public void SetAlpha(byte Alpha)
		{
			colour = colour & 0x000000FF;
			colour = colour | (uint)(Alpha);
		}

		public byte GetAlpha()
		{
			return (byte)((colour << 24) >> 24);
		}
	}
}
