//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyTurnChangedListenerComponent anyTurnChangedListener { get { return (AnyTurnChangedListenerComponent)GetComponent(GameComponentsLookup.AnyTurnChangedListener); } }
    public bool hasAnyTurnChangedListener { get { return HasComponent(GameComponentsLookup.AnyTurnChangedListener); } }

    public void AddAnyTurnChangedListener(System.Collections.Generic.List<IAnyTurnChangedListener> newValue) {
        var index = GameComponentsLookup.AnyTurnChangedListener;
        var component = (AnyTurnChangedListenerComponent)CreateComponent(index, typeof(AnyTurnChangedListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyTurnChangedListener(System.Collections.Generic.List<IAnyTurnChangedListener> newValue) {
        var index = GameComponentsLookup.AnyTurnChangedListener;
        var component = (AnyTurnChangedListenerComponent)CreateComponent(index, typeof(AnyTurnChangedListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyTurnChangedListener() {
        RemoveComponent(GameComponentsLookup.AnyTurnChangedListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAnyTurnChangedListener;

    public static Entitas.IMatcher<GameEntity> AnyTurnChangedListener {
        get {
            if (_matcherAnyTurnChangedListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyTurnChangedListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyTurnChangedListener = matcher;
            }

            return _matcherAnyTurnChangedListener;
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

    public void AddAnyTurnChangedListener(IAnyTurnChangedListener value) {
        var listeners = hasAnyTurnChangedListener
            ? anyTurnChangedListener.value
            : new System.Collections.Generic.List<IAnyTurnChangedListener>();
        listeners.Add(value);
        ReplaceAnyTurnChangedListener(listeners);
    }

    public void RemoveAnyTurnChangedListener(IAnyTurnChangedListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyTurnChangedListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyTurnChangedListener();
        } else {
            ReplaceAnyTurnChangedListener(listeners);
        }
    }
}