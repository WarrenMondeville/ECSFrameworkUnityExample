using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSystems : Feature
{
    public AllSystems(Contexts ctxs) : base("All Systems")
    {
        Add(new EmitInputSystem(ctxs));
        Add(new CreateMoverSystem(ctxs));
        Add(new CommandMoveSystem(ctxs));
        Add(new MiddleMouseKeyChangeSpriteSystem(ctxs));

        Add(new AddViewSystem(ctxs));
        Add(new RenderSpriteSystem(ctxs));
        Add(new RenderPositionSystem(ctxs));
        Add(new RenderDirectionSystem(ctxs));

        Add(new MoveSystem(ctxs));
    }
}
