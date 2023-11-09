using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem explosion = default;
    [SerializeField] private float tiempodeExplotar;
    private bool explotando;
    private void OnBecameVisible()
    {
        explotando = false;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(TiempodeExplosion());
        
        if (explotando)
        {
            explosion.Play();
        }
    }
    private IEnumerator TiempodeExplosion()
    {
        yield return new WaitForSeconds(tiempodeExplotar);
        explotando = true;
        
        //gameObject.SetActive(false);

    }
}
