using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCube : MonoBehaviour
{

    public GameObject cube;
    
    // defaults for camera position
    public int vectorX = 0;
    public int vectorY = 5;
    public int vectorZ = -7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = cube.transform.position + new Vector3(vectorX, vectorY, vectorZ);
        
    }
}
