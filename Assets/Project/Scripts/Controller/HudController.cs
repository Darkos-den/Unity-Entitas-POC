using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour, IAnyTurnStateListener {

    [SerializeField] private Image _spriteRenderer;

    void Start() {
        Contexts.sharedInstance.game.CreateEntity().AddAnyTurnStateListener(this);
    }

    public void OnAnyTurnState(GameEntity entity, TurnState state) {
        var res = Contexts.sharedInstance.game.boardItemResources;

        if (state == TurnState.Nolik) {
            _spriteRenderer.sprite = res.Nolik;
        } else {
            _spriteRenderer.sprite = res.Krestik;
        }
    }
}
