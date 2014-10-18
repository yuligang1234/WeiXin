using System.Web.Mvc;
using WeiXin.Common;

namespace WeiXin.Web.Controllers
{
    public class BaseController : Controller
    {

        /// <summary>
        ///  当操作中发生未经处理的异常时调用。
        /// </summary>
        /// <param name="filterContext">有关当前请求和操作的信息。</param>
        /// Author  : 俞立钢
        /// Company : 绍兴标点电子技术有限公司
        /// Created : 2014-09-23 17:02:53
        protected override void OnException(ExceptionContext filterContext)
        {
            LogHelper.ErrorLog("<br/>【<strong>客户机IP</strong>】：" + Request.UserHostAddress + "<br />【<strong>错误地址</strong>】：" + Request.Url, filterContext.Exception);
            filterContext.Result = Content("<script>top.window.location.href='/Error/Index';</script>");
            base.OnException(filterContext);
        }

    }
}
