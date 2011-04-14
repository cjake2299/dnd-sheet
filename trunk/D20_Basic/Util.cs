using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace D20_Basic
{
	public static class Util
	{
		public static XmlElement LoadXMLFile(string path)
		{
			XmlDocument doc = new XmlDocument();

			try
			{
				doc.Load(path);

				return doc.DocumentElement;
			}
			catch (Exception ex) // 에러는 종류별로 좀 더 세분화시켜서 로그를 남길 수 있을 듯.
			{
                string filename = System.IO.Path.GetFileName(path);
                LogManager.Instance.AddLog("파일 불러오기", ErrorLog.LogType.Error,
                                            filename + " 파일을 읽어오는 데 실패했습니다.", ex.Message);
				/*
				using (ErrorLogForm dlg = new ErrorLogForm())
				{
					dlg.ViewErrors();
				}
				*/
				return null;

			}
		}

		public static string GetNodeData(XmlNode rootNode, string xmlPath)
		{
			return GetNodeData(rootNode, xmlPath, true);
		}

		public static string GetNodeData(XmlNode rootNode, string xmlPath, bool isMessageError)
		{
			XmlNode node = rootNode.SelectSingleNode(xmlPath);
			if (node == null)
			{
				if (isMessageError)
				{
					LogManager.Instance.AddLog("Get Element", ErrorLog.LogType.Error,
											"'" + xmlPath + "' 엘리먼트가 없습니다",
											"전달된 엘리먼트가 null입니다. 다른 곳에서 앨리먼트 정보를 읽는 데 실패했는지 확인하십시오.");
				}
				return string.Empty;
			}
			return GetNodeData(node, isMessageError);
		}

		public static string GetNodeData(XmlNode node, bool isMessageError)
		{
			if (node == null)
			{
				if (isMessageError)
				{
					LogManager.Instance.AddLog("Undefined", ErrorLog.LogType.Error,
											"앨리먼트가 없습니다",
											"전달된 엘리먼트가 null입니다. 다른 곳에서 앨리먼트 정보를 읽는 데 실패했는지 확인하십시오.");
				}
				return string.Empty;
			}
			if (node.FirstChild == null)
			{
				if (isMessageError)
				{
					LogManager.Instance.AddLog(node.OwnerDocument.Name, ErrorLog.LogType.Error,
												"'" + node.Name + "' 엘리먼트에 값이 없습니다.",
												"엘리먼트가 없거나 비어 있습니다. xml 파일의 내용을 확인하십시오.");
				}
				return string.Empty;
			}

			return node.FirstChild.Value.Trim();
		}

		public static string GetNodeData(XmlNode node)
		{
			return GetNodeData(node, true);
		}

		public static int GetNodeIntData(XmlNode rootNode, string xmlPath, bool isMessageError)
		{
			XmlNode node = rootNode.SelectSingleNode(xmlPath);
			if (node == null)
			{
				if (isMessageError)
				{
					LogManager.Instance.AddLog("Get Element", ErrorLog.LogType.Error,
											"'" + xmlPath + "' 엘리먼트가 없습니다",
											"전달된 엘리먼트가 null입니다. 다른 곳에서 앨리먼트 정보를 읽는 데 실패했는지 확인하십시오.");
				}
				return 0;
			}
			return GetNodeIntData(node, isMessageError);
		}

		public static int GetNodeIntData(XmlNode rootNode, string xmlPath)
		{
			return GetNodeIntData(rootNode, xmlPath, true);
		}

		public static int GetNodeIntData(XmlNode node, bool isMessageError)
		{
			string buf = GetNodeData(node, isMessageError);
            if (buf == string.Empty) return 0; // 노드 읽을 때 에러가 났으면 에러메세지는 이미 출력되었을 것이므로 패스.

            try
			{
				int value = int.Parse(buf);
				return value;
			}
			catch (Exception ex)
			{
                LogManager.Instance.AddLog(node.OwnerDocument.Name, ErrorLog.LogType.Error,
                                            "'" + node.Name + "' 엘리먼트의 값이 정수가 아니거나 범위를 초과했습니다.", 
											ex.Message);
				return 0;
			}
		}

		public static int GetNodeIntData(XmlNode node)
		{
			return GetNodeIntData(node, true);
		}

		public static double GetNodeDoubleData(XmlNode rootNode, string xmlPath, bool isMessageError)
		{
			XmlNode node = rootNode.SelectSingleNode(xmlPath);
			if (node == null)
			{
				if (isMessageError)
				{
					LogManager.Instance.AddLog("Get Element", ErrorLog.LogType.Error,
											"'" + xmlPath + "' 엘리먼트가 없습니다",
											"전달된 엘리먼트가 null입니다. 다른 곳에서 앨리먼트 정보를 읽는 데 실패했는지 확인하십시오.");
				}
				return 0.0;
			}
			return GetNodeDoubleData(node, isMessageError);
		}

		public static double GetNodeDoubleData(XmlNode rootNode, string xmlPath)
		{
			return GetNodeDoubleData(rootNode, xmlPath, true);
		}

		public static double GetNodeDoubleData(XmlNode node, bool isMessageError)
		{
			string buf = GetNodeData(node, isMessageError);
            if (buf == string.Empty) return 0; // 노드 읽을 때 에러가 났으면 에러메세지는 이미 출력되었을 것이므로 패스.

			try
			{
				double value = double.Parse(buf);
				return value;
			}
			catch (Exception ex)
			{
				LogManager.Instance.AddLog("캐릭터 시트 파일 불러오기", ErrorLog.LogType.Error,
                                            "'" + node.Name + "' 엘리먼트의 값이 실수가 아니거나 범위를 초과했습니다.",
											ex.Message);
				return 0;
			}
		}

		public static double GetNodeDoubleData(XmlNode node)
		{
			return GetNodeDoubleData(node, true);
		}

        public static int GetNodeIntAttribute(XmlNode node, string attributeName)
        {
            return ParseToInt( GetNodeAttribute(node, attributeName) );
        }

		public static string GetNodeAttribute(XmlNode node, string attributeName)
		{
            if (node == null)
            {
                LogManager.Instance.AddLog("Undefined", ErrorLog.LogType.Error,
                                        "앨리먼트가 없습니다",
                                        "전달된 엘리먼트가 null입니다. 다른 곳에서 앨리먼트 정보를 읽는 데 실패했는지 확인하십시오.");
            }

			string attr = node.Attributes[attributeName].Value;
			if (attr == null)
			{
				// 에러 처리
                LogManager.Instance.AddLog(node.OwnerDocument.Name, ErrorLog.LogType.Error,
                                        node.Name + " 앨리먼트에 " + attributeName + " 어트리뷰트가 정의되지 않았습니다.",
										"어트리뷰트 항목이 없거나 값이 null입니다. XML 파일의 내용을 점검해보십시오.");
				return string.Empty;
			}
			return attr.Trim();
		}

        public static int ParseToInt(string str)
        {
            int value;
            try
            {
                value = int.Parse(str.Trim());
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog(str, ErrorLog.LogType.Error,"'" + str + "'은(는) 정수가 아니거나 범위를 벗어났습니다.", "");
                value = 0;
            }

            return value;
        }

        public static double ParseToDouble(string str)
        {
            double value;
            try
            {
                value = double.Parse(str.Trim());
            }
            catch (Exception ex)
            {
                LogManager.Instance.AddLog(str, ErrorLog.LogType.Error,"'" + str + "'은(는) 실수가 아니거나 범위를 벗어났습니다.", "");
                value = 0;
            }

            return value;
        }
	}
}
