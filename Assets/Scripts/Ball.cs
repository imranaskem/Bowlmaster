using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public bool launchedBall = false;
    private Rigidbody rigidBall;
    private AudioSource ballSound;

	// Use this for initialization
	void Start ()
    {
        ballSound = GetComponent<AudioSource>();
        rigidBall = GetComponent<Rigidbody>();

        rigidBall.useGravity = false;
    }

    public void LaunchBall(Vector3 velocity)
    {
        rigidBall.useGravity = true;
        rigidBall.velocity = velocity;

        ballSound.Play();

        launchedBall = true;
    }

    
}
