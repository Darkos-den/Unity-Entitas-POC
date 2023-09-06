//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ItemStateListenerComponent itemStateListener { get { return (ItemStateListenerComponent)GetComponent(GameComponentsLookup.ItemStateListener); } }
    public bool hasItemStateListener { get { return HasComponent(GameComponentsLookup.ItemStateListener); } }

    public void AddItemStateListener(System.Collections.Generic.List<IItemStateListener> newValue) {
        var index = GameComponentsLookup.ItemStateListener;
        var component = (ItemStateListenerComponent)CreateComponent(index, typeof(ItemStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceItemStateListener(System.Collections.Generic.List<IItemStateListener> newValue) {
        var index = GameComponentsLookup.ItemStateListener;
        var component = (ItemStateListenerComponent)CreateComponent(index, typeof(ItemStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveItemStateListener() {
        RemoveComponent(GameComponentsLookup.ItemStateListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherItemStateListener;

    public static Entitas.IMatcher<GameEntity> ItemStateListener {
        get {
            if (_matcherItemStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ItemStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherItemStateListener = matcher;
            }

            return _matcherItemStateListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public void AddItemStateListener(IItemStateListener value) {
        var listeners = hasItemStateListener
            ? itemStateListener.value
            : new System.Collections.Generic.List<IItemStateListener>();
        listeners.Add(value);
        ReplaceItemStateListener(listeners);
    }

    public void RemoveItemStateListener(IItemStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = itemStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveItemStateListener();
        } else {
            ReplaceItemStateListener(listeners);
        }
    }
}
