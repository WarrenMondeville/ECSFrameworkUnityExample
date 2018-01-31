using Entitas;
using UnityEngine;
using UnityEngine.UI;

public class PauseButtonBehaviour : MonoBehaviour, IPauseListener
{
    GameContext _context;
    Text _text;
    Button _btn;
    private void Awake()
    {
        _context = Contexts.sharedInstance.game;
        _context.CreateEntity().AddPauseListener(this);
    }

    private void Start()
    {
        _text = GetComponentInChildren<Text>();
        _btn = GetComponent<Button>();
        _btn.onClick.AddListener(PressButton);
    }

    private void OnDestroy()
    {
        _btn.onClick.RemoveListener(PressButton);
    }
    public void PauseStateChanged(bool isPause)
    {
        _text.text = isPause ? "Resume" : "Pause";
    }

    public void PressButton()
    {
        _context.isPause = !_context.isPause;
    }
}

