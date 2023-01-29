using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    public float FollowSpeed = 2.0f;
    public float yOffset = 1.0f;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        
    
    if (target != null)
    {
        // Camera Follow Target
        Vector3 newPos = new Vector3 (target.position.x, target.position.y - yOffset, -10f);
        transform.position = Vector3.Slerp (transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
        
        
    }
}
