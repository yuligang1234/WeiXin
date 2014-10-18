
namespace WeiXin.Model.SendMsg
{
    public class SendText : BaseModel
    {

        /// <summary>
        ///  回复的消息内容（换行：在content中能够换行，微信客户端就支持换行显示）
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 10:44:26
        public string Content { get; set; }

    }
}
