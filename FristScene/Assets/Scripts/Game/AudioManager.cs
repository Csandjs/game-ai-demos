using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;
    private AudioSource audioSource;
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
