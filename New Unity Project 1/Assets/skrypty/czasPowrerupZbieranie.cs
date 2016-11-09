using UnityEngine;
using System.Collections;

public class czasPowrerupZbieranie : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
        {
        if (col.gameObject.tag == "Player");
        Destroy(gameObject);
        }
}
