using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource audioSource;
    private AudioSource bgmSource;
    public AudioClip bgmClip;
    public AudioClip coinClip;
    public AudioClip jumpClip;
    public AudioClip hitClip;
    public AudioClip hurtClip;
    public AudioClip winClip;
    public AudioClip loseClip;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        audioSource = GetComponent<AudioSource>();
        bgmSource = gameObject.AddComponent<AudioSource>();
        bgmSource.clip = bgmClip;
        bgmSource.loop = true;
        bgmSource.playOnAwake = false;
        bgmSource.volume = 0.3f;
        bool musicOn = SaveManager.LoadMusicOn();
        bgmSource.mute = !musicOn;
        if (musicOn && bgmClip != null)
        {
            bgmSource.Play();
        }
    }
    public void PlaySfx(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
    public void PlayCoin() => PlaySfx(coinClip);
    public void PlayJump() => PlaySfx(jumpClip);
    public void PlayHit() => PlaySfx(hitClip);
    public void PlayHurt() => PlaySfx(hurtClip);
    public void PlayWin() => PlaySfx(winClip);
    public void PlayLose() => PlaySfx(loseClip);
    public void SetMusicOn(bool isOn)
    {
        bgmSource.mute = !isOn; 
        bool musicOn = SaveManager.LoadMusicOn();
        if (musicOn && bgmClip != null)
        {
            bgmSource.Play();
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
