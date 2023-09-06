using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SpawnPlayerSystem : IInitializeSystem {

    private IContext<GameEntity> _context;

    public SpawnPlayerSystem(IContext<GameEntity> context) {
        _context = context;
    }

    public void Initialize() {
        var entity = _context.CreateEntity();
        entity.AddHealth(100);
    }
}
