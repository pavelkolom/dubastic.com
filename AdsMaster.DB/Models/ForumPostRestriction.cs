using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_ForumPostRestrictions")]
	public class ForumPostRestriction
	{
		[Key]
		public int ForumPostRestrictionId { get; set; }
		
		public int ForumID { get; set; }
		
		public Forum Forum { get; set; }
		
		public ForumRole ForumRole { get; set; }


		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Role { get; set; }
	}
}
