using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace Sheet
{
    public class ClassInfo
    {
        public enum SpellCastType { wizard, sorcerer, non_caster }

        #region 멤버
        public enum ClassBABType { Good, Average, Poor, Undefined }
        public enum ClassSaveType { Good, Poor, Undefined }

        string m_code;
        string m_name;
        ClassBABType m_BABType;
        ClassSaveType m_fort;
        ClassSaveType m_ref;
        ClassSaveType m_will;
        Dictionary<int, List<SpecialQuilityInfo>> m_features = new Dictionary<int,List<SpecialQuilityInfo>>();

        int m_casterLevelRatio = 0;
        SpellCastType m_castType;
        string m_relatedAbility;

        int[, ] m_spellPerDay = new int[21, 10]; // 1~20레벨까지고, 0번 값은 사용하지 않음.
        Dictionary<string, int> m_spellList = new Dictionary<string, int>();

        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public ClassBABType BABType { get { return m_BABType; } }
        public ClassSaveType Fort { get { return m_fort; } }
        public ClassSaveType Ref { get { return m_ref; } }
        public ClassSaveType Will { get { return m_will; } }
        public Dictionary<int, List<SpecialQuilityInfo>> Features { get { return m_features; } }
        public int CasterLevelRatio { get { return m_casterLevelRatio; } }
        public bool IsCasterClass { get { return m_casterLevelRatio > 0 ? true : false; } }
        public SpellCastType CastType { get { return m_castType; } }
        public string RelatedAbility { get { return m_relatedAbility; } }
        public int[,] SpellPerDay { get { return m_spellPerDay; } }
        #endregion

        #region 생성자

        public ClassInfo(string path)
        {
            LoadClassData(path);
        }

        #endregion

        #region 메소드
        public void LoadClassData(string path)
        {
            XmlNode node;

			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
			if (root == null) return;
			#endregion

            #region 클래스 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper();  // 모든 코드는 대문자.
			if (m_code == string.Empty)
				return;
            #endregion

            #region 클래스 이름 얻기
            m_name = Util.GetNodeData(root, "/Class/Name/" + Setting.instance.Language);
			if (m_name == string.Empty)
				m_name = "이름 없음";
            #endregion

            #region BAB 타입 얻기
            string BABTypeStr = Util.GetNodeData(root, "/Class/BAB");

			switch (BABTypeStr.ToUpper())
            {
                case "GOOD": m_BABType = ClassBABType.Good; break;
                case "AVERAGE": m_BABType = ClassBABType.Average; break;
                case "POOR":
                case "BAD": m_BABType = ClassBABType.Poor; break;
                default: m_BABType = ClassBABType.Undefined; break;
            }
            #endregion

            #region 내성 타입 얻기
            m_fort = GetSaveType(Util.GetNodeData(root, "/Class/Save/Fort"));
            m_ref = GetSaveType(Util.GetNodeData(root, "/Class/Save/Ref"));
            m_will = GetSaveType(Util.GetNodeData(root, "/Class/Save/Will"));
            #endregion

            #region 클래스 피쳐 얻기
            XmlNodeList features = root.SelectNodes("/Class/Feature//Level");
            foreach (XmlNode feature in features)
            {
                int lv = Util.ParseToInt(Util.GetNodeAttribute(feature, "code"));

                List<SpecialQuilityInfo> SQList = new List<SpecialQuilityInfo>();
                XmlNodeList SQs = feature.SelectNodes(".//SpecialQuility");
                foreach (XmlNode SQ in SQs)
                {
                    string SQCode = Util.GetNodeAttribute(SQ, "code");
                    if (DataManager.Instance.SpecialQuilityData.ContainsKey(SQCode))
                        SQList.Add(DataManager.Instance.SpecialQuilityData[SQCode]);
                    else
                        LogManager.Instance.AddLog("Get SpecialQuility", ErrorLog.LogType.Error,
                                            "'" + SQCode + "' 에 해당하는 특수능력 정보가 없습니다.", 
                                            "특수능력 정보가 없습니다. 코드의 오타, 혹은 데이터 폴더 내에 해당 xml 파일이 있는지 확인하십시오.");
                    // 횟수 등의 정보를 얻는다.
                    // 아직 미구현.
                }

                m_features.Add(lv, SQList);
            }

            #endregion

            #region 주문 정보 얻기
            // 캐스터레벨 비율
            m_casterLevelRatio = Util.GetNodeIntData(root, "/Class/SpellInfo/CasterLevelRatio", false);

            // 캐스팅 타입
            string castTypeStr = Util.GetNodeData(root, "/Class/SpellInfo/CastType", false);
            switch (castTypeStr.ToUpper())
            {
                case "WIZARD": m_castType = SpellCastType.wizard; break;
                case "SORCERER": m_castType = SpellCastType.sorcerer; break;
                default: m_castType = SpellCastType.non_caster; break;
            }

            // 주문시전 관련 능력치
            m_relatedAbility = Util.GetNodeData(root, "/Class/SpellInfo/RelatedAbility", false);

            // 주문갯수 테이블 초기화
            // 0은 능력치 보너스 등으로 사용가능한 경우를 뜻하므로, 초기값은 모두 -1로 한다.
            for (int i = 0; i < 21; i++) for (int j = 0; j < 10; j++) m_spellPerDay[i, j] = -1;

            // 주문 갯수
            XmlNodeList casterLevels = root.SelectNodes("/Class/SpellInfo/SpellPerDay//Level");
            foreach (XmlNode casterLevel in casterLevels)
            {
                int level = Util.GetNodeIntAttribute(casterLevel, "number");
                XmlNodeList spellLevels = casterLevel.SelectNodes(".//SpellNumber");
                foreach( XmlNode spellNumber in spellLevels)
                {
                    int spellLv = Util.GetNodeIntAttribute(spellNumber, "level");
                    m_spellPerDay[level, spellLv] = Util.GetNodeIntData(spellNumber);
                }
            }

            // 주문 목록
            XmlNodeList spellLevel = root.SelectNodes("/Class/SpellInfo/SpellList/SpellLevel");
            foreach (XmlNode spellList in spellLevel)
            {
                int lv = Util.GetNodeIntAttribute(spellList, "number");
                XmlNodeList spells = spellList.SelectNodes(".//Spell");
                //if (!m_spellList.ContainsKey(lv)) m_spellList.Add(lv, new List<string>());
                foreach (XmlNode spell in spells)
                    m_spellList.Add(Util.GetNodeData(spell), lv);
            }

            #endregion
        }

        private ClassSaveType GetSaveType(string saveType)
        {
            if (saveType == null) 
                return ClassSaveType.Undefined;

            switch (saveType.ToUpper())
            {
                case "GOOD": 
                    return ClassSaveType.Good;
                case "POOR":
                case "BAD": 
                    return ClassSaveType.Poor;
                default: 
                    return ClassSaveType.Undefined;
            }
        }

        public int GetSpellLevel(string code)
        {
            if (m_spellList.ContainsKey(code))
                return m_spellList[code];
            else
                return -1;
        }
        #endregion
    }
}
