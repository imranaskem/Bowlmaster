using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinSetter : MonoBehaviour {

    
    Text noOfPins;

    // Use this for initialization
    void Start ()
    {
        noOfPins = GameObject.Find("NoOfPins").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        noOfPins.text = CountStanding().ToString();
	}

    int CountStanding()
    {
        int pinCount = 0;
        Pin[] pins = GameObject.FindObjectsOfType<Pin>();

        foreach (Pin indivPin in pins)
        {
            if (indivPin.IsStanding())
            {
                pinCount++;
            }            
        }
        return pinCount;
    }
}
