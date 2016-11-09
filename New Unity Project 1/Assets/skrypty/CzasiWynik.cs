using UnityEngine;
using UnityEngine.UI;

public class CzasiWynik : MonoBehaviour {

	public Text czasZycie;
	public Text scoreHighscore;

	public static int score; 
	public static int hscore; 

 

	void Start () 
	{
		score = 0;
	}
	

	void Update ()
	{
		czasZycie.text = "Czas: " + Mathf.RoundToInt(ruchGracza.czas) + "\nZycie: " + ruchGracza.zycie;
		scoreHighscore.text = "Wynik: " + score + "\nBest: " +hscore;

	


	}
}
