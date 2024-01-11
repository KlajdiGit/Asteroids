using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObj)
    {
        Component c = otherObj.gameObject.GetComponent<IsDestroyable>();
        if (c != null)
        {
           Destroy(otherObj.gameObject);
        }


    }
}
