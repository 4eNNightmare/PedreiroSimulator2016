using UnityEngine;
using System.Collections;

public class ScrTransportableBehaviour : ScrObject
{

    public Vector3 carryPosition;
	private float delay;
	private GameObject hand;
	public GameObject inHandObject;
    public bool wasCaught = false; // check if gameObject was caught.




	void Awake ()
    {
		hand = GameObject.Find(CommonValues.handTranspStr);
	}

	

	private void Carry(){
        Highlight(this.gameObject, new Color(0,0,0,0));
        GetComponent<Rigidbody>().useGravity = false;
		GetComponent<Rigidbody>().isKinematic = true;
		GetComponent<Rigidbody>().detectCollisions = false;
		carryPosition = hand.transform.position;
		transform.position = carryPosition;
		transform.SetParent(hand.transform);
		inHandObject = this.gameObject;
	}

	private void Drop(){
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().detectCollisions = true;
        transform.SetParent(null);
		inHandObject = null;
        
	}

	void OnMouseOver()
	{
		if(hand.transform.childCount == 0 && selectable && Vector3.Distance(hand.transform.position,transform.position) < CommonValues.maxGrabRange){
			targeted = true;
			Highlight(this.gameObject,new Color(0,1,0));
		}
	}

	void OnMouseExit(){

		if (hand.transform.childCount == 0)
		{
			targeted = false;
			Highlight(this.gameObject,new Color(0,0,0,0));
		}
	}


	public void Update()
    {
		delay += Time.deltaTime;
		if(Input.GetMouseButtonDown(0) && hand.transform.childCount == 0 && targeted){
			delay = 0;
			Carry();
            if (!wasCaught) wasCaught = true;
		}

		if(delay > 0.25){
			if(Input.GetMouseButtonDown(0) && hand.transform.childCount > 0){
				Drop();
			}
		}
	}
}

