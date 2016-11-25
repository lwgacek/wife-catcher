using UnityEngine;
using System.Collections;

public class powerupy : MonoBehaviour {

	public GameObject[] powerUpy;
    //public GameObject timePowerup;
    //public GameObject slowPowerup;
    float czas = 10.0f;

	void Start () {

        InvokeRepeating("TimePowerUp", czas, czas);
    }

    void TimePowerUp() {
        //Instantiate(timePowerup, new Vector2 (Random.Range(-8, 8), 6), Quaternion.identity);
		Instantiate(powerUpy[Random.Range(0,2)], new Vector2(Random.Range(-8, 8), 7), Quaternion.identity);
    }
       
	
	void Update () {
	
	}
}
