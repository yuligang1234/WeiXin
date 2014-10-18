
using System;

namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  链接参数
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:55:07
    public class BaseLink : BaseModel
    {

        /// <summary>
        ///  消息标题
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:56:09
        public string Title { get; set; }

        /// <summary>
        ///  消息描述
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:56:09
        public string Description { get; set; }

        /// <summary>
        ///  消息链接
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:56:09
        public string Url { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:56:09
        public Int64 MsgId { get; set; }

    }
}
