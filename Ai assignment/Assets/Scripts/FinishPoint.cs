using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishPoint : MonoBehaviour {
	Text GameOverText;
	public Text hud2;

	// Use this for initialization
	void Start () {
		GameOverText = GameObject.Find ("GameOverText").GetComponent<Text> ();
		GameOverText.enabled = false;
	}
	
	// Update is called once per frame
	void OnTriggerEnter() {
		GameOverText.enabled = true;
	}
}
