using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    public class SpellState
    {
        public string code;
        public bool isUsing;

        public SpellState(string code, bool isUsing)
        {
            this.code = code;
            this.isUsing = isUsing;
        }
    }

    partial class CharacterSheet
    {
        public int GetCasterLevel(string classCode)
        {
            int casterLevel = 0;

            // 클래스 얻어오기
            ClassInfo casterClass =  DataManager.Instance.GetClass(classCode);

            // 데이터에 없는 클래스면 캐스터레벨 0을 반환.
            if(casterClass == null) return 0;

            // 선택된 캐릭터가 캐릭터가 가진 클래스인지 확인해서 
            int classLevel = GetClassLevel(classCode);
            if ( classLevel > 0 )
                // 클래스레벨에 캐스터레벨 비율을 나눈 값이 기본 캐스터레벨임.
                casterLevel = classLevel / casterClass.CasterLevelRatio; 
            else
                return 0; // 0을 나누면 에러가 나니까.. -_-;

            casterLevel += GetEffectValue("CASTER_LEVEL_BONUS"); // 캐스터레벨에 영향을 주는 이펙트를 활성화된 이펙트 목록에서 검색한다.

            return casterLevel;
        }

        public int GetSpellPerDay(string classCode, int spellLevel)
        {
            int count = 0;

            // 클래스 얻어오기
            ClassInfo casterClass = DataManager.Instance.GetClass(classCode);
            // 데이터에 없는 클래스면 갯수 0을 반환.
            if (casterClass == null) return 0;

            // 클래스레벨 얻어오기
            int classLevel = GetClassLevel(classCode);
            // 캐릭터에 없는 클래스면 0을 반환
            if(classLevel < 1) return 0;

            // 기본 주문 갯수 얻기
            count = casterClass.SpellPerDay[classLevel, spellLevel];
            if (count < 0) return 0; // -1일 경우 해당주문 사용불가.

            // 능력치에 의한 추가 주문 갯수 얻기.
            if (spellLevel > 0) // 0레벨은 능력치에 의한 추가주문갯수가 없음
            {
                int bonus = GetAbilityBonus(casterClass.RelatedAbility);
                if (bonus == spellLevel) count += 1; // 0으로 나눌 수 없으므로 예외처리해줌.
                else if(bonus > spellLevel) count += (bonus - spellLevel) / 4 + 1;
            }

            // 이펙트에 따른 주문 개수 보너스 얻기.
            count += GetEffectValue("LEVEL_" + spellLevel + "_SPELL_COUNT_BOUNS");

            return count;
        }

        public int GetBaseSpellDC(string classCode)
        {
            int dc = 10;
            // 연관능력치 정보 얻기

            // 클래스 얻어오기
            ClassInfo casterClass = DataManager.Instance.GetClass(classCode);

            // 데이터에 없는 클래스면 DC 0을 반환.
            if (casterClass == null) return 0;

            // 연관능력치의 보너스를 주문의 DC에 추가.
            dc += GetAbilityBonus(casterClass.RelatedAbility);

            return dc;
        }

        public List<SpellState> GetPreparedSpellList(string classCode, int level)
        {
            if (!m_spellList.ContainsKey(classCode)) return null;
            if (!m_spellList[classCode].ContainsKey(level)) return null;

            return m_spellList[classCode][level];
        }

        public void ActiveSpell(string spellCode)
        {
            SpellInfo spell = DataManager.Instance.GetSpell(spellCode);
            if (spell == null) return;

            // 이팩트 모두를 활성화시킨다.(주문에는 패시브 이펙트가 없다)
            foreach (EffectSet effectSet in spell.Effects)
            {
                m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
            }
        }

        public void LoadPreparedSpells(XmlNode root)
        {
            //m_spellList =Dictionary<string, Dictionary<int, List<KeyValuePair<string, bool>>>>();
            XmlNodeList classes = root.SelectNodes("/CharacterSheet/Spells//CasterClass");
            foreach (XmlNode casterclass in classes)
            {
                string classCode = Util.GetNodeAttribute(casterclass, "code");
                // 스펠리스트 테이블에 해당 클래스가 없을 경우, 생성한다.
                if (!m_spellList.ContainsKey(classCode))
                    m_spellList.Add(classCode, new Dictionary<int, List<SpellState>>());
                // 클래스의 주문 목록.
                Dictionary<int, List<SpellState>> spellListByClass = m_spellList[classCode];

                XmlNodeList levels = casterclass.SelectNodes(".//Level");
                foreach (XmlNode spellLevel in levels)
                {
                    int lv = Util.GetNodeIntAttribute(spellLevel, "number");
                    // 해당 레벨에 해당하는 리스트 없으면 생성.
                    if (!spellListByClass.ContainsKey(lv)) spellListByClass.Add(lv, new List<SpellState>());
                    // 레벨별 주문 목록.
                    List<SpellState> spellListByLevel = spellListByClass[lv];

                    XmlNodeList spells = spellLevel.SelectNodes(".//Spell");
                    foreach (XmlNode spell in spells)
                    {
                        // 주문 추가.
                        spellListByLevel.Add(
                            new SpellState( Util.GetNodeAttribute(spell, "code"),
                                            Util.GetNodeData(spell, "./Using", false).ToUpper() == "TRUE" ? true : false )
                        );
                    }
                }

            }
        }
    }
}
