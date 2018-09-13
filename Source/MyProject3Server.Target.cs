using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class MyProject3ServerTarget : TargetRules
{
    public MyProject3ServerTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Server;
        bUsesSteam = true;
        ExtraModuleNames.Add("MyProject3");
    }
   
}