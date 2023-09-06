using Entitas;
using Entitas.CodeGeneration.Attributes;

public enum BoardItemState {
    Empty, Kretik, Nolik
}

[Game, Event(EventTarget.Self)]
public sealed class ItemStateComponent : IComponent {
    public BoardItemState State;
}
