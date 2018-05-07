using System.Collections.Generic;
using PerkinElmer.Domain.Contracts;

namespace PerkinElmer.Domain.Implementation
{
	internal class Batch : IBatch
	{
		public IBatchInfo Info { get; set; }

		public IList<IBatchSample> BatchSamples { get; set; }
	}
}