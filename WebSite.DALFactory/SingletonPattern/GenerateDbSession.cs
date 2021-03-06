﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//	   如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类实现方法。
// </auto-generated>
//
// <copyright file="WebSiteDbContext">
//		Copyright(c)2018 rights reserved.
//		开 发 者：黄翔宇@中国
//		生成时间：2018-06-15 16:33
// </copyright>
//------------------------------------------------------------------------------
using WebSite.IDAL.SingletonPattern;

namespace WebSite.DALFactory.SingletonPattern
{
	/// <summary>
	/// 数据会话层：就是一个工厂类，负责完成所有数据操作类实例的创建，然后业务层通过数据会话层来获取要操作数据类的实例。所以数据会话层将业务层与数据层解耦。
	/// 在数据会话层中提供一个方法：完成所有数据的保存。
	/// </summary>
	public partial class DbSession : IDbSession
	{
        private IActionInfoDal _actionInfoDal = null;
        /// <summary>
		/// 获取IActionInfoDal接口的实例
		/// </summary>
		public IActionInfoDal ActionInfoDal
		{
			get
			{
				if (_actionInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_actionInfoDal = AbstractFactory.CreateInstanceDal<IActionInfoDal>();
				}
				return _actionInfoDal;
			}
		}

        private IActionInfo_DepartmentInfoDal _actionInfo_DepartmentInfoDal = null;
        /// <summary>
		/// 获取IActionInfo_DepartmentInfoDal接口的实例
		/// </summary>
		public IActionInfo_DepartmentInfoDal ActionInfo_DepartmentInfoDal
		{
			get
			{
				if (_actionInfo_DepartmentInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_actionInfo_DepartmentInfoDal = AbstractFactory.CreateInstanceDal<IActionInfo_DepartmentInfoDal>();
				}
				return _actionInfo_DepartmentInfoDal;
			}
		}

        private ICategoryDal _categoryDal = null;
        /// <summary>
		/// 获取ICategoryDal接口的实例
		/// </summary>
		public ICategoryDal CategoryDal
		{
			get
			{
				if (_categoryDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_categoryDal = AbstractFactory.CreateInstanceDal<ICategoryDal>();
				}
				return _categoryDal;
			}
		}

        private IDepartmentInfoDal _departmentInfoDal = null;
        /// <summary>
		/// 获取IDepartmentInfoDal接口的实例
		/// </summary>
		public IDepartmentInfoDal DepartmentInfoDal
		{
			get
			{
				if (_departmentInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_departmentInfoDal = AbstractFactory.CreateInstanceDal<IDepartmentInfoDal>();
				}
				return _departmentInfoDal;
			}
		}

        private IJD_Commodity_001Dal _jD_Commodity_001Dal = null;
        /// <summary>
		/// 获取IJD_Commodity_001Dal接口的实例
		/// </summary>
		public IJD_Commodity_001Dal JD_Commodity_001Dal
		{
			get
			{
				if (_jD_Commodity_001Dal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_jD_Commodity_001Dal = AbstractFactory.CreateInstanceDal<IJD_Commodity_001Dal>();
				}
				return _jD_Commodity_001Dal;
			}
		}

        private IJD_Commodity_002Dal _jD_Commodity_002Dal = null;
        /// <summary>
		/// 获取IJD_Commodity_002Dal接口的实例
		/// </summary>
		public IJD_Commodity_002Dal JD_Commodity_002Dal
		{
			get
			{
				if (_jD_Commodity_002Dal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_jD_Commodity_002Dal = AbstractFactory.CreateInstanceDal<IJD_Commodity_002Dal>();
				}
				return _jD_Commodity_002Dal;
			}
		}

        private IJD_Commodity_003Dal _jD_Commodity_003Dal = null;
        /// <summary>
		/// 获取IJD_Commodity_003Dal接口的实例
		/// </summary>
		public IJD_Commodity_003Dal JD_Commodity_003Dal
		{
			get
			{
				if (_jD_Commodity_003Dal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_jD_Commodity_003Dal = AbstractFactory.CreateInstanceDal<IJD_Commodity_003Dal>();
				}
				return _jD_Commodity_003Dal;
			}
		}

        private IJD_Commodity_004Dal _jD_Commodity_004Dal = null;
        /// <summary>
		/// 获取IJD_Commodity_004Dal接口的实例
		/// </summary>
		public IJD_Commodity_004Dal JD_Commodity_004Dal
		{
			get
			{
				if (_jD_Commodity_004Dal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_jD_Commodity_004Dal = AbstractFactory.CreateInstanceDal<IJD_Commodity_004Dal>();
				}
				return _jD_Commodity_004Dal;
			}
		}

