using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
    partial class CharacterSheet
    {
        string m_selectedSpellCastingClass = string.Empty;

        public string SelectedSpellCastingClass 
        { 
            get { return m_selectedSpellCastingClass; }
            set { m_selectedSpellCastingClass = value; }
        }

        public int GetCasterLevel()
        {
            int casterLevel = 0;

            // 클래스 얻어오기
            ClassInfo casterClass =  DataManager.Instance.GetClass(m_selectedSpellCastingClass);

            // 데이터에 없는 클래스면 캐스터레벨 0을 반환.
            if(casterClass == null) return 0;

            // 선택된 캐릭터가 캐릭터가 가진 클래스인지 확인해서 
            int classLevel = GetClassLevel(m_selectedSpellCastingClass);
            if ( classLevel > 0 )
                // 클래스레벨에 캐스터레벨 비율을 나눈 값이 기본 캐스터레벨임.
                casterLevel = classLevel / casterClass.CasterLevelRatio; 
            else
                return 0; // 0을 나누면 에러가 나니까.. -_-;

            casterLevel += GetEffectValue("CASTER_LEVEL_BONUS"); // 캐스터레벨에 영향을 주는 이펙트를 활성화된 이펙트 목록에서 검색한다.

            return casterLevel;
        }

        public int GetSpellPerDay(int spellLevel)
        {
            int count = 0;

            // 클래스 얻어오기
            ClassInfo casterClass = DataManager.Instance.GetClass(m_selectedSpellCastingClass);
            // 데이터에 없는 클래스면 갯수 0을 반환.
            if (casterClass == null) return 0;

            // 클래스레벨 얻어오기
            int classLevel = GetClassLevel(m_selectedSpellCastingClass);
            // 캐릭터에 없는 클래스면 0을 반환
            if(classLevel < 1) return 0;

            count = casterClass.SpellPerDay[classLevel, spellLevel];

            count += GetEffectValue("LEVEL_" + spellLevel + "_SPELL_COUNT_BOUNS");

            return count;
        }

        public int GetBaseSpellDC()
        {
            int dc = 10;
            // 연관능력치 정보 얻기

            return dc;
        }

        public string[] GetSpells(int level)
        {
            List<string> spells = new List<string>();


            return spells.ToArray();
        }

        SpellInfo GetSpell(string spellCode)
        {
            if (DataManager.Instance.SpellData.ContainsKey(spellCode))
                return DataManager.Instance.SpellData[spellCode];
            else
                return null;
        }
    }
}
