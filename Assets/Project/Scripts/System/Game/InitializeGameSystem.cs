using Entitas;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class InitializeGameSystem : ReactiveSystem<GameEntity> {

    private GameContext _context;
    private IGroup<GameEntity> _entities;

    public InitializeGameSystem(GameContext context) : base(context) {
        _context = context;
        _entities = context.GetGroup(GameMatcher.BoardIndex);
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return CollectorContextExtension.CreateCollector(
            context, TriggerOnEventMatcherExtension.Added(GameMatcher.GameState)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasGameState;
    }

    protected override void Execute(List<GameEntity> entities) {
        var state = entities.First().gameState.Stage;

        if (state == GameStage.Idle) {
            foreach (var entity in _entities.GetEntities()) {
                entity.ReplaceItemState(BoardItemState.Empty);
            }

            _context.ReplaceGameState(GameStage.Progress);
        }
    }
}
