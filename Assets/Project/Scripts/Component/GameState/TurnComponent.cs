using Entitas;
using Entitas.CodeGeneration.Attributes;

public enum TurnState {
    Krestik, Nolik
}

[Game, Unique, Event(EventTarget.Any)]
public sealed class TurnStateComponent : IComponent {

    public TurnState State;
}
