using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique, Event(EventTarget.Any)]
public sealed class TurnStateComponent : IComponent {

    public TurnState State;
}
