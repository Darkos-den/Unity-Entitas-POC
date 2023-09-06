using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    [SerializeField] private Baker _baker;

    [SerializeField] private Sprite _empty;
    [SerializeField] private Sprite _krestik;
    [SerializeField] private Sprite _nolik;

    private RootSystems _rootSystems;
    private EventSystems _eventSystems;

    private void Start() {
        var contexts = Contexts.sharedInstance;

        _rootSystems = new RootSystems(contexts.game);
        _eventSystems = new EventSystems(contexts);

        InitGameState(contexts.game);
        InitBoardItemResources(contexts.game);

        _rootSystems.Initialize();
        _eventSystems.Initialize();
        

        _baker.Bake(contexts.game);
    }

    private void Update() {
        _rootSystems.Execute();
        _eventSystems.Execute();
    }

    private void InitGameState(GameContext context) {
        var entity = context.CreateEntity();

        entity.AddTurnState(TurnState.Krestik);
        entity.AddSelectedBuffer(new List<int>(), new List<int>());
        entity.AddGameState(GameStage.Idle);
    }

    private void InitBoardItemResources(GameContext context) {
        var entity = context.CreateEntity();

        entity.AddBoardItemResources(_empty, _krestik, _nolik);
    }

}
