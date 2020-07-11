using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Friend")]
	public class Friend
	{
		[Key]
		public int Id { get; set; }
		
		public int FromUserID { get; set; }
		
		public int ToUserID { get; set; }
		
		public bool IsApproved { get; set; }
	}
}
