
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Xml;

namespace WeiXin.Common
{
    public static class OperateXml
    {



        /// <summary>
        ///  解析传递过来的XML文件,存储到字典中
        /// </summary>
        /// <param name="xml">XML</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 16:56:47
        public static Dictionary<string, string> ReadXml(this string xml)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            if (doc.DocumentElement != null)
            {
                XmlNodeList data = doc.DocumentElement.ChildNodes;
                for (int i = 0; i < data.Count; i++)
                {
                    XmlNode node = data.Item(i);
                    if (node != null)
                    {
                        dic.Add(node.LocalName, node.InnerText);
                    }
                }
            }
            return dic;
        }

        /// <summary>
        ///  读取值
        /// </summary>        
        /// <param name="dic">Dictionary</param>
        /// <param name="key">key</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 20:23:49
        public static string ReadKey(this Dictionary<string, string> dic, string key)
        {
            string value;
            dic.TryGetValue(key, out value);
            return value;
        }

        /// <summary>
        ///  输出回复信息
        /// </summary>
        /// <param name="msg">Msg</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 20:30:59
        public static void ResponseEnd(string msg)
        {
            HttpContext.Current.Response.ContentEncoding = Encoding.UTF8;
            HttpContext.Current.Response.Write(msg);
            HttpContext.Current.Response.End();
        }



    }
}
