using UnityEngine;

using UnityEngine.UI;
using System.Collections;


public class menuScript : MonoBehaviour {


	public Canvas quitMenu;
	public Button quitButton;
	


	// Use this for initialization

	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas>();
		quitButton = quitButton.GetComponent<Button>();
		quitMenu.enabled = false;
	
}
	
	

	//When "Quit" button is pressed
	public void QuitPress(){
		quitMenu.enabled = true;
		quitButton.enabled = false;
	}

	//When "No" is pressed on Quit Menu
	public void NoPress(){
		quitMenu.enabled = false;
		quitButton.enabled = true;
	}

	//When "Yes" is pressed on Quit Menu
	public void YesPress(){
		Application.Quit();
	}

}
