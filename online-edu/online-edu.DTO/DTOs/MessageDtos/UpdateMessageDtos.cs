﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_edu.DTO.DTOs.MessageDtos
{
	public class UpdateMessageDtos
	{
		public int MessageId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Subject { get; set; }
		public string Content { get; set; }
	}
}
