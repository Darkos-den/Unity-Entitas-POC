using Entitas;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class WinCheckSystem : ReactiveSystem<GameEntity> {

    private GameContext _context;

    public WinCheckSystem(GameContext context) : base(context) {
        _context = context;
    }

    protected override void Execute(List<GameEntity> entities) {
        var turn = _context.turnState;

        var buffer = entities.First();

        bool isWin;
        if (turn.State == TurnState.Nolik) {
            isWin = CheckWinState(buffer.selectedBuffer.Noliki);
        } else {
            isWin = CheckWinState(buffer.selectedBuffer.Krestiki);
        }

        //todo
    }

    private bool CheckWinState(List<int> items) {
        var horizontales = items.Contains(0) && items.Contains(1) && items.Contains(2) ||
            items.Contains(3) && items.Contains(4) && items.Contains(5) ||
            items.Contains(6) && items.Contains(7) && items.Contains(8);
        var verticales = items.Contains(0) && items.Contains(3) && items.Contains(6) ||
            items.Contains(1) && items.Contains(4) && items.Contains(7) ||
            items.Contains(2) && items.Contains(5) && items.Contains(8);
        var diagonales = items.Contains(0) && items.Contains(4) && items.Contains(8) ||
            items.Contains(2) && items.Contains(4) && items.Contains(6);

        return horizontales || verticales || diagonales;
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasSelectedBuffer;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.SelectedBuffer);
    }
}
