
using System;

namespace WeiXin.Model.SendMsg
{
    public class SendVideo : BaseModel
    {

        /// <summary>
        ///  通过上传多媒体文件，得到的id
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public int MediaId { get; set; }

        /// <summary>
        ///  视频消息的标题
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public string Title { get; set; }

        /// <summary>
        ///  视频消息的描述
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:50:27
        public Int64 Description { get; set; }

    }
}
