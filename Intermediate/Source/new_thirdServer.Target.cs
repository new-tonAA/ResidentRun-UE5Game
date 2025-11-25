using UnrealBuildTool;

public class new_thirdServerTarget : TargetRules
{
	public new_thirdServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("new_third");
	}
}
