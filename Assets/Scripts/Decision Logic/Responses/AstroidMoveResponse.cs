using UnityEngine;

public class AstroidMoveResponse : Response
{
    private Vector3 direction;

    public AstroidMoveResponse()
    {
        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
    }

    public override void Dispatch()
    {
        
    }
}
