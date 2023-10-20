using UnrealBuildTool;

public class ARImageT503Target : TargetRules
{
	public ARImageT503Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ARImageT503");
	}
}
