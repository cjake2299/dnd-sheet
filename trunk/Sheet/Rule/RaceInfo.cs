using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
	public class RaceInfo
	{
		public enum SizeCategory { Fine, Diminutive, Tiny, Small, Medium, Large, Huge, Gargantuan, Colossal }

        #region 멤버
        string m_code;
        string m_name;
        SizeCategory m_size;
		int m_landSpeed;
		int m_flySpeed;
		string m_description;		
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public SizeCategory Size { get { return m_size; } }
		public int LandSpeed { get { return m_landSpeed; } }
		public string Description { get { return m_description; } }
        #endregion

        #region 생성자
        public RaceInfo()
        {

        }

		public RaceInfo(string path)
        {
            LoadRaceData(path);
        }
        #endregion

        #region 메소드
        public void LoadRaceData(string path)
        {
			XmlNode node;

			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
			if (root == null) return;
			#endregion

            #region 종족 코드 얻기
			m_code = Util.GetNodeAttribute(root, "code");
			if (m_code == string.Empty)
				return;
            #endregion

            #region 종족 이름 얻기
			node = root.SelectSingleNode("/Race/Name/" + Setting.instance.Language);
			m_name = Util.GetNodeData(node);
			if (m_name == string.Empty)
				m_name = "이름 없음";
            #endregion

            #region 사이즈 얻기
			node = root.SelectSingleNode("/Race/Size");
			string sizeStr = Util.GetNodeData(node).ToLower();

			switch (sizeStr)
            {
				case "fine": m_size = SizeCategory.Fine; break;
				case "diminutive": m_size = SizeCategory.Diminutive; break;
				case "tiny": m_size = SizeCategory.Tiny; break;
				case "small": m_size = SizeCategory.Small; break;
				case "medium": m_size = SizeCategory.Medium; break;
				case "large": m_size = SizeCategory.Large; break;
				case "huge": m_size = SizeCategory.Huge; break;
				case "gargantuan": m_size = SizeCategory.Gargantuan; break;
				case "colossal": m_size = SizeCategory.Colossal; break;
                default:
					LogManager.Instance.AddLog("종족 정보 얻기", ErrorLog.LogType.Warning,
											"종족의 크기 정보가 없습니다.", "");
					m_size = SizeCategory.Medium; break;
            }
            #endregion

			#region 이동속도 얻기
			node = root.SelectSingleNode("/Race/LandSpeed");
			m_landSpeed = Util.GetNodeIntData(node);
			#endregion

			#region 종족 설명 얻기
			node = root.SelectSingleNode("/Race/Description/" + Setting.instance.Language);
			m_description = Util.GetNodeData(node);
			#endregion
		}
        #endregion
	}
}
