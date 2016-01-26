using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Ball ball;
    public Vector3 offset;

    private GameObject pins;

	// Use this for initialization
	void Start () {
        pins = GameObject.Find("BowlingPins");
                
        transform.position = ball.transform.position + offset;
	}
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.z <= pins.transform.position.z) {
            transform.position = ball.transform.position + offset;
        }
    }    
}
