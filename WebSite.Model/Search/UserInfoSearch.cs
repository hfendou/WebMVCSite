﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Model.Search
{
	/// <summary>
	/// 构建搜索用户信息的条件
	/// </summary>
	public class UserInfoSearch : BaseSearch
	{
		public string UserName { get; set; }
		public string Remark { get; set; }
	}
}