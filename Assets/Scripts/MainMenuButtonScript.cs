using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuButtonScript : MonoBehaviour {

	public Button eat;
	public Button task;
	public Button games;
	public Button shop;
	public Button friends;
	public Button info;

	public Text playerText;

	void Start () 
	{
		eat.onClick.AddListener (EatOnClick);
		task.onClick.AddListener (TaskOnClick);
		games.onClick.AddListener (GamesOnClick);
		shop.onClick.AddListener (ShopOnClick);
		friends.onClick.AddListener (FriendsOnClick);
		info.onClick.AddListener (InfoOnClick);

		playerText.text = "Name: " + PlayerPrefs.GetString("Name") + 
			"\n" + "Age: " + PlayerPrefs.GetString("Age") + 
			"\n" + "Status: Undergrad";
	}

	void EatOnClick ()
	{
		SceneManager.LoadScene ("EatScene", LoadSceneMode.Single); 
	}

	void TaskOnClick ()
	{
		SceneManager.LoadScene ("TaskScene", LoadSceneMode.Single); 
	}

	void GamesOnClick ()
	{
		SceneManager.LoadScene ("GameScene", LoadSceneMode.Single); 
	}

	void ShopOnClick ()
	{
		SceneManager.LoadScene ("ShopScene", LoadSceneMode.Single); 
	}

	void FriendsOnClick ()
	{
		SceneManager.LoadScene ("FriendScene", LoadSceneMode.Single); 
	}

	void InfoOnClick ()
	{
		SceneManager.LoadScene ("InfoScene", LoadSceneMode.Single);
	}
}
