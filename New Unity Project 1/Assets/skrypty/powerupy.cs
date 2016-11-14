using UnityEngine;
using System.Collections;

public class powerupy : MonoBehaviour {

    public GameObject timePowerup;
    public GameObject slowPowerup;
    float czas = 10.0f;

	void Start () {

        InvokeRepeating("TimePowerUp", czas, czas);
    }

    void TimePowerUp() {
        //Instantiate(timePowerup, new Vector2 (Random.Range(-8, 8), 6), Quaternion.identity);
        Instantiate(slowPowerup, new Vector2(Random.Range(-8, 8), 6), Quaternion.identity);
    }
       
	
	void Update () {
	
	}
}
