
namespace WeiXin.Model.SendMsg
{
    public class SendMusic : BaseModel
    {

        /// <summary>
        ///  音乐标题
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:09:30
        public string Title { get; set; }

        /// <summary>
        ///  音乐描述
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:09:30
        public string Description { get; set; }

        /// <summary>
        ///  音乐链接
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:09:30
        public string MusicUrl { get; set; }

        /// <summary>
        ///  高质量音乐链接，WIFI环境优先使用该链接播放音乐
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:09:30
        public string HqMusicUrl { get; set; }

        /// <summary>
        ///  缩略图的媒体id，通过上传多媒体文件，得到的id
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:09:30
        public int ThumbMediaId { get; set; }

    }
}
