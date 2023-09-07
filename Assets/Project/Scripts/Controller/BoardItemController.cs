using Entitas.Unity;
using Entitas;
using UnityEngine;

public class BoardItemController : MonoBehaviour, IItemStateListener, IHighlightedListener
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    #region Unity

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    #endregion

    #region Entitas

    public virtual void Link(IEntity entity) {
        gameObject.Link(entity);
        var e = (GameEntity)entity;
        e.AddItemStateListener(this);
        e.AddHighlightedListener(this);
    }

    public void OnItemState(GameEntity entity, BoardItemState state) {
        var resources = Contexts.sharedInstance.game.boardItemResources;

        var color = Color.white;
        _spriteRenderer.color = color;

        switch (entity.itemState.State) {
            case BoardItemState.Empty: {
                    _spriteRenderer.sprite = resources.Empty;
                    break;
                }
            case BoardItemState.Kretik: {
                    _spriteRenderer.sprite = resources.Krestik;
                    break;
                }
            case BoardItemState.Nolik: {
                    _spriteRenderer.sprite = resources.Nolik;
                    break;
                }
        }
    }

    public void OnHighlighted(GameEntity entity) {
        var resources = Contexts.sharedInstance.game.boardItemResources;
        var turn = Contexts.sharedInstance.game.turnState.State;

        var color = Color.white;
        Sprite sprite;

        if (entity.isHighlighted) {
            color.a = 0.5f;

            if (turn == TurnState.Nolik) {
                sprite = resources.Nolik;
            } else {
                sprite = resources.Krestik;
            }
        } else {
            if (entity.itemState.State == BoardItemState.Empty) {
                sprite = resources.Empty;
            } else {
                sprite = _spriteRenderer.sprite;
            }
        }

        _spriteRenderer.color = color;
        _spriteRenderer.sprite = sprite;
    }

    #endregion
}
