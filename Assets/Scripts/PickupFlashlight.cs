using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupFlashlight : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Flashlight;
    public GameObject FlashlightOnPlayer;



    void Update() {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver () {
        if (TheDistance <= 1) {
            
            ActionText.GetComponent<Text> ().text = "Pick Up Flashlight";
            ActionDisplay.SetActive (true);
            ActionText.SetActive (true);
        }
        if(Input.GetButtonDown("Action")) {
            if (TheDistance <= 1) {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive (false);
                ActionText.SetActive(false);
                Flashlight.SetActive(false);
                FlashlightOnPlayer.SetActive(true);
            }
        }
    }
    void OnMouseExit() {
        ActionDisplay.SetActive (false);
        ActionText.SetActive(false);

    }

}
