using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDestroyable : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float scaleDecrease = 0.5f;

    public void Split()
    {
        if(transform.localScale.x > 0.001f)
        {
            for(int i = 0; i < 2; i++)
            {
                GameObject newEnemy = Instantiate(enemy, transform.position, transform.rotation);
                newEnemy.transform.localScale = transform.localScale * scaleDecrease;
            }
        }

        Destroy(this.gameObject);
    }

}
