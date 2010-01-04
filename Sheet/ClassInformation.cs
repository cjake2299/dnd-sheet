using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;


namespace Sheet
{
    public class ClassInformation
    {
        #region 멤버
        public enum ClassBABType { Good, Average, Poor, Undefined }

        string m_code;
        string m_name;
        ClassBABType m_BABType;
        #endregion

        #region 프로퍼티
        public string Code { get { return m_code; } }
        public string Name { get { return m_name; } }
        public ClassBABType BABType { get { return m_BABType; } }

        #endregion

        #region 생성자
        public ClassInformation()
        {

        }

        public ClassInformation(string path)
        {
            LoadClassData(path);
        }

        #endregion

        #region 메소드
        public void LoadClassData(string path)
        {
            XmlDocument doc = new XmlDocument();

            #region XML 파일 로드
            try
            {
                doc.Load(path);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            XmlElement root = doc.DocumentElement;
            #endregion

            #region 클래스 코드 얻기
            m_code = root.GetAttribute("code").Trim();
            if (m_code == null)
            {
                // 에러 처리
                LogManager.Instance.AddLog("클래스 코드 읽기", ErrorLog.LogType.Error, 
                                        "XML 파일 내에 클래스 코드 어트리뷰트가 정의되지 않았습니다.", 
                                        "XML 파일의 내용이 맞지 않습니다. 해당 파일을 점검해보십시오.",
                                        path);
                m_code = "UNDEFINED";
            }
            #endregion

            #region 클래스 이름 얻기
            XmlNode className = root.SelectSingleNode("/Class/Name/" + Setting.instance.Language);
            if (className == null)
            {
                // 에러 처리
                LogManager.Instance.AddLog("클래스 이름 읽기", ErrorLog.LogType.Error,
                                        "XML 파일 내에 클래스 이름 엘리먼트가 정의되지 않았습니다.",
                                        "XML 파일의 내용이 맞지 않습니다. 해당 파일을 점검해보십시오.",
                                        path);
                m_name = "이름 없음";
            }
            m_name = className.FirstChild.Value.Trim();
            #endregion

            #region BAB 타입 얻기
            XmlNode BABNode = root.SelectSingleNode("/Class/BAB");
            if (BABNode == null)
            {
                // 에러 처리
                LogManager.Instance.AddLog("클래스 이름 읽기", ErrorLog.LogType.Error,
                                        "XML 파일 내에 클래스 BAB 타입 엘리먼트가 정의되지 않았습니다.",
                                        "XML 파일의 내용이 맞지 않습니다. 해당 파일을 점검해보십시오.",
                                        path);
                m_BABType = ClassBABType.Undefined;
            }

            switch (BABNode.FirstChild.Value.Trim().ToLower())
            {
                case "good": m_BABType = ClassBABType.Good; break;
                case "average": m_BABType = ClassBABType.Average; break;
                case "poor":
                case "bad": m_BABType = ClassBABType.Poor; break;
                default: m_BABType = ClassBABType.Undefined; break;
            }
            #endregion
        }
        #endregion
    }
}
