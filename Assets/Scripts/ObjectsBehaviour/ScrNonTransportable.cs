using UnityEngine;
using System.Collections;

public class ScrNonTransportable : ScrObject {
	public Vector4 borderColor;
	public override void Highlight(){
		if(selectable){
			Debug.Log("Estou Brilhando AZUUUUULLL!!!");
		}
	}
	public void DoSomething(){
		Debug.Log("Algo aconteceu!");
	}
}