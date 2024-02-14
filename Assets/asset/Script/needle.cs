using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle : MonoBehaviour
{
    static float minAngle = 230f;
    static float maxAngle = -50f;
    static needle thisspeed;
    // Start is called before the first frame update
    void Start()
    {
        thisspeed = this;
    }

    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisspeed.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
