using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
	public class SheetManager
	{
		List<Value> m_values = new List<Value>();
		List<EffectSet> m_effects = new List<EffectSet>();

		#region 시트 값 입력함수
		Value AddValue() 
		{
			return AddValue( new Value(this) );
		}
		Value AddValue(string relatedEffectType)
		{
			return AddValue( new Value(this, relatedEffectType) );
		}

		Value AddValue(Value val)
		{
			m_values.Add(val);
			return val;
		}
		#endregion

		public int GetEffectValue(string type)
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
