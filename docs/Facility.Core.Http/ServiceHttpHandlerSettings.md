# ServiceHttpHandlerSettings class

Settings for service HTTP handlers.

```csharp
public class ServiceHttpHandlerSettings
```

## Public Members

| name | description |
| --- | --- |
| [ServiceHttpHandlerSettings](ServiceHttpHandlerSettings/ServiceHttpHandlerSettings.md)() | The default constructor. |
| [Aspects](ServiceHttpHandlerSettings/Aspects.md) { get; set; } | The aspects used when receiving requests and sending responses. |
| [BytesSerializer](ServiceHttpHandlerSettings/BytesSerializer.md) { get; set; } | The content serializer used by requests and responses for bytes (optional). |
| [ContentSerializer](ServiceHttpHandlerSettings/ContentSerializer.md) { get; set; } | The content serializer used by requests and responses. |
| [RootPath](ServiceHttpHandlerSettings/RootPath.md) { get; set; } | The root path of the service, default "/". |
| [SkipRequestValidation](ServiceHttpHandlerSettings/SkipRequestValidation.md) { get; set; } | True to prevent the validation of request DTOs after they are received. |
| [SkipResponseValidation](ServiceHttpHandlerSettings/SkipResponseValidation.md) { get; set; } | True to prevent the validation of response DTOs before they are sent. |
| [Synchronous](ServiceHttpHandlerSettings/Synchronous.md) { get; set; } | True to call services synchronously, allowing tasks to be safely blocked. |
| [TextSerializer](ServiceHttpHandlerSettings/TextSerializer.md) { get; set; } | The content serializer used by requests and responses for text (optional). |

## See Also

* namespace [Facility.Core.Http](../Facility.Core.md)
* [ServiceHttpHandlerSettings.cs](https://github.com/FacilityApi/FacilityCSharp/tree/master/src/Facility.Core/Http/ServiceHttpHandlerSettings.cs)

<!-- DO NOT EDIT: generated by xmldocmd for Facility.Core.dll -->
