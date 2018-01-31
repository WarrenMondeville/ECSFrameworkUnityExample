//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ElixirLisenterComponent elixirLisenter { get { return (ElixirLisenterComponent)GetComponent(GameComponentsLookup.ElixirLisenter); } }
    public bool hasElixirLisenter { get { return HasComponent(GameComponentsLookup.ElixirLisenter); } }

    public void AddElixirLisenter(IElixirListener newValue) {
        var index = GameComponentsLookup.ElixirLisenter;
        var component = CreateComponent<ElixirLisenterComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceElixirLisenter(IElixirListener newValue) {
        var index = GameComponentsLookup.ElixirLisenter;
        var component = CreateComponent<ElixirLisenterComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveElixirLisenter() {
        RemoveComponent(GameComponentsLookup.ElixirLisenter);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherElixirLisenter;

    public static Entitas.IMatcher<GameEntity> ElixirLisenter {
        get {
            if (_matcherElixirLisenter == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ElixirLisenter);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherElixirLisenter = matcher;
            }

            return _matcherElixirLisenter;
        }
    }
}
