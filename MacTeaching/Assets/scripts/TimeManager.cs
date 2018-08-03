using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameStatus {
	PLAYING, PAUSE, ADDTIME, FINISH
};

public class TimeManager : MonoBehaviour {

	public Text timer;
	private float timeLeft = 60f;
	private GameStatus status;
	
	void Start() {
		this.timer.text = this.timeLeft + "";
	}

	// Update is called once per frame
	void Update () {
		if(status == GameStatus.PLAYING){
			timeLeft -= Time.deltaTime;
			this.timer.text = this.timeLeft + "";
			if ( timeLeft < 0 )
			{
				Debug.Log("over");
			}
		}
	}

	public void changeStatus(GameStatus newStatus){
		this.status = newStatus;
	}

	public void addTime(){
		this.timeLeft += 0.15f;
	}
}
