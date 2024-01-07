using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] int coin;
    [SerializeField] TMP_Text coinText;

    private void Start()
    {
        coinText.text = "Coin number: " + coin.ToString();
    }
    public void GetCoin()
    {
        coin += 1;
        coinText.text = "Coin number: " + coin.ToString();
    }
        
}
