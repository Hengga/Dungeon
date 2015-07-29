using UnityEngine;
using System.Collections;

public class TextBoxTrigger : MonoBehaviour {
	public GameObject TextBox;

	void Start () {
		if (Application.loadedLevelName.Equals("introScene"))
		{
			showTextBox ();
	}
	}

	public void showTextBox() {
		
		textBox.SetActive(true);
		
	}
	
	public void hideTextboxl() {
		
		TextBox.SetActive(false);
		
	}
}