using Entitas;
using UnityEngine;

public sealed class ItemSelectionInputSystem : IExecuteSystem {

    private IGroup<GameEntity> _entities;
    private GameContext _context;

    public ItemSelectionInputSystem(GameContext context) {
        _entities = context.GetGroup(GameMatcher.Highlighted);
        _context = context;
    }

    public void Execute() {
        if (Input.GetMouseButtonDown(0)) {

            foreach (var entity in _entities.GetEntities()) {
                if(entity.itemState.State == BoardItemState.Empty) {
                    var buffer = _context.selectedBuffer;
                    var turn = _context.turnState;

                    if (turn.State == TurnState.Krestik) {
                        buffer.Krestiki.Add(entity.boardIndex.Value);
                        entity.ReplaceItemState(BoardItemState.Kretik);
                    } else {
                        buffer.Noliki.Add(entity.boardIndex.Value);
                        entity.ReplaceItemState(BoardItemState.Nolik);
                    }
                    entity.isHighlighted = false;

                    TurnState newState;
                    if (turn.State == TurnState.Krestik) {
                        newState = TurnState.Nolik;
                    } else {
                        newState = TurnState.Krestik;
                    }
                    _context.turnStateEntity.ReplaceTurnState(newState);
                }
            }
        }
    }

}
