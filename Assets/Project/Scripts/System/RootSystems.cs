using Entitas;

public class RootSystems : Feature {
    
    public RootSystems(IContext<GameEntity> context) {
        Add(new HealthLogSystem(context));
        Add(new SpawnPlayerSystem(context));
    }
}
