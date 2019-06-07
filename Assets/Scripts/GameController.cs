using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text countText;
    public Text coinsRemainingText;
    public GameObject gameMenu;

    int count;
    int coinsNumber;

    public void CollectCoin() 
    {
        count++;
        SetGameInfo();
    }

    void Start()
    {
        count = 0;
        coinsNumber = GameObject.FindGameObjectsWithTag("coins").Length;
        SetGameInfo();
    } 
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            gameMenu.SetActive(true); 
        }
    }  

    void SetGameInfo()
    {
        countText.text = $"Score: {count}";
        coinsRemainingText.text = $"Coins remaining: {coinsNumber - count}";

        if (count < coinsNumber) return;

        Time.timeScale = 0;
    }
}