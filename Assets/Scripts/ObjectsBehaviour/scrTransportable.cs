using UnityEngine;
using System.Collections;

[System.Serializable]
public class ScrTransportable : ScrObject {
	public Color borderColor;
	public bool carried;
	public Vector3 carryPosition;

	public override void Highlight(){
		if(selectable){
			borderColor = CommonValues.tranportableHLColor;
			Debug.Log("Estou Brilhando VERDEEEEEEEE!!!");
		}
	}

	public void Carry(){
		if(carried){
			carryPosition = GameObject.Find(CommonValues.handTranspStr).transform.position;
			self.transform.position = carryPosition;
		}
	}

	public ScrTransportable(GameObject thisGameObject){
		self = thisGameObject;
	}
}
