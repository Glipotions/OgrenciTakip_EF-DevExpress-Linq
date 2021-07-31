using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OgrenciTakip.Business.Function
{
	public static class ValidationFuction
	{

		public static List<PropertyAttribute<TAttribute>> GetPropertyAttributesFromType<TAttribute>(this Type entityType) where TAttribute: Attribute
		{
			var list = new List<PropertyAttribute<TAttribute>>();
			var properties = entityType.GetProperties();

			foreach (var property in properties)
			{
				var attributes = property.GetCustomAttributes<TAttribute>(true).ToList();
				if (!attributes.Any()) continue;

				list.AddRange(attributes.Select(x => new PropertyAttribute<TAttribute>(property, x)));
			}

			var interfaces = entityType.GetInterfaces();
			foreach (var iface in interfaces)
				list.AddRange(iface.GetPropertyAttributesFromType<TAttribute>());


			return list;
		}
		public class PropertyAttribute<TAttribute>
		{
			public PropertyInfo Property { get; set; }
			public TAttribute Attribute { get; set; }

			public PropertyAttribute(PropertyInfo property, TAttribute attribute)
			{
				Property = property;
				Attribute = attribute;
			}
		}
	}
}
