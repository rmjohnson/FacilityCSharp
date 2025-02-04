// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
#nullable enable
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core.Http;

namespace Facility.ConformanceApi.Http
{
	/// <summary>
	/// API for a Facility test server.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class ConformanceApiHttpHandler : ServiceHttpHandler
	{
		/// <summary>
		/// Creates the handler.
		/// </summary>
		public ConformanceApiHttpHandler(IConformanceApi service, ServiceHttpHandlerSettings? settings = null)
			: base(settings)
		{
			m_service = service ?? throw new ArgumentNullException(nameof(service));
		}

		/// <summary>
		/// Creates the handler.
		/// </summary>
		public ConformanceApiHttpHandler(Func<HttpRequestMessage, IConformanceApi> getService, ServiceHttpHandlerSettings? settings = null)
			: base(settings)
		{
			m_getService = getService ?? throw new ArgumentNullException(nameof(getService));
		}

		/// <summary>
		/// Attempts to handle the HTTP request.
		/// </summary>
		public override async Task<HttpResponseMessage?> TryHandleHttpRequestAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default)
		{
			return await AdaptTask(TryHandleGetApiInfoAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleBodyTypesAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleCheckQueryAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleCheckPathAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleMirrorBytesAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleMirrorFieldsAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleMirrorHeadersAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleMirrorTextAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleMixedAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleRequiredAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleGetWidgetsAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleCreateWidgetAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleGetWidgetBatchAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleGetWidgetAsync(httpRequest, cancellationToken)).ConfigureAwait(true) ??
				await AdaptTask(TryHandleDeleteWidgetAsync(httpRequest, cancellationToken)).ConfigureAwait(true);
		}

		/// <summary>
		/// Gets API information.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleGetApiInfoAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.GetApiInfoMapping, httpRequest, GetService(httpRequest).GetApiInfoAsync, cancellationToken);

		/// <summary>
		/// Gets widgets.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleGetWidgetsAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.GetWidgetsMapping, httpRequest, GetService(httpRequest).GetWidgetsAsync, cancellationToken);

		/// <summary>
		/// Creates a new widget.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleCreateWidgetAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.CreateWidgetMapping, httpRequest, GetService(httpRequest).CreateWidgetAsync, cancellationToken);

		/// <summary>
		/// Gets the specified widget.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleGetWidgetAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.GetWidgetMapping, httpRequest, GetService(httpRequest).GetWidgetAsync, cancellationToken);

		/// <summary>
		/// Deletes the specified widget.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleDeleteWidgetAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.DeleteWidgetMapping, httpRequest, GetService(httpRequest).DeleteWidgetAsync, cancellationToken);

		/// <summary>
		/// Gets the specified widgets.
		/// </summary>
		public Task<HttpResponseMessage?> TryHandleGetWidgetBatchAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.GetWidgetBatchMapping, httpRequest, GetService(httpRequest).GetWidgetBatchAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleMirrorFieldsAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.MirrorFieldsMapping, httpRequest, GetService(httpRequest).MirrorFieldsAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleCheckQueryAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.CheckQueryMapping, httpRequest, GetService(httpRequest).CheckQueryAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleCheckPathAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.CheckPathMapping, httpRequest, GetService(httpRequest).CheckPathAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleMirrorHeadersAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.MirrorHeadersMapping, httpRequest, GetService(httpRequest).MirrorHeadersAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleMixedAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.MixedMapping, httpRequest, GetService(httpRequest).MixedAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleRequiredAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.RequiredMapping, httpRequest, GetService(httpRequest).RequiredAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleMirrorBytesAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.MirrorBytesMapping, httpRequest, GetService(httpRequest).MirrorBytesAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleMirrorTextAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.MirrorTextMapping, httpRequest, GetService(httpRequest).MirrorTextAsync, cancellationToken);

		public Task<HttpResponseMessage?> TryHandleBodyTypesAsync(HttpRequestMessage httpRequest, CancellationToken cancellationToken = default) =>
			TryHandleServiceMethodAsync(ConformanceApiHttpMapping.BodyTypesMapping, httpRequest, GetService(httpRequest).BodyTypesAsync, cancellationToken);

		/// <summary>
		/// Returns the HTTP status code for a custom error code.
		/// </summary>
		protected override HttpStatusCode? TryGetCustomHttpStatusCode(string errorCode) =>
			HttpApiErrors.TryGetHttpStatusCode(errorCode);

		private IConformanceApi GetService(HttpRequestMessage httpRequest) => m_service ?? m_getService!(httpRequest);

		readonly IConformanceApi? m_service;
		readonly Func<HttpRequestMessage, IConformanceApi>? m_getService;
	}
}
