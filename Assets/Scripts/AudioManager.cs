using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum Sfx
    {
        Wing = 0,
        Point = 1,
        Die = 2
    }

    public static AudioManager Instance;
    [SerializeField] private AudioClip[] playerSfx;
    private AudioSource _audio;

    private void Awake()
    {
        Instance = this;
        _audio = GetComponent<AudioSource>();
    }

    public void PlaySfx(Sfx type)
    {
        _audio.clip = playerSfx[(int)type];
        _audio.Play();
    }
}