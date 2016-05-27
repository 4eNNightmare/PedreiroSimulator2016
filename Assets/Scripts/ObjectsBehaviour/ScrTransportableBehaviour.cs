using UnityEngine;
using System.Collections;

public class ScrTransportableBehaviour : ScrObject {
	public Vector3 carryPosition;
	public float delay;
	private GameObject hand;


	void Awake () {
		hand = GameObject.Find(CommonValues.handTranspStr);
	}

	public override void Highlight(bool state){
		if(state == true){
			if(selectable){
				gameObject.GetComponent<Renderer>().material.SetColor("_OutlineColor", CommonValues.tranportableHLColor);
				gameObject.GetComponent<Renderer>().material.SetFloat("_Outline", 0.01f);
			}
		}
		else{
			gameObject.GetComponent<Renderer>().material.SetColor("_OutlineColor", new Color(CommonValues.tranportableHLColor.r, CommonValues.tranportableHLColor.g, CommonValues.tranportableHLColor.b, 0));
			gameObject.GetComponent<Renderer>().material.SetFloat("_Outline", 0);
		}
	}

	private void Carry(){
		Highlight(false);
		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<Rigidbody>().detectCollisions = false;
		carryPosition = hand.transform.position;
		transform.position = carryPosition;
		transform.SetParent(hand.transform);

	}

	private void Drop(){
		GetComponent<Rigidbody>().isKinematic = false;
		GetComponent<Rigidbody>().detectCollisions = true;
		transform.SetParent(null);
	}

	void OnMouseOver()
	{
		if(hand.transform.childCount == 0 && selectable && Vector3.Distance(hand.transform.position,transform.position) < CommonValues.maxGrabRange){
			targeted = true;
			Highlight(true);
		}
	}

	void OnMouseExit(){

		if (hand.transform.childCount == 0)
		{
			targeted = false;
			Highlight(false);
		}
	}


	void Update(){
		delay += Time.deltaTime;
		if(Input.GetMouseButtonDown(0) && hand.transform.childCount == 0 && targeted){
			delay = 0;
			Carry();
		}

		if(delay > 0.25){
			if(Input.GetMouseButtonDown(0) && hand.transform.childCount > 0){
				Drop();
			}
		}
	}
}

