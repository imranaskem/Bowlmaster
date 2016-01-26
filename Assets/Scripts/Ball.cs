using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public bool launchedBall = false;
    public bool inPlay;

    private Rigidbody rigidBall;
    private AudioSource ballSound;
    private Vector3 ballStart;

	// Use this for initialization
	void Start ()
    {
        ballSound = GetComponent<AudioSource>();
        rigidBall = GetComponent<Rigidbody>();

        ballStart = transform.position;
        rigidBall.useGravity = false;
    }

    public void LaunchBall(Vector3 velocity)
    {
        rigidBall.useGravity = true;
        rigidBall.velocity = velocity;

        ballSound.Play();

        launchedBall = true;
    }

    public void Reset()
    {
        inPlay = false;
        transform.position = ballStart;
        rigidBall.useGravity = false;
        rigidBall.velocity = Vector3.zero;
        rigidBall.angularVelocity = Vector3.zero;        
    }
}
