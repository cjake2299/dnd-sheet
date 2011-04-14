using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
    partial class CharacterSheet
    {
        public int GetBAB()
        {
            int BAB = 0;

            Dictionary<string, int> levels = GetLevelInfo();

            foreach (KeyValuePair<string, int> level in levels)
            {
                ClassInfo.ClassBABType BABType = DataManager.Instance.ClassData[level.Key].BABType;
                BAB += GetBAB(BABType, level.Value);
            }

            return BAB;
        }

        public int GetBAB(ClassInfo.ClassBABType BABType, int level)
        {
            switch (BABType)
            {
                case ClassInfo.ClassBABType.Good: return level * 1;
                case ClassInfo.ClassBABType.Average: return level * 3 / 4;
                case ClassInfo.ClassBABType.Poor: return level / 2;
                default:
                    // 예외처리
                    LogManager.Instance.AddLog("캐릭터 BAB 계산", ErrorLog.LogType.Warning,
                                                    "정의되지 않은 BAB 타입입니다", "");
                    return 0;
            }
        }

		public int GetGrappleBonus()
		{
			int bonus = GetBAB();
			bonus += GetStrBonus(); // 힘보너스를 더한다.
			bonus += GetEffectValue("GRAPPLE_BONUS"); // 그래플 수정치에 영향을 주는 이펙트를 활성화된 이펙트 목록에서 검색한다.

			return bonus;
		}

        public int GetAttack()
        {
			int atk = GetBAB();
			atk += GetStrBonus(); // 힘보너스를 더한다.
			atk += GetEffectValue("ATTACK_BONUS"); // 명중보너스에 영향을 주는 이펙트를 활성화된 이펙트 목록에서 검색한다.
			atk += GetEffectValue("WEAPON_ATTACK_BONUS"); // 무기의 명중보너스도 일단 그냥 명중보너스에 추가한다.

			return atk;
        }

		public string GetAttackDescription()
		{
			return "+" + GetAttack().ToString();
		}

		public int[] GetFullAttack()
		{
			List<int> fullAttack = new List<int>();
			int atk = GetAttack();

			for (int i = 0; i <= GetBAB() / 5; i++)
			{
				fullAttack.Add(atk);
				atk -= 5;
			}

			return fullAttack.ToArray();
		}

		public string GetFullAttackDescription()
		{
			string desc = string.Empty;
			int[] fullAttack = GetFullAttack();

			foreach(int atk in fullAttack)
			{
				desc += "+" + atk.ToString() + " / ";
			}

			return desc;
		}
    }
}
