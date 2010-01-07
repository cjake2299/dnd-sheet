using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    class FeatInfo
    {
        #region 멤버
        string m_code; // 피트 코드
        string m_name; // 피트명
        string m_description; // 피트 설명
        List<EffectSet> m_effects = new List<EffectSet>(); // 피트 발동효과
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public List<EffectSet> Effects { get { return m_effects; } }
        #endregion

        public FeatInfo(string path)
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

            #region 피트 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper(); // 모든 코드는 대문자.
            if (m_code == string.Empty)
                return;
            #endregion

            #region 피트 이름 얻기
            node = root.SelectSingleNode("/Feat/Name/" + Setting.instance.Language);
            m_name = Util.GetNodeData(node);
            if (m_name == string.Empty)
                m_name = "이름 없음";
            #endregion

            #region 피트 설명 얻기
            node = root.SelectSingleNode("/Feat/Description/" + Setting.instance.Language);
            m_description = Util.GetNodeData(node);
            #endregion

            #region 이펙트 정보 얻기
			XmlNodeList effectNodes = root.SelectNodes("/Feat/Effects//EffectSet");
			foreach (XmlNode effectSetNode in effectNodes)
			{
				m_effects.Add( new EffectSet(effectSetNode, "FEAT", m_code) );
			}
			#endregion
        }
    }
}
