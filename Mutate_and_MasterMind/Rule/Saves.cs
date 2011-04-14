using System;
using System.Collections.Generic;
using System.Text;

namespace Sheet
{
    partial class CharacterSheet
    {
        public int GetFort()
        {
            int fort = 0;

            // 레벨에 따른 내성보너스 읽어오기
            Dictionary<string, int> characterlevel = GetLevelInfo();
            foreach (KeyValuePair<string, int> classlevel in characterlevel)
            {
                fort += GetSaveValue(classlevel.Value, DataManager.Instance.ClassData[classlevel.Key].Fort);
            }

            // 건강수정치 계산
            fort += GetConBonus();

            // 이펙트에 의한 수정치 계산
            fort += GetEffectValue("SAVE_FORT_BONUS");
			fort += GetEffectValue("ALL_SAVE_BONUS");

            return fort;
        }

        public int GetRef()
        {
            int reflex = 0;

            // 레벨에 따른 내성보너스 읽어오기
            Dictionary<string, int> characterlevel = GetLevelInfo();
            foreach (KeyValuePair<string, int> classlevel in characterlevel)
            {
                reflex += GetSaveValue(classlevel.Value, DataManager.Instance.ClassData[classlevel.Key].Ref);
            }

            // 건강수정치 계산
            reflex += GetDexBonus();

            // 이펙트에 의한 수정치 계산
            reflex += GetEffectValue("SAVE_REF_BONUS");
			reflex += GetEffectValue("ALL_SAVE_BONUS");

            return reflex;
        }

        public int GetWill()
        {
            int will = 0;

            // 레벨에 따른 내성보너스 읽어오기
            Dictionary<string, int> characterlevel = GetLevelInfo();
            foreach (KeyValuePair<string, int> classlevel in characterlevel)
            {
                will += GetSaveValue(classlevel.Value, DataManager.Instance.ClassData[classlevel.Key].Will);
            }

            // 건강수정치 계산
            will += GetWisBonus();

            // 이펙트에 의한 수정치 계산
            will += GetEffectValue("SAVE_WILL_BONUS");
			will += GetEffectValue("ALL_SAVE_BONUS");

            return will;
        }

        private int GetSaveValue(int level, ClassInfo.ClassSaveType type)
        {
            switch(type)
            {
                case ClassInfo.ClassSaveType.Good:
                    return 2 + level / 2;
                case ClassInfo.ClassSaveType.Poor:
                    return level / 3;
                default:
                    return 0;
            }
        }
	}
}
