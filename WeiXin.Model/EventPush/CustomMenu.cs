
namespace WeiXin.Model.EventPush
{

    /// <summary>
    ///  自定义菜单事件
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-09 22:06:54
    public class CustomMenu : BaseModel
    {

        /// <summary>
        ///  事件类型，CLICK-->点击菜单拉取消息时的事件推送
        ///  事件类型，VIEW-->点击菜单跳转链接时的事件推送
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string Event { get; set; }

        /// <summary>
        ///  事件KEY值，与自定义菜单接口中KEY值对应-->点击菜单拉取消息时的事件推送
        ///  事件KEY值，设置的跳转URL-->点击菜单跳转链接时的事件推送
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 22:09:38
        public string EventKey { get; set; }

    }



}
