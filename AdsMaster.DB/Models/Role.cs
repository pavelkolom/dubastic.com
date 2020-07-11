using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Role")]
	public class ForumRole
	{
		//[Key]
		//public int RoleID { get; set; }
		[Key]
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Role { get; set; }

		public List<ForumPostRestriction> ForumPostRestrictions { get; set; }
		
		public List<ForumViewRestriction> ForumViewRestrictions { get; set; }
		
		public List<UserRole> UserRoles { get; set; }
	}
}
