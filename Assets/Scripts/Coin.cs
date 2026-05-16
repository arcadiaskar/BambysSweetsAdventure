using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public AudioClip coinClip;
    private TextMeshProUGUI coinText;

    private void Start()
    {
        coinText = GameObject.FindWithTag("CoinText").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 3;
            player.PlaySFX(coinClip, 0.4f);

 //           if(player.coins == 5)
 //           {
 //               player.extraJumpValue++;
 //               player.addExtraJumps();
 //               player.coins = 0;
 //           }

            coinText.text = player.coins.ToString();
            //coinText.text = player.coins;

            Destroy(gameObject);
        }
    }
}
