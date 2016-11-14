using UnityEngine;

public class ruchWroga : MonoBehaviour {

	private float speed = 6f;
	float czas = 2.5f;

	void Update ()
	{
		transform.Translate (Vector3.down * speed * Time.deltaTime);
		czas -= Time.deltaTime;
		if (czas <= 0)
			Destroy (gameObject);
        
    }
}
