using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_TopicSearchWords")]
	public class TopicSearchWord
	{
		[Key]
		public int TopicSearchWordID { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string SearchWord { get; set; }
		
		public int TopicID { get; set; }
		

		public int Rank { get; set; }
	}
}
