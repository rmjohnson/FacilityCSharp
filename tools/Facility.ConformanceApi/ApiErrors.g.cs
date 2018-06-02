// DO NOT EDIT: generated by fsdgencsharp
using System;
using Facility.Core;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Custom errors.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public static partial class ApiErrors
	{
		/// <summary>
		/// The user is not an administrator.
		/// </summary>
		public const string NotAdmin = "NotAdmin";

		/// <summary>
		/// The user is not an administrator.
		/// </summary>
		public static ServiceErrorDto CreateNotAdmin(string message = null) => new ServiceErrorDto(NotAdmin, message ?? "The user is not an administrator.");
	}
}