        private IJD_Commodity_005Dal _jD_Commodity_005Dal = null;
        /// <summary>
		/// 获取IJD_Commodity_005Dal接口的实例
		/// </summary>
		public IJD_Commodity_005Dal JD_Commodity_005Dal
		{
			get
			{
				if (_jD_Commodity_005Dal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_jD_Commodity_005Dal = AbstractFactory.CreateInstanceDal<IJD_Commodity_005Dal>();
				}
				return _jD_Commodity_005Dal;
			}
		}

        private IKeyWordsRankDal _keyWordsRankDal = null;
        /// <summary>
		/// 获取IKeyWordsRankDal接口的实例
		/// </summary>
		public IKeyWordsRankDal KeyWordsRankDal
		{
			get
			{
				if (_keyWordsRankDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_keyWordsRankDal = AbstractFactory.CreateInstanceDal<IKeyWordsRankDal>();
				}
				return _keyWordsRankDal;
			}
		}

        private IRoleInfoDal _roleInfoDal = null;
        /// <summary>
		/// 获取IRoleInfoDal接口的实例
		/// </summary>
		public IRoleInfoDal RoleInfoDal
		{
			get
			{
				if (_roleInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_roleInfoDal = AbstractFactory.CreateInstanceDal<IRoleInfoDal>();
				}
				return _roleInfoDal;
			}
		}

        private IRoleInfo_ActionInfoDal _roleInfo_ActionInfoDal = null;
        /// <summary>
		/// 获取IRoleInfo_ActionInfoDal接口的实例
		/// </summary>
		public IRoleInfo_ActionInfoDal RoleInfo_ActionInfoDal
		{
			get
			{
				if (_roleInfo_ActionInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_roleInfo_ActionInfoDal = AbstractFactory.CreateInstanceDal<IRoleInfo_ActionInfoDal>();
				}
				return _roleInfo_ActionInfoDal;
			}
		}

        private IRoleInfo_UserInfoDal _roleInfo_UserInfoDal = null;
        /// <summary>
		/// 获取IRoleInfo_UserInfoDal接口的实例
		/// </summary>
		public IRoleInfo_UserInfoDal RoleInfo_UserInfoDal
		{
			get
			{
				if (_roleInfo_UserInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_roleInfo_UserInfoDal = AbstractFactory.CreateInstanceDal<IRoleInfo_UserInfoDal>();
				}
				return _roleInfo_UserInfoDal;
			}
		}

        private ISearchDetailsDal _searchDetailsDal = null;
        /// <summary>
		/// 获取ISearchDetailsDal接口的实例
		/// </summary>
		public ISearchDetailsDal SearchDetailsDal
		{
			get
			{
				if (_searchDetailsDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_searchDetailsDal = AbstractFactory.CreateInstanceDal<ISearchDetailsDal>();
				}
				return _searchDetailsDal;
			}
		}

        private IUserInfoDal _userInfoDal = null;
        /// <summary>
		/// 获取IUserInfoDal接口的实例
		/// </summary>
		public IUserInfoDal UserInfoDal
		{
			get
			{
				if (_userInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_userInfoDal = AbstractFactory.CreateInstanceDal<IUserInfoDal>();
				}
				return _userInfoDal;
			}
		}

        private IUserInfo_ActionInfoDal _userInfo_ActionInfoDal = null;
        /// <summary>
		/// 获取IUserInfo_ActionInfoDal接口的实例
		/// </summary>
		public IUserInfo_ActionInfoDal UserInfo_ActionInfoDal
		{
			get
			{
				if (_userInfo_ActionInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_userInfo_ActionInfoDal = AbstractFactory.CreateInstanceDal<IUserInfo_ActionInfoDal>();
				}
				return _userInfo_ActionInfoDal;
			}
		}

        private IUserInfo_DepartmentInfoDal _userInfo_DepartmentInfoDal = null;
        /// <summary>
		/// 获取IUserInfo_DepartmentInfoDal接口的实例
		/// </summary>
		public IUserInfo_DepartmentInfoDal UserInfo_DepartmentInfoDal
		{
			get
			{
				if (_userInfo_DepartmentInfoDal == null)
				{
					//通过抽象工厂封装了类的实例的创建
					_userInfo_DepartmentInfoDal = AbstractFactory.CreateInstanceDal<IUserInfo_DepartmentInfoDal>();
				}
				return _userInfo_DepartmentInfoDal;
			}
		}

    }
}