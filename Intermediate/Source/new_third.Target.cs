using UnrealBuildTool;

public class new_thirdTarget : TargetRules
{
	public new_thirdTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("new_third");
	}
}
