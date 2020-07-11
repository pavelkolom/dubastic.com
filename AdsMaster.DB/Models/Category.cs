using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Category")]
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Title { get; set; }
		
		public List<Forum> Forums { get; set; }

		[Required]
		public int SortOrder { get; set; }
	}
}
