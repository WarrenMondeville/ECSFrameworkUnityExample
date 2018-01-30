// DebugMessageComponent.cs  
// Entitas的命名空间，其他的可以删掉了，不会用到的  
using Entitas;

// Game标签，说明这个Component是GameContext下的，框架中暂时就两种标签：Game、Input  
// 标签是必须的，不然没法通过Context找到该Component  
[Game]

// 继承于IComponent，说明该类是一个Component  
public class DebugMessageComponent : IComponent
{
    // 属性数据  
    public string message;
}