using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
	partial class CharacterSheet
	{
        // 코드에 해당하는 능력치 값 반환
        public int GetAbility(string code)
        {
            switch (code.ToUpper())
            {
                case "STR": return GetStr();
                case "DEX": return GetDex();
                case "CON": return GetCon();
                case "INT": return GetInt();
                case "WIS": return GetWis();
                case "Cha": return GetCha();
                default: return 0;
            }
        }

        // 코드에 해당하는 능력치 보너스 반환
        public int GetAbilityBonus(string code)
        {
            switch (code.ToUpper())
            {
                case "STR": return GetStrBonus();
                case "DEX": return GetDexBonus();
                case "CON": return GetConBonus();
                case "INT": return GetIntBonus();
                case "WIS": return GetWisBonus();
                case "Cha": return GetChaBonus();
                default: return 0;
            }
        }

		#region 힘
		public int GetStr()
		{
			int str = m_baseStr;
			str += GetEffectValue("STR_BONUS");
			return str;
		}

		public int GetStrBonus()
		{
			return GetStr() / 2 - 5;
		}
		#endregion

		#region 민첩
		public int GetDex()
		{
			int dex = m_baseDex;
			dex += GetEffectValue("DEX_BONUS");
			return dex;
		}

		public int GetDexBonus()
		{
			return GetDex() / 2 - 5;
		}
		#endregion

		#region 건강
		public int GetCon()
		{
			int con = m_baseCon;
			con += GetEffectValue("CON_BONUS");
			return con;
		}

		public int GetConBonus()
		{
			return GetCon() / 2 - 5;
		}
		#endregion

		#region 지능
		public int GetInt()
		{
			int intellience = m_baseInt;
			intellience += GetEffectValue("INT_BONUS");
			return intellience;
		}

		public int GetIntBonus()
		{
			return GetInt() / 2 - 5;
		}
		#endregion

		#region 지혜
		public int GetWis()
		{
			int wis = m_baseWis;
			wis += GetEffectValue("WIS_BONUS");
			return wis;
		}

		public int GetWisBonus()
		{
			return GetWis() / 2 - 5;
		}
		#endregion

		#region 매력
		public int GetCha()
		{
			int cha = m_baseCha;
			cha += GetEffectValue("CHA_BONUS");
			return cha;
		}

		public int GetChaBonus()
		{
			return GetCha() / 2 - 5;
		}
		#endregion

		private void LoadAbilityInfo(XmlElement root)
		{
			m_baseStr = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Strength");
			m_baseDex = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Dexterity");
			m_baseCon = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Constitution");
			m_baseInt = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Intelligence");
			m_baseWis = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Wisdom");
			m_baseCha = Util.GetNodeIntData(root, "/CharacterSheet/Ability/Charisma");
		}
	}
}
