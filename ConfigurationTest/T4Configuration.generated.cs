using System;
using System.Configuration;

namespace ConfigurationTest
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

