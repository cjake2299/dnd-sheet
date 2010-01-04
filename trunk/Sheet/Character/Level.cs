using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Sheet
{
    public class LevelData
    {
        string m_classCode;
        int m_hitPoint;
        //string skillCode;
        //int usedSkillPoint;
        //string featCode;

        public string ClassCode { get { return m_classCode; } }
        public int HP { get { return m_hitPoint; } }

        public LevelData(string classCode, int hitPoint)
        {
            this.m_classCode = classCode;
            this.m_hitPoint = hitPoint;
        }
    }

    partial class CharacterSheet
    {
        Dictionary<string, int> GetLevelInfo()
        {
            Dictionary<string, int> levels = new Dictionary<string, int>();

            foreach (LevelData data in m_levelInfo)
            {
                if (levels.ContainsKey(data.ClassCode))
                {
                    levels[data.ClassCode]++;
                }
                else
                {
                    levels[data.ClassCode] = 1;
                }
            }

            return levels;
        }

        public string GetLevelInfoStr()
        {
            Dictionary<string, int> levels = GetLevelInfo();
            List<string> levelInfoStr = new List<string>();

            foreach (KeyValuePair<string, int> level in levels)
            {
                levelInfoStr.Add(level.Key + " " + level.Value);
            }

            return string.Join(" / ", levelInfoStr.ToArray());
        }

		public int GetTotalLevel()
		{
			return m_levelInfo.Count;
		}

		public int GetHD()
		{
			// 토탈레벨+종족 베이스 HD+이펙트에 의한 수정치.
			return GetTotalLevel();
		}

		public int GetECL()
		{
			// 토탈레벨+템플릿이나 종족수정치
			return GetTotalLevel();
		}

		private void LoadLevelInfo(XmlElement root)
		{
			XmlNodeList levels = root.SelectNodes("/CharacterSheet/LevelInfo//Level");
			foreach (XmlNode level in levels)
			{
				string classCode = Util.GetNodeData(level.SelectSingleNode("./ClassCode"));
                int hitPoint = Util.GetNodeIntData(level.SelectSingleNode("./HP"));
				m_levelInfo.Add(new LevelData(classCode, hitPoint));
			}
		}
    }
}
