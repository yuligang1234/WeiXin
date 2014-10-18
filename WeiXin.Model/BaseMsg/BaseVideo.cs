
namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  视频消息
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:49:56
    public class BaseVideo : BaseModel
    {

        /// <summary>
        ///  视频消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public int MediaId { get; set; }

        /// <summary>
        ///  视频消息缩略图的媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public int ThumbMediaId { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public int MsgId { get; set; }

    }


}
