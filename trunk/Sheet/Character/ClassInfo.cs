using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace Sheet
{
    public class ClassInfo
    {
        #region 멤버
        public enum ClassBABType { Good, Average, Poor, Undefined }
        public enum ClassSaveType { Good, Poor, Undefined }

        string m_code;
        string m_name;
        ClassBABType m_BABType;
        ClassSaveType m_fort;
        ClassSaveType m_ref;
        ClassSaveType m_will;
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public ClassBABType BABType { get { return m_BABType; } }
        public ClassSaveType Fort { get { return m_fort; } }
        public ClassSaveType Ref { get { return m_ref; } }
        public ClassSaveType Will { get { return m_will; } }

        #endregion

        #region 생성자
        public ClassInfo()
        {

        }

        public ClassInfo(string path)
        {
            LoadClassData(path);
        }

        #endregion

        #region 메소드
        public void LoadClassData(string path)
        {
            XmlNode node;

			#region XML 파일 로드
			XmlElement root = Util.LoadXMLFile(path);
			if (root == null) return;
			#endregion

            #region 클래스 코드 얻기
            m_code = Util.GetNodeAttribute(root, "code").ToUpper();  // 모든 코드는 대문자.
			if (m_code == string.Empty)
				return;
            #endregion

            #region 클래스 이름 얻기
            node = root.SelectSingleNode("/Class/Name/" + Setting.instance.Language);
            m_name = Util.GetNodeData(node);
			if (m_name == string.Empty)
				m_name = "이름 없음";
            #endregion

            #region BAB 타입 얻기
            node = root.SelectSingleNode("/Class/BAB");
            string BABTypeStr = Util.GetNodeData(node);

			switch (BABTypeStr.ToUpper())
            {
                case "GOOD": m_BABType = ClassBABType.Good; break;
                case "AVERAGE": m_BABType = ClassBABType.Average; break;
                case "POOR":
                case "BAD": m_BABType = ClassBABType.Poor; break;
                default: m_BABType = ClassBABType.Undefined; break;
            }
            #endregion

            #region 내성 타입 얻기
            node = root.SelectSingleNode("/Class/Save/Fort");
            m_fort = GetSaveType(Util.GetNodeData(node));

            node = root.SelectSingleNode("/Class/Save/Ref");
            m_ref = GetSaveType(Util.GetNodeData(node));

            node = root.SelectSingleNode("/Class/Save/Will");
            m_will = GetSaveType(Util.GetNodeData(node));

            #endregion
        }

        private ClassSaveType GetSaveType(string saveType)
        {
            if (saveType == null) 
                return ClassSaveType.Undefined;

            switch (saveType.ToUpper())
            {
                case "GOOD": 
                    return ClassSaveType.Good;
                case "POOR":
                case "BAD": 
                    return ClassSaveType.Poor;
                default: 
                    return ClassSaveType.Undefined;
            }
        }
        #endregion
    }
}
