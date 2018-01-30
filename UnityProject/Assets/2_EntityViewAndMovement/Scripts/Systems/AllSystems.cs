using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSystems : Feature
{
    public AllSystems(Contexts ctxs) : base("All Systems")
    {
        Add(new EmitInputSystem(ctxs));
        Add(new CreateMoverReactiveSystem(ctxs));
        Add(new CommandMoveReactiveSystem(ctxs));
        Add(new MiddleMouseKeyChangeSpriteSystem(ctxs));

        Add(new AddViewReactiveSystem(ctxs));
        Add(new RenderSpriteReactiveSystem(ctxs));
        Add(new RenderPositionReactiveSystem(ctxs));
        Add(new RenderDirectionReactiveSystem(ctxs));

        Add(new MoveSystem(ctxs));
    }
}
