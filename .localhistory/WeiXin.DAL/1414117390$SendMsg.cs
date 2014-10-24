
using System.Collections.Generic;
using WeiXin.Common;
using WeiXin.Model.SendMsg;

namespace WeiXin.DAL
{
    public class SendMsg
    {

        #region 回复消息的公共函数

        /// <summary>
        ///  回复文本消息的函数
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="content">The content.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-17 14:46:20
        private static void ProduceText(Dictionary<string, string> model, string content)
        {
            SendText text = new SendText();
            text.ToUserName = model.ReadKey(PublicField.FromUserName);
            text.FromUserName = model.ReadKey(PublicField.ToUserName);
            text.CreateTime = int.Parse(model.ReadKey(PublicField.CreateTime));
            text.MsgType = "text";
            text.Content = content;
            OperateXml.ResponseEnd(Templete.SendText(text));
        }

        private static void ProduceImage(Dictionary<string, string> model,int mediaId)
        {
            SendImage text = new SendImage();
            text.ToUserName = model.ReadKey(PublicField.FromUserName);
            text.FromUserName = model.ReadKey(PublicField.ToUserName);
            text.CreateTime = int.Parse(model.ReadKey(PublicField.CreateTime));
            text.MsgType = "image";
            text.MediaId = mediaId;
        }

        /// <summary>
        ///  回复图文消息的函数
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="articles">The content.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-24 09:57:37
        private static void ProduceNews(Dictionary<string, string> model, List<ArticlesModel> articles)
        {
            SendPicTxt text = new SendPicTxt();
            text.ToUserName = model.ReadKey(PublicField.FromUserName);
            text.FromUserName = model.ReadKey(PublicField.ToUserName);
            text.CreateTime = int.Parse(model.ReadKey(PublicField.CreateTime));
            text.MsgType = "news";
            text.ArticleCount = articles.Count.ToString("D");
            text.Articles = articles;
            OperateXml.ResponseEnd(Templete.SendNews(text));
        }

        #endregion


        /// <summary>
        ///  回复文本消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 12:58:35
        public static void ReplyTexts(Dictionary<string, string> model)
        {
            string content = string.Format("您输入的内容1为：{0}", model.ReadKey(PublicField.Content));
            ProduceText(model, content);
        }

        /// <summary>
        ///  回复扫码推事件消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-13 16:01:33
        public static void ReplyScanCodePush(Dictionary<string, string> model)
        {

        }

        /// <summary>
        ///  回复扫码推事件且弹出“消息接收中”提示框消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-13 16:09:53
        public static void ReplyScanCodeWaitmsg(Dictionary<string, string> model)
        {
            /*string value = model.ReadKey("ScanCodeInfo");
            string content = string.Format("项目编号：{0};\n验收状态：{1};\n验收结果：{2};\n报表查看：<a href='{3}'>点击查看</a>", value.Substring(6), "完成", "通过", "http://www.sxajj.gov.cn/1.jpg");
            ProduceText(model, content);*/
            List<ArticlesModel> articles = new List<ArticlesModel>();
            for (int i = 1; i < 3; i++)
            {
                ArticlesModel article = new ArticlesModel();
                article.Title = string.Format("{0}号项目", i == 1 ? "一" : "二");
                article.Description = string.Format("项目编号：{0};\n验收状态:完成;\n验收结果:通过;\n", i == 1 ? "CX2501" : "CX2502");
                article.PicUrl = "http://www.sxajj.gov.cn/1.jpg";
                article.Url = "http://www.sxajj.gov.cn/1.jpg";
                articles.Add(article);
            }
            ProduceNews(model, articles);
        }





    }
}
