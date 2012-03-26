using System;
using System.Configuration;

namespace ConfigurationTest
{
	public static class Config
	{
	
		public static String webSetting1
		{
			get
			{
				return ConfigurationManager.AppSettings["webSetting1"];
			}
		}
	
		public static String webSetting2
		{
			get
			{
				return ConfigurationManager.AppSettings["webSetting2"];
			}
		}
		public static String conn1
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["conn1"].ConnectionString;
			}
		}
	}
}

