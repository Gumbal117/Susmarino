using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion = default;
    [SerializeField] private GameObject luz;
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private float tiempodeExplotar;
    [SerializeField] private int numExplosion;
    private bool explotando;
    public bool yaExploto;
    [SerializeField] private AudioSource sondioExplosion;

    private void Awake()
    {
        explosion = GetComponent<ParticleSystem>();
        sprite = GetComponent<SpriteRenderer>();

    }
    private void OnEnable()
    {
        numExplosion = 0;
        sprite.enabled = true;
        explotando = false;
        luz.SetActive(false);
        yaExploto=false;
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
                luz.SetActive(true);
                sondioExplosion.Play();
                yaExploto = true;
            }
            else
            {
                if (explosion.particleCount == 0 && numExplosion > 0)
                {
                    explosion.Pause();
                    explosion.Stop();
                    gameObject.SetActive(false);
                    yaExploto = false;
                }
            }
        }
    }
    private IEnumerator TiempodeExplosion()
    {
        yield return new WaitForSeconds(tiempodeExplotar);
        explotando = true;
    }
   
}
