// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Request for MirrorBytes.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class MirrorBytesRequestDto : ServiceDto<MirrorBytesRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public MirrorBytesRequestDto()
		{
		}

		public byte[]? Content { get; set; }

		public string? Type { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(MirrorBytesRequestDto? other)
		{
			return other != null &&
				ServiceDataUtility.AreEquivalentBytes(Content, other.Content) &&
				Type == other.Type;
		}
	}
}
