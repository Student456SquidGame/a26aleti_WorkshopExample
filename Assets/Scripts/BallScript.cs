using System;
using System.Collections;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Rigidbody2D rb;
    private void Start()
    { rb = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<BoxCollider2D>();


// Set speed
        float speed = 10f;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger"))
        {
            FindAnyObjectByType<GameManager>().ActivateMagnet();
            //gameObject.GetComponent<Collider2D>().enabled = false;
            //gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        }
        
        if (other.gameObject.CompareTag("Magnet"))
        {
            other.gameObject.SetActive(false);
            float angleDegrees = UnityEngine.Random.Range(-45f, 45f); // limit to ±45° from horizontal
            float angleRadians = angleDegrees * Mathf.Deg2Rad;
            Vector2 direction = new Vector2(
                Mathf.Cos(angleRadians),
                Mathf.Sin(angleRadians)
            ).normalized;

            rb.linearVelocity = new Vector2( UnityEngine.Random.Range(-45f, 45f),  UnityEngine.Random.Range(-45f, 45f));
        }
        

    }
    

}
