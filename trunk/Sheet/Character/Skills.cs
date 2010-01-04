using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;

namespace Sheet
{
    partial class CharacterSheet
    {
        private void LoadSkillInfo(XmlElement root)
        {
            XmlNodeList skills = root.SelectNodes("/CharacterSheet/Skills//Skill");

            foreach (XmlNode node in skills)
            {
                m_skills.Add(Util.GetNodeAttribute(node, "code"), Util.GetNodeIntData(node));
            }
        }

        public int GetSkillBonus(string code)
        {
            if(!m_skills.ContainsKey(code)) return 0;

            // 랭크 얻기
            int bonus = m_skills[code];

            // 스킬에 해당하는 능력치 보너스 추가.
            bonus += GetAbilityBonus(DataManager.Instance.SkillData[code].RelatedAbility);

            // 시너지 스킬 추가.
            foreach(KeyValuePair<KeyValuePair<string, int>, int> s in DataManager.Instance.SkillData[code].Synergy)
            {
                if (m_skills.ContainsKey(s.Key.Key)) // 시너지 스킬이 사용자의 스킬 목록에 있는가
                {
                    // m_skills는 [보유한 스킬의 코드]-[랭크]의 테이블.
                    // s는 [ [시너지 스킬의 코드]-[보너스를 받는데 필요한 요구 랭크] ] - [시너지 보너스값] 의 테이블.
                    if (m_skills[s.Key.Key] >= s.Key.Value) // 사용자의 스킬랭크가 시너지 스킬의 적용 요구치 이상인가
                        bonus += s.Value;
                }
            }

            // 기타 수정사항 추가.
            bonus += GetEffectValue("ALL_SKILL_BONUS");
			bonus += GetEffectValue(code + "_SKILL_BONUS");

            return bonus;
        }

		public void AddSkill(string skillCode, int rank)
		{
			// 해당 스킬이 이미 있을 경우 랭크를 더하고, 없으면 추가한다.
			if (m_skills.ContainsKey(skillCode))
				m_skills[skillCode] += rank;
			else
				m_skills.Add(skillCode, rank);
		}

        public KeyValuePair<string, int> GetSkill(string code)
        {
            return new KeyValuePair<string, int>(
                        DataManager.Instance.SkillData[code].Name,
                        GetSkillBonus(code)
                        );
        }
    }
}
