using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PinSetter : MonoBehaviour {

    public int lastStandingCount = -1;

    private Ball ball;
    private float lastChangeTime;
    private bool ballEnteredBox = false;
    private Text noOfPins;

    // Use this for initialization
    void Start ()
    {
        noOfPins = GameObject.Find("NoOfPins").GetComponent<Text>();
        ball = GameObject.FindObjectOfType<Ball>();
	}
	
	// Update is called once per frame
	void Update () {
        if (ballEnteredBox)
        {
            noOfPins.text = CountStanding().ToString();
            CheckStanding();
        }
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

    void CheckStanding()
    {
        int currentStanding = CountStanding();

        if (currentStanding != lastStandingCount)
        {
            lastChangeTime = Time.time;
            lastStandingCount = currentStanding;
            return;
        }

        float settleTime = 3f;

        if ((Time.time - lastChangeTime) > settleTime)
        {
            PinsHaveSettled();
        }
    }

    void PinsHaveSettled()
    {
        lastStandingCount = -1;
        ballEnteredBox = false;
        noOfPins.color = Color.green;
        ball.Reset();
    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.GetComponent<Ball>())
        {
            ballEnteredBox = true;
            noOfPins.color = Color.red;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.GetComponent<Pin>())
        {
            Destroy(obj.gameObject);
        }
        
    }
}
