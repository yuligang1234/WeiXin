
using System.Text;
using WeiXin.Tools.DAL.Helper;
using WeiXin.Tools.Model;

namespace WeiXin.Tools.DAL
{
    public class BaseInfoDao
    {

        /// <summary>
        ///  更新
        /// </summary>
        /// <param name="info">实体类</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 09:51:11
        public static bool UpdateBaseInfo(BaseInfo info)
        {
            StringBuilder sb = new StringBuilder();
            if (info.Url != null)
            {
                sb.AppendFormat("Url='{0}',", info.Url);
            }
            if (info.Token != null)
            {
                sb.AppendFormat("Token='{0}',", info.Token);
            }
            if (info.Appid != null)
            {
                sb.AppendFormat("Appid='{0}',", info.Appid);
            }
            if (info.Appsecret != null)
            {
                sb.AppendFormat("Appsecret='{0}',", info.Appsecret);
            }
            if (info.AccessToken != null)
            {
                sb.AppendFormat("AccessToken='{0}',", info.AccessToken);
            }
            if (info.StartDateTime != null)
            {
                sb.AppendFormat("StartDateTime='{0}',", info.StartDateTime);
            }
            if (info.EndDateTime != null)
            {
                sb.AppendFormat("EndDateTime='{0}',", info.EndDateTime);
            }
            if (info.TimeSpace != null)
            {
                sb.AppendFormat("TimeSpace='{0}',", info.TimeSpace);
            }
            string content = sb.ToString().Trim(',');
            string sql = string.Format("Update Base_Info Set {0} where Id={1}", content, info.Id);
            int i = SqLiteHelper.ExecuteSql(sql);
            return i == 1;
        }

        /// <summary>
        ///  根据ID查询
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 10:08:36
        public static BaseInfo SelectBaseInfo(int id)
        {
            string sql = string.Format("select * from Base_Info where Id={0}", id);
            return SqLiteHelper.GetEnumerable<BaseInfo>(sql);
        }

        /// <summary>
        ///  查询
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 13:24:10
        public static BaseInfo SelectBaseInfo()
        {
            string sql = string.Format("select * from Base_Info limit 1");
            return SqLiteHelper.GetEnumerable<BaseInfo>(sql);
        }

    }
}
