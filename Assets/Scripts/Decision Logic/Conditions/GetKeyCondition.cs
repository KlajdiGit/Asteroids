using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeyCondition : Condition
{
    /*[SerializeField]*/// private KeyCode _key;

    public KeyCode Key { get; set; }
    public GetKeyCondition(/*KeyCode key*/)
    {
        //_key = key;    
    }

    public override bool Eval()
    {
        // bool rval = (Input.GetKeyDown(_key));
        bool rval = (Input.GetKeyDown(Key));

        return rval;
    }
}
