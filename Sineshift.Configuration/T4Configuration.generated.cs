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
	
		public static String Setting2
		{
			get
			{
				return ConfigurationManager.AppSettings["Setting2"];
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

