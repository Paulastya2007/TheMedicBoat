using UnrealBuildTool;

public class MedicBoatTarget : TargetRules
{
	public MedicBoatTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MedicBoat");
	}
}
