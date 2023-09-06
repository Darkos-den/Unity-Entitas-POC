using Entitas;
using Entitas.CodeGeneration.Attributes;

public enum GameStage {
    Idle, Progress, Win, Draw
}

[Game, Unique, Event(EventTarget.Any)]
public sealed class GameStateComponent : IComponent {

    public GameStage Stage;
}
