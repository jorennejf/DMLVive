using UnityEngine;
using System.Collections;
//using System;


/*
 * Description: Uses the current hour (in 24h) to determine whether to display
 * 				day or night sky.
 * 
 */

public class DayNight : MonoBehaviour {


	public GameObject clouds;
	//public GameObject stars;
	SkyboxSwitcher stars; //script that contains the night sky
	public int sunriseHour = 6; //static?
	public int sunsetHour = 18; //static?
	//public Material daySky; 
	//public Material nightSky;

	// Initializes the animations according to system time
	void Start () {
		var time = System.DateTime.Now.Hour;
		//Debug.Log (System.DateTime.Now.Hour.ToString ()); //prints to console the current hour in 24h
		stars = GetComponent<SkyboxSwitcher>();

		//if nighttime
		if (time >= sunsetHour || time <= sunriseHour) {
			makeNight();
			//RenderSettings.skybox = nightSky;
		}

		//if daytime
		else{
			makeDay();
			//RenderSettings.skybox = daySky;
		}

	}

	private void makeDay(){
		clouds.SetActive (true);
		stars.enabled = false;
	}

	private void makeNight(){
		clouds.SetActive (false);
		stars.enabled = true;
	}
	

}
