using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdsMaster.DB.Models
{
	[Table("pf_ExternalUserAssociation")]
	public class ExternalUserAssociation
	{
		[Key]
		public int ExternalUserAssociationID { get; set; }

		public int UserID { get; set; }

		[Column(TypeName = "NVARCHAR(50)")]
		[Required]
		public string Issuer { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string ProviderKey { get; set; }
		
		[Column(TypeName = "NVARCHAR(256)")]
		[Required]
		public string Name { get; set; }
	}
}
