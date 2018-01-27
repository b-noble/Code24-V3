using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class IntroMenuUIScript : MonoBehaviour {

	public Button cont;
	public InputField nameText;
	public InputField ageText;
	public Text yellFace;
	private Animator textAnim;
	public string playerName;
	public string playerAge;

	void Start () 
	{
		cont.onClick.AddListener (ContOnClick);
		playerName = "Preset Name";
		playerAge = "00";
		textAnim = yellFace.GetComponent<Animator> ();
		//yellFace.gameObject.SetActive (false);
	}

	void ContOnClick () 
	{
		if (nameText.text.Length > 0 & ageText.text.Length > 0) 
		{
			playerName = nameText.text;
			playerAge = ageText.text;
			PlayerPrefs.SetString ("Name", playerName);
			PlayerPrefs.SetString ("Age", playerAge);
			SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
		} 
		else 
		{
			textAnim.SetTrigger ("TextTrigger");
			//yellFace.gameObject.SetActive (true);
		}
	}
}
