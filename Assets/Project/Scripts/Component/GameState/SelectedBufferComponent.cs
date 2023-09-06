using Entitas;
using Entitas.CodeGeneration.Attributes;
using System.Collections.Generic;

[Game, Unique]
public sealed class SelectedBufferComponent : IComponent {

    public List<int> Krestiki = new();
    public List<int> Noliki = new();

}
