using Entitas;
using Entitas.Unity;
using UnityEngine;

public class BoardItemAuthoring : Baker {

    public override void Bake(IContext<GameEntity> context) {
        var entity = context.CreateEntity();
        entity.AddHealth(100);
        entity.AddView(gameObject);
        gameObject.Link(entity);
    }
}