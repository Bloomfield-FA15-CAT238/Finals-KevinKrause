using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public bool isGame_Start = false;
	
	void OnMouseUp (){
		if(isGame_Start){
			Application.LoadLevel(1);
		}
	}
}
