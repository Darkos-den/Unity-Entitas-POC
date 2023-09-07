using Entitas;
using Entitas.CodeGeneration.Attributes;

[Game, Unique, Event(EventTarget.Any)]
public sealed class GameStateComponent : IComponent {

    public GameStage Stage;
}
