using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {

    public float standingThreshold;

    public bool IsStanding()
    {
        Vector3 rotation = transform.rotation.eulerAngles;
        float stand360 = 360f - standingThreshold;

        //Debug.Log(Mathf.Abs(rotation.y));
        //float tiltInX = Mathf.Abs(rotation.x);
        //float tiltInZ = Mathf.Abs(rotation.z);

        if (Mathf.Abs(rotation.y) > standingThreshold || (300f < Mathf.Abs(rotation.y) && Mathf.Abs(rotation.y) < stand360))
        {
            return false;
        }
        else
        {
            return true;
        }
    }    
}
