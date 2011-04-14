using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
	public class Value
	{
		#region ��� ����
		int m_baseValue; // �⺻��ġ
		int m_cachedValue; // ����ġ�� ����� ������� �����ϴ� ����. ĳ�̿�.
		int m_limit = 65535; // ����ġ. ����Ʈ�� ������ ū ��.
		string m_desctiption;

		List<string> m_relatedEffectTypes = new List<string>(); // ��ġ���� ������ �ִ� ����Ʈ�� �ĺ��ڵ�
		Dictionary<Value, double> m_relatedValues = new Dictionary<Value, double>(); // ��ġ���� ������ �ִ� �ٸ� ��ġ���� ������ ��.
		readonly SheetManager m_parent; // ��Ʈ �Ŵ��� Ŭ������ ���۷���. �����Ǹ� ���� ���� ����.
		#endregion

		#region ������
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

		#region ��/����ġ �߰� �Լ���
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
				// �⺻��
				int resultValue = m_baseValue;

				// ������ ��ġ�� ���� ����ġ �ݿ�
				foreach (KeyValuePair<Value, double> modifier in m_relatedValues)
				{
					resultValue += (int)(modifier.Key.GetValue() * modifier.Value);
				}

				// ����Ʈ�� ���� ����ġ �ݿ�
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
