using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLogic : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject bullet;
    [SerializeField] private KeyCode firekey;
    private GetKeyCondition fire = new();
    

    void Start()
    {
       // fire = new(firekey);
       fire.Key = firekey;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(firekey))
        if(fire.Eval())
        {
            //UnityEngine.Debug.Log("key was pressed");
            bullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
        }
        
    }
}
