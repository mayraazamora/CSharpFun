using System.Collections;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public AudioClip pickupSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Make sure your player is tagged "Player"
        {
            //Play Sound
            if (pickupSound != null)
            {
                AudioSource tempSource = gameObject.AddComponent<AudioSource>();
                tempSource.clip = pickupSound;
                tempSource.volume = 0.1f;  // ← Set your desired volume (0.0 to 1.0)
                tempSource.Play();
                Destroy(tempSource, pickupSound.length); // Clean up after the sound is done
            }

            // Add score
            GameManager.Instance.AddScore(1);

            // Animate and destroy
            StartCoroutine(AnimateAndDestroy());

            IEnumerator AnimateAndDestroy()
            {
                float time = 0.2f;
                Vector3 originalScale = transform.localScale;
                Vector3 targetScale = originalScale * 1.5f;

                float t = 0;
                while (t < time)
                {
                    t += Time.deltaTime;
                    transform.localScale = Vector3.Lerp(originalScale, targetScale, t / time);
                    yield return null;
                }

                Destroy(gameObject);
            }
        }
    }
}