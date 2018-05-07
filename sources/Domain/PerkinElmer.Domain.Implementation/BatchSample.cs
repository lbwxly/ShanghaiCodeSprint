using System;
using PerkinElmer.Domain.Contracts;

namespace PerkinElmer.Domain.Implementation
{
	internal class BatchSample : IBatchSample
	{
		public string Name { get; set; }

		public Guid Guid { get; set; }

		public SampleType SampleType { get; set; }

		public SynchronizationType SynchronizationType { get; set; }
	}
}