using Microsoft.Extensions.Logging;
using MirrorSharp.Advanced;
using SharpLab.Container.Manager.Internal;
using SourceMock;

[assembly: GenerateMocksForTypes(
    typeof(IWorkSession),
    typeof(IRoslynSession),
    typeof(IDateTimeProvider),
    typeof(ILogger<>)
)]