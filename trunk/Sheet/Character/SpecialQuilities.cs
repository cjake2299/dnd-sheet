using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
    partial class CharacterSheet
    {
        public void AddSpecialQuility(SpecialQuilityInfo SQ)
        {
            // 특수능력 추가.
            m_specialQuilities.Add(SQ);

            // 이펙트 등록
            foreach(EffectSet effectSet in SQ.Effects)
            {
                // 패시브 이펙트일 경우만
                if (effectSet.Type == EffectSet.EffectType.passive)
                    m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
            }
        }

        public void ActiveSpecialQuility(SpecialQuilityInfo SQ)
        {
            // 액티브 이팩트 모두를 활성화시킨다.
            foreach (EffectSet effectSet in SQ.Effects)
            {
                //  액티브 이펙트일 경우만
                if (effectSet.Type == EffectSet.EffectType.active)
                    m_effects.Add(effectSet); // 활성화된 이펙트 목록에 이펙트를 추가한다.
            }
        }
    }
}
