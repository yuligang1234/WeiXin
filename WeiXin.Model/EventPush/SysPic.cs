
namespace WeiXin.Model.EventPush
{
    /// <summary>
    ///  系统拍照发图事件推送
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:22:01
    public class SysPic : BaseModel
    {

        /// <summary>
        ///  事件类型，pic_sysphoto-->弹出系统拍照发图的事件推送
        ///  事件类型，pic_photo_or_album-->弹出拍照或者相册发图的事件推送
        ///  事件类型，pic_weixin-->弹出微信相册发图器的事件推送
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
        ///  发送的图片信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string SendPicsInfo { get; set; }

        /// <summary>
        ///  发送的图片数量
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string Count { get; set; }

        /// <summary>
        ///  图片列表
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string PicList { get; set; }

        /// <summary>
        ///  图片的MD5值，开发者若需要，可用于验证接收到图片
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:23:09
        public string PicMd5Sum { get; set; }

    }
}
