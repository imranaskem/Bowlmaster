using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {

    public float standingThreshold;

    public bool IsStanding()
    {
        Vector3 rotation = transform.rotation.eulerAngles;

        float tiltInX = Mathf.Abs(rotation.x);
        float tiltInZ = Mathf.Abs(rotation.z);

        if (tiltInX < standingThreshold && tiltInZ < standingThreshold)
        {
            return false;
        } else
        {
            return true;
        }
    }
}
