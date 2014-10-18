
using System;

namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  文本消息
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:43:26
    public class BaseText : BaseModel
    {

        /// <summary>
        ///  文本消息内容
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:44:26
        public string Content { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:44:26
        public Int64 MsgId { get; set; }

    }
}
