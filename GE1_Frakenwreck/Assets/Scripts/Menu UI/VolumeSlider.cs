using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{

    [SerializeField] private Slider volumeSlider;

    private void OnEnable()
    {
        LoadVolume();
    }

    //Save
    public void SetVolume(float newVolume)
    {
        PlayerPrefs.SetFloat("Volume", newVolume);        
    }

    //Load
    public void LoadVolume()
    {
        float volume = PlayerPrefs.GetFloat("Volume", 1f);
        volumeSlider.value = volume;
    }
}
