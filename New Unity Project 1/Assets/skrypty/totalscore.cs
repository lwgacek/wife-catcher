using UnityEngine;
using UnityEngine.UI;

public class totalscore : MonoBehaviour {
 		
	public Text koniecZycia;
	string odmiana;
	public Text text;                      


	void Start()
	{
		if (CzasiWynik.score == 0 | CzasiWynik.score > 4)
			odmiana = " punktów";
		if (CzasiWynik.score == 1)
			odmiana = " punkt";
		if (CzasiWynik.score > 1 && CzasiWynik.score < 5 | CzasiWynik.score > 21 && CzasiWynik.score < 25 | CzasiWynik.score > 31 && CzasiWynik.score < 35)
			odmiana = " punkty";
		
	}

		void Update ()
	{
		text.text = "Zdobyleś " + CzasiWynik.score + odmiana;


		if (ruchGracza.zycie == 0)
			koniecZycia.text = "Koniec Żyć";
	}
}

