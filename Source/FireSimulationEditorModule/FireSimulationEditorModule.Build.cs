using UnrealBuildTool;

public class FireSimulationEditorModule : ModuleRules
{
    public FireSimulationEditorModule(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "FireSimulation"
            }
            );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "Slate",
                "SlateCore",
                "UnrealEd",
                "InputCore",
                "AssetTools",
                "ContentBrowser",
                "PropertyEditor"
            }
            );
    }
}
