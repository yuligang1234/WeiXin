
namespace WeiXin.Model
{
    public class BaseModel
    {

        /// <summary>
        ///  开发者微信号
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string ToUserName { get; set; }

        /// <summary>
        ///  发送方帐号（一个OpenID）
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string FromUserName { get; set; }

        /// <summary>
        ///  消息创建时间 （整型）
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public int CreateTime { get; set; }

        /// <summary>
        ///  消息类型(event/text/image/video/voice/location/link)
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string MsgType { get; set; }

        

    }
}
