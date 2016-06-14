using UnityEngine;
using System.Collections;

public class BrokenObject : MonoBehaviour {

    public GameObject breakBreaked;
    private float velocityImpact;
    public float MaxImpactForce;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        velocityImpact = this.GetComponent<Rigidbody>().velocity.magnitude;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.GetComponent<Rigidbody>() != null)
        {
            velocityImpact = +col.gameObject.GetComponent<Rigidbody>().velocity.magnitude;
        }
        if (velocityImpact > MaxImpactForce)
        {
            Instantiate(breakBreaked, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
