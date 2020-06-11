using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform BirdTransform;
    Vector3 range;
    // Start is called before the first frame update
    void Awake()
    {
        range = transform.position - BirdTransform.position;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(range.x + BirdTransform.position.x, 0, range.z + BirdTransform.position.z); 
    }
}
