using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    class SkillInfo
    {
        #region 멤버
        string m_code; // 스킬 코드
        string m_name; // 스킬명
        string m_description; // 스킬 소개
        string m_relatedAbilityCode; // 관련된 능력치의 코드
        Dictionary<KeyValuePair<string, int>, int> m_synergy = new Dictionary<KeyValuePair<string,int>,int>(); // 시너지 테이블. 요구사항[스킬명-랭크]-보너스수치 형태.

        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public string Description { get { return m_description; } }
        public string RelatedAbility { get { return m_relatedAbilityCode; } }
        public Dictionary<KeyValuePair<string, int>, int> Synergy { get { return m_synergy; } }

        #endregion

        public SkillInfo(string path)
        {
            LoadSkillData(path);
        }

        public void LoadSkillData(string path)
        {
            XmlNode node;

			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
			if (root == null) return;
			#endregion

            #region 스킬 코드 얻기
			m_code = Util.GetNodeAttribute(root, "code").ToUpper(); // 모든 코드는 대문자.
			if (m_code == string.Empty)
				return;
            #endregion

            #region 스킬명 얻기
            node = root.SelectSingleNode("/Skill/Name/" + Setting.instance.Language);
            m_name = Util.GetNodeData(node);
			if (m_name == string.Empty)
				m_name = "이름 없음";
            #endregion

            #region 스킬설명 얻기
            node = root.SelectSingleNode("/Skill/Description/" + Setting.instance.Language);
            m_description = Util.GetNodeData(node);
            #endregion

            #region 관련능력치 얻기
            node = root.SelectSingleNode("/Skill/RelatedAbility");
            m_relatedAbilityCode = Util.GetNodeData(node).ToUpper(); // 모든 코드는 대문자.
            #endregion

            #region 시너지 스킬정보 얻기
            XmlNodeList nodes = root.SelectNodes("/Skill/RelatedSkillList//Related");
            foreach (XmlNode n in nodes)
            {
                KeyValuePair<string, int> p = 
                    new KeyValuePair<string, int>(
                        Util.GetNodeAttribute(n.SelectSingleNode("./RequiredSkill"), "code").ToUpper(), // 모든 코드는 대문자.
                        Util.GetNodeIntData( n.SelectSingleNode("./RequiredSkill") )
                        );
                m_synergy.Add( p, Util.GetNodeIntData(n.SelectSingleNode("./SkillBonus")) );
            }
            #endregion
        }
    }
}
