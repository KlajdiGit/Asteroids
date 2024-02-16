using UnityEngine;

public class AstroidMoveResponse : Response
{
    private Vector3 direction;
    private float speed;
    private Transform pos;

    public AstroidMoveResponse(Vector3 d, float s, Transform t)
    {
        direction = d;
        speed = s;
        pos = t;
    }

    public override void Dispatch()
    {
        pos.position += direction * speed * Time.deltaTime;
    }
}
