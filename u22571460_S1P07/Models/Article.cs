using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u22571460_S1P07.Models
{
	public class Article : Publication
	{
        public override string GetTypeName()
        {
            return "Article";
        }
    }
}