using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManger : MonoBehaviour
{
    public int playerScore = 0;
    public int cpuScore = 0;

    public Image playerCard;
    public Image cpuCard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDealButtonPressed()
    {
        // Generate 2 random numbers
        // [2, 15)
        int left = Random.Range(2, 15);
        int right = Random.Range(2, 15);
        // use random numbers to render card images
        playerCard.sprite = Instantiate<Sprite>(Resources.Load<Sprite>("card" + left));
        cpuCard.sprite = Instantiate(Resources.Load<Sprite>("card" + right));
        // compare numbers and determine winner
    }
}
