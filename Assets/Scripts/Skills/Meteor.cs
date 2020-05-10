using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public GameObject meteorprefab;
    Transform castpoint;
    public Vector3 meteoroffset;

    float thrust = 1f;
    Rigidbody rb;

    private void Update()
    {
        //if (Input.GetKeyDown("1"))
        //{
        //    Cast();
        //}
    }

    //void Cast()
   // {
      //  castpoint.position = Input.mousePosition;
    //    Debug.Log("castpoint " + castpoint.position.x + " " + castpoint.position.y + " " + castpoint.position.z);
        //GameObject meteor = Instantiate(meteorprefab);
        //meteor.transform.position = (castpoint.position + meteoroffset);
        //rb = meteor.GetComponent<Rigidbody>();
        //rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    //}
}
