using System;
using System.Collections.Generic;
using System.Text;

namespace D20_Basic
{
        #region 로그 메세지 구조체 정의
        public struct ErrorLog
        {
            #region 멤버 정의
            public enum LogType { Error, Warning }

            DateTime time;
            string fileName;
            string filePath;
            string taskName;
            LogType type;
            string message;
            string description;
            #endregion

            #region 프로퍼티
            public DateTime Time { get { return time; } }
            public string FileName { get { return fileName; } }
            public string FilePath { get { return filePath; } }
            public string TaskName { get { return taskName; } }
            public LogType Type { get { return type; } }
            public string TypeStr
            {
                get
                {
                    switch (type)
                    {
                        case LogType.Error: return "Error";
                        case LogType.Warning: return "Warning";
                        default: return "Undefined Type";
                    }
                }
            }
            public string Message { get { return message; } }
            public string Description { get { return description; } }
            #endregion

            #region 생성자
			public ErrorLog(DateTime time, LogType type, string taskName, string message, string description, string fileName,
                                    string filePath)
            {
                this.time = time;
                this.type = type;
                this.taskName = taskName;
                this.message = message;
                this.description = description;
                this.fileName = fileName;
                this.filePath = filePath;
            }
            #endregion
        }
        #endregion

    public class LogManager
    {
        // singleton 구현
        public static readonly LogManager Instance = new LogManager();

        // 실제 구현
        List<ErrorLog> logs;
        public List<ErrorLog> Logs { get { return logs; } }

        // 생성자
        private LogManager()
        {
            logs = new List<ErrorLog>();
        }

        public void AddLog(string taskName, ErrorLog.LogType type, string message, string description)
        {
            AddLog(taskName, type, message, description, "", "");
        }

        public void AddLog(string taskName, ErrorLog.LogType type, string message, string description, string fileFullPath)
        {
            AddLog(taskName, type, message, description,
                    System.IO.Path.GetDirectoryName(fileFullPath),
                    System.IO.Path.GetFileName(fileFullPath));
        }

        public void AddLog(string taskName, ErrorLog.LogType type, string message, string description, string filePath, string fileName)
        {
			logs.Add(new ErrorLog(DateTime.Now, type, taskName, message, description, fileName, filePath));
        }

        public void ClearLog()
        {
            Logs.Clear();
        }

        public int GetErrorCount()
        {
            return Logs.Count;
        }
    }
}
