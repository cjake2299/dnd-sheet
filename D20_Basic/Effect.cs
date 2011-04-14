using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace D20_Basic
{
    public class Effect
    {
		/*
		// 수정치 종류
		enum ModifierType
		{
			None, // 특정 효과에 기반하지 않는 수정치. (갑옷의 기본 AC, 피트 보너스 등)
			Alclemical,
			Armor,
			Circumstance,
			Competence,
			Deflection,
			Devine,
			Dodge,
			Enhancement,
			Insight,
			Inherit,
			Luck,
			Morale,
			Base_Natural,
			Natural,
			Profane,
			Racial,
			Resistance,
			Sacred,
			Shield,
			Size
		}

		// 수정치 입력 방식
		enum ModifierInputType
		{
			Value,
			Dice,
			Input
		}
 		*/

		string m_typeCode; // 이펙트의 타입(적용되는 곳. 명중, HP, 능력치 등)
		Dice m_value; // 수정치 값.
		string m_modifierType; // 수정치(보너스) 타입

		//bool m_isStack; // 누적가능 여부

		Dictionary<string, string> m_options; // 추가정보

		#region 프로퍼티
		public string TypeCode { get { return m_typeCode; } }
		public string ModifierType { get { return m_modifierType; } }
		public int Value { get { return m_value.Roll(); } }
		public Dictionary<string, string> Options { get { return m_options; } }
		#endregion

		public Effect(XmlNode node)
		{
			LoadEffectData(node);
		}

		private void SetValue(int value)
		{

		}

		private void SetValue(Dice dice)
		{

		}

		private void SetValue(string Title, int min, int max)
		{

		}

		private bool CheckStack(string type)
		{
			if (type.ToLower() == "circumstance" ||
				type.ToLower() == "dodge")
				return true;
			else 
				return false;
		}

		public void LoadEffectData(XmlNode node)
		{
			XmlNode tmpNode;
			
			// 이펙트 적용 대상 정보 읽기
			tmpNode = node.SelectSingleNode("./Type");
			m_typeCode = Util.GetNodeData(tmpNode).ToUpper();

			// 수정치 타입 읽기
			tmpNode = node.SelectSingleNode("./ModifierType");
			m_modifierType = Util.GetNodeData(tmpNode).ToUpper();

			// 수정치 값 읽기
			tmpNode = node.SelectSingleNode("./Value");
			m_value.Value = Util.GetNodeIntData(tmpNode);
		}
    }
}
