
namespace WeiXin.Model.EventPush
{
    /// <summary>
    ///  扫描带参数二维码事件
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-09 21:52:37
    public class Scan : BaseModel
    {

        /// <summary>
        ///  事件类型，subscribe(订阅)-->用户未关注时，进行关注后的事件推送
        ///  事件类型，Scan-->用户已关注时的事件推送
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string Event { get; set; }

        /// <summary>
        ///  事件KEY值，qrscene_为前缀，后面为二维码的参数值-->用户未关注时，进行关注后的事件推送
        ///  事件KEY值，是一个32位无符号整数，即创建二维码时的二维码scene_id-->用户已关注时的事件推送
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 0001-01-01 00:00:00
        public string EventKey { get; set; }

        /// <summary>
        ///  二维码的ticket，可用来换取二维码图片
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:54:36
        public string Ticket { get; set; }

    }


}
