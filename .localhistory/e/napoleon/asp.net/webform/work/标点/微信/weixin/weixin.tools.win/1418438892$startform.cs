
using System;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Windows.Forms;
using WeiXin.Tools.Common;
using WeiXin.Tools.DAL;
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
        private delegate void DoUpAndDown(string accessToken);

        #endregion

        #region 变量

        private readonly Cache _cacheBaseInfo = HttpRuntime.Cache;
        private BaseInfo _baseInfo;

        #endregion


        public StartForm()
        {
            //应用皮肤
            ApplySkin("McSkin");
            InitializeComponent();
            LoadBaseXml();
            //CheckForIllegalCrossThreadCalls = false;//如果不设置，会报线程不能调用控件的错误
        }

        /// <summary>
        ///  加载基本配置
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 09:28:37
        private void LoadBaseXml()
        {
            BaseInfo info = BaseInfoDao.SelectBaseInfo(PublicFileds.UserName);
            //缓存数据
            _cacheBaseInfo.Remove(PublicFileds.BaseInfo);
            _cacheBaseInfo.Insert(PublicFileds.BaseInfo, info);
            TxtUrl.Text = info.Url;
            TxtToken.Text = info.Token;
            TxtAppId.Text = info.Appid;
            TxtAppSecret.Text = info.Appsecret;
            TxtAccessToken.Text = info.AccessToken;
        }

        #region 缓存

        /// <summary>
        ///  获取缓存实体类
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-20 12:36:39
        private BaseInfo GetBaseInfo()
        {
            _baseInfo = (BaseInfo)_cacheBaseInfo.Get(PublicFileds.BaseInfo);
            if (_baseInfo.Id > 0)
            {
                _baseInfo = BaseInfoDao.SelectBaseInfo(PublicFileds.UserName);
            }
            return _baseInfo;
        }

        #endregion

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
                _baseInfo = new BaseInfo();
                _baseInfo.Id = GetBaseInfo().Id;
                _baseInfo.Url = TxtUrl.Text;
                _baseInfo.Token = TxtToken.Text;
                _baseInfo.Appid = TxtAppId.Text;
                _baseInfo.Appsecret = TxtAppSecret.Text;
                if (BaseInfoDao.UpdateBaseInfo(_baseInfo))
                {
                    MessageBox.Show("保存成功！");
                    //更新缓存
                    _cacheBaseInfo.Remove(PublicFileds.BaseInfo);
                    _cacheBaseInfo.Insert(PublicFileds.BaseInfo, BaseInfoDao.SelectBaseInfo(_baseInfo.Id));
                    return;
                }
                MessageBox.Show("保存失败！");
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
            _baseInfo = GetBaseInfo();
            //判access_token是否过期
            if (!PublicFun.JudgeAccessToken(_baseInfo.StartDateTime, _baseInfo.EndDateTime))
            {
                MessageBox.Show("该access_token没有过期，不需要重新获取！");
                return;
            }
            ShowProgress();
            TxtAccessToken.Text = "";
            RequestAccessToken();
            HideProgress();
        }

        /// <summary>
        ///  重新获取access_token
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-15 15:01:17
        private void RequestAccessToken()
        {
            _baseInfo = GetBaseInfo();
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid={0}&secret={1}", _baseInfo.Appid, _baseInfo.Appsecret);
            string json = PublicFun.RequestGetData(url);
            AccessTokens tokens = json.ResolveJson();
            if (tokens.access_token != null)
            {
                //获取成功，写入信息
                TxtAccessToken.Text = tokens.access_token;
                BaseInfo info = new BaseInfo();
                DateTime start = DateTime.Now;
                DateTime end = start.AddSeconds(Convert.ToDouble(_baseInfo.TimeSpace));
                info.Id = _baseInfo.Id;
                info.StartDateTime = start.ToString("yyyy-MM-dd HH:mm:ss");
                info.EndDateTime = end.ToString("yyyy-MM-dd HH:mm:ss");
                info.AccessToken = TxtAccessToken.Text;
                BaseInfoDao.UpdateBaseInfo(info);
                //更新缓存
                _cacheBaseInfo.Remove(PublicFileds.BaseInfo);
                _cacheBaseInfo.Insert(PublicFileds.BaseInfo, BaseInfoDao.SelectBaseInfo(info.Id));
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
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("正在获取中......");
            BtnSave.Enabled = BtnAccessToken.Enabled = false;
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
            splashScreenManager1.CloseWaitForm();
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
            //获取数据
            _baseInfo = GetBaseInfo();
            string accessToken = _baseInfo.AccessToken;
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("请先获取Access_Token！");
            }
            else
            {
                if (!PublicFun.JudgeAccessToken(_baseInfo.StartDateTime, _baseInfo.EndDateTime))
                {
                    ShowPrgSelect();
                    SelectMenu(accessToken);
                    HidePrgSelect();
                    return;
                }
                MessageBox.Show("Access_Token已经过期，请重新获取！");
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
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("正在查询中......");
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
            splashScreenManager1.CloseWaitForm();
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
            _baseInfo = GetBaseInfo();
            string accessToken = _baseInfo.AccessToken;
            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("请先获取Access_Token！");
            }
            else
            {
                if (!PublicFun.JudgeAccessToken(_baseInfo.StartDateTime, _baseInfo.EndDateTime))
                {
                    if (string.IsNullOrEmpty(MenuCreate.Text))
                    {
                        MessageBox.Show("不能创建空菜单！");
                        return;
                    }
                    ShowPrgCreate();
                    CreateMenu(accessToken);
                    HidePrgCreate();
                    return;
                }
                MessageBox.Show("Access_Token已经过期，请重新获取！");
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
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("正在创建中......");
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
            splashScreenManager1.CloseWaitForm();
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
            _baseInfo = GetBaseInfo();
            if (string.IsNullOrEmpty(TxtUploadUrl.Text))
            {
                MessageBox.Show("请先选择需要上传的多媒体文件！");
                return;
            }
            if (PublicFun.JudgeAccessToken(_baseInfo.StartDateTime, _baseInfo.EndDateTime))
            {
                MessageBox.Show("Access_Token已经过期，请重新获取！");
                return;
            }
            ShowPrgUpload();
            DoUploadFile(_baseInfo.AccessToken);
            HidePrgUpload();
        }

        /// <summary>
        ///  上传多媒体文件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:14:19
        private void DoUploadFile(string accessToken)
        {
            string httpUrl = string.Format("http://file.api.weixin.qq.com/cgi-bin/media/upload?access_token={0}&type={1}", accessToken, "image");
            TxtUploadResult.Text = PublicFun.RequestUploadFile(httpUrl, HttpMethod.Post.ToString(), TxtUploadUrl.Text);
        }

        /// <summary>
        ///  显示进度条
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-18 15:19:17
        private void ShowPrgUpload()
        {
            splashScreenManager1.ShowWaitForm();
            splashScreenManager1.SetWaitFormDescription("正在上传中......");
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

        /// <summary>
        ///  微信帐号选择事件
        /// </summary>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-10-23 16:34:33
        private void cobUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PublicFileds.UserName = cobUserName.SelectedItem.ToString();
            LoadBaseXml();
        }




    }
}
