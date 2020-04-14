using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostOneInterp : MonoBehaviour
{
    public Transform[] waypoints;

    Light Changelight;
    private Vector3 quarter;
    private Vector3 half;
    private Vector3 threeQ;

    // Start is called before the first frame update
    void Start()
    {
        quarter = (1.0f - 0.25f) * waypoints[0].position + 0.25f * waypoints[1].position;
        half = (1.0f - 0.5f) * waypoints[0].position + 0.5f * waypoints[1].position;
        threeQ = (1.0f - 0.75f) * waypoints[0].position + 0.75f * waypoints[1].position;
        Changelight = GetComponent<Light>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   if(transform.position.z < threeQ.z)
        {
            Changelight.color = Color.green;
        } else if(transform.position.z >= quarter.z)
        {
            Changelight.color = Color.blue;
        } else if (transform.position.z >= half.z)
        {
            Changelight.color = Color.yellow;
        } else if (transform.position.z >= threeQ.z)
        {
            Changelight.color = Color.magenta;
        }
    }
}
