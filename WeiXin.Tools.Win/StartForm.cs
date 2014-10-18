
using System;
using System.Windows.Forms;
using WeiXin.Tools.Common;
using WeiXin.Tools.Model;

namespace WeiXin.Tools.Win
{
    public partial class StartForm : BaseForm
    {

        #region 定义委托

        /// <summary>
        ///  获取access_token的委托
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 15:06:28
        private delegate void DoRequestAccessToken();

        /// <summary>
        ///  查询自定义菜单的委托
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:29:59
        private delegate void DoSelectCustomMenu(string accessToken);

        /// <summary>
        ///  创建自定义菜单的委托
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:30:34
        private delegate void DoCreateCustomMenu(string accessToken);

        /// <summary>
        ///  操作多媒体的委托
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:12:25
        private delegate void DoUpAndDown();

        #endregion

        public StartForm()
        {
            //应用皮肤
            ApplySkin("McSkin");
            InitializeComponent();
            LoadBaseXml();
            CheckForIllegalCrossThreadCalls = false;//如果不设置，会报线程不能调用控件的错误
        }

        /// <summary>
        ///  加载基本配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 09:28:37
        private void LoadBaseXml()
        {
            TxtUrl.Text = PublicFileds.Url.GetAppConfig();
            TxtToken.Text = PublicFileds.Token.GetAppConfig();
            TxtAppId.Text = PublicFileds.AppId.GetAppConfig();
            TxtAppSecret.Text = PublicFileds.AppSecret.GetAppConfig();
            TxtAccessToken.Text = PublicFileds.AccessToken.GetAppConfig();
        }

        #region 配置信息

