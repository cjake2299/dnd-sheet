using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    public partial class CharacterSheet
    {
        #region 시트 정보 멤버변수
        string m_playerName = string.Empty; // 플레이어명
        string m_teamName = string.Empty; // 팀명
        string m_characterName = string.Empty; // 캐릭터 이름
        string m_raceCode = string.Empty; // 종족 코드
        string m_alignment = string.Empty; // 가치관
        string m_age = string.Empty; // 나이. 수치로 계산할 필요가 없으므로 다양성을 위해 문자열 타입을 사용.
		double m_height; // 키
		double m_weight; // 몸무게
        string m_description = string.Empty; // 캐릭터 소개(백스토리 등)
        string m_memo = string.Empty; // 메모

        List<LevelData> m_levelInfo = new List<LevelData>(); // 캐릭터 레벨 정보
		int m_baseHP; // 기본 HP
		int m_currentHP; // 현재 HP

        int m_baseStr; // 기본 힘 능력치
		int m_baseDex; // 기본 민첩 능력치
		int m_baseCon; // 기본 건강 능력치
		int m_baseInt; // 기본 지능 능력치
		int m_baseWis; // 기본 지혜 능력치
		int m_baseCha; // 기본 매력 능력치

        // 피트
        List<string> m_feats = new List<string>(); // 피트리스트. 피트 코드만.

        // 특수능력
        List<SpecialQuilityInfo> m_specialQuilities = new List<SpecialQuilityInfo>();

        // 스킬
        Dictionary<string, int> m_skills = new Dictionary<string,int>(); // 스킬리스트. 스킬코드-랭크 쌍.

        // 장비
		List<Item> m_equipments = new List<Item>();

        // 보유아이템(인벤토리)
		List<Item> m_inventroy = new List<Item>();

        // 소지금
        double m_gold; 

        // 활성화된 이펙트
		List<EffectSet> m_effects = new List<EffectSet>();

        #endregion

        #region 프로퍼티
        public string PlayerName 
        { 
            get { return m_playerName; } 
            set { m_playerName = value; } 
        }
        public string TeamName 
        { 
            get { return m_teamName; } 
            set { m_teamName = value; } 
        }
        public string ChatacterName 
        { 
            get { return m_characterName; } 
            set { m_characterName = value; } 
        }
        public string RaceCode 
        { 
            get { return m_raceCode; } 
            set { m_raceCode = value; } 
        }
        public string Alignment 
        { 
            get { return m_alignment; } 
            set { m_alignment = value; } 
        }
        public string Age
        {
            get { return m_age; }
            set { m_age = value; }
        }
        public double Height
        { 
            get { return m_height; } 
            set { m_height = value; } 
        }
        public double Weight 
        { 
            get { return m_weight; } 
            set { m_weight = value; } 
        }
        public string Description 
        { 
            get { return m_description; } 
            set { m_description = value; } 
        }
        public string Memo 
        { 
            get { return m_memo; } 
            set { m_memo = value; } 
        }
        public List<LevelData> Levels { get { return m_levelInfo; } }
        public int CurrentHP
        {
            get { return m_currentHP; }
            set { m_currentHP = value; }
        }
        public int BaseStr
        {
            get { return m_baseStr; }
            set { m_baseStr = value; }
        }
        public int BaseDex
        {
            get { return m_baseDex; }
            set { m_baseDex = value; }
        }
        public int BaseCon
        {
            get { return m_baseCon; }
            set { m_baseCon = value; }
        }
        public int BaseInt
        {
            get { return m_baseInt; }
            set { m_baseInt = value; }
        }
        public int BaseWis
        {
            get { return m_baseWis; }
            set { m_baseWis = value; }
        }
        public int BaseCha
        {
            get { return m_baseCha; }
            set { m_baseCha = value; }
        }
        public List<string> Feats { get { return m_feats; } }
        public List<SpecialQuilityInfo> SpecialQuilities { get { return m_specialQuilities; } }
        public Dictionary<string, int> Skills { get { return m_skills; } }
        public List<Item> Equipments { get { return m_equipments; } }
		public List<Item> Inventroy { get { return m_inventroy; } }
        public List<EffectSet> Effects { get { return m_effects; } }
        public double Gold
        {
            get { return m_gold; }
            set { m_gold = value; }
        }
        #endregion

        #region 내부적으로 사용되는 멤버변수

        #endregion

        #region 생성자
        public CharacterSheet() // 빈 캐릭터 생성.
        {
            InitSheet();   
        }
        #endregion

        public void InitSheet()
        {
            m_raceCode = "HUMAN";
            m_baseStr = 10;
            m_baseDex = 10;
            m_baseCon = 10;
            m_baseInt = 10;
            m_baseWis = 10;
            m_baseCon = 10;

			m_levelInfo.Clear();
			m_feats.Clear();
			m_skills.Clear();
			m_equipments.Clear();
			m_inventroy.Clear();
			m_effects.Clear();

			m_gold = 0.0;
        }

        public void SaveSheetFile(string path)
		{
            XmlDocument doc = new XmlDocument();
            XmlNode node;
            XmlAttribute attr;

            // XML 양식 정의
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "euc-kr", "yes"));

            // 루트 엘리먼트
            XmlNode root = doc.CreateElement("CharacterSheet");
            doc.AppendChild(root);

            #region 기본 정보 쓰기
            // 플레이어 이름
            node = doc.CreateElement("PlayerName");
            node.InnerText = m_playerName;
            root.AppendChild(node);

            // 팀 이름
            node = doc.CreateElement("TeamName");
            node.InnerText = m_teamName;
            root.AppendChild(node);

            // 캐릭터 이름
            node = doc.CreateElement("CharacterName");
            node.InnerText = m_characterName;
            root.AppendChild(node);

            // 종족
            node = doc.CreateElement("Race");
            node.InnerText = m_raceCode;
            root.AppendChild(node);

            // 가치관
            node = doc.CreateElement("Alignment");
            node.InnerText = m_alignment;
            root.AppendChild(node);

            // 나이
            node = doc.CreateElement("Age");
            node.InnerText = m_age;
            root.AppendChild(node);

            // 키
            node = doc.CreateElement("Height");
            node.InnerText = m_height.ToString();
            root.AppendChild(node);

            // 몸무게
            node = doc.CreateElement("Weight");
            node.InnerText = m_weight.ToString();
            root.AppendChild(node);

            // 소개
            node = doc.CreateElement("Description");
            node.InnerText = m_description;
            root.AppendChild(node);

            // 메모
            node = doc.CreateElement("Memo");
            node.InnerText = m_memo;
            root.AppendChild(node);
            #endregion

            #region 레벨 정보 쓰기
            // 레벨정보 엘리먼트
            node = doc.CreateElement("LevelInfo");
            root.AppendChild(node);

            XmlNode lvNode;
            XmlNode lvInfoNode;
            for(int i=0; i < m_levelInfo.Count; i++)
            {
                // Level 엘리먼트 생성
                lvNode = doc.CreateElement("Level");
                node.AppendChild(lvNode);
                // number 어트리뷰트 추가.
                attr = doc.CreateAttribute("number");
                attr.Value = (i+1).ToString();
                lvNode.Attributes.Append(attr);

                // 클래스코드 엘리먼트 추가
                lvInfoNode = doc.CreateElement("ClassCode");
                lvInfoNode.InnerText = m_levelInfo[i].ClassCode;
                lvNode.AppendChild(lvInfoNode);
                
                // HP 엘리먼트 추가
                lvInfoNode = doc.CreateElement("HP");
                lvInfoNode.InnerText = m_levelInfo[i].HP.ToString();
                lvNode.AppendChild(lvInfoNode);
            }
            #endregion

            #region HP 정보 쓰기
            // HP 엘리먼트
            node = doc.CreateElement("HP");
            root.AppendChild(node);
            // 현재 HP 엘리먼트
            XmlNode currentHPNode = doc.CreateElement("CurrentHP");
            currentHPNode.InnerText = m_currentHP.ToString();
            node.AppendChild(currentHPNode);
            #endregion

            #region 능력치 정보 쓰기
            node = doc.CreateElement("Ability");
            root.AppendChild(node);
            XmlNode abilityNode;
            
            // Str
            abilityNode = doc.CreateElement("Strength");
            abilityNode.InnerText = m_baseStr.ToString();
            node.AppendChild(abilityNode);

            // Dex
            abilityNode = doc.CreateElement("Dexterity");
            abilityNode.InnerText = m_baseDex.ToString();
            node.AppendChild(abilityNode);

            // Con
            abilityNode = doc.CreateElement("Constitution");
            abilityNode.InnerText = m_baseCon.ToString();
            node.AppendChild(abilityNode);

            // Int
            abilityNode = doc.CreateElement("Intelligence");
            abilityNode.InnerText = m_baseInt.ToString();
            node.AppendChild(abilityNode);

            // Wis
            abilityNode = doc.CreateElement("Wisdom");
            abilityNode.InnerText = m_baseWis.ToString();
            node.AppendChild(abilityNode);

            // Cha
            abilityNode = doc.CreateElement("Charisma");
            abilityNode.InnerText = m_baseCha.ToString();
            node.AppendChild(abilityNode);
            #endregion

            #region 피트 정보 쓰기
            // 피트목록 엘리먼트
            node = doc.CreateElement("Feats");
            root.AppendChild(node);

            XmlNode featNode;
            foreach (string feat in m_feats)
            {
                // 피트 엘리먼트 생성
                featNode = doc.CreateElement("Feat");
                // 피트 엘리먼트에 어트리뷰트 추가
                attr = doc.CreateAttribute("code");
                attr.Value = feat;
                featNode.Attributes.Append(attr);
                // 피트 엘리먼트를 피트목록에 추가.
                node.AppendChild(featNode);
            }
            #endregion

            #region 스킬 정보 쓰기
            // 스킬목록 엘리먼트 생성
            node = doc.CreateElement("Skills");
            root.AppendChild(node);

            XmlNode skillNode;
            foreach (KeyValuePair<string, int> skill in m_skills)
            {
                // 스킬 엘리먼트 생성
                skillNode = doc.CreateElement("Skill");
                skillNode.InnerText = skill.Value.ToString();
                // 스킬 엘리먼트에 어트리뷰트 추가
                attr = doc.CreateAttribute("code");
                attr.Value = skill.Key;
                skillNode.Attributes.Append(attr);
                // 스킬 엘리먼트를 스킬목록에 추가.
                node.AppendChild(skillNode);
            }
            #endregion

            #region 착용아이템 정보 쓰기
            // 장비목록 엘리먼트 생성
            node = doc.CreateElement("Equipments");
            root.AppendChild(node);

            XmlNode equipmentNode;
            foreach (Item item in m_equipments)
            {
                // 장비 엘리먼트 생성
                equipmentNode = doc.CreateElement("Item");
                // 장비 엘리먼트에 어트리뷰트 추가
                attr = doc.CreateAttribute("code");
                attr.Value = item.Code;
                equipmentNode.Attributes.Append(attr);
                // 장비 엘리먼트를 장비목록에 추가.
                node.AppendChild(equipmentNode);
            }
            #endregion

            #region 인벤토리 정보 쓰기
            // 인벤토리 엘리먼트 생성
            node = doc.CreateElement("Inventory");
            root.AppendChild(node);

            XmlNode inventoryNode;
            foreach (Item item in m_inventroy)
            {
                // 아이템 엘리먼트 생성
                inventoryNode = doc.CreateElement("Item");
                // 아이템 엘리먼트에 어트리뷰트 추가
                attr = doc.CreateAttribute("code");
                attr.Value = item.Code;
                inventoryNode.Attributes.Append(attr);
                // 아이템 엘리먼트를 인벤토리에 추가.
                node.AppendChild(inventoryNode);
            }

            // 소지금 쓰기
            node = doc.CreateElement("Gold");
            node.InnerText = m_gold.ToString();
            root.AppendChild(node);
            #endregion

            #region 활성화된 이펙트 정보 쓰기
            // 파일에는 기록되지 않지만 기본 활성화된 이펙트가 있으므로 쓰기 애매.
            // 대부분의 이펙트는 임시이므로 활성화된 이펙트를 굳이 파일로 저장할 필요는 없을 수도 있음.
            // 추후 버전에서 생각.
            /*
            // 이펙트 목록 엘리먼트 생성
            node = doc.CreateElement("ActivedEffects");
            root.AppendChild(node);

            XmlNode effectNode;
            foreach (EffectSet effectSet in m_effects)
            {
                // 이펙트셋 엘리먼트 생성
                effectNode = doc.CreateElement("EffectSet");

                // 이펙트셋 엘리먼트를 피트목록에 추가.
                node.AppendChild(effectNode);
            }
            */
            #endregion

            doc.Save(path);
        }

        public void LoadSheetFile(string path)
		{
			//멤버 데이터 초기화
			InitSheet();


			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
            if (root == null) return;
			#endregion

			#region 기본 정보 읽기
			// 플레이어 이름
			m_playerName = Util.GetNodeData(root, "/CharacterSheet/PlayerName", false);
			// 팀 이름
			m_teamName = Util.GetNodeData(root, "/CharacterSheet/TeamName", false);
			// 캐릭터 이름
			m_characterName = Util.GetNodeData(root, "/CharacterSheet/CharacterName", false);
			// 종족
			m_raceCode = Util.GetNodeData(root, "/CharacterSheet/Race", false);
			// 가치관
			m_alignment = Util.GetNodeData(root, "/CharacterSheet/Alignment", false);
			// 나이
			m_age = Util.GetNodeData(root, "/CharacterSheet/Age", false);
			// 키
			m_height = Util.GetNodeDoubleData(root, "/CharacterSheet/Height", false);
			// 몸무게
			m_weight = Util.GetNodeDoubleData(root, "/CharacterSheet/Weight", false);
			// 소개
			m_description = Util.GetNodeData(root, "/CharacterSheet/Description", false);
			// 메모
			m_memo = Util.GetNodeData(root, "/CharacterSheet/Memo", false);
			#endregion

			// 레벨 정보 읽기
			LoadLevelInfo(root);

            #region HP 읽기
			m_currentHP = Util.GetNodeIntData(root, "/CharacterSheet/HP/CurrentHP");
			#endregion

			// 능력치 정보 읽기
			LoadAbilityInfo(root);

            // 피트 정보 읽기
            LoadFeats(root);

            // 스킬 정보 읽기
            LoadSkillInfo(root);

			#region 아이템 정보 읽기
			LoadEquipments(root);
            LoadInventory(root);
            LoadGold(root);

			#endregion

			// 에러 여부 표시
			using (ErrorLogForm dlg = new ErrorLogForm())
			{
				dlg.ViewErrors();
			}
		}

		#region 크기 정보 얻기
		public string GetSize()
		{
			if (!DataManager.Instance.RaceData.ContainsKey(m_raceCode))
			{
				// 에러처리
				LogManager.Instance.AddLog("캐릭터 정보 읽기", ErrorLog.LogType.Error,
										"'" + m_raceCode + "' 에 해당하는 종족 정보가 없습니다.", "");
				return "Undefinded";
			}

			return DataManager.Instance.RaceData[m_raceCode].Size.ToString();
		}
		#endregion

		#region 이동속도 정보 얻기
		public string GetSpeed()
		{
			if (!DataManager.Instance.RaceData.ContainsKey(m_raceCode))
			{
				// 에러처리
				LogManager.Instance.AddLog("캐릭터 정보 읽기", ErrorLog.LogType.Error,
										"'" + m_raceCode + "' 에 해당하는 종족 정보가 없습니다.", "");
				return "Undefinded";
			}
			int landSpeed = DataManager.Instance.RaceData[m_raceCode].LandSpeed;
			return "land " + landSpeed + "ft";

		}
		#endregion

		#region HP 정보 얻기
		public int GetMaxHP()
		{
			int hp = 0;

			foreach (LevelData lv in m_levelInfo)
				hp += lv.HP;
			
			hp += GetTotalLevel() * GetConBonus();

			return hp;
		}
		#endregion

        #region 우선권 정보 얻기
        public int GetInitiative()
        {
            int init = 0;
            init += GetDexBonus();
            init += GetEffectValue("INITIATIVE_BONUS");

            return init;
        }
        #endregion

        private int GetEffectValue(string type)
		{
			int totalValue = 0;
            // 수정자 리스트. 타입-수정치 형태의 목록이 저장된다.
			Dictionary<string, int> ModifierTable = new Dictionary<string, int>();

            foreach (EffectSet effectSet in m_effects)
            {
                foreach (Effect effect in effectSet.EffectList)
                {
                    if (effect.TypeCode == type)
                    {
                        if (ModifierTable.ContainsKey(effect.ModifierType))
                        {
                            // 같은 보너스 타입의 경우 높은 쪽의 값을 선택한다.
                            if (ModifierTable[effect.ModifierType] < effect.Value)
                                ModifierTable[effect.ModifierType] = effect.Value;
                        }
                        else
                        {
                            // 같은 보너스 타입이 없다면 그냥 입력.
                            ModifierTable[effect.ModifierType] = effect.Value;
                        }
                    }
                }
            }

			// 분류가 끝난 이펙트의 수정치들을 적용한다.
			foreach (KeyValuePair<string, int> valuePair in ModifierTable)
			{
				totalValue += valuePair.Value;
			}

			return totalValue;
		}
	}
}
