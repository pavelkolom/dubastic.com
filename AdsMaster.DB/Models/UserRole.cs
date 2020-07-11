using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PopForumsUserRole")]
	public class UserRole
	{
		public int UserRoleId { get; set; }

		public int UserID { get; set; }
		
		public User User { get; set; }
		
		//public int RoleId { get; set; }

		public ForumRole ForumRole { get; set; }

		//[NotMapped]

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Role { get; set; }
	}
}
