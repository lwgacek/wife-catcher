using UnityEngine;
using UnityEngine.SceneManagement;

public class wczytajPostac : MonoBehaviour {

	public static int numer;

	public void Wybrana(int numer)
	{
		PlayerPrefs.SetInt("numer", numer);
	}

	public void Wczytaj (int level)
	{
		SceneManager.LoadScene(level);
	}

	public void wyjdz()
	{
		Application.Quit ();
	}

	void Update() 
	{

	
		Cursor.visible = true;

		if (Input.GetKey (KeyCode.Escape))
			Application.Quit();
	}
}

