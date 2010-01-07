using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
	partial class CharacterSheet
	{
		private void LoadEquipments(XmlElement root)
		{
			XmlNodeList itemNodeList = root.SelectNodes("/CharacterSheet/Equipments//Item");
			string itemCode;
            Item item;

			foreach (XmlNode itemNode in itemNodeList)
			{
				itemCode = Util.GetNodeAttribute(itemNode, "code");
                item = GetItem(itemCode);
				// 아이템을 시트의 장비 목록에 추가한다.
                m_equipments.Add(item);

				foreach (EffectSet effectSet in item.Effects)
                    m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
			}
		}

        private void LoadInventory(XmlElement root)
        {
            XmlNodeList itemNodeList = root.SelectNodes("/CharacterSheet/Inventory//Item");
            string itemCode;

            foreach (XmlNode itemNode in itemNodeList)
            {
                itemCode = Util.GetNodeAttribute(itemNode, "code");

                // 아이템을 시트의 인벤토리 아이템 목록에 추가한다.
                m_inventroy.Add(GetItem(itemCode));
            }
        }

		public Item FindInventory(string itemCode)
		{
			foreach (Item item in m_inventroy)
				if (item.Code == itemCode) return item;

			// 없을 경우 디폴트 리턴.
			return Item.GetUndefinedItem("인벤토리에 없는 아이템");
		}

		public Item FindEquipment(string itemCode)
		{
			foreach (Item item in m_equipments)
				if (item.Code == itemCode) return item;

			// 없을 경우 디폴트 리턴.
			return Item.GetUndefinedItem("인벤토리에 없는 아이템");
		}

        public void EquipItem(string itemCode)
        {
			Item item = FindInventory(itemCode);
            // 해당 아이템이 인벤토리에 없으면 그냥 리턴.
            if (item.Code == "UNDEFINED_ITEM") return;

            // 아이템 장비
            m_equipments.Add(item);

            // 아이템 이팩트 적용
            foreach (EffectSet effectSet in item.Effects)
            {
                effectSet.SetEffectSource("ITEM", itemCode); // 이펙트의 소스를 아이템으로 설정한다.
                m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
            }

            // 인벤토리에서 삭제.
			m_inventroy.Remove(item);
        }

        public void RemoveEquipment(string itemCode)
        {
			Item item = FindEquipment(itemCode);

            // 해당 아이템이 장비리스트에 없으면 그냥 리턴.
			if (item.Code == "UNDEFINED_ITEM") return;

            // 아이템 인벤토리에 추가
            m_inventroy.Add(item);

            // 장비리스트에서 삭제.
            m_equipments.Remove(item);

            // 아이템 이팩트 삭제
			List<EffectSet> deletedItemList = new List<EffectSet>();
            foreach (EffectSet effectSet in m_effects)
            {
				if (effectSet.SourceType == "ITEM" && effectSet.SourceName == itemCode)
					deletedItemList.Add(effectSet);
            }

			foreach (EffectSet effectSet in deletedItemList)
				m_effects.Remove(effectSet);
        }

		public void SellItem(string itemCode, double sellPencentage)
		{
			Item item = FindInventory(itemCode);
			// 해당 아이템이 장비리스트에 없으면 그냥 리턴.
			if (item.Code == "UNDEFINED_ITEM") return;
			
			// 판매대금 소지금에 추가.
			m_gold += item.Cost * sellPencentage;

			// 아이템 삭제.
			m_inventroy.Remove(item);
		}

		public void AddItem(string itemCode)
		{
			// 아이템 존재 여부 체크.
			if (!DataManager.Instance.ItemData.ContainsKey(itemCode))
				return;

			// 인벤토리에 추가.
			m_inventroy.Add(DataManager.Instance.ItemData[itemCode]);
		}

        private void LoadGold(XmlElement root)
        {
            m_gold = Util.GetNodeDoubleData(root, "/CharacterSheet/Gold");
        }

        private Item GetItem(string itemCode)
        {

            if (itemCode == string.Empty)
            {
                // 에러처리
                return Item.GetUndefinedItem("아이템 코드가 존재하지 않습니다.");
            }

            if (!DataManager.Instance.ItemData.ContainsKey(itemCode))
            {
                // 에러처리.
                return Item.GetUndefinedItem("아이템 '" + itemCode + "'이(가) 아이템 목록에 존재하지 않습니다.");
            }

            return DataManager.Instance.ItemData[itemCode];
        }

        public double GetLoad()
        {
            double load = 0.0;

            foreach (Item item in m_equipments)
                load += item.Weight;

            foreach (Item item in m_inventroy)
                load += item.Weight;

            return load;
        }
	}
}
