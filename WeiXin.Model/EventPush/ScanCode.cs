
namespace WeiXin.Model.EventPush
{
    /// <summary>
    ///  扫码事件推送
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:21:19
    public class ScanCode : BaseModel
    {

        /// <summary>
        ///  事件类型，scancode_push-->扫码推事件的事件推送
        ///  事件类型，scancode_waitmsg-->扫码推事件且弹出“消息接收中”提示框的事件推送
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string Event { get; set; }

        /// <summary>
        ///  事件KEY值，由开发者在创建菜单时设定
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 22:09:38
        public string EventKey { get; set; }

        /// <summary>
        ///  扫描信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string ScanCodeInfo { get; set; }

        /// <summary>
        ///  扫描类型，一般是qrcode
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string ScanType { get; set; }

        /// <summary>
        ///  扫描结果，即二维码对应的字符串信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string ScanResult { get; set; }

    }
}
