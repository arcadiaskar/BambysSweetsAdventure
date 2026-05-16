using UnityEngine;
using TMPro;

public class Silver : MonoBehaviour
{
    public AudioClip silverClip;
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
            player.coins += 1;
            player.PlaySFX(silverClip, 0.4f);

            coinText.text = player.coins.ToString();
            //coinText.text = player.coins;

            Destroy(gameObject);
        }
    }
}

