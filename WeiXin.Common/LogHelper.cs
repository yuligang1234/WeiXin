using System;


namespace WeiXin.Common
{
    public class LogHelper
    {

        //对应配置文件中的loginfo节点
        private static readonly log4net.ILog LogInfo = log4net.LogManager.GetLogger("loginfo");

        //对应配置文件中的logerror节点
        private static readonly log4net.ILog LogError = log4net.LogManager.GetLogger("logerror");

        /// <summary>
        ///  操作记录
        /// </summary>
        /// <param name="info"></param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-23 16:53:42
        public static void WriteLog(string info)
        {
            if (LogInfo.IsInfoEnabled)
            {
                LogInfo.Info(info);
            }
        }

        /// <summary>
        /// 错误记录
        /// </summary>
        /// <param name="info">附加信息</param>
        /// <param name="ex">错误</param>
        public static void ErrorLog(string info, Exception ex)
        {
            if (!string.IsNullOrEmpty(info) && ex == null)
            {
                LogError.ErrorFormat("【附加信息】:{0}<br>", new object[] { info });
            }
            else if (!string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BeautyErrorMsg(ex);
                LogError.ErrorFormat("【附加信息】:{0}<br>{1}", new object[] { info, errorMsg });
            }
            else if (string.IsNullOrEmpty(info) && ex != null)
            {
                string errorMsg = BeautyErrorMsg(ex);
                LogError.Error(errorMsg);
            }
        }

        /// <summary>
        /// 美化错误信息
        /// </summary>
        /// <param name="ex">异常</param>
        /// <returns>错误信息</returns>
        private static string BeautyErrorMsg(Exception ex)
        {
            string errorMsg = string.Format("【异常类型】：{0} <br>【异常信息】：{1} <br>【堆栈调用】：{2}", new object[] { ex.GetType().Name, ex.Message, ex.StackTrace });
            errorMsg = errorMsg.Replace("\r\n", "<br>");
            errorMsg = errorMsg.Replace("位置", "<strong style=\"color:red\">位置</strong>");
            return errorMsg;
        }

    }
}
