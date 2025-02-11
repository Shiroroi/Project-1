using Unity.VisualScripting;
using UnityEngine;

public class PlayOneShotAudio : MonoBehaviour
{
    public AudioClip AudioClip;
    public float LifeTime = 1f;
    public AudioSource _audioSource;
    private float _timer = 0f;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        if (_audioSource && AudioClip && !_audioSource.isPlaying)
        {
            _audioSource.PlayOneShot(AudioClip);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < LifeTime)
        {
            _timer += Time.deltaTime;
            return;
        }

        Destroy(gameObject);
    }
}
