
using System.Collections.Generic;

namespace WeiXin.Model.SendMsg
{
    public class SendPicTxt : BaseModel
    {

        /// <summary>
        ///  图文消息个数，限制为10条以内
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public string ArticleCount { get; set; }

        /// <summary>
        ///  多条图文消息信息，默认第一个item为大图,注意，如果图文数超过10，则将会无响应
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public List<ArticlesModel> Articles { get; set; }

        

    }


    public class ArticlesModel
    {
        /// <summary>
        ///  图文消息标题
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public string Title { get; set; }

        /// <summary>
        ///  图文消息描述
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public string Description { get; set; }

        /// <summary>
        ///  图片链接，支持JPG、PNG格式，较好的效果为大图360*200，小图200*200
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public string PicUrl { get; set; }

        /// <summary>
        ///  点击图文消息跳转链接
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:16:58
        public string Url { get; set; }
    }


}
