
public class EventSystems : Feature {

    public EventSystems(Contexts contexts) {
        Add(new AnyTurnStateEventSystem(contexts));
        Add(new AnyGameStateEventSystem(contexts));
    }
}
