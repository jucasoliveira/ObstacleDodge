using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    public void HandleHit()
    {
        if (gameObject.CompareTag("Hit")) return;
        Debug.Log("Collision Detected with " + gameObject.name);
        GetComponent<MeshRenderer>().material.color = Color.black;
        gameObject.tag = "Hit";
    }

}
