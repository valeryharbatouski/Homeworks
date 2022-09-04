
using UnityEngine;
using TMPro;

public class CoinsCounter : MonoBehaviour
{
    public TextMeshProUGUI coinsText;
    private int coinsCounter = 0;
    private GameObject coin;

    void Start()
    {
        coinsText.text = "0";
        gameObject.tag = "coin";
    }

    void Update()
    {

    }

    
    private void OnTriggerEnter(Collider other)
    {
        coinsCounter = coinsCounter + 5;
        coinsText.text = coinsCounter.ToString();
        Debug.Log("collected");
        Destroy(this.gameObject);
        
    }


    
}
