using Entitas;
using Entitas.Unity;
using UnityEngine;

public class BoardItemAuthoring : Baker {

    [SerializeField]
    private int _index;

    public override void Bake(IContext<GameEntity> context) {
        var entity = context.CreateEntity();
        entity.AddView(gameObject.GetComponent<SpriteRenderer>());
        gameObject.Link(entity);
        entity.AddBoardIndex(_index);
        entity.AddItemState(BoardItemState.Empty);
    }
}