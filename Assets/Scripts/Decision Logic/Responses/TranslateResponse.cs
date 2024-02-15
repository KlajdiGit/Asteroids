using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateResponse : Response
{
    /*public UnityEngine.Vector3 _translation;
    public UnityEngine.Space _space;

    public override void Dispatch()
    {
        this.gameObject.transform.root.Translate(_translation * Time.deltaTime, _space);
    }*/

    
    public UnityEngine.Vector3 _translation;
    public UnityEngine.Space _space;
    public float Speed {  get;  set; }

    public override void Dispatch()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        float inputMagnitude = input.magnitude;
        this.gameObject.transform.root.Translate((_translation + input * Speed) * Time.deltaTime, _space);
    }

}
