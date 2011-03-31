using System;
using System.Configuration;

namespace Sineshift.Configuration
{
	public static class Config
	{
	
		public static String Setting1
		{
			get
			{
				return ConfigurationManager.AppSettings["Setting1"];
			}
		}
	
		public static String Setting2
		{
			get
			{
				return ConfigurationManager.AppSettings["Setting2"];
			}
		}
	}
}

