﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Common.UtilityClass;
using WebSite.IBLL;
using WebSite.Model.DataModel;

namespace WebSite.WebApp.Controllers
{
	public class LoginController : Controller
	{
		public IUserInfoService UserInfoService { get; set; }

		// GET: Login
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// 显示验证码
		/// </summary>
		/// <returns></returns>
		public ActionResult ShowValidateCode()
		{
			ValidateCode validateCode = new ValidateCode();
			//产生验证码
			string code = validateCode.CreateValidateCode(4);
			Session["validateCode"] = code;
			//将验证码画到画布上
			byte[] buffer = validateCode.CreateValidateGraphic(code);
			return File(buffer, "image/jpeg");
		}

		/// <summary>
		/// 完成用户登录
		/// </summary>
		/// <returns></returns>
		public ActionResult UserLogin()
		{
			ResultModel<string> resultModel = null;
			var sessionCode = Session["validateCode"];
			string validateCode = sessionCode != null ? sessionCode.ToString() : string.Empty;
			if (string.IsNullOrEmpty(validateCode))
			{
				resultModel = new ResultModel<string>(new CodeMessage(ResultCodeEnum.Failure, "验证码错误"));
			}
			else
			{
				Session["validateCode"] = null;
				string txtCode = Request["vCode"];
				if (!validateCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
				{
					resultModel = new ResultModel<string>(new CodeMessage(ResultCodeEnum.Failure, "验证码错误"));
				}
				else
				{
					string account = Request["LoginCode"];
					string userPwd = Request["LoginPwd"];
					var userInfo = UserInfoService.LoadEntities(o => o.Account == account && o.UserPassword == userPwd).FirstOrDefault();
					if (userInfo != null)
					{
						// Session["userInfo"] = userInfo;
						//产生一个GUID值作为Memache的键.
						//  System.Web.Script.Serialization.JavaScriptSerializer
						string sessionId = Guid.NewGuid().ToString();
						//将登录用户信息存储到Memcache中。
						MemcacheHelper.Set(sessionId, SerializeHelper.SerializeToString(userInfo), DateTime.Now.AddMinutes(20));
						//将Memcache的key以Cookie的形式返回给浏览器。
						Response.Cookies["sessionId"].Value = sessionId;
						resultModel = new ResultModel<string>(new CodeMessage(ResultCodeEnum.Success, "登录成功"));
					}
					else
					{
						resultModel = new ResultModel<string>(new CodeMessage(ResultCodeEnum.Failure, "登录失败"));
					}
				}
			}
			return Json(resultModel, JsonRequestBehavior.AllowGet);
		}
	}
}