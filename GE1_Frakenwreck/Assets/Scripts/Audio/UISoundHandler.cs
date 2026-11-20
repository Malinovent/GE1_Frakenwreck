using UnityEngine;

public class UISoundHandler : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    public void PlaySound()
    {
        UISoundsManager.Singleton.PlaySound(audioClip);
    }

}
