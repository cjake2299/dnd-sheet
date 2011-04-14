using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
	public class SheetManager
	{
		List<Value> m_values = new List<Value>();
		List<EffectSet> m_effects = new List<EffectSet>();

		#region ��Ʈ �� �Է��Լ�
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
			// ������ ����Ʈ. Ÿ��-����ġ ������ ����� ����ȴ�.
			Dictionary<string, int> ModifierTable = new Dictionary<string, int>();

			foreach (EffectSet effectSet in m_effects)
			{
				foreach (Effect effect in effectSet.EffectList)
				{
					if (effect.TypeCode == type)
					{
						if (ModifierTable.ContainsKey(effect.ModifierType))
						{
							// ���� ���ʽ� Ÿ���� ��� ���� ���� ���� �����Ѵ�.
							if (ModifierTable[effect.ModifierType] < effect.Value)
								ModifierTable[effect.ModifierType] = effect.Value;
						}
						else
						{
							// ���� ���ʽ� Ÿ���� ���ٸ� �׳� �Է�.
							ModifierTable[effect.ModifierType] = effect.Value;
						}
					}
				}
			}

			// �з��� ���� ����Ʈ�� ����ġ���� �����Ѵ�.
			foreach (KeyValuePair<string, int> valuePair in ModifierTable)
			{
				totalValue += valuePair.Value;
			}

			return totalValue;
		}
	}
}   
