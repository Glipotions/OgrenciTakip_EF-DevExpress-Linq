using DataAccess.Base;
using DataAccess.Interfaces;
using DevExpress.Utils.Extensions;
using OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Runtime.InteropServices;
using System.Security;

namespace OgrenciTakip.Business.Function
{
	public static class GeneralFunctions
	{
		public static IList<string> DegisenAlanlariGetir<T>(this T oldEntity, T currentEntity)
		{
			List<string> alanlar = new List<string>();
			foreach (var prop in currentEntity.GetType().GetProperties())
			{
				if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;
				var oldValue = prop.GetValue(oldEntity) ?? string.Empty;
				var currentValue = prop.GetValue(currentEntity) ?? string.Empty;

				if (prop.PropertyType == typeof(byte[]))
				{
					if (string.IsNullOrEmpty(oldValue.ToString()))
						oldValue = new byte[] { };
					if (string.IsNullOrEmpty(currentValue.ToString()))
						currentValue = new byte[] { };
					if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
						alanlar.Add(prop.Name);

				}
				else if (!currentValue.Equals(oldValue))
					alanlar.Add(prop.Name);
			}
			return alanlar;
		}
		public static string GetConnectionString()
		{
			return ConfigurationManager.ConnectionStrings["OgrenciTakipContext"].ConnectionString;
		}
		private static TContext CreateContext<TContext>() where TContext : DbContext
		{
			return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
		}
		public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow) where T : class, IBaseEntity where TContext : DbContext
		{
			uow?.Dispose();
			uow = new UnitOfWork<T>(CreateContext<TContext>());
		}

		public static SecureString ConvertToSecureString(this string value)
		{
			var secureString = new SecureString();

			if (value.Length > 0)
				value.ToCharArray().ForEach(x => secureString.AppendChar(x));

			secureString.MakeReadOnly();
			return secureString;
		}

		public static string ConvertToUnSecureString(this SecureString value)
		{
			var result = Marshal.SecureStringToBSTR(value);
			return Marshal.PtrToStringAuto(result);
		}

	}
}
