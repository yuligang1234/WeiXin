using System;

namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  语音消息
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:47:21
    public class BaseVoice : BaseModel
    {

        /// <summary>
        ///  语音消息媒体id，可以调用多媒体文件下载接口拉取数据。
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:48:27
        public int MediaId { get; set; }

        /// <summary>
        ///  语音格式，如amr，speex等
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:48:27
        public string Format { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:48:27
        public Int64 MsgId { get; set; }

    }
}
