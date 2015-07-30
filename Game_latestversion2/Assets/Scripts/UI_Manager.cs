using UnityEngine;
using System.Collections;

public class UI_Manager : MonoBehaviour {
	
	public GameObject pnl_about;
	
	void Start () {
		hideAboutPanel ();		
	}
	
	public void StartGame()
	{
		Application.LoadLevel("2_game");
		
	}
	
	public void showAboutPanel() {
		
		pnl_about.SetActive(true);
		
	}
	
	public void hideAboutPanel() {
		
		pnl_about.SetActive(false);
		
	}
	
}
