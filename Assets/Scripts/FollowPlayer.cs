using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(1000)]
public class FollowPlayer : MonoBehaviour
{
    Camera cameraFollowPlayer;
    public Transform target;
    private Vector3 offset = new Vector3(0, 5, -10);

    // Start is called before the first frame update
    void Start()
    {
        cameraFollowPlayer = GetComponent<Camera>();

        transform.parent = null;

        //if target not set, then set it to the player
        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (target == null)
            Debug.LogError("Target not set on Camera Follow.");

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cameraFollowPlayer.transform.position + offset;
        
    }
}
