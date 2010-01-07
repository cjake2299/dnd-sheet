using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
	public class Item
	{
		enum EquipPart { head, eye, neck, torso, body, waist, shoulder, arms, hands, finger, feet, weapon, undefined }

        #region 멤버
        string m_code; // 아이템의 인식코드
		string m_name; // 아이템 이름
		string m_description; // 아이템 설명
		double m_cost; // 가격
		double m_weight; // 중량
		EquipPart m_part; // 착용부위
		string m_material; // 재질
		int m_currentHP; // 현재 HP
		int m_HP; // 물체의 HP
		int m_hardness; // 물체의 hardness;
		List<EffectSet> m_effects = new List<EffectSet>(); // 아이템 효과
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; }	}
        public string Name { get { return m_name; } }
		public string Description { get { return m_description; } }
		public List<EffectSet> Effects { get { return m_effects; } }
        //public EquipPart Part { get { return m_part; } }
        public string PartStr { get { return m_part.ToString(); } }
        public double Weight { get { return m_weight; } }
		public double Cost { get { return m_cost; } }
        #endregion

        public Item()
        {
            
        }

		public Item(string path)
		{
			LoadItemData(path);
		}

        static public Item GetUndefinedItem(string message)
        {
            Item undefinedItem = new Item();
            undefinedItem.m_code = "UNDEFINED_ITEM";
            undefinedItem.m_name = message;
            return undefinedItem;
        }

		public void LoadItemData(string path)
		{
			XmlDocument doc = new XmlDocument();
			XmlNode node;

			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
			if (root == null) return;
			#endregion

			#region 아이템 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper();  // 모든 코드는 대문자.
			if (m_code == string.Empty)
				return;
			#endregion

			#region 아이템 기본 정보얻기
			// 이름
			node = root.SelectSingleNode("/Item/Name/" + Setting.instance.Language);
			m_name = Util.GetNodeData(node);

			// 설명
			node = root.SelectSingleNode("/Item/Description/" + Setting.instance.Language);
			m_description = Util.GetNodeData(node);

			// 중량
			node = root.SelectSingleNode("/Item/Weight");
			m_weight = Util.GetNodeDoubleData(node);

			// HP
			node = root.SelectSingleNode("/Item/MaxHP");
			m_HP = Util.GetNodeIntData(node);
			node = root.SelectSingleNode("/Item/CurrentHP");
			m_currentHP = Util.GetNodeIntData(node);

			// hardness
			node = root.SelectSingleNode("/Item/HardNess");
			m_hardness = Util.GetNodeIntData(node);

			// 가격
			node = root.SelectSingleNode("/Item/Cost");
			m_cost = Util.GetNodeDoubleData(node);
			
			// 재질
			node = root.SelectSingleNode("/Item/Material");
			if(node != null) // 재질정보는 없어도 되므로 없을 경우 그냥 패스.
				m_material = Util.GetNodeData(node);
			

			#region 착용부위 정보 얻기
			node = root.SelectSingleNode("/Item/EquipPart");
			string partStr = Util.GetNodeData(node);

			switch (partStr.ToUpper())
			{
				case "HEAD": m_part = EquipPart.head; break;
				case "EYE": m_part = EquipPart.eye; break;
				case "NECK": m_part = EquipPart.neck; break;
				case "TORSO": m_part = EquipPart.torso; break;
				case "BODY": m_part = EquipPart.body; break;
				case "WAIST": m_part = EquipPart.waist; break;
				case "SHOULDER": m_part = EquipPart.shoulder; break;
				case "ARMS": m_part = EquipPart.arms; break;
				case "HANDS": m_part = EquipPart.head; break;
				case "FINGER": m_part = EquipPart.finger; break;
				case "FEET": m_part = EquipPart.feet; break;
				case "WEAPON": m_part = EquipPart.weapon; break;
				default: m_part = EquipPart.undefined; break;
			}
			#endregion
			#endregion

			#region 이펙트 정보 얻기
			XmlNodeList effectNodes = root.SelectNodes("/Item/Effects//EffectSet");
			foreach (XmlNode effectSetNode in effectNodes)
			{
				m_effects.Add( new EffectSet(effectSetNode, "ITEM", m_code) );
			}
			#endregion
		}
	}
}
