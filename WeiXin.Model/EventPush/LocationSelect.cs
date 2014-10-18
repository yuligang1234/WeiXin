
namespace WeiXin.Model.EventPush
{
    /// <summary>
    ///  弹出地理位置选择器的事件推送
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:31:34
    public class LocationSelect : BaseModel
    {

        /// <summary>
        ///  事件类型，location_select
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
        ///  发送的位置信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string SendLocationInfo { get; set; }

        /// <summary>
        ///  X坐标信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string LocationX { get; set; }

        /// <summary>
        ///  Y坐标信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:19:21
        public string LocationY { get; set; }

        /// <summary>
        ///  精度，可理解为精度或者比例尺、越精细的话 scale越高
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:23:09
        public string Scale { get; set; }

        /// <summary>
        ///  地理位置的字符串信息
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:32:01
        public string Label { get; set; }

        /// <summary>
        ///  朋友圈POI的名字，可能为空
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:32:01
        public string Poiname { get; set; }

    }
}
