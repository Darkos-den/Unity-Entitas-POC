using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class HighlightRenderSystem : ReactiveSystem<GameEntity> {

    private GameContext _context;

    public HighlightRenderSystem(GameContext context) : base(context) {
        _context = context;
    }

    protected override void Execute(List<GameEntity> entities) {
        var turn = _context.turnState;
        var resources = _context.boardItemResources;

        foreach (var entity in entities) {
            var color = Color.white;
            color.a = 0.5f;
            entity.view.Value.color = color;

            if (turn.State == TurnState.Nolik) {
                entity.view.Value.sprite = resources.Nolik;
            } else {
                entity.view.Value.sprite = resources.Krestik;
            }
        }
    }

    protected override bool Filter(GameEntity entity) {
        return entity.isHighlighted;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.Highlighted.Added());
    }

}
