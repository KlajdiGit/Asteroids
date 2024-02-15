using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionLogic : MonoBehaviour
{
    [SerializeField] private List<Statement> _data;

    // do the work
    private void DecisionLogicUpdate()
    {
        // iterate over all statements, and evalute them
        foreach (Statement s in _data)
        {
            if (s._condition.Eval())
                s._response.Dispatch();
        }
    }

    // Update is called once per frame
    void Update()
    {
        DecisionLogicUpdate();
    }
}
