using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_Profile")]
	public class Profile
	{
		[Key]
		public int UserID { get; set; }

		public User User { get; set; }

		[Required]
		public bool IsSubscribed { get; set; }

		[Column(TypeName = "NVARCHAR(MAX)")]
		[Required]
		public string Signature { get; set; }

		[Required]
		public bool ShowDetails { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Location { get; set; }

		[Required]
		public bool IsPlainText { get; set; }

		public DateTime? Dob { get; set; } = null!;

		[Column(TypeName = "NVARCHAR(256)")]
		public string Web { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		public string Facebook { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		public string Twitter { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		public string Instagram { get; set; }

		[Required]
		public bool IsTos { get; set; }

		[Required]
		public int TimeZone { get; set; }

		[Required]
		public bool IsDaylightSaving { get; set; }

		public int? AvatarID { get; set; } = null!;

		public int? ImageID { get; set; } = null!;

		[Required]
		public bool HideVanity { get; set; }

		public int? LastPostID { get; set; } = null!;

		[Required]
		public int Points { get; set; }
	}
}
