using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        hitCount++;
        Debug.Log("Collision Detected with " + collision.gameObject.name + " " + hitCount + " times.");
    }
}
