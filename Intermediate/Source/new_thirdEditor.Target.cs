using UnrealBuildTool;

public class new_thirdEditorTarget : TargetRules
{
	public new_thirdEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("new_third");
	}
}
