using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugResponse : Response
{
    public string msg;

    public override void Dispatch()
    {
        UnityEngine.Debug.Log(msg);
    }
}
