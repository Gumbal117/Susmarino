using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionFuncion : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2Dbomba;
    [SerializeField] private CircleCollider2D circleCollider;
    private Explosion detector;
    private void Awake()
    {
        rigidbody2Dbomba = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        detector = GetComponent<Explosion>();
    }
    private void OnEnable()
    {
        circleCollider.enabled = false;
    }

    void Update()
    {
        
        if (detector.yaExploto)
        {
            rigidbody2Dbomba.velocity = Vector2.zero;
            circleCollider.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (circleCollider != null)
        {

        }
    }
}
