using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLogic : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;
    [SerializeField] private KeyCode upKey;
    [SerializeField] private float rotSpeed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb != null)
        {
            if(Input.GetKey(leftKey))
            {
                rb.AddForce(new UnityEngine.Vector3(30.0f, 0.0f, 0.0f));
                this.transform.Rotate(UnityEngine.Vector3.up, rotSpeed, Space.World);
            }
            if (Input.GetKey(rightKey))
            {
                rb.AddForce(new UnityEngine.Vector3(-30.0f, 0.0f, 0.0f));
                this.transform.Rotate(UnityEngine.Vector3.up, -rotSpeed, Space.World);
            }
            if (Input.GetKey(upKey))
            {
                rb.AddForce(new UnityEngine.Vector3(0.0f, 30.0f, 0.0f));
                this.transform.Rotate(UnityEngine.Vector3.up, rotSpeed, Space.World);
            }
        }  
    }

    private void OnCollisionEnter(Collision otherObj)
    {
        Component c = otherObj.gameObject.GetComponent<IsDestroyable>();
        if (c != null)
        {
            Destroy(this.gameObject);
        }

    }
}
