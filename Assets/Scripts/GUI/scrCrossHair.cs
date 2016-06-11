using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class scrCrossHair : MonoBehaviour
{

    private Image crossHair;
    public Sprite fillCross, emptyCross;
    public bool playerIsCarrying;

#if UNITY_EDITOR

    void Awake()
    {
        if (fillCross == null || emptyCross == null)
            Debug.LogError("Object with CrossHairScript! some crossHair doesn't have sprite ");
    }

#endif

    void Start()
    {
        crossHair = GetComponent<Image>();
    }

    void Update()
    {
        playerIsCarrying = scrPlayer.isCarrying;
        //get if player is carrying something
        if (playerIsCarrying)
        {
            crossHair.sprite = fillCross;
            crossHair.rectTransform.sizeDelta = new Vector2(20, 20);
        }
        else
        {
            crossHair.sprite = emptyCross;
            float playerSpd = 10 + 2 * scrPlayer.mySpd;
            crossHair.rectTransform.sizeDelta = new Vector2(playerSpd, playerSpd);
        }

        
            
    }

}
