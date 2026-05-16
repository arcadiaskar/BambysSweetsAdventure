using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameObject winUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if (player.coins >= 150)
            {
                Time.timeScale = 0;
                winUI.SetActive(true);

            }
        }
    }
}
