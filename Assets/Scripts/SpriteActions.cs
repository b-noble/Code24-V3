using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpriteActions : MonoBehaviour {

	public Button middle;
	private Animator spriteAnim;

	void Start () 
	{
		middle.onClick.AddListener (MiddleButton);
		spriteAnim = GetComponent<Animator> ();
	}

	void MiddleButton () 
	{
		spriteAnim.SetTrigger ("MiddleTrigger");
	}
}
