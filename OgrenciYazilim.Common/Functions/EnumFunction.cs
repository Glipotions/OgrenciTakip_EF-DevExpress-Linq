using System;
using System.ComponentModel;

namespace OgrenciYazilim.Common.Functions
{
	public static class EnumFunction
	{
		private static T GetAttribute<T>(this Enum value) where T : Attribute
		{
			if (value == null) return null;
			var memberInfo = value.GetType().GetMember(value.ToString());
			var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
			return (T)attributes[0];
		}

		public static string ToName(this Enum value)
		{
			if (value == null) return null;
			var attribute = value.GetAttribute<DescriptionAttribute>();
			return attribute == null ? value.ToString() : attribute.Description;
		}
	}
}
