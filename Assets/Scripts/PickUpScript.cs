using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public LayerMask pickableLayer;
    public KeyCode keyInteract = KeyCode.E;
    public float reach;
    public Transform camera;
    private SpringJoint springJoint;
    public GameObject pickUpPoint;
    private GameObject point;
    private bool isPickingUp;
    // public KeyCode keyInteract = KeyCode.E;
    
    // Start is called before the first frame update
    void Start()
    {
        isPickingUp = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(point == null || point.GetComponent<SpringJoint>() == null){
            isPickingUp = false;
            if(point != null)GameObject.Destroy(point);

        }
        if(Input.GetKeyDown(keyInteract)){
            Debug.Log(isPickingUp);
            if(isPickingUp){
                //Let go
                isPickingUp = false;
                GameObject.Destroy(point);
            }
            else{
                isPickingUp = true;
                RaycastHit hit;
                Debug.DrawRay(camera.transform.position, camera.forward * reach, Color.red,1f);
                if(Physics.Raycast(camera.transform.position, camera.forward, out hit, reach, ~pickableLayer)){
                    Debug.Log("hit");
                    //Pick Up
                    Vector3 pointPos = camera.transform.position+camera.transform.forward*3;
                    point = GameObject.Instantiate(pickUpPoint, pointPos, transform.rotation, camera);

                    springJoint = point.GetComponent<SpringJoint>();
                    springJoint.connectedBody = hit.rigidbody;
                    Debug.Log(springJoint.connectedBody);
                }
            }
        }
    }
}
