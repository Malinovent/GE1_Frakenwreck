using System.Collections.Generic;
using UnityEngine;

public class UISoundsManager : MonoBehaviour
{

    [SerializeField] private List<AudioSource> audioSources = new List<AudioSource>();

    #region SINGLETON
    public static UISoundsManager Singleton;

    private void Awake()
    {
        if(Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    #endregion

    public void PlaySound(AudioClip clip)
    {
        foreach(AudioSource source in audioSources)
        {
            if(source.isPlaying == false)
            {
                source.clip = clip;
                source.Play();
                return;
            }
        }

        AudioSource newAudioSource = this.gameObject.AddComponent<AudioSource>();
        audioSources.Add(newAudioSource);

        newAudioSource.clip = clip;
        newAudioSource.Play();
    }

}
