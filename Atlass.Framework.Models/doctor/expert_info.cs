//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//     Website: http://www.freesql.net
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace Atlass.Framework.Models {

	
	public partial class expert_info {

		/// <summary>
		/// 工作单位
		/// </summary>
		[JsonProperty]
		public string company_name { get; set; } = string.Empty;
		/// <summary>
		/// 咨询次数
		/// </summary>
		[JsonProperty]
		public int expert_count { get; set; }
		/// <summary>
		/// 专家名称
		/// </summary>
		[JsonProperty, Column(DbType = "varchar(100)")]
		public string expert_name { get; set; } = string.Empty;
		/// <summary>
		/// 专家简介
		/// </summary>
		[JsonProperty]
		public string expert_profile { get; set; } = string.Empty;
		/// <summary>
		/// 专家头衔
		/// </summary>
		[JsonProperty]
		public string expert_title { get; set; } = string.Empty;
		/// <summary>
		/// 专家类型
		/// </summary>
		[JsonProperty, Column(DbType = "char(24)")]
		public string expert_type { get; set; } = string.Empty;
		[JsonProperty, Column(DbType = "varchar(50)")]
		public string type_name { get; set; } = string.Empty;
		/// <summary>
		/// 头像
		/// </summary>
		[JsonProperty]
		public string head_url { get; set; } = string.Empty;
		/// <summary>
		/// 数据id
		/// </summary>
		[JsonProperty, Column(IsPrimary =true,DbType = "char(24)")]
		public string id { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime insert_time { get; set; }

		[JsonProperty]
		public long insert_uid { get; set; }
		/// <summary>
		/// 删除
		/// </summary>
		[JsonProperty, Column(DbType = "tinyint(1)")]
		public int is_delete { get; set; }
		/// <summary>
		/// 免费
		/// </summary>
		[JsonProperty, Column(DbType = "tinyint(1)")]
		public bool is_free { get; set; }
		/// <summary>
		/// 是否展示
		/// </summary>
		[JsonProperty, Column(DbType = "tinyint(1)")]
		public bool is_show { get; set; }
		/// <summary>
		/// 关联openId
		/// </summary>
		[JsonProperty, Column(DbType = "char(28)")]
		public string open_id { get; set; } = string.Empty;

		/// <summary>
		/// 职位
		/// </summary>
		[JsonProperty]
		public string position_name { get; set; } = string.Empty;

		[JsonProperty]
		public string remark { get; set; } = string.Empty;
		/// <summary>
		/// 排序
		/// </summary>
		[JsonProperty]
		public short show_sort { get; set; }
		/// <summary>
		/// 评分
		/// </summary>
		[JsonProperty, Column(DbType = "decimal(2,1)")]
		public decimal star_score { get; set; }

		/// <summary>
		/// 工作年限
		/// </summary>
		[JsonProperty]
		public int work_year { get; set; }

	}

}