        /// <summary>
        ///  保存配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 09:45:11
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUrl.Text) || string.IsNullOrEmpty(TxtToken.Text) ||
                string.IsNullOrEmpty(TxtAppId.Text) || string.IsNullOrEmpty(TxtAppSecret.Text))
            {
                MessageBox.Show("配置不能为空！！！");
            }
            else
            {
                PublicFileds.Url.SaveAppConfig(TxtUrl.Text);
                PublicFileds.Token.SaveAppConfig(TxtToken.Text);
                PublicFileds.AppId.SaveAppConfig(TxtAppId.Text);
                PublicFileds.AppSecret.SaveAppConfig(TxtAppSecret.Text);
            }
        }

        /// <summary>
        ///  获取access_token
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 10:09:03
        private void BtnAccessToken_Click(object sender, EventArgs e)
        {
            //判access_token是否过期
            if (!PublicFun.JudgeAccessToken())
            {
                MessageBox.Show("该access_token没有过期，不需要重新获取！");
                return;
            }
            ShowProgress();
            DoRequestAccessToken invote = RequestAccessToken;
            invote.BeginInvoke(AsyncCallback, invote);
        }

        /// <summary>
        ///  回调委托
        /// </summary>
        /// <param name="ar">The ar.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 16:55:37
        private void AsyncCallback(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                HideProgress();
            }
        }

        /// <summary>
        ///  重新获取access_token
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 15:01:17
        private void RequestAccessToken()
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", PublicFileds.AppId.GetAppConfig(), PublicFileds.AppSecret.GetAppConfig());
            string json = PublicFun.RequestGetData(url);
            AccessTokens tokens = json.ResolveJson();
            if (tokens.access_token != null)
            {
                //获取成功，写入信息
                TxtAccessToken.Text = tokens.access_token;
                DateTime start = DateTime.Now;
                DateTime end = start.AddSeconds(Convert.ToDouble(PublicFileds.TimeSpace.GetAppConfig()));
                PublicFileds.AccessToken.SaveAppConfig(TxtAccessToken.Text);
                PublicFileds.StartDateTime.SaveAppConfig(start.ToString(""));
                PublicFileds.EndDateTime.SaveAppConfig(end.ToString(""));
            }
            else
            {
                MessageBox.Show("获取失败！！！");
            }
        }

        /// <summary>
        ///  显示加载条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 15:04:56
        private void ShowProgress()
        {
            BtnSave.Enabled = BtnAccessToken.Enabled = false;
            progressPanel1.Visible = true;
            Application.DoEvents();
        }

        /// <summary>
        ///  隐藏加载条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 15:04:56
        private void HideProgress()
        {
            progressPanel1.Visible = false;
            BtnAccessToken.Enabled = BtnSave.Enabled = true;
            Application.DoEvents();
        }

        #endregion

        #region 查询自定义菜单

        /// <summary>
        ///  查询自定义菜单
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:16:33
        private void BtnSelect_Click(object sender, EventArgs e)
        {
            string accessToken = PublicFileds.AccessToken.GetAppConfig();
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("请先获取Access_Token！");
            }
            else
            {
                if (!PublicFun.JudgeAccessToken())
                {
                    ShowPrgSelect();
                    DoSelectCustomMenu selectCustomMenu = SelectMenu;
                    selectCustomMenu.BeginInvoke(accessToken, AsyncCallbackSelect, selectCustomMenu);
                    return;
                }
                MessageBox.Show("Access_Token已经过期，请重新获取！");
            }
        }

        /// <summary>
        ///  回调委托
        /// </summary>
        /// <param name="ar">The ar.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 16:55:37
        private void AsyncCallbackSelect(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                HidePrgSelect();
            }
        }

        /// <summary>
        ///  查询自定义菜单操作
        /// </summary>
        /// <param name="accessToken">accessToken</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:25:32
        private void SelectMenu(string accessToken)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/get?access_token={0}", accessToken);
            MenuSelect.Text = PublicFun.RequestUpDownData(url, HttpMethod.Get, "");
        }

        /// <summary>
        ///  显示查询进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:27:15
        private void ShowPrgSelect()
        {
            PrgSelect.Visible = true;
            BtnCreate.Enabled = BtnSelect.Enabled = false;
            Application.DoEvents();
        }

        /// <summary>
        ///  隐藏查询进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:27:15
        private void HidePrgSelect()
        {
            PrgSelect.Visible = false;
            BtnCreate.Enabled = BtnSelect.Enabled = true;
            Application.DoEvents();
        }

        #endregion

        #region 创建自定义菜单

        /// <summary>
        ///  创建自定义菜单
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:51:11
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string accessToken = PublicFileds.AccessToken.GetAppConfig();
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("请先获取Access_Token！");
            }
            else
            {
                if (!PublicFun.JudgeAccessToken())
                {
                    if (string.IsNullOrEmpty(MenuCreate.Text))
                    {
                        MessageBox.Show("不能创建空菜单！");
                        return;
                    }
                    ShowPrgCreate();
                    DoCreateCustomMenu createCustomMenu = CreateMenu;
                    createCustomMenu.BeginInvoke(accessToken, AsyncCallbackCreate, createCustomMenu);
                    return;
                }
                MessageBox.Show("Access_Token已经过期，请重新获取！");
            }
        }

        /// <summary>
        ///  回调委托
        /// </summary>
        /// <param name="ar">The ar.</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 16:55:37
        private void AsyncCallbackCreate(IAsyncResult ar)
        {
            if (ar.IsCompleted)
            {
                HidePrgCreate();
            }
        }

        /// <summary>
        ///  查询自定义菜单操作
        /// </summary>
        /// <param name="accessToken">accessToken</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:25:32
        private void CreateMenu(string accessToken)
        {
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/menu/create?access_token={0}", accessToken);
            MenuCreate.Text = PublicFun.RequestUpDownData(url, HttpMethod.Post, MenuCreate.Text);
        }

        /// <summary>
        ///  显示查询进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:27:15
        private void ShowPrgCreate()
        {
            PrgCreate.Visible = true;
            BtnCreate.Enabled = BtnSelect.Enabled = false;
            MenuCreate.Properties.ReadOnly = true;
            Application.DoEvents();
        }

        /// <summary>
        ///  隐藏查询进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-16 10:27:15
        private void HidePrgCreate()
        {
            PrgCreate.Visible = false;
            BtnCreate.Enabled = BtnSelect.Enabled = true;
            MenuCreate.Properties.ReadOnly = false;
            Application.DoEvents();
        }

        #endregion

        #region 多媒体上传下载

        /// <summary>
        ///  浏览多媒体文件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 10:39:55
        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "所有文件(*.*)|*.*";
                dialog.Multiselect = false;
                dialog.FileName = "选择需要上传的多媒体文件";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    TxtUploadUrl.Text = dialog.FileName;
                }
            }
        }

        /// <summary>
        ///  上传多媒体文件到服务器
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 11:07:34
        private void BtnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUploadUrl.Text))
            {
                MessageBox.Show("请先选择需要上传的多媒体文件！");
                return;
            }
            if (PublicFun.JudgeAccessToken())
            {
                MessageBox.Show("Access_Token已经过期，请重新获取！");
                return;
            }
            ShowPrgUpload();
            DoUpAndDown upAndDown = DoUploadFile;
            upAndDown.BeginInvoke(AsyncCallbackUpload, upAndDown);
        }

        /// <summary>
        ///  上传多媒体文件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:14:19
        private void DoUploadFile()
        {
            string httpUrl = string.Format("http://file.api.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}", PublicFileds.AccessToken.GetAppConfig(), "image");
            TxtUploadResult.Text = PublicFun.RequestUpDownData(httpUrl, HttpMethod.Post, TxtUploadUrl.Text);
        }

        /// <summary>
        ///  委托回调函数
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:24:52
        private void AsyncCallbackUpload(IAsyncResult ac)
        {
            if (ac.IsCompleted)
            {
                HidePrgUpload();
            }
        }

        /// <summary>
        ///  显示进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:19:17
        private void ShowPrgUpload()
        {
            PrgUpload.Visible = true;
            BtnUpload.Enabled = BtnBrowser.Enabled = false;
            Application.DoEvents();
        }

        /// <summary>
        ///  隐藏季度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:26:04
        private void HidePrgUpload()
        {
            PrgUpload.Visible = false;
            BtnUpload.Enabled = BtnBrowser.Enabled = true;
            Application.DoEvents();
        }



        #endregion




    }
}
