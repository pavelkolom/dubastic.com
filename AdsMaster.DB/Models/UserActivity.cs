using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_UserActivity")]
	public class UserActivity
	{
		[Key]
		public int UserID { get; set; }
		public User User { get; set; }
		[Required]
		public DateTime LastActivityDate { get; set; }
		[Required]
		public DateTime LastLoginDate { get; set; }
	}
}
