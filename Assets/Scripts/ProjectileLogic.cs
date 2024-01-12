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
        IsDestroyable c = otherObj.gameObject.GetComponent<IsDestroyable>();
        if (c != null)
        {
            c.Split();
            // Destroy the bullet after 0.5 seconds
            Destroy(this.gameObject, 0.5f);
        }

    }
}
