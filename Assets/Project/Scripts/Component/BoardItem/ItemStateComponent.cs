using Entitas;

public enum BoardItemState {
    Empty, Kretik, Nolik
}

public sealed class ItemStateComponent : IComponent {
    public BoardItemState State;
}
