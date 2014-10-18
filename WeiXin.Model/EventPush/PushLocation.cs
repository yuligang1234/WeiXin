
namespace WeiXin.Model.EventPush
{

    /// <summary>
    ///  上报地理位置事件
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-09 22:01:32
    public class PushLocation : BaseModel
    {

        /// <summary>
        ///  事件类型，Location
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 21:03:38
        public string Event { get; set; }

        /// <summary>
        ///  地理位置纬度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 22:01:59
        public string Latitude { get; set; }

        /// <summary>
        ///  地理位置经度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 22:02:28
        public string Longitude { get; set; }

        /// <summary>
        ///  地理位置精度
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-09 22:02:53
        public string Precision { get; set; }


    }
}
