using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    partial class CharacterSheet
    {
        private void LoadFeats(XmlElement root)
        {
            XmlNodeList featNodeList = root.SelectNodes("/CharacterSheet/Feats//Feat");
            string featCode;

            foreach (XmlNode featNode in featNodeList)
            {
                featCode = Util.GetNodeAttribute(featNode, "code");

                // 피트를 추가한다.
                AddFeat(featCode);               
            }
        }

		public void AddFeat(string featCode)
		{
			if (!DataManager.Instance.FeatData.ContainsKey(featCode))
				return;

			// 피트를 추가한다.
			m_feats.Add(featCode);
			foreach (EffectSet effectSet in DataManager.Instance.FeatData[featCode].Effects)
			{
				// 패시브 이펙트일 경우만
				if(effectSet.Type == EffectSet.EffectType.passive)
					m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
			}
		}
    }
}
