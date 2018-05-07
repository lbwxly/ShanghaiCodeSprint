using System;

namespace PerkinElmer.Domain.Contracts
{
	public interface IBatchSample
	{
		string Name { get; set; }

		Guid Guid { get; set; }

		SampleType SampleType { get; set; }

		SynchronizationType SynchronizationType { get; set; }
	}
}