using UnityEngine;
using System.Collections;

public class scrMSG_autoDestruction : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject.Destroy(this.gameObject,7);

	}

}
