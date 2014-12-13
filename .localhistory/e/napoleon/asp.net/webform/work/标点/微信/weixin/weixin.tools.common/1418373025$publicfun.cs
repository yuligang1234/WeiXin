
using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using WeiXin.Tools.Model;

namespace WeiXin.Tools.Common
{

    /// <summary>
    ///  提交请求的方式
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-18 14:12:38
    public enum HttpMethod
    {
        Get,
        Post,
    }

    public static class PublicFun
    {

        #region 操作配置文件

        /// <summary>
        ///  根据key读取value
        /// </summary>
        /// <param name="key">The key.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-20 09:59:25
        public static string GetAppConfig(this string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        ///  保存配置文件
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-08-20 10:12:26
        public static void SaveAppConfig(this string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Full);
            ConfigurationManager.RefreshSection("appSettings");
        }

        #endregion

        #region Web请求

        /// <summary>
        ///  Get请求
        /// </summary>
        /// <param name="url">URL</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 11:06:04
        public static string RequestGetData(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            string srcString = "";
            if (stream != null)
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                srcString = reader.ReadToEnd();
                stream.Close();
                reader.Close();
            }
            return srcString;
        }

        /// <summary>
        ///  Post请求
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="parameter">参数</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 13:25:02
        public static string RequestPostData(string url, string parameter)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] postData = Encoding.ASCII.GetBytes(parameter);
            // 提交请求
            Stream outputStream = request.GetRequestStream();
            request.AllowAutoRedirect = true;
            outputStream.Write(postData, 0, postData.Length);
            outputStream.Close();
            // 获取返回值
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            string srcString = "";
            if (responseStream != null)
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                srcString = reader.ReadToEnd();
                responseStream.Close();
                reader.Close();
            }
            return srcString;
        }

        /// <summary>
        ///  获取数据（GET/POST）
        /// </summary>
        /// <param name="url">URL</param>
        /// <param name="method">(get/post)</param>
        /// <param name="parameter">参数</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 13:55:48
        public static string RequestUpDownData(string url, HttpMethod method, string parameter)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = CredentialCache.DefaultCredentials;
            byte[] byteParameter = Encoding.UTF8.GetBytes(parameter);
            byte[] byteResult;
            if (method == HttpMethod.Get)
            {
                byteResult = webClient.DownloadData(url);
            }
            else
            {
                byteResult = webClient.UploadData(url, "POST", byteParameter);
            }
            string result = Encoding.UTF8.GetString(byteResult);
            return result;
        }

        /// <summary>
        ///  上传文件，并返回结果
        /// </summary>
        /// <param name="httpUrl">The HTTP URL.</param>
        /// <param name="method">The method.</param>
        /// <param name="fileUrl">The file URL.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 14:29:28
        public static string RequestUploadFile(string httpUrl, string method, string fileUrl)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = CredentialCache.DefaultCredentials;
            byte[] byteResult = webClient.UploadFile(httpUrl, method, fileUrl);
            string result = Encoding.UTF8.GetString(byteResult);
            return result;
        }

        /// <summary>
        ///  下载文件
        /// </summary>
        /// <param name="httpUrl">httpUrl</param>
        /// <param name="fileUrl">fileUrl</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 14:38:41
        public static void RequestDownloadFile(string httpUrl, string fileUrl)
        {
            WebClient webClient = new WebClient();
            webClient.Credentials = CredentialCache.DefaultCredentials;
            webClient.DownloadFile(httpUrl, fileUrl);
        }

        #endregion

        #region 解析json

        /// <summary>
        ///  解析access_token的返回数据
        /// </summary>
        /// <param name="json">json</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 13:50:14
        public static AccessTokens ResolveJson(this string json)
        {
            AccessTokens tokens = JsonConvert.DeserializeObject<AccessTokens>(json);
            return tokens;
        }

        #endregion

        #region 公用方法

        /// <summary>
        ///  判断access_token是否过期
        /// </summary>
        /// <param name="startDateTime">开始时间</param>
        /// <param name="endDateTime">结束时间</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 11:12:05
        public static bool JudgeAccessToken(string startDateTime, string endDateTime)
        {
            //没有过期，不需要重新获取
            if (!string.IsNullOrEmpty(startDateTime) && !string.IsNullOrEmpty(endDateTime))
            {
                DateTime endTime = Convert.ToDateTime(endDateTime);
                if (endTime > DateTime.Now)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion



    }
}
