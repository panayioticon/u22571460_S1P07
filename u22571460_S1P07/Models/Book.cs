using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22571460_S1P07.Models
{
	public class Book : Publication
	{
		public int EditionCount { get; set; }
        public override string GetTypeName()
        {
            return "Book";
        }
        public string GetEditionInfo()
        {
            return $"{EditionCount} Edition(s)";
        }
    }
}