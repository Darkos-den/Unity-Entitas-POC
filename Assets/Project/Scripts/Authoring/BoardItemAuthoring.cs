using Entitas;
using UnityEngine;

public class BoardItemAuthoring : Baker {

    [SerializeField]
    private int _index;

    [SerializeField]
    private BoardItemController _controller;

    public override void Bake(IContext<GameEntity> context) {
        var entity = context.CreateEntity();
        
        entity.AddBoardIndex(_index);
        entity.AddItemState(BoardItemState.Empty);

        _controller.Link(entity);
    }
}