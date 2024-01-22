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
        targetCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        scoreGui.text = score.ToString();
        targetCountGui.text = targetCount.ToString();
    }

}
