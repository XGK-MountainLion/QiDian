// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class QiDian : ModuleRules
{
	public QiDian(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
