using UnityEngine;
using UnityEngine.SceneManagement;

public class ruchGracza : MonoBehaviour
{

	private float speed = 10f;
	public float vs = 0.2f;
	public AudioClip punkt;
	public AudioClip error;
	public AudioClip skok;
    public AudioClip slow;
	private AudioSource sorce;
	public static float czas;
	public static float zycie;
	float czasskoku;
	float skokopuznienie;
	float timerskoku = 0;
	Animation animacja;
	Vector3 ruch;
	bool skacze = false;
	static public bool buletTime = false;
	float buletimeTime;
	float bulettimeTrwanie = 2.5f;
	//float bulettimeTimer = 0;


	void Start ()
	    {
		    czas = opcjeSlidery.czass;
		    zycie = opcjeSlidery.zycia;
		    sorce = GetComponent<AudioSource> ();
			animacja = GetComponent<Animation>();
            Cursor.visible = false;
        }

	void Skok()
	{ 
		skacze = true;
		gameObject.layer = 11;
		sorce.PlayOneShot (skok);
		if (buletTime == true) 
			{
				czasskoku = 0.5f;
			} 
		else
			{
				czasskoku = 1.0f;
			}
		animacja.Play ("misza");
		if (buletTime == true) 
			{
			animacja.Play("miszaslow");
			}
	}
	    

	void Koniecskoku()
	    {
		    gameObject.layer = 10;
		    skacze = false;
	    }

	void BuletTime()
		{
		buletTime = true;
		buletimeTime = bulettimeTrwanie;
		Time.timeScale = 0.5f;
		}
		
	void BuletTimeKoniec()
		{
		Time.timeScale = 1f;
		buletTime = false;
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
            if (col.gameObject.tag == "timePowerUp")
                {
                    czas += 5;
                    sorce.PlayOneShot(punkt);
                }
            if (col.gameObject.tag == "slowPowerUp")
                {
                    sorce.PlayOneShot(slow);
					BuletTime ();
                }
    }

	void Update ()
	    {
		if (buletTime == true) {
			skokopuznienie = 0.50f;
		}
			else
			{
			skokopuznienie = 1.0f;
		}
		    ruch = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical") * vs, 0);
		if (skacze == false && buletTime == false)
			transform.position += ruch * speed * Time.deltaTime;

		if (skacze == true && buletTime == false)
			transform.position += ruch * 6 * Time.deltaTime;

		//if (skacze == true && buletTime == true)
			//transform.position += ruch * Time.deltaTime;

		if (buletTime == true) 
			transform.position += ruch * speed * 2 * Time.deltaTime;
		
                
      
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

			buletimeTime -= Time.deltaTime;
			if (buletimeTime <= 0)
				BuletTimeKoniec();
        }
}
