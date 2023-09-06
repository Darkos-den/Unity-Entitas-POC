using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

[Game, Unique]
public sealed class BoardItemResourcesComponent : IComponent {

    public Sprite Empty;
    public Sprite Krestik;
    public Sprite Nolik;
}
