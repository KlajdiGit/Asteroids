using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 25.0f;
    [SerializeField] private Vector3 translation;
    [SerializeField] private Space space;
    [SerializeField] float turnSpeed = 100f;
    private TranslateResponse translateResponse;

    void Start()
    {
        translateResponse = gameObject.AddComponent<TranslateResponse>();
        translateResponse._translation = translation * movementSpeed;
        translateResponse._space = space;
        translateResponse.Speed = movementSpeed;
    }

    void Update()
    {
        Thrust();
        Turn();
    }

    void Thrust()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            translateResponse.Dispatch();
        }
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal"); // Rotation on Y
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Pitch"); // Rotation on X
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Roll"); // Rotation on Z

        transform.Rotate(-pitch, yaw, -roll);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Component c = collision.gameObject.GetComponent<IsDestroyable>();
        if (c != null)
        {
            Destroy(this.gameObject);
        }
    }
}
