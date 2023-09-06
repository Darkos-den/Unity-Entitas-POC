using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class HighlightCleanSystem : ReactiveSystem<GameEntity> {

    private GameContext _context;

    public HighlightCleanSystem(GameContext context) : base(context) {
        _context = context;
    }

    protected override void Execute(List<GameEntity> entities) {
        var resources = _context.boardItemResources;

        foreach (var entity in entities) {
            var color = Color.white;

            entity.view.Value.color = color;
            entity.view.Value.sprite = resources.Empty;
        }
    }

    protected override bool Filter(GameEntity entity) {
        return entity.itemState.State == BoardItemState.Empty;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.Highlighted.Removed());
    }

}
