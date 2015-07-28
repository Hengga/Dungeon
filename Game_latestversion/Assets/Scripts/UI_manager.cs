using UnityEngine;
using System.Collections;

public class UI_manager : MonoBehaviour {	
	public GameObject pnl_about;

public void StartGame()
	{
		Application.LoadLevel ("2_game");
	}
	// Use this for initialization
	void Start () {
			pnl_about.SetActive (false);
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
