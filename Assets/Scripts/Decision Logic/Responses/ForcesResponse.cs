using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForcesResponse : Response
{
    [SerializeField] private UnityEngine.Vector3 _force;
    [SerializeField] private UnityEngine.ForceMode _mode;

    public override void Dispatch()
    {
        Rigidbody rb = this.gameObject.transform.root.GetComponent<Rigidbody>();    // this could fail, try/catch

        if (rb != null)
        {
            rb.AddForce(_force, _mode);
        }
    }
}
