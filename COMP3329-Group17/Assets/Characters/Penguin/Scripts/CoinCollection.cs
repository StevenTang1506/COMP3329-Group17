using UnityEngine;

public class WinterCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Make sure your player GameObject has the tag "Player"
        {
            // Optionally, play a sound or animation
            // CoinManager.Instance.AddCoins(1); // Add 1 coin to the total count
            Destroy(gameObject); // Destroy the coin object
        }
    }
}