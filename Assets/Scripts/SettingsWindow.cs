using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsWindow : MonoBehaviour
{
    [SerializeField] private Scrollbar _scrollbarMusic;
    [SerializeField] private Scrollbar _scrollbarEffect;
    private void Awake()
    {
        _scrollbarMusic.value = Controller.Instance.MusicSource.volume;
        _scrollbarEffect.value = Controller.Instance.EffectSource.volume;
    }

    public void ChangeValueMusic(float value)
    {
        Controller.Instance.MusicSource.volume = value;
    }
    public void ChangeValueEffect(float value)
    {
        Controller.Instance.EffectSource.volume = value;
    }
}
