using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web.Mvc;
using System.Web.Security;
using WeiXin.Common;
using WeiXin.DAL;

namespace WeiXin.Web.Controllers
{
    public class HomeController : BaseController
    {

        //转换过的xml数据
        private string _xmlData;
        //传输方式(post/get)
        private string _httpMethod;

        public void Index()
        {
            //ProduceImage();
            _httpMethod = Request.HttpMethod.ToLower();
            Dictionary<string, string> model = new Dictionary<string, string>();
            //POST方式发送过来的xml数据
            if (_httpMethod == "post")
            {
                //将xml数据转换
                using (Stream stream = HttpContext.Request.InputStream)
                {
                    byte[] byteData = new byte[stream.Length];
                    stream.Read(byteData, 0, (Int32)stream.Length);
                    _xmlData = Encoding.UTF8.GetString(byteData);
                }
                //判断传输过来的xml是否有数据
                if (!string.IsNullOrEmpty(_xmlData))
                {
                    try
                    {
                        model = _xmlData.ReadXml();
                    }
                    catch (Exception)
                    {
                        OperateXml.ResponseEnd("出错了！！！");
                    }
                }
                if (model.Count > 0)//回复消息
                {
                    DoMsg(model);
                }
            }
            else//get方式
            {
                GetCheck();
            }
        }

        /// <summary>
        ///  生成图片
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-17 14:22:08
        private void ProduceImage()
        {
            Process process = new Process();
            //string path = Server.MapPath("~");
            process.StartInfo.FileName = @"E:\Napoleon\Asp.net\Webform\Work\标点\微信\WeiXin\WindowsFormsApplication1\bin\Debug\超级报表生成图片.exe";
            process.StartInfo.Arguments = @"E:\Napoleon\Asp.net\Webform\Work\标点\微信\WeiXin\2.tab E:\Napoleon\Asp.net\Webform\Work\标点\微信\WeiXin\1.jpg";
            process.Start();
            process.WaitForExit();
        }

        /// <summary>
        ///  处理信息
        /// </summary>
        /// <param name="model">Dictionary</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 09:56:36
        private void DoMsg(Dictionary<string, string> model)
        {
            //通过MsgType判断是普通消息还是事件推送
            string msgType = model.ReadKey(PublicField.MsgType);
            switch (msgType)
            {

                #region 普通消息
                case "text": //文本消息
                    SendMsg.ReplyTexts(model);
                    break;
                case "image": //图片
                    break;
                case "voice": //声音
                    break;
                case "video": //视频
                    break;
                case "location": //地理位置
                    break;
                case "link": //链接
                    break;
                #endregion

                #region 事件推送
                case "event":
                    //事件类型
                    msgType = model.ReadKey(PublicField.Event);
                    switch (msgType)
                    {
                        case "subscribe"://关注
                            /*if (model.ReadKey(PublicField.EventKey).StartsWith("qrscene_"))
                            {
                                //带参数的二维码扫描关注
                            }
                            else
                            {
                                //普通关注
                            }*/
                            SendMsg.ReplaySubscribeText(model);
                            break;
                        case "unsubscribe"://取消关注
                            break;
                        case "SCAN"://已经关注的用户扫描带参数的二维码
                            break;
                        case "LOCATION"://用户上报地理位置
                            break;
                        case "CLICK"://自定义菜单点击
                            break;
                        case "VIEW"://自定义菜单跳转事件
                            break;
                        case "scancode_push"://扫码推事件的事件推送
                            break;
                        case "scancode_waitmsg"://扫码推事件且弹出“消息接收中”提示框的事件推送
                            SendMsg.ReplyScanCodeWaitmsg(model);
                            //SendMsg.ReplayTemplete(model);
                            break;
                        case "pic_sysphoto"://弹出系统拍照发图的事件推送
                            break;
                        case "pic_photo_or_album"://弹出拍照或者相册发图的事件推送
                            break;
                        case "pic_weixin"://弹出微信相册发图器的事件推送
                            break;
                        case "location_select"://弹出地理位置选择器的事件推送
                            break;
                    }
                    break;
                #endregion

            }
        }

        /// <summary>
        ///  get方式验证
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 15:41:54
        public void GetCheck()
        {
            string token = PublicField.Token;
            string echoString = Request.QueryString["echostr"];
            string signature = Request.QueryString["signature"];
            string timestamp = Request.QueryString["timestamp"];
            string nonce = Request.QueryString["nonce"];
            if (CheckSignature(token, signature, timestamp, nonce))
            {
                OperateXml.ResponseEnd(echoString);
            }
        }

        /// <summary>
        ///  验证微信签名
        /// </summary>
        /// <param name="token">The token.</param>
        /// <param name="signature">The signature.</param>
        /// <param name="timestamp">The timestamp.</param>
        /// <param name="nonce">The nonce.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-10 15:53:55
        public bool CheckSignature(string token, string signature, string timestamp, string nonce)
        {
            string[] arrTmp = { token, timestamp, nonce };
            Array.Sort(arrTmp);
            string tmpStr = string.Join("", arrTmp);
            tmpStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tmpStr, "SHA1");
            if (tmpStr != null)
            {
                tmpStr = tmpStr.ToLower();
                if (tmpStr == signature)
                {
                    return true;
                }
            }
            return false;
        }


        public ActionResult Get()
        {
            Response.ContentType = "application/octet-stream";
            string filePath = @"E:\Napoleon\Asp.net\Webform\Work\标点\微信\WeiXin\WeiXin.Web\2.tab";
            Response.BinaryWrite(System.IO.File.ReadAllBytes(filePath));
            return null;
        }

    }
}
