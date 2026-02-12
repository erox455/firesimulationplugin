# FireSimulationPlugin (Unreal Engine 5.7)

This plugin simulates fire and smoke propagation in Unreal Engine scenes and was upgraded for **UE 5.7**.

## Production improvements included

- Runtime module is now editor-safe for packaged games (editor-only UI/customization logic moved to the editor module).
- Runtime settings are now read from `GGameIni` instead of editor-only config, making builds and real gameplay scenarios work reliably.
- Removed exception-based runtime flow in fire actor creation and replaced with explicit validation.
- Plugin metadata updated for UE 5.7.

## How to Use

1. Place `FireManagerActor` in your scene.
2. Create and size a `GridActor` to define the simulation bounds.
3. Place `ExponentialHeightFog` in the level to visualize smoke.
4. Add `FireSimulationComponent` to actors participating in simulation:
   - `Mass`
   - `IsWall`
   - `IsBurning` (recommended single initial source)
   - `SelectedMaterial` (from `Content/Data/materials.json`)
5. Add `RoomMarker` actors to define rooms.
6. Add `DoorComponent` to doors and configure connected rooms/direction.
7. Open the **Fire Simulation** editor tab, configure simulation values, and confirm.

## Notes for shipping games

- Configure plugin values once in editor and commit/cook project configs so `GGameIni` values are available at runtime.
- Keep grid cell sizes reasonable to avoid extreme actor/component counts.
- Prefer Niagara or optimized FX assets for large scenes (plugin currently uses particle system assets selected from content browser).
