using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField]
    private GameSetup _gameSetup;

    private RootSystems _rootSystems;

    private void Start() {
        var contexts = new Contexts();

        _rootSystems = new RootSystems(contexts.game);

        _rootSystems.Initialize();

        var entity = contexts.game.CreateEntity();
        entity.AddHealth(100);
        entity.AddGameSetup(_gameSetup);
    }

    private void Update() {
        _rootSystems.Execute();
    }

}
