
namespace WeiXin.Model.MsgModel
{
    public class MediaMsg : BaseMsg
    {

        /// <summary>
        ///  媒体文件类型，分别有图片（image）、语音（voice）、视频（video）和缩略图（thumb）
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-24 13:32:49
        public string type { get; set; }

        /// <summary>
        ///  媒体文件上传后，获取时的唯一标识
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-24 13:32:49
        public string media_id { get; set; }

        /// <summary>
        ///  媒体文件上传时间戳
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-24 13:32:49
        public string created_at { get; set; }

    }
}
