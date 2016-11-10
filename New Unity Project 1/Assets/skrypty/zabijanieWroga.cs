using UnityEngine;

public class zabijanieWroga : MonoBehaviour {

	public int punkty = 1;

	void OnTriggerEnter2D (Collider2D col)
    {
            if( col.gameObject.tag == "Player" )
		Destroy(gameObject);
		CzasiWynik.score += punkty;
		if (CzasiWynik.score > CzasiWynik.hscore)
			CzasiWynik.hscore = CzasiWynik.score;
	}
}
