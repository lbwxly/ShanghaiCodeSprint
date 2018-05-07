using System;
using PerkinElmer.Domain.Contracts;

namespace PerkinElmer.Domain.Implementation
{
	internal class BatchInfo : IBatchInfo
	{
		public string Name { get; set; }

		public Guid Guid { get; set; }

		public DateTime CreatedDateUtc { get; set; }

		public DateTime ModifiedDateUtc { get; set; }
	}
}