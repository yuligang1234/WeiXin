
namespace WeiXin.Model.EventPush
{
    /// <summary>
    ///  关注/取消关注事件
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-09 21:50:38
    public class Attention : BaseModel
    {

        /// <summary>
        ///  事件类型，subscribe(订阅)、unsubscribe(取消订阅)
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string Event { get; set; }

    }
}
