using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Baker: MonoBehaviour {
    public abstract void Bake(IContext<GameEntity> context);
}
