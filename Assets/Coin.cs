using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Amount = 10;

    private Collider2D _collider2D;
    private AudioSource _audioSource;
    public GameObject Graphics;
    public GameObject DeathSound;
    public GameObject DeathParticles;
    public ScoreManager _scoreManager;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        //_audioSource = GetComponent<AudioSource>();
        _scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();

        if (_collider2D)
            Debug.Log("This is the collider");
       
        
    }

    private void OnMouseOver()
    {
        Debug.Log("Destroy this object and give score");

        //if (_audioSource && AudioClip && !_audioSource.isPlaying)
        //{
        //    _audioSource.PlayOneShot(AudioClip);
        //}
        //if (Graphics)
        //{
        //    Graphics.SetActive(false);
        //}
        //Invoke("Destroy", 0.3f);

        if (DeathSound)
        {
            GameObject.Instantiate(DeathSound, transform.position, transform.rotation);
        }

        if (DeathParticles)
        {
            GameObject.Instantiate(DeathParticles, transform.position, transform.rotation);
        }

        if (_scoreManager)
        {
            _scoreManager.AddScore(Amount);
        }

        Destroy(gameObject);
    }

    void Destroy()
    {
        //Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
