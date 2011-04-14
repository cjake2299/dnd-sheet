using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
	public class Value
	{
		#region 멤버 변수
		int m_baseValue; // 기본수치
		int m_cachedValue; // 수정치가 적용된 결과값을 저장하는 변수. 캐싱용.
		int m_limit = 65535; // 상한치. 디폴트는 적당히 큰 값.
		string m_desctiption;

		List<string> m_relatedEffectTypes = new List<string>(); // 수치값에 영향을 주는 이펙트의 식별자들
		Dictionary<Value, double> m_relatedValues = new Dictionary<Value, double>(); // 수치값에 영향을 주는 다른 수치값과 비율의 쌍.
		readonly SheetManager m_parent; // 시트 매니저 클래스의 레퍼런스. 설정되면 변할 일이 없음.
		#endregion

		#region 생성자
        public Value(SheetManager parent)
        {
            m_parent = parent;
        }

		public Value(SheetManager parent, string relatedEffectType)
		{
			m_relatedEffectTypes.Add(relatedEffectType);
			m_parent = parent;
		}
		#endregion

		#region 값/수정치 추가 함수들
		public void SetBaseValue(int value) { m_baseValue = value; }

		public void AddRelatedEffectType(string relatedEffectType) { m_relatedEffectTypes.Add(relatedEffectType); }

		public void AddModifiers(Value value, double ratio) { m_relatedValues.Add(value, ratio); }
		#endregion

		public int GetValue() { return GetValue(true); }

		public int GetValue(bool isUpdate)
		{
			if (isUpdate) Update();
			return m_cachedValue;
		}

		public void Update()
		{
			if (m_parent == null) return;

			try
			{
				// 기본값
				int resultValue = m_baseValue;

				// 연관된 수치에 의한 수정치 반영
				foreach (KeyValuePair<Value, double> modifier in m_relatedValues)
				{
					resultValue += (int)(modifier.Key.GetValue() * modifier.Value);
				}

				// 이펙트에 의한 수정치 반영
				foreach (string effectTypeIdentifier in m_relatedEffectTypes)
				{
					resultValue += m_parent.GetEffectValue(effectTypeIdentifier);
				}

				m_cachedValue = resultValue;
			}
			catch (Exception e)
			{
				return;
			}
        }
	}
}
