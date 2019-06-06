// Some copyright should be here...

using UnrealBuildTool;
using System.IO;

public class VictoryBPLibrary : ModuleRules
{
	public VictoryBPLibrary(ReadOnlyTargetRules Target) : base(Target)
	{ 
		PrivatePCHHeaderFile = "Private/VictoryBPLibraryPrivatePCH.h";

		//4.15 Include What You Use
		bEnforceIWYU = false;
		
		PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));
		
		PrivateIncludePaths.Add(Path.Combine(ModuleDirectory, "Private"));			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core"
			}
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject", 
				"Engine", 
				"InputCore",
				
				"RHI",
				"RenderCore",
				 
				"HTTP",
				"UMG", "Slate", "SlateCore",
				
				"ImageWrapper",
				
				"PhysX", 
				
				"HeadMountedDisplay",
  
                "AIModule",
				
				"NavigationSystem",
				
				"Vorbis",
				
				"ApplicationCore"
			}
		);
		
		//APEX EXCLUSIONS
		if (Target.Platform != UnrealTargetPlatform.Android && Target.Platform != UnrealTargetPlatform.HTML5 && Target.Platform != UnrealTargetPlatform.IOS)
		{
			PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"APEX"
			}
			);
			
			PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"ApexDestruction"
			}
			);
		
		}
	}
}
