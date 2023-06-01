using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
<<<<<<< HEAD
    private Vector3 offset = new Vector3(0,5,-13);
=======
    private Vector3 offset = new Vector3(10,0,0);
>>>>>>> 9e276e3175fb4756d648a30993acb495168b2d4f


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
