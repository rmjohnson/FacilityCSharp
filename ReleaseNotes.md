# Release Notes

## 2.9.0

* Support bytes/strings as request/response body fields.
* Support custom content type on request/response body fields.
* Support `Content-Type` as header fields.

## 2.8.1

* Update dependencies.

## 2.8.0

* Support and generate delegating implementations of services.
* Allow default cancellation token on public client methods.

## 2.7.2

* Add .NET 5 support to `fsdgencsharp` and `FacilityConformance`.
* Nullable reference improvement to `ServiceResult.GetValueOrDefault`.

## 2.7.1

* Simplify generated null check.

## 2.7.0

* Add .NET Standard 2.1 target.
* Make `ServiceResult<T>.GetValueOrDefault` maybe null.

## 2.6.0

* Only load JSON streams into memory when `ForceAsyncIO` is set.
* Add `JsonHttpContentSerializer.MemoryStreamCreator`.

## 2.5.0

* Load JSON request streams into memory to avoid synchronous I/O, which ASP.NET Core doesn't allow by default. (This was already true for JSON responses.)

## 2.4.1

* Add .NET Core App 3.1 support to `fsdgencsharp` and `FacilityConformance`.
* A few nullable reference improvements.
* Update `Facility.Definition` and `Facility.CodeGen.Console`.

## 2.4.0

* Support shorthand for required attribute, e.g. `string!`.

## 2.3.0

* Support DTO validation, specifically for `[required]` fields.

## 2.2.1

* Support nullable references.
* Use `--nullable` to generate code with nullable references.
* Add `ServiceResult.ToFailure`.

## 2.1.0

* Expose `BaseUri` to derived `HttpClientService`.
* Stop using `System.Net.Http` reference.
* Minor optimization in `HttpClientService`.

## 2.0.3

* Stop using `System.Net.Http` NuGet package.

## 2.0.2

* Upgrade to .NET Standard 2.0.
* Upgrade NuGet dependencies, including `Facility.Definition` and `Facility.CodeGen.Console`.
* Convert `fsdgencsharp` to a .NET Core Global Tool.
* Drop `--csproj` support from `fsdgencsharp` (SDK-style projects don't need it.)
* Support static `CSharpGenerator.GenerateCSharp` for C# build scripts.
* Publish `Facility.ConformanceApi` library and `FacilityConformance` tool.
* Allow null `ServiceHttpHandlerSettings`.

## 1.3.2

* Start tracking version history.
