using System;
using System.Configuration;

namespace Sineshift.Configuration
{
	public static class Config
	{
	
		public static String ClientValidationEnabled
		{
			get
			{
				return ConfigurationManager.AppSettings["ClientValidationEnabled"];
			}
		}
	
		public static String UnobtrusiveJavaScriptEnabled
		{
			get
			{
				return ConfigurationManager.AppSettings["UnobtrusiveJavaScriptEnabled"];
			}
		}
		public static String ApplicationServices
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString;
			}
		}
		public static String MisAdminWebEntities
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["MisAdminWebEntities"].ConnectionString;
			}
		}
		public static String MisDataContext
		{
			get
			{
				return ConfigurationManager.ConnectionStrings["MisDataContext"].ConnectionString;
			}
		}
	}
}

