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
	void LateUpdate() {
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
            CommonValues.moneyReward(this.gameObject.tag, CommonValues.PUNISH);
            CommonValues.MessageManager.DrawMsgBox("Você estragou esse material. Manusei com cuidado, os materiais devem ser guardados em segurança.", CommonValues.ERROR);
            Destroy(this.gameObject);
        }

        if (GetComponent<ScrTransportableBehaviour>().wasCaught == true)
            onGround = true;
        
    }


    //REWARD SYSTEM
    public bool rewarded = false, onGround = false;

    void OnTriggerStay(Collider collider)
    {

        if (collider.tag == CommonValues.tagTriggers && onGround)
        {
            if (!rewarded)
            {
                CommonValues.moneyReward(this.gameObject.tag, CommonValues.REWARD);
                rewarded = true;
            }
        }
    }


}
