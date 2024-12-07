using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Option : MonoBehaviour
{
    [SerializeField] private GameObject option;

    [SerializeField] private Slider bgmSlider;
    [SerializeField] private Slider sfxSlider;

    [SerializeField] private bool isOption;

    private void Awake()
    {
        bgmSlider.onValueChanged.AddListener(ChangeBgmSound);
        sfxSlider.onValueChanged.AddListener(ChangeSfxSound);
    }

    public void OnOffOption()
    {
        isOption = !isOption;
        option.SetActive(isOption);
        Time.timeScale = isOption ? 0 : 1;
    }

    private void ChangeBgmSound(float value)
    {
        //SoundManager.instance.bgmVolume = value;
    }
    private void ChangeSfxSound(float value)
    {
        //SoundManager.instance.sfxVolume = value;
    }
}
