﻿using System.Collections.Generic;
using WebSite.Model.DataBaseModel;

namespace WebSite.IBLL.SingletonPattern
{
	public partial interface IKeyWordsRankService : IBaseService<KeyWordsRank>
	{
		/// <summary>
		/// 将统计的明细表的数据插入。
		/// </summary>
		/// <returns></returns>
		bool InsertKeyWordsRank();

		/// <summary>
		/// 删除汇总中的数据。
		/// </summary>
		/// <returns></returns>
		bool DeleteAllKeyWordsRank();

		List<string> GetSearchMsg(string term);
	}
}
