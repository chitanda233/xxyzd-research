// IL2CPP structure dump. Method bodies are placeholders, NOT recovered source.

// Namespace: 
internal class <Module> // TypeDefIndex: 28997
{}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Diagnostics : IDiagnostics // TypeDefIndex: 28998
{
	// Fields
	[CompilerGenerated]
	private readonly IDictionary<string, string> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x863B944 Offset: 0x8637944 VA: 0x863B944 Slot: 4
	public void SendDiagnostic(string name, string message, IDictionary<string, string> tags) { }

	// RVA: 0x863B948 Offset: 0x8637948 VA: 0x863B948
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class DiagnosticsFactory : IDiagnosticsFactory, IServiceComponent // TypeDefIndex: 28999
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, string> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x863B9D0 Offset: 0x86379D0 VA: 0x863B9D0 Slot: 4
	public IDiagnostics Create(string packageName) { }

	// RVA: 0x863BA20 Offset: 0x8637A20 VA: 0x863BA20
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class Metrics : IMetrics // TypeDefIndex: 29000
{
	// Fields
	[CompilerGenerated]
	private readonly IDictionary<string, string> <PackageTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x863BAA8 Offset: 0x8637AA8 VA: 0x863BAA8 Slot: 4
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendGaugeMetric(string name, double value, IDictionary<string, string> tags) { }

	// RVA: 0x863BAAC Offset: 0x8637AAC VA: 0x863BAAC Slot: 5
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendHistogramMetric(string name, double time, IDictionary<string, string> tags) { }

	// RVA: 0x863BAB0 Offset: 0x8637AB0 VA: 0x863BAB0 Slot: 6
	private void Unity.Services.Core.Telemetry.Internal.IMetrics.SendSumMetric(string name, double value, IDictionary<string, string> tags) { }

	// RVA: 0x863BAB4 Offset: 0x8637AB4 VA: 0x863BAB4
	public void .ctor() { }
}

// Namespace: Unity.Services.Core.Telemetry.Internal
internal class MetricsFactory : IMetricsFactory, IServiceComponent // TypeDefIndex: 29001
{
	// Fields
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<string, string> <CommonTags>k__BackingField; // 0x10

	// Methods

	// RVA: 0x863BB3C Offset: 0x8637B3C VA: 0x863BB3C Slot: 4
	public IMetrics Create(string packageName) { }

	// RVA: 0x863BB8C Offset: 0x8637B8C VA: 0x863BB8C
	public void .ctor() { }
}

