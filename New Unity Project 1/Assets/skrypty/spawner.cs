using UnityEngine;

public class spawner : MonoBehaviour {

	public GameObject[] wrog;
    public float czas = 11.0f;
	public static GameObject go;
	void Start ()
	{
		czas -= Time.deltaTime;
		InvokeRepeating("Spawn", czas, czas);
	}

	void Spawn()
	{
		go = (GameObject)Instantiate (wrog[Random.Range(0,4)], new Vector2 (Random.Range(-8,8), 6), Quaternion.identity);
	}
}
