using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Sheet
{
    class DataManager
    {
        // singleton 구현
        public static readonly DataManager Instance = new DataManager();

		#region 멤버
        Dictionary<string, ClassInfo> m_classData = new Dictionary<string, ClassInfo>();
        Dictionary<string, Item> m_itemData = new Dictionary<string, Item>();
        Dictionary<string, RaceInfo> m_raceData = new Dictionary<string, RaceInfo>();
        Dictionary<string, SkillInfo> m_skillData = new Dictionary<string, SkillInfo>();
        Dictionary<string, FeatInfo> m_featData = new Dictionary<string, FeatInfo>();
        Dictionary<string, SpecialQuilityInfo> m_specialQuilityData = new Dictionary<string, SpecialQuilityInfo>();
        Dictionary<string, SpellInfo> m_spellData = new Dictionary<string, SpellInfo>();
		#endregion

		#region 프로퍼티
        public Dictionary<string, ClassInfo> ClassData { get { return m_classData; } }
		public Dictionary<string, Item> ItemData { get { return m_itemData; } }
		public Dictionary<string, RaceInfo> RaceData { get { return m_raceData; } }
        public Dictionary<string, SkillInfo> SkillData { get { return m_skillData; } }
        public Dictionary<string, FeatInfo> FeatData { get { return m_featData; } }
        public Dictionary<string, SpecialQuilityInfo> SpecialQuilityData { get { return m_specialQuilityData; } }
        public Dictionary<string, SpellInfo> SpellData { get { return m_spellData; } }
		#endregion

		// 생성자
		private DataManager()
        {

        }

        // 전체 데이터 가져오기
        public void LoadAllData()
        {
            LoadAllSkillData();
            LoadAllFeatData();
            LoadAllSpecialQuilityData();
            LoadAllSpellData();
            LoadAllItemData();
            LoadAllRaceData();
            LoadAllClassData(); // 클래스 데이터를 맨 마지막에.
        }
		// 클래스 정보 가져오기
        public void LoadAllClassData()
        {
            // xml 파일이 저장되는 경로
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
                        + Setting.instance.ClassDataFolder;

            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {
                if (Path.GetExtension(fileName).ToLower() == ".xml")
                {
                    ClassInfo classInfo = new ClassInfo(fileName);
                    m_classData.Add(classInfo.Code, classInfo);
                }
            }
        }

		// 아이템 정보 가져오기
		public void LoadAllItemData()
		{
			// xml 파일이 저장되는 경로
			string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
						+ Setting.instance.ItemFolder;

			string[] files = Directory.GetFiles(path);
			foreach (string fileName in files)
			{
				if (Path.GetExtension(fileName).ToLower() == ".xml")
				{
					Item item = new Item(fileName);
					m_itemData.Add(item.Code, item);
				}
			}
		}

		// 종족 정보 가져오기
		public void LoadAllRaceData()
		{
			// xml 파일이 저장되는 경로
			string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
						+ Setting.instance.RaceFolder;

			string[] files = Directory.GetFiles(path);
			foreach (string fileName in files)
			{
				if (Path.GetExtension(fileName).ToLower() == ".xml")
				{
					RaceInfo race = new RaceInfo(fileName);
					m_raceData.Add(race.Code, race);
				}
			}
		}

        // 스킬 정보 가져오기
        public void LoadAllSkillData()
        {
            // xml 파일이 저장되는 경로
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
                        + Setting.instance.SkillFolder;

            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {
                if (Path.GetExtension(fileName).ToLower() == ".xml")
                {
                    SkillInfo skill = new SkillInfo(fileName);
                    m_skillData.Add(skill.Code, skill);
                }
            }
        }

        // 피트 정보 가져오기
        public void LoadAllFeatData()
        {
            // xml 파일이 저장되는 경로
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
                        + Setting.instance.FeatFolder;

            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {
                if (Path.GetExtension(fileName).ToLower() == ".xml")
                {
                    FeatInfo feat = new FeatInfo(fileName);
                    m_featData.Add(feat.Code, feat);
                }
            }
        }

        // 특수능력 정보 가져오기
        public void LoadAllSpecialQuilityData()
        {
            // xml 파일이 저장되는 경로
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
                        + Setting.instance.SpecialQuilityFolder;

            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {
                if (Path.GetExtension(fileName).ToLower() == ".xml")
                {
                    SpecialQuilityInfo sq = new SpecialQuilityInfo(fileName);
                    m_specialQuilityData.Add(sq.Code, sq);
                }
            }
        }

        // 주문 정보 가져오기
        public void LoadAllSpellData()
        {
            // xml 파일이 저장되는 경로
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath)
                        + Setting.instance.SpellFolder;

            string[] files = Directory.GetFiles(path);
            foreach (string fileName in files)
            {
                if (Path.GetExtension(fileName).ToLower() == ".xml")
                {
                    SpellInfo spell = new SpellInfo(fileName);
                    m_spellData.Add(spell.Code, spell);
                }
            }
        }

        public Item GetItem(string code)
        {
            if (m_itemData.ContainsKey(code))
                return m_itemData[code];
            else
                return Item.GetUndefinedItem("'" + code + "' : 존재하지 않는 아이템");
        }

        public ClassInfo GetClass(string code)
        {
            if( m_classData.ContainsKey(code) )
                return m_classData[code];
            else
                return null; // 에러용 빈 클래스 객체를 생성하는 new 구문으로 바꾸는게 좋을 듯.
        }

        public SpellInfo GetSpell(string code)
        {
            if (m_spellData.ContainsKey(code))
                return m_spellData[code];
            else
                return null;
        }
/*
        SpecialQuilityInfo GetSpecialQuility(string code)
        {
            if (m_specialQuilityData.ContainsKey(code))
                return m_specialQuilityData[code];
            else
                return null;
        }
*/
    }
}
