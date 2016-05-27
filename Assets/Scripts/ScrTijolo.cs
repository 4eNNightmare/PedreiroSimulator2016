using UnityEngine;
using System.Collections;

public class ScrTijolo : MonoBehaviour {
	public ScrTransportable properties;

	void Awake () {
		properties = new ScrTransportable(this.gameObject);
	}

	void OnMouseOver()
	{
			properties.targeted = true;
			properties.Highlight();
	}

	void OnMouseExit(){
		properties.targeted = false;
	}

	void Update(){
		if(Input.GetMouseButtonDown(0) && properties.targeted){
			properties.carried = true;
		}
		properties.Carry();
			
	}
}
