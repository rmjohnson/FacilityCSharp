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
	public class UserAgentClientAspectTests
	{
		[Test]
		public async Task UserAgentClientAspectWorks()
		{
			const string header = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2227.1 Safari/537.36";
			var aspect = UserAgentClientAspect.Create(header);
			var httpRequest = new HttpRequestMessage();
			await aspect.RequestReadyAsync(httpRequest, new TestDto(), CancellationToken.None);
			httpRequest.Headers.UserAgent.ToString().Should().Be(header);
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
