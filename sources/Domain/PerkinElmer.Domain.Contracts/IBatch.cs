using System.Collections.Generic;

namespace PerkinElmer.Domain.Contracts
{
	public interface IBatch
	{
		IBatchInfo Info { get; set; }

		IList<IBatchSample> BatchSamples { get; set; }
	}
}