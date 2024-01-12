using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLogic : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    [SerializeField] private KeyCode firekey;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(firekey))
        {
            UnityEngine.Debug.Log("key was pressed");
            bullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
        }
        
    }
}