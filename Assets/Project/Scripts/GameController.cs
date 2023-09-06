using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField]
    private GameSetup _gameSetup;

    [SerializeField]
    private Baker _baker;

    private RootSystems _rootSystems;

    private void Start() {
        var contexts = new Contexts();

        _rootSystems = new RootSystems(contexts.game);

        _rootSystems.Initialize();

        _baker.Bake(contexts.game);
    }

    private void Update() {
        _rootSystems.Execute();
    }

}
