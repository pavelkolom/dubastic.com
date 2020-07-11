using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_PopForumsUser")]
	public class User
	{
		[Key]
		public int UserID { get; set; }

		public UserActivity UserActivity { get; set; }
		
		public UserAvatar UserAvatar { get; set; }

		public Profile Profile { get; set; }

		[Required]
		public DateTime CreationDate { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Name { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Email { get; set; }
		
		public Guid AuthorizationKey { get; set; }
		
		public bool IsApproved { get; set; }

		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Password { get; set; }
		
		public Guid? Salt { get; set; }

		[NotMapped]
		public List<string> Roles { get; set; }

		public List<PrivateMessageUser> PrivateMessageUsers { get; set; }
		
		public List<UserImage> UserImages { get; set; }

		public List<LastForumView> LastForumViews { get; set; }
		public List<LastTopicView> LastTopicViews { get; set; }
		public List<SubscribeTopic> SubscribeTopics { get; set; }
		public List<Favorite> Favorites { get; set; }
		public List<UserRole> UserRoles { get; set; }
		

		public bool IsInRole(string role)
		{
			if (Roles == null)
				throw new Exception("Roles not set for user.");
			return Roles.Contains(role);
		}
	}
}
