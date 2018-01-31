using Entitas;
using UnityEngine;
using UnityEngine.UI;

public class TimePickerBehaviour : MonoBehaviour, IPauseListener
{
    private GameContext _context;
    private Slider _slider;

    private void Awake()
    {
        _context = Contexts.sharedInstance.game;
        _context.CreateEntity().AddPauseListener(this);
    }
    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(ChangedValue);
    }
    private void OnDestroy()
    {
        _slider.onValueChanged.RemoveListener(ChangedValue);

    }

    public void PauseStateChanged(bool isPause)
    {
        _slider.enabled = isPause;
        
        _slider.maxValue = _context.tick.currentTick;
        _slider.value = _context.tick.currentTick;
        
    }

    public void ChangedValue(float value)
    {
        //Debug.Log(value);
        //float value = _slider.value;
        _context.ReplaceJumpInTime((long)value);
    }

}

