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

	
	public partial class sys_user {

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string account_name { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "int(20)")]
		public int city { get; set; }

		[JsonProperty, Column(DbType = "int(20)")]
		public int county { get; set; }

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string create_person { get; set; } = string.Empty;

		[JsonProperty]
		public DateTime create_time { get; set; }

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string email { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string fax { get; set; } = string.Empty;

		[JsonProperty]
		public long id { get; set; }

		[JsonProperty, Column(DbType = "tinyint(1)")]
		public bool is_super { get; set; }

		[JsonProperty, Column(DbType = "varchar(20)")]
		public string mobile_phone { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "varchar(100)")]
		public string pass_word { get; set; } = string.Empty;

		[JsonProperty, Column(DbType = "int(20)")]
		public int province { get; set; }

		[JsonProperty, Column(DbType = "varchar(100)")]
		public string real_name { get; set; } = string.Empty;

		[JsonProperty]
		public string remark { get; set; } = string.Empty;

		[JsonProperty]
		public long sys_role_id { get; set; }

		[JsonProperty]
		public int user_level { get; set; }

	}

}
