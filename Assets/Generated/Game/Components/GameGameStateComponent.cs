//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity gameStateEntity { get { return GetGroup(GameMatcher.GameState).GetSingleEntity(); } }
    public GameStateComponent gameState { get { return gameStateEntity.gameState; } }
    public bool hasGameState { get { return gameStateEntity != null; } }

    public GameEntity SetGameState(GameStage newStage) {
        if (hasGameState) {
            throw new Entitas.EntitasException("Could not set GameState!\n" + this + " already has an entity with GameStateComponent!",
                "You should check if the context already has a gameStateEntity before setting it or use context.ReplaceGameState().");
        }
        var entity = CreateEntity();
        entity.AddGameState(newStage);
        return entity;
    }

    public void ReplaceGameState(GameStage newStage) {
        var entity = gameStateEntity;
        if (entity == null) {
            entity = SetGameState(newStage);
        } else {
            entity.ReplaceGameState(newStage);
        }
    }

    public void RemoveGameState() {
        gameStateEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public GameStateComponent gameState { get { return (GameStateComponent)GetComponent(GameComponentsLookup.GameState); } }
    public bool hasGameState { get { return HasComponent(GameComponentsLookup.GameState); } }

    public void AddGameState(GameStage newStage) {
        var index = GameComponentsLookup.GameState;
        var component = (GameStateComponent)CreateComponent(index, typeof(GameStateComponent));
        component.Stage = newStage;
        AddComponent(index, component);
    }

    public void ReplaceGameState(GameStage newStage) {
        var index = GameComponentsLookup.GameState;
        var component = (GameStateComponent)CreateComponent(index, typeof(GameStateComponent));
        component.Stage = newStage;
        ReplaceComponent(index, component);
    }

    public void RemoveGameState() {
        RemoveComponent(GameComponentsLookup.GameState);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherGameState;

    public static Entitas.IMatcher<GameEntity> GameState {
        get {
            if (_matcherGameState == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameState);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameState = matcher;
            }

            return _matcherGameState;
        }
    }
}
