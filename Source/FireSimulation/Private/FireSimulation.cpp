#include "FireSimulation.h"
#include <MaterialDataManager.h>

#define LOCTEXT_NAMESPACE "FFireSimulationModule"

void FFireSimulationModule::StartupModule()
{
    FMaterialDataManager::Get().LoadMaterialData();
}

void FFireSimulationModule::ShutdownModule()
{
}

#undef LOCTEXT_NAMESPACE

IMPLEMENT_MODULE(FFireSimulationModule, FireSimulation)
