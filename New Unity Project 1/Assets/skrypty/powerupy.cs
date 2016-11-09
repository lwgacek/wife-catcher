using UnityEngine;
using System.Collections;

public class powerupy : MonoBehaviour {

    public GameObject timePowerup;
    float czas = 10.0f;

	void Start () {

        InvokeRepeating("Powerup", czas, czas);
    }

    void Powerup() {
        Instantiate(timePowerup, new Vector2 (Random.Range(-8, 8), 6), Quaternion.identity);
    }
       
	
	void Update () {
	
	}
}
