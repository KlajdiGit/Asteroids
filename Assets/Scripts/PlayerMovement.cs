using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /* [SerializeField] private float movementSpeed = 25.0f;

     private void Update()
     {
         transform.position += transform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
         transform.position += transform.right * movementSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
     }*/

    [SerializeField] private float movementSpeed = 25.0f;
    [SerializeField] private Vector3 translation;
    [SerializeField] private Space space;
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
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            translateResponse.Dispatch();
        }
    }
}
