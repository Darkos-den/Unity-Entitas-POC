using Entitas;
using Entitas.Unity;
using UnityEngine;

public sealed class HighlightInputSystem : IExecuteSystem {

    private IGroup<GameEntity> _entities;

    private Camera _camera;

    public HighlightInputSystem(IContext<GameEntity> context) {
        
        _entities = context.GetGroup(GameMatcher.BoardIndex);
        _camera = Camera.main;
    }

    public void Execute() {
        RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        GameEntity lastHighlight = null;
        GameEntity newHighlight = null;

        foreach (var entity in _entities.GetEntities()) {
            if (entity.itemState.State == BoardItemState.Empty) {
                if(entity.isHighlighted) {
                    lastHighlight = entity;
                }

                if (hit.collider != null && hit.collider.gameObject.GetEntityLink() != null) {
                    var id = hit.collider.gameObject.GetEntityLink().entity.creationIndex;

                    if (entity.creationIndex == id) {
                        newHighlight = entity;
                    }
                }
            }
        }

        if (lastHighlight?.creationIndex != newHighlight?.creationIndex) {
            if (newHighlight != null) {
                newHighlight.isHighlighted = true;
            }
            if (lastHighlight != null) {
                lastHighlight.isHighlighted = false;
            }
        }
    }

}
