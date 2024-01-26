using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score;
    public int targetCount;

    [SerializeField] private TextMeshProUGUI scoreGui;
    [SerializeField] private TextMeshProUGUI targetCountGui;
    [SerializeField] private TextMeshProUGUI winGame;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        Init();
    }

    private void Init()
    {
        score = 0;
        //targetCount = 1;
      
    }

    private void CheckIsDestroyable()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        int isDestroyableCount = 0;
        foreach (GameObject obj in allObjects)
        {
            if (obj.gameObject.GetComponent<IsDestroyable>())
            {
                isDestroyableCount++;
            }
        }
        targetCount = isDestroyableCount;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsDestroyable();

        scoreGui.text = score.ToString();
        targetCountGui.text = targetCount.ToString();
        if (GameManager.Instance.targetCount == 0)
        {
            winGame.text = "YOU WIN!!!";
        }
    }

}
