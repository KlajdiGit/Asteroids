using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 25.0f;

    private void Update()
    {
        transform.position += transform.forward * movementSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        transform.position += transform.right * movementSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
    }
}
