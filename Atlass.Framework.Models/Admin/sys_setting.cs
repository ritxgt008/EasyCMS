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


	public partial class sys_setting {

		[JsonProperty, Column(DbType = "varchar(50)")]
		public string create_person { get; set; } = string.Empty;

		[JsonProperty]
		public DateTime create_time { get; set; }

		[JsonProperty, Column(DbType = "int(20)")]
		public int ds_pd { get; set; }

		[JsonProperty, Column(DbType = "int(20)")]
		public int ds_warn { get; set; }

		[JsonProperty]
		public long id { get; set; }

		[JsonProperty, Column(DbType = "datetime")]
		public DateTime last_count_time { get; set; }

		[JsonProperty]
		public long max_num { get; set; }

		[JsonProperty]
		public long min_num { get; set; }

		[JsonProperty]
		public int set_type { get; set; }

		[JsonProperty, Column(DbType = "decimal(5,2)")]
		public decimal step_warn_percent { get; set; }

		[JsonProperty, Column(DbType = "float(255,0)")]
		public float temp_max { get; set; }

		[JsonProperty, Column(DbType = "float(255,0)")]
		public float temp_min { get; set; }

	}

}