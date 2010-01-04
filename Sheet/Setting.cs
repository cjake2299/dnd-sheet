using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
    class Setting
    {
        #region 멤버
        string m_language;
        string m_classDataFolder;
        string m_characterSheetFolder;
        string m_itemFolder;
        string m_raceFolder;
        string m_skillFolder;
        string m_featFolder;
        string m_specialQuilityFolder;
        string m_spellFolder;
        #endregion

        #region 프로퍼티
        public string Language { get { return m_language; } }
        public string ClassDataFolder { get { return m_classDataFolder; } }
        public string CharacterSheetFolder { get { return m_characterSheetFolder; } }
        public string ItemFolder { get { return m_itemFolder; } }
        public string RaceFolder { get { return m_raceFolder; } }
        public string SkillFolder { get { return m_skillFolder; } }
        public string FeatFolder { get { return m_featFolder; } }
        public string SpecialQuilityFolder { get { return m_specialQuilityFolder; } }
        public string SpellFolder { get { return m_spellFolder; } }
        #endregion

        // singleton 구현
        public static readonly Setting instance = new Setting();
        public Setting Instance
        {
            get { return instance; }
        }

        private Setting()
        {
            m_language = "Korean";
            m_classDataFolder = @"\..\data\class";
            m_characterSheetFolder = @"\..\data\charactersheet";
            m_itemFolder = @"\..\data\item";
            m_raceFolder = @"\..\data\race";
            m_skillFolder = @"\..\data\skill";
            m_featFolder = @"\..\data\feat";
            m_specialQuilityFolder = @"\..\data\specialquility";
            m_spellFolder = @"\..\data\spell";
        }
    }
}
