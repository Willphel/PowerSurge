using UnrealBuildTool;

public class PowerSurgeTarget : TargetRules
{
	public PowerSurgeTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PowerSurge");
	}
}
