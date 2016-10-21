// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ExampleApi
{
	/// <summary>
	/// An obsolete DTO.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	[Obsolete]
	public sealed partial class ObsoleteDataDto : ServiceDto<ObsoleteDataDto>
	{
		public bool? Unused { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(ObsoleteDataDto other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalent(Unused, other.Unused);
		}
	}
}
