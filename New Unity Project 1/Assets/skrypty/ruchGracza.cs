using UnityEngine;
using UnityEngine.SceneManagement;

public class ruchGracza : MonoBehaviour
{

	private float speed = 10f;
	public float vs = 0.2f;
	public AudioClip punkt;
	public AudioClip error;
	public AudioClip skok;
	private AudioSource sorce;
	public static float czas;
	public static float zycie;
	float czasskoku;
	float skokopuznienie = 0.84f;
	float timerskoku = 0;
	Animation animacja;
	Vector3 ruch;
	bool skacze = false;

	void Start ()
	    {
		    czas = opcjeSlidery.czass;
		    zycie = opcjeSlidery.zycia;
		    sorce = GetComponent<AudioSource> ();
		    animacja = GetComponent<Animation> ();
            Cursor.visible = false;
        }

	void Skok()
	    { 
		    skacze = true;
		    gameObject.layer = 11;
		    sorce.PlayOneShot (skok);
		    czasskoku = 0.84f;
		    animacja.Play ("misza");
	    }

	void Koniecskoku()
	    {
		    gameObject.layer = 10;
		    skacze = false;
	    }
		
	void OnTriggerEnter2D()
        {
		    sorce.PlayOneShot (punkt);
	    }

	void OnCollisionEnter2D (Collision2D col)
	    {
            if (CzasiWynik.score > 0)
                {
                CzasiWynik.score -= 1;
                }
		    if (col.gameObject.tag == "wrog")
                {
			        sorce.PlayOneShot (error);
			        zycie -= 1;
		        }
            if (col.gameObject.tag == "powerup")
                {
                    czas += 5;
                    sorce.PlayOneShot(punkt);
                }
		}

	void Update ()
	    {
		    ruch = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical") * vs, 0);
            if (skacze == false)
                {
                    transform.position += ruch * speed * Time.deltaTime;
                }
            else
                {
                    transform.position += ruch * 4 * Time.deltaTime;
                }

		    if (Input.GetKey (KeyCode.Escape))
			    SceneManager.LoadScene ("menu");
		

		    czas -= Time.deltaTime;
		    if (czas < 0 || zycie < 1)
			    SceneManager.LoadScene ("wynik");

            timerskoku -= Time.deltaTime;
            if (Input.GetKeyDown (KeyCode.Space) && timerskoku <= 0) 
		        {
			        Skok ();
			        timerskoku = skokopuznienie;
		        }

            czasskoku -= Time.deltaTime;
            if (czasskoku <= 0)
			    Koniecskoku ();
        }
}
