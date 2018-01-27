using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShopMenuButtonScript : MonoBehaviour {

	public Button back;

	void Start () 
	{
		back.onClick.AddListener (BackOnClick);
	}

	void BackOnClick () 
	{
		SceneManager.LoadScene ("MainScene", LoadSceneMode.Single);
	}
}
