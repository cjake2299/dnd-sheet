using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
	partial class CharacterSheet
	{
		public int GetAC()
		{
			int ac = 10;
			ac += GetDexBonus();
			ac += GetEffectValue("AC_BONUS");
			return ac;
		}
	}
}
