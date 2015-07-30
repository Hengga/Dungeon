using UnityEngine;
using System.Collections;

public class TextBoxTrigger : MonoBehaviour {
	public GameObject TextBox;
	
	void Start () {
		showTextBox ();		
	}
	
	public void showTextBox() {
		
		TextBox.SetActive(true);
		
	}
	
	public void hideTextBox() {
		
		TextBox.SetActive(false);
		
	}
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			hideTextBox ();
			
		}
	}
	
}
