using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
	public class Dice
	{
		int m_count = 0; // 다이스 갯수
		int m_sides = 0; // 다이스 면 수
		int m_modifier = 0; // 수정치

		static Random r = new Random();

		public int Value 
		{ 
			get { return Roll(); }
			set { m_modifier = value; }
		}

		public Dice(int count, int sides, int modifier)
		{
			m_count = count;
			m_sides = sides;
			m_modifier = modifier;
		}

		public Dice(string expression)
		{

		}

		public Dice(int value)
		{
			m_modifier = value;
		}

		public int Roll()
		{
			int result = 0;
			for (int i = 0; i < m_count; i++)
				result += r.Next(1, m_sides);
			return result;
		}
	}
}
