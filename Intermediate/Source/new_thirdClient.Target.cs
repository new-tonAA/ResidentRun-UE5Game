using UnrealBuildTool;

public class new_thirdClientTarget : TargetRules
{
	public new_thirdClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("new_third");
	}
}
