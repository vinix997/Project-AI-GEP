using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class VolumeSlider : MonoBehaviour {

public AudioMixer bgm;
    public float save;
    public Slider vol;

    public void Start()
    {
        if(vol==null)
        {
        vol = GameObject.Find("Slider").GetComponent<Slider>();
        }
       save = PlayerPrefs.GetFloat("saved");
       vol.value = save;
       
    }
    void Update()
    {
        save = PlayerPrefs.GetFloat("saved",save);
        vol.value=save;
    }
	public void SetVolume(float volume)
    {
        bgm.SetFloat("volume", volume);
        save = volume;
        PlayerPrefs.SetFloat("saved",save);
        PlayerPrefs.Save();
        
    }
}
