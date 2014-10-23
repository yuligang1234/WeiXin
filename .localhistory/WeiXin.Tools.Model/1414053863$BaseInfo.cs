
namespace WeiXin.Tools.Model
{
    public class BaseInfo
    {

        /// <summary>
        /// Id
        /// </summary>		
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }        
        /// <summary>
        /// 服务器URL
        /// </summary>		
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        /// <summary>
        /// 令牌
        /// </summary>		
        private string _token;
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
        /// <summary>
        /// 应用ID
        /// </summary>		
        private string _appid;
        public string Appid
        {
            get { return _appid; }
            set { _appid = value; }
        }
        /// <summary>
        /// 应用密钥
        /// </summary>		
        private string _appsecret;
        public string Appsecret
        {
            get { return _appsecret; }
            set { _appsecret = value; }
        }
        /// <summary>
        /// 接口密钥
        /// </summary>		
        private string _accesstoken;
        public string AccessToken
        {
            get { return _accesstoken; }
            set { _accesstoken = value; }
        }
        /// <summary>
        /// 接口密钥开始时间
        /// </summary>		
        private string _startdatetime;
        public string StartDateTime
        {
            get { return _startdatetime; }
            set { _startdatetime = value; }
        }
        /// <summary>
        /// 接口密钥结束时间
        /// </summary>		
        private string _enddatetime;
        public string EndDateTime
        {
            get { return _enddatetime; }
            set { _enddatetime = value; }
        }
        /// <summary>
        /// 接口密钥有效时长（秒）
        /// </summary>		
        private string _timespace;
        public string TimeSpace
        {
            get { return _timespace; }
            set { _timespace = value; }
        }
        /// <summary>
        /// 微信帐号
        /// </summary>
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

    }
}
