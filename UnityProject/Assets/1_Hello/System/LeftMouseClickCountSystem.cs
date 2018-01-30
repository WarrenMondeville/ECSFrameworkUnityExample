using Entitas;
using UnityEngine;

public class LeftMouseClickCountSystem : IExecuteSystem
{
    private GameContext gameCtx;
    private int count = 0;
    private GameEntity entity;

    public string CountMsg
    {
        get { return string.Format("左键被按了{0}次", count); }
    }

    public LeftMouseClickCountSystem(Contexts ctxs)
    {
        gameCtx = ctxs.game;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            count++;
            // 如果没有打印信息的Entity，则创建一个  
            if (entity == null)
            {
                entity = gameCtx.CreateEntity();
                entity.AddDebugMessage(CountMsg);
                return;
            }
            entity.ReplaceDebugMessage(CountMsg);
            //entity.debugMessage.message = CountMsg;
        }
    }
}