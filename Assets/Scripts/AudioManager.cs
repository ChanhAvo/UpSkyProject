using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    
    public AudioClip background;
    public AudioClip death;
    public AudioClip checkpoint;
    public AudioClip enemiesTouch;
    
    private void Start() {
        musicSource.clip = background; 
        musicSource.Play(); 
    }
    public void PlaySFX(AudioClip clip) { 
        SFXSource.PlayOneShot(clip); 
    }
}
