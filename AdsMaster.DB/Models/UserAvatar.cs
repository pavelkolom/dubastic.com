using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_UserAvatar")]
	public class UserAvatar
	{
		[Key]
		public int UserAvatarID { get; set; }
		
		public int UserID { get; set; }
		
		public User User { get; set; }
		
		public DateTime TimeStamp { get; set; }

		[Column(TypeName = "VARBINARY(MAX)")]
		[Required]
		public byte[] ImageData { get; set; }
	}
}
