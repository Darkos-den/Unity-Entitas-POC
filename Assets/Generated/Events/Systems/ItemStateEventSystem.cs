//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class ItemStateEventSystem : Entitas.ReactiveSystem<GameEntity> {

    readonly System.Collections.Generic.List<IItemStateListener> _listenerBuffer;

    public ItemStateEventSystem(Contexts contexts) : base(contexts.game) {
        _listenerBuffer = new System.Collections.Generic.List<IItemStateListener>();
    }

    protected override Entitas.ICollector<GameEntity> GetTrigger(Entitas.IContext<GameEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GameMatcher.ItemState)
        );
    }

    protected override bool Filter(GameEntity entity) {
        return entity.hasItemState && entity.hasItemStateListener;
    }

    protected override void Execute(System.Collections.Generic.List<GameEntity> entities) {
        foreach (var e in entities) {
            var component = e.itemState;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.itemStateListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnItemState(e, component.State);
            }
        }
    }
}
