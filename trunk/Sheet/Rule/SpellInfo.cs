using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    class SpellInfo
    {
        #region 멤버
        string m_code; // 주문 코드
        string m_name; // 주문 이름
        string m_description; // 주문 설명
        List<EffectSet> m_effects = new List<EffectSet>(); // 주문 효과
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public List<EffectSet> Effects { get { return m_effects; } }
        #endregion

        public SpellInfo(string path)
        {
            LoadFeatData(path);
        }

        public void LoadFeatData(string path)
        {
            XmlNode node;

            #region XML 파일 로드
            XmlElement root = Util.LoadXMLFile(path);
            if (root == null) return;
            #endregion

            #region 주문 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper(); // 모든 코드는 대문자.
            if (m_code == string.Empty)
                return;
            #endregion

            #region 주문 이름 얻기
            node = root.SelectSingleNode("/Spell/Name/" + Setting.instance.Language);
            m_name = Util.GetNodeData(node);
            if (m_name == string.Empty)
                m_name = "이름 없음";
            #endregion

            #region 주문 설명 얻기
            node = root.SelectSingleNode("/Spell/Description/" + Setting.instance.Language);
            m_description = Util.GetNodeData(node);
            #endregion

            #region 이펙트 정보 얻기
            XmlNodeList effectNodes = root.SelectNodes("/Spell/Effects//EffectSet");
			foreach (XmlNode effectSetNode in effectNodes)
			{
				m_effects.Add( new EffectSet(effectSetNode) );
			}
			#endregion
        }
    }
}
