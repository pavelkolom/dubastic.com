using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_UserImages")]
	public class UserImage
	{
		[Key]
		public int UserImageID { get; set; }
		
		public int UserID { get; set; }
		
		public User User { get; set; }
		
		public int SortOrder { get; set; }
		
		public bool IsApproved { get; set; }
		
		public DateTime TimeStamp { get; set; }
		
		[Column(TypeName = "VARBINARY(MAX)")]
		[Required]
		public byte[] ImageData { get; set; }
	}
}
