using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioManager instance;
    public AudioManager Instance
    {
        get => instance;
    }
    private void Awake()
    {
        if (instance == null )
        {
           instance = this;
              DontDestroyOnLoad(gameObject);
        }
        else
        {
           Destroy(gameObject);

        }
    }
    [Header("Audio sounce")]
    public AudioSource musicSource;

    [Header("Audio clips")]
    public AudioClip backgroundMusic;

    public void PlayBackgroundMusic()
    {
        musicSource.clip = backgroundMusic;
        musicSource.loop = true;
        musicSource.Play();
    }
    private void Start()
    {
        PlayBackgroundMusic();
    }

}
