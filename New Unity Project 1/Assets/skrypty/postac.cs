using UnityEngine;

public class postac : MonoBehaviour {


	public GameObject misza;
	public GameObject grzeg;
	public GameObject gacek;
	public GameObject artek;


	// Use this for initialization
	void Start () {
		wczytajPostac.numer = PlayerPrefs.GetInt ("numer");
		//Debug.Log (wczytajPostac.numer);

		if(wczytajPostac.numer == 1)
			Instantiate(misza);

		if (wczytajPostac.numer == 2)
			Instantiate (grzeg);
		
		if (wczytajPostac.numer == 3)
			Instantiate (gacek);
		
		if (wczytajPostac.numer == 4)
			Instantiate (artek);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
