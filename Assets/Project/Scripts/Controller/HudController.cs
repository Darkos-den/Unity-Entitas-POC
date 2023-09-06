using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour, IAnyTurnStateListener, IAnyGameStateListener {

    [SerializeField] private Image _spriteRenderer;
    [SerializeField] private GameObject _winHud;
    [SerializeField] private TextMeshProUGUI _statusText;

    void Start() {
        Contexts.sharedInstance.game.CreateEntity().AddAnyTurnStateListener(this);
        Contexts.sharedInstance.game.CreateEntity().AddAnyGameStateListener(this);
    }

    public void OnAnyTurnState(GameEntity entity, TurnState state) {
        var res = Contexts.sharedInstance.game.boardItemResources;

        if (state == TurnState.Nolik) {
            _spriteRenderer.sprite = res.Nolik;
        } else {
            _spriteRenderer.sprite = res.Krestik;
        }
    }

    public void OnAnyGameState(GameEntity entity, GameStage stage) {
        switch (stage) {
            case GameStage.Idle: {
                    _winHud.SetActive(false);
                    break;
                }

            case GameStage.Progress:
                break;
            case GameStage.Win: {
                    _winHud.SetActive(true);
                    _statusText.text = "You WIN";
                    break;
                }
            case GameStage.Draw: {
                    _winHud.SetActive(true);
                    _statusText.text = "DRAW";
                    break;
                }
        }
    }

    public void OnRestartClick() {
        _winHud.SetActive(false);
        Contexts.sharedInstance.game.ReplaceGameState(GameStage.Idle);
    }
}
