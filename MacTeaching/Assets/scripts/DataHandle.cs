using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataHandle : MonoBehaviour {

	string URL = "";

	void Start(){
		getDataTest();
	}

	// Use this for initialization
	public void getDataTest () {
		StartCoroutine(getData("wagner"));
	}

	IEnumerator getData (string data){
		this.URL = this.URL + 23;
		WWW getDelivery = new WWW(this.URL);

		yield return getDelivery;
		Debug.Log(getDelivery.text);
	}
}
