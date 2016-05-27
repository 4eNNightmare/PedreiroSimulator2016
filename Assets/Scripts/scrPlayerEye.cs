using UnityEngine;
using System.Collections;

public class scrPlayerEye : MonoBehaviour
{
    //Components
        private Camera eye;
    
    //Vars
        [SerializeField]private float lookSensivity = 5f;
        private float xRot = 0,yRot = 0;

    void Awake()
    {
        eye = Camera.main;
    }

    CursorLockMode cursorLock;

    void Update()
    {

        xRot -= Input.GetAxis("Mouse Y") * lookSensivity;
        yRot += Input.GetAxis("Mouse X") * lookSensivity;

        xRot = Mathf.Clamp(xRot, -40f, 40f);
        //yRot = Mathf.Clamp(yRot, -70f, 70f);
        eye.transform.rotation = Quaternion.Euler(xRot, yRot, 0);

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
        //Cursor.lockState = CursorLockMode.Locked;
        
    }
}
