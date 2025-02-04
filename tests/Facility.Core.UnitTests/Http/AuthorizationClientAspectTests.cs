using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core.Http;
using FluentAssertions;
using NUnit.Framework;

#pragma warning disable 618 // obsolete

namespace Facility.Core.UnitTests.Http
{
	public class AuthorizationClientAspectTests
	{
		[Test]
		public async Task AuthorizationClientAspectWorks()
		{
			const string header = "MyAuth Whatever";
			var aspect = AuthorizationClientAspect.Create(header);
			var httpRequest = new HttpRequestMessage();
			await aspect.RequestReadyAsync(httpRequest, new TestDto(), CancellationToken.None);
			httpRequest.Headers.Authorization!.ToString().Should().Be(header);
		}

		private class TestDto : ServiceDto<TestDto>
		{
			public override bool IsEquivalentTo(TestDto? other)
			{
				return other != null;
			}
		}
	}
}
