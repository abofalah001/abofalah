using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField]private Transform player;
    

    [SerializeField]private Vector3 offset;

   
    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.position + offset;
        
    }
}
