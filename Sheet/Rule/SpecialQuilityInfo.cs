using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    public class SpecialQuilityInfo
    {
        public enum SpecialQuilityType { active, passive }
        #region 멤버
        string m_code; // 특수능력 코드
        string m_name; // 특수능력 이름
        string m_description; // 특수능력 설명
        SpecialQuilityType m_type; // 특수능력 타입
        List<EffectSet> m_effects = new List<EffectSet>(); // 특수능력 발동효과
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public SpecialQuilityType Type { get { return m_type; } }
        public List<EffectSet> Effects { get { return m_effects; } }
        #endregion

        public SpecialQuilityInfo(string path)
        {
            LoadSpecialQuilityData(path);
        }

        public void LoadSpecialQuilityData(string path)
        {
            #region XML 파일 로드
            XmlElement root = Util.LoadXMLFile(path);
            if (root == null) return;
            #endregion

            #region 특수능력 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper(); // 모든 코드는 대문자.
            if (m_code == string.Empty)
                return;
            #endregion

            #region 특수능력 이름 얻기
            m_name = Util.GetNodeData(root, "/SpecialQuility/Name/" + Setting.instance.Language);
            if (m_name == string.Empty)
                m_name = "이름 없음";
            #endregion

            #region 특수능력 설명 얻기
            m_description = Util.GetNodeData(root, "/SpecialQuility/Description/" + Setting.instance.Language, false);
            #endregion

            #region 특수능력 타입 얻기
            string typeStr = Util.GetNodeData(root, "/SpecialQuility/Type", false);
            switch (typeStr.ToUpper())
            {
                case "ACTIVE": m_type = SpecialQuilityType.active; break;
                case "PASSIVE": m_type = SpecialQuilityType.passive; break;
                default: m_type = SpecialQuilityType.passive; break;
            }
            #endregion

            #region 이펙트 정보 얻기
            XmlNodeList effectNodes = root.SelectNodes("/SpecialQuility/Effects//EffectSet");
			foreach (XmlNode effectSetNode in effectNodes)
			{
				m_effects.Add( new EffectSet(effectSetNode, "SPECIALQUILITY", m_code) );
			}
			#endregion
        }
    }
}
