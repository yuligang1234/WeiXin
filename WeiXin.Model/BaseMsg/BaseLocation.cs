
using System;

namespace WeiXin.Model.BaseMsg
{
    /// <summary>
    ///  地理位置信息
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:52:09
    public class BaseLocation : BaseModel
    {

        /// <summary>
        ///  地理位置维度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:53:33
        public string LocationX { get; set; }

        /// <summary>
        ///  地理位置经度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:53:33
        public string LocationY { get; set; }

        /// <summary>
        ///  地图缩放大小
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:53:33
        public string Scale { get; set; }

        /// <summary>
        ///  地理位置信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:53:33
        public string Label { get; set; }

        /// <summary>
        ///  消息id，64位整型
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:53:33
        public Int64 MsgId { get; set; }

    }

}
