
using System;

namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  图片消息
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:45:19
    public class BaseImage : BaseModel
    {

        /// <summary>
        ///  图片链接
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:46:12
        public string PicUrl { get; set; }

        /// <summary>
        ///  图片消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:46:12
        public int MediaId { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:46:12
        public Int64 MsgId { get; set; }

    }
}
