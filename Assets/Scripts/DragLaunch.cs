using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Ball))]
public class DragLaunch : MonoBehaviour {

    private Ball ball;
    private Vector3 mouseStart;
    private Vector3 mouseEnd;
    private float startTime;
    private float endTime;

	// Use this for initialization
	void Start ()
    {
        ball = GetComponent<Ball>();
	}

    public void DragStart ()
    {
        startTime = Time.timeSinceLevelLoad;
        mouseStart = Input.mousePosition;
    }

    public void DragEnd()
    {
        float timeDiff;
        Vector3 posDiff = new Vector3 (0,0,0);

        endTime = Time.timeSinceLevelLoad;
        mouseEnd = Input.mousePosition;

        timeDiff = endTime - startTime;
        posDiff = mouseEnd - mouseStart;

        posDiff.x = posDiff.x / timeDiff;        
        posDiff.z = posDiff.y / timeDiff;
        posDiff.y = 0;
                
        ball.LaunchBall(posDiff);
    }

    public void MoveStart(float xNudge)
    {
        //Vector3 pos = ball.transform.position;
        //Mathf.Clamp(ball.transform.position.x, -52.5f, 52.5f);
        //ball.transform.position = pos;

        if (!ball.launchedBall)
        {            
            ball.transform.Translate(xNudge, 0, 0);
        }
        
    }
	
}
