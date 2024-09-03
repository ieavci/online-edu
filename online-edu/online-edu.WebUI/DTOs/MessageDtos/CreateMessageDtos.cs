using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.WebUI.DTOs.MessageDtos
{
    public class CreateMessageDtos
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Content { get; set; }
	}
}
