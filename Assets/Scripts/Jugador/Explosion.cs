using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion = default;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Rigidbody2D rigidbody2Dbomba;
    [SerializeField] private GameObject luz;
    [SerializeField] private CircleCollider2D circleCollider;
    [SerializeField] private float tiempodeExplotar;
    [SerializeField] private int numExplosion;
    private bool explotando;
    [SerializeField] private AudioSource sondioExplosion;

    private void Awake()
    {
        explosion = GetComponent<ParticleSystem>();
        sprite = GetComponent<SpriteRenderer>();
        rigidbody2Dbomba = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();

    }
    private void OnEnable()
    {
        numExplosion = 0;
        sprite.enabled = true;
        explotando = false;
        circleCollider.enabled = false;
        luz.SetActive(false);
    }
   
    void Update()
    {
        StartCoroutine(TiempodeExplosion());
        
        if (explotando)
        {
            if (!explosion.isPlaying&&numExplosion==0)
            {
                sprite.enabled = false;
                numExplosion=+1;
                explosion.Play();
                rigidbody2Dbomba.velocity = Vector2.zero;
                circleCollider.enabled = true;
                luz.SetActive(true);
                sondioExplosion.Play();
            }
            else
            {
                if (explosion.particleCount == 0 && numExplosion > 0)
                {
                    explosion.Pause();
                    explosion.Stop();
                    gameObject.SetActive(false);
                }
            }
        }
    }
    private IEnumerator TiempodeExplosion()
    {
        yield return new WaitForSeconds(tiempodeExplotar);
        explotando = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (circleCollider!= null)
        {
            
        }
    }
}
