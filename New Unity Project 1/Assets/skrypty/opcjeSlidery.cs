using UnityEngine;
using UnityEngine.UI;

public class opcjeSlidery : MonoBehaviour {

	public Text zyciaText;
	public Text czasText;

	public Slider zyciaSlider;
	public Slider czasSlider;

	public static float zycia =5f;
	public static float czass =10f;

	void Update () 
	{
		zycia = zyciaSlider.value;
		czass = czasSlider.value;

		zyciaText.text = "Życia: " + zycia;
		czasText.text = "Czas: " + czass;
	}
}
