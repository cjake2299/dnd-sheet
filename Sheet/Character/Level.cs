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
                // 해당 레벨의 클래스코드 얻기.
				string classCode = Util.GetNodeData(level.SelectSingleNode("./ClassCode"));
                // 해당 레벨의 HP 얻기
                int hitPoint = Util.GetNodeIntData(level.SelectSingleNode("./HP"));
                // 레벨정보에 추가.
				m_levelInfo.Add(new LevelData(classCode, hitPoint));
			}

            // 클래스레벨 정보 얻기.
            Dictionary<string, int> classLevels = GetLevelInfo();
            // 각각의 클래스레벨에 대해
            foreach (KeyValuePair<string, int> classLevel in classLevels)
            {
                // 해당 클래스가 존재하지 않으면 에러.
                if(!DataManager.Instance.ClassData.ContainsKey(classLevel.Key))
                {
                    LogManager.Instance.AddLog("Load class feature", ErrorLog.LogType.Error, 
                                                "'" + classLevel.Key + "' 에 해당하는 클래스가 없습니다.",
                                                "클래스 정보가 없습니다. 코드가 잘못되었거나 해당 xml 파일이 없는지 확인하십시오.");
                    continue;
                }
                
                // 각 클래스 레벨에 대해 루프를 돌며 클래스피쳐 목록을 가져온다.
                Dictionary<int, List<SpecialQuilityInfo>> features = DataManager.Instance.ClassData[classLevel.Key].Features;
                for (int i = 0; i < classLevel.Value; i++)
                {
                    // 클래스피쳐가 존재한다면
                    if (features.ContainsKey(i))
                    {
                        // 클래스피쳐 전부를 SQ로 등록한다.
                        foreach (SpecialQuilityInfo SQ in features[i])
                            AddSpecialQuility(SQ);
                    }
                }
            }
		}
    }
}
