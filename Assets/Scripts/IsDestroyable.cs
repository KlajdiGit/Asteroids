using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDestroyable : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private float scaleDecrease = 0.5f;

    [SerializeField] private float speed = 1.0f;
    private Vector3 direction;
  //  private SplitResponse splitResponse;

    void Start()
    {
        direction = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        
    }


    void Update()
    {
        this.transform.position += direction * speed * Time.deltaTime;
    }


    public void Split()
    {
        if (transform.localScale.x > 15.0f)
        {
            for (int i = 0; i < 2; i++)
            {
                // Define a random offset
                Vector3 randomOffset = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), Random.Range(-3f, 3f));

                // Add the random offset to the position
                GameObject newEnemy = Instantiate(enemy, transform.position + randomOffset, transform.rotation);
                newEnemy.transform.localScale = transform.localScale * scaleDecrease;

                // Copy properties from the parent target to the new target
                newEnemy.GetComponent<IsDestroyable>().enemy = this.GetComponent<IsDestroyable>().enemy;
            }
        }

        Destroy(this.gameObject);
       
    }
    
   /* public void Split()
    {
        if (transform.localScale.x > 15.0f)
        {
            for (int i = 0; i < 2; i++)
            {
                splitResponse.UpdateTransform(transform);
                splitResponse.Dispatch();
            }
        }

        Destroy(this.gameObject);
    }*/
}
