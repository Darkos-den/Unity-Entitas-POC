using Entitas;
using System.Collections.Generic;
using UnityEngine;

public sealed class ItemRenderSystem : ReactiveSystem<GameEntity> {

    private GameContext _context;

    public ItemRenderSystem(GameContext context) : base(context) {
        _context = context;
    }

    protected override void Execute(List<GameEntity> entities) {
        var resources = _context.boardItemResources;

        foreach (var entity in entities) {
            var color = Color.white;
            entity.view.Value.color = color;

            if (entity.itemState.State == BoardItemState.Nolik) {
                entity.view.Value.sprite = resources.Nolik;
            } else {
                entity.view.Value.sprite = resources.Krestik;
            }
        }
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasItemState && entity.itemState.State != BoardItemState.Empty;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.ItemState);
    }

}
