using System;
using System.Linq;
using System.Security.Principal;

namespace PEGASUS.Pegasus
{
	internal class Constants
	{
		public static bool Breached;

		public static bool Started;

		public static string IV;

		public static string Key;

		public static string ApiUrl = "https://api.auth.gg/csharp/";

		public static bool Initialized;

		public static Random random = new Random();

		public static string Token { get; set; }

		public static string Date { get; set; }

		public static string APIENCRYPTKEY { get; set; }

		public static string APIENCRYPTSALT { get; set; }

		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
				select s[random.Next(s.Length)]).ToArray());
		}

		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}
	}
}
