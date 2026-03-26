using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            HandleHit();
        }
    }

    public void HandleHit()
    {
        if (gameObject.CompareTag("Hit")) return;
        Debug.Log("Collision Detected with " + gameObject.name);
        GetComponent<MeshRenderer>().material.color = Color.black;
        gameObject.tag = "Hit";
    }

}
