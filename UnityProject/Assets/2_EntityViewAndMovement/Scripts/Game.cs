using UnityEngine;
using Entitas;

public class Game : MonoBehaviour
{
    Systems _systems;

	// Use this for initialization
	void Start ()
    {
        var ctxs = Contexts.sharedInstance;
        _systems = new Feature("System")
            .Add(new AllSystems(ctxs));
        _systems.Initialize();
	}
	
	// Update is called once per frame
	void Update ()
    {
        _systems.Execute();
        _systems.Cleanup();
	}
}
