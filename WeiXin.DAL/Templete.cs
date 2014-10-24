using WeiXin.Model.SendMsg;

namespace WeiXin.DAL
{
    /// <summary>
    ///  消息模版
    /// </summary>
    /// Author  : 俞立钢
    /// Company : 绍兴标点电子技术有限公司
    /// Created : 2014-10-10 10:41:23
    public class Templete
    {

        /// <summary>
        ///  回复文本消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:00:22
        public static string SendText(SendText model)
        {
            return string.Format(@"<xml><ToUserName><![CDATA[{0}]]></ToUserName><FromUserName><![CDATA[{1}]]></FromUserName><CreateTime>{2}</CreateTime><MsgType><![CDATA[{3}]]></MsgType><Content><![CDATA[{4}]]></Content></xml>", model.ToUserName, model.FromUserName, model.CreateTime, model.MsgType, model.Content);
        }

        /// <summary>
        ///  回复图片消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:00:22
        public static string SendImg(SendImage model)
        {
            return string.Format(@"<xml>
                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                    <CreateTime>{2}</CreateTime>
                                    <MsgType><![CDATA[{3}]]></MsgType>
                                    <Image>
                                        <MediaId><![CDATA[{4}]]></MediaId>
                                    </Image>
                                   </xml>", model.ToUserName, model.FromUserName, model.CreateTime, model.MsgType, model.MediaId);
        }

        /// <summary>
        ///  回复语音消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:00:22
        public static string SendVoice(SendVoice model)
        {
            return string.Format(@"<xml>
                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                    <CreateTime>{2}</CreateTime>
                                    <MsgType><![CDATA[{3}]]></MsgType>
                                    <Voice>
                                        <MediaId><![CDATA[{4}]]></MediaId>
                                    </Voice>
                                   </xml>", model.ToUserName, model.FromUserName, model.CreateTime, model.MsgType, model.MediaId);
        }

        /// <summary>
        ///  回复视频消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:00:22
        public static string SendVideo(SendVideo model)
        {
            return string.Format(@"<xml>
                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                    <CreateTime>{2}</CreateTime>
                                    <MsgType><![CDATA[{3}]]></MsgType>
                                    <Video>
                                        <MediaId><![CDATA[{4}]]></MediaId>
                                        <Title><![CDATA[{5}]]></Title>
                                        <Description><![CDATA[{6}]]></Description>
                                    </Video> 
                                   </xml>", model.ToUserName, model.FromUserName, model.CreateTime, model.MsgType, model.MediaId, model.Title, model.Description);

        }

        /// <summary>
        ///  回复音乐消息
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>System.String.</returns>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:04:08
        public static string SendMusic(SendMusic model)
        {
            return string.Format(@"<xml>
                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                    <CreateTime>{2}</CreateTime>
                                    <MsgType><![CDATA[{3}]]></MsgType>
                                    <Music>
                                        <Title><![CDATA[{4}]]></Title>
                                        <Description><![CDATA[{5}]]></Description>
                                        <MusicUrl><![CDATA[{6}]]></MusicUrl>
                                        <HQMusicUrl><![CDATA[{7}]]></HQMusicUrl>
                                        <ThumbMediaId><![CDATA[{8}]]></ThumbMediaId>
                                    </Music>
                                   </xml>", model.ToUserName, model.FromUserName,
                                           model.CreateTime, model.MsgType,
                                           model.Title, model.Description,
                                           model.MusicUrl, model.HqMusicUrl, model.ThumbMediaId);


        }

        /// <summary>
        ///  回复图文信息
        /// </summary>
        /// <param name="model">The model.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 11:19:47
        public static string SendNews(SendPicTxt model)
        {
            string item = "";
            foreach (ArticlesModel articles in model.Articles)
            {
                item += string.Format(@"
                                    <item>
                                    <Title><![CDATA[{0}]]></Title>
                                    <Description><![CDATA[{1}]]></Description>
                                    <PicUrl><![CDATA[{2}]]></PicUrl>
                                    <Url><![CDATA[{3}]]></Url>
                                    </item>", articles.Title, articles.Description, articles.PicUrl, articles.Url);
            }
            return string.Format(@"<xml>
                                    <ToUserName><![CDATA[{0}]]></ToUserName>
                                    <FromUserName><![CDATA[{1}]]></FromUserName>
                                    <CreateTime>{2}</CreateTime>
                                    <MsgType><![CDATA[{3}]]></MsgType>
                                    <ArticleCount>{4}</ArticleCount>
                                    <Articles>{5}</Articles>
                                   </xml> ", model.ToUserName, model.FromUserName, model.CreateTime, model.MsgType, model.ArticleCount, item);
        }


    }
}
