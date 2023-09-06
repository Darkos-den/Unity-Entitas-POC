using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class HealthLogSystem : ReactiveSystem<GameEntity> {
    public HealthLogSystem(IContext<GameEntity> context) : base(context) {
    }

    protected override void Execute(List<GameEntity> entities) {
        foreach (var entity in entities) {
            var health = entity.health.Value;
            Debug.Log(">> health: " + health);
        }
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasHealth;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context) {
        return context.CreateCollector(GameMatcher.Health);
    }
}

/*
 public sealed class HealthLogSystem : IExecuteSystem {

    readonly IGroup<GameEntity> _entities;

    public HealthLogSystem(Contexts contexts) {
        _entities = contexts.game.GetGroup(GameMatcher.Health);
    }

    public void Execute() {
        foreach (var entity in _entities) {
            var health = entity.health.Value;
            Debug.Log(">> health: " + health);
        }
    }
}
 */
