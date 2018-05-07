using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using log4net;
using PerkinElmer.Domain.Contracts;
using PerkinElmer.Domain.Implementation;

namespace PerkinElmer.Domain.Factory
{
	public static class DomainFactory
	{
		private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private static readonly IDictionary<Type, Type> DomainTypesImplementation = new Dictionary<Type, Type>
		{
			{typeof(IBatch), typeof(Batch)},
			{typeof(IBatchInfo), typeof(BatchInfo)},
			{typeof(IBatchSample), typeof(BatchSample)}
		};

		static DomainFactory()
		{
		}

		public static T Create<T>()
		{
			var type = typeof(T);

			if (!DomainTypesImplementation.TryGetValue(type,
				out var domainObjectType))
			{
				var message = string.Format(CultureInfo.InvariantCulture, "Type '{0}' can't be created!", type.Name);
				Log.Error(message);
				throw new Exception(message);
			}

			Log.Debug(string.Format(CultureInfo.InvariantCulture, "Type '{0}' was created", type.Name));

			return (T) Activator.CreateInstance(domainObjectType);
		}
	}
}