using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22571460_S1P07.Models
{
	public class Publication
	{
		public string Title { get; set; }
		public string Image { get; set; }
		public Author Author { get; set; }
		public string Summary { get; set; }
		public string Link { get; set; }
		public DateTime DatePublished { get; set; }
		public virtual string GetPublicationDate()
		{
			return DatePublished.ToString("dddd, dd MMMM yyyy");
		}
		public virtual string GetTypeName()
		{
			return "Publication";
		}

	}
}