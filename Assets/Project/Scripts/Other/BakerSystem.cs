using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class BakerSystem : Baker
{
    public Baker[] bakers;

    public override void Bake(IContext<GameEntity> context) {
        foreach (var item in bakers) {
            item.Bake(context);
        }
    }
}
