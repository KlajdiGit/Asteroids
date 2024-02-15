/*using UnityEngine;

public class SplitResponse : Response
{
    private GameObject enemy;
    private Transform enemyTransform;
    private float scaleDecrease;
    private float speed;

    public SplitResponse(GameObject e, Transform t, float scale, float speed)
    {
        enemy = e;
        enemyTransform = t;
        scaleDecrease = scale;
        speed = speed;
    }

    public void UpdateTransform(Transform newTransform)
    {
        enemyTransform = newTransform;
    }

    public override void Dispatch()
    {
        // Define a random offset
        Vector3 randomOffset = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));

        // Add the random offset to the position
        GameObject newEnemy = Instantiate(enemy, enemyTransform.position + randomOffset, enemyTransform.rotation);
        newEnemy.transform.localScale = enemyTransform.localScale * scaleDecrease;

        // Copy properties from the parent target to the new target
        newEnemy.GetComponent<IsDestroyable>().enemy = enemy;
    }
}
*/