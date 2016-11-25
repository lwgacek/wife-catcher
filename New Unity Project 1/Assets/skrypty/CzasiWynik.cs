using UnityEngine;
using UnityEngine.UI;

public class CzasiWynik : MonoBehaviour {

	public Text czas;
	public Text zycia;
	public Text scoreHighscore;

	public static int score; 
	public static int hscore; 

 

	void Start () 
	{
		score = 0;
	}
	

	void Update ()
	{
		czas.text = "Czas: " + Mathf.RoundToInt (ruchGracza.czas);
		scoreHighscore.text = "Wynik: " + score;
		zycia.text = "Życia: " + ruchGracza.zycie;

	


	}
}
