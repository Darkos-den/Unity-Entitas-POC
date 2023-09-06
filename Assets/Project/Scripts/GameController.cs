using UnityEngine;

public class GameController : MonoBehaviour {

    private RootSystems _rootSystems;

    private void Start() {
        var contexts = new Contexts();

        _rootSystems = new RootSystems(contexts.game);

        _rootSystems.Initialize();
    }

    private void Update() {
        _rootSystems.Execute();
    }

}
