using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
	public class EffectSet
	{
		public enum EffectType { active, passive }
		public enum SpecialAbilityType { extraordinary, supernatural, spellLikeAbility }

		List<Effect> m_effectList = new List<Effect>();

		EffectType m_type;
		SpecialAbilityType m_specialAbilityType;
		int m_duration;
        string m_sourceType; // 이펙트 소스의 타입(주문, 아이템, 피트 등)
		string m_sourceName; // 이펙트 소스의 이름(코드)


		public EffectType Type { get { return m_type; } }
		public SpecialAbilityType AbilityType { get { return m_specialAbilityType; } }
		public List<Effect> EffectList { get { return m_effectList; } }
        public string SourceType { get { return m_sourceType; } }
        public string SourceName { get { return m_sourceName; } }

		public EffectSet(XmlNode node)
		{
			LoadEffectSet(node);
		}

        public void SetEffectSource(string type, string name)
        {
            m_sourceType = type;
            m_sourceName = name;
        }

		public void LoadEffectSet(XmlNode node)
		{
			XmlNodeList effectSet = node.SelectNodes("./Effect");

			// 이펙트 종류 읽어오기
			string type = Util.GetNodeData(node, "./Type", false);

			if (type == string.Empty) // 종류 항목이 xml 파일 내에 없다면 패시브로 설정한다.
			{
				m_type = EffectType.passive;
			}
			else // 그렇지 않을 경우 읽어들여서 설정한다.
			{
				switch (type.ToUpper())
				{
					case "ACTIVE": m_type = EffectType.active; break;
					case "PASSIVE": m_type = EffectType.passive; break;
					default: m_type = EffectType.passive; break;
				}
			}

			// 특수능력 타입 읽어오기
			string abilityType = Util.GetNodeData(node, "./AbilityType", false);

			if (type == string.Empty) // 종류 항목이 xml 파일 내에 없다면 패시브로 설정한다.
			{
				m_type = EffectType.passive;
			}
			else // 그렇지 않을 경우 읽어들여서 설정한다.
			{
				switch (type.ToUpper())
				{
					case "EXTRAORDINARY": m_specialAbilityType = SpecialAbilityType.extraordinary; break;
					case "SUPERNATURAL": m_specialAbilityType = SpecialAbilityType.supernatural; break;
					case "SPELLLIKE_ABILITY": m_specialAbilityType = SpecialAbilityType.spellLikeAbility; break;
					default: m_specialAbilityType = SpecialAbilityType.extraordinary; break;
				}
			}

			// 각각의 이펙트 읽어오기
			foreach (XmlNode effectNode in effectSet)
			{
				m_effectList.Add(new Effect(effectNode));
			}
		}
	}
}
