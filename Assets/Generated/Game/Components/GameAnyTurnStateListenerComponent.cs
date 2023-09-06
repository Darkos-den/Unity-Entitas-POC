//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AnyTurnStateListenerComponent anyTurnStateListener { get { return (AnyTurnStateListenerComponent)GetComponent(GameComponentsLookup.AnyTurnStateListener); } }
    public bool hasAnyTurnStateListener { get { return HasComponent(GameComponentsLookup.AnyTurnStateListener); } }

    public void AddAnyTurnStateListener(System.Collections.Generic.List<IAnyTurnStateListener> newValue) {
        var index = GameComponentsLookup.AnyTurnStateListener;
        var component = (AnyTurnStateListenerComponent)CreateComponent(index, typeof(AnyTurnStateListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAnyTurnStateListener(System.Collections.Generic.List<IAnyTurnStateListener> newValue) {
        var index = GameComponentsLookup.AnyTurnStateListener;
        var component = (AnyTurnStateListenerComponent)CreateComponent(index, typeof(AnyTurnStateListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAnyTurnStateListener() {
        RemoveComponent(GameComponentsLookup.AnyTurnStateListener);
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

    static Entitas.IMatcher<GameEntity> _matcherAnyTurnStateListener;

    public static Entitas.IMatcher<GameEntity> AnyTurnStateListener {
        get {
            if (_matcherAnyTurnStateListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AnyTurnStateListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnyTurnStateListener = matcher;
            }

            return _matcherAnyTurnStateListener;
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

    public void AddAnyTurnStateListener(IAnyTurnStateListener value) {
        var listeners = hasAnyTurnStateListener
            ? anyTurnStateListener.value
            : new System.Collections.Generic.List<IAnyTurnStateListener>();
        listeners.Add(value);
        ReplaceAnyTurnStateListener(listeners);
    }

    public void RemoveAnyTurnStateListener(IAnyTurnStateListener value, bool removeComponentWhenEmpty = true) {
        var listeners = anyTurnStateListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveAnyTurnStateListener();
        } else {
            ReplaceAnyTurnStateListener(listeners);
        }
    }
}
