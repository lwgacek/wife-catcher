using UnityEngine;
using System.Collections;

public class czasPowrerupZbieranie : MonoBehaviour {

        Animation animacja;

    void Start()
    {
        animacja = GetComponent<Animation>();
        
    }
    void OnCollisionEnter2D(Collision2D col)
        {
        if (col.gameObject.tag == "Player");
        Destroy(gameObject);
        }
    void Update()
    {
        animacja.Play("timepowerup");
    }
}
