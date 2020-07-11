using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_UserSession")]
	public class UserSession
	{
		[Key]
		public int SessionID { get; set; }
		
		public int UserID { get; set; }

		public DateTime LastTime { get; set; }
	}
}
