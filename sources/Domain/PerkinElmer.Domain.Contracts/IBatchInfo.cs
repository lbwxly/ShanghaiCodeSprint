using System;

namespace PerkinElmer.Domain.Contracts
{
	public interface IBatchInfo
	{
		string Name { get; set; }

		Guid Guid { get; set; }

		DateTime CreatedDateUtc { get; set; }

		DateTime ModifiedDateUtc { get; set; }
	}
}