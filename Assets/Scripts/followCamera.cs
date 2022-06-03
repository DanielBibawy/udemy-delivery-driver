using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{

    public GameObject toFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = toFollow.transform.position + new Vector3 (0, 0, -10);
    }
}
