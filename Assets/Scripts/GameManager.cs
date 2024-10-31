using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{   
    public static GameManager instance = null;

    private int coin = 0;

    [HideInInspector]
    public bool isGameOver = false;

    [SerializeField]
    private TextMeshProUGUI text;

    [SerializeField]
    private GameObject gmaeOverPanel;
    
    void Awake() {
        if(instance == null){
            instance = this;
        }
    }
    
    public void IncreaseCoin(){
        coin++;
        text.SetText(coin.ToString());
        
        if(coin%10==0){
            Player player = FindObjectOfType<Player>();
            if (player != null)
            {
                player.Upgrade();
            }
        }
    }
    
    public void SetGameOver(){
        isGameOver = true;
        
        EnemySpawner enemySpawner = FindObjectOfType<EnemySpawner>();
        if(enemySpawner != null){
            enemySpawner.StopEnemyRoutine();
        }

        Invoke("ShowGameOverPanel", 1f);
    }
    
    void ShowGameOverPanel(){
        gmaeOverPanel.SetActive(true);
    }
    
    public void PlayAgain(){
        SceneManager.LoadScene("Scene");
    }
    
}
