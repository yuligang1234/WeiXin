using System.Net;
using System.Text;

namespace WeiXin.Common
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

    public class PublicFun
    {

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

    }
}
