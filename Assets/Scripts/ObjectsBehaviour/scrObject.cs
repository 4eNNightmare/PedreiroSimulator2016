using UnityEngine;
using System.Collections;

public abstract class ScrObject : MonoBehaviour{
	public bool selectable = true;
	public bool targeted;
	public string info;

	public abstract void Highlight(bool state);

	public void ShowInfo(){
		if(targeted){
			Debug.Log(info);
		}

	}
}