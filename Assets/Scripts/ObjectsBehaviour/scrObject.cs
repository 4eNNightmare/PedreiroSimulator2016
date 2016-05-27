using UnityEngine;
using System.Collections;

public abstract class ScrObject {
	public bool selectable = true;
	public bool targeted;
	public string info;
	public GameObject self;

	public abstract void Highlight();

	public void ShowInfo(){
		if(targeted){
			Debug.Log(info);
		}

	}
}