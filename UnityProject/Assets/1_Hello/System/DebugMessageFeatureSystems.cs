// TutorialSystems.cs  
public class DebugMessageFeatureSystems : Feature
{
    // 添加所有要用到的System，base里面是调试节点的名字  
    public DebugMessageFeatureSystems(Contexts contexts) : base("Tutorial Systems")
    {
        Add(new DebugMessageInitializeSystem(contexts));
        Add(new DebugMessageExecuteSystem(contexts));
        Add(new DebugMessageReactiveSystem(contexts));
        Add(new DebugMessageCleanupSystem(contexts));
   
    }
}