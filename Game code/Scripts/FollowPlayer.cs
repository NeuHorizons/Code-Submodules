using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Late update makes it so its delayed so it dosent stutter or jurk back and forth when the car hits an object
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
