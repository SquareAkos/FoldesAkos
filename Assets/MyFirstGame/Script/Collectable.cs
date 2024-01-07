
using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField] Bounds teleportArea;
    void OnTriggerEnter(Collider other)

    {
        Collector Collector = other.GetComponent<Collector>();
        if (Collector != null)
        {
            Collector.GetCoin();
            OnCollect();
            //Destroy(gameObject);
        }
    
        
    }

    public void OnCollect()
    {
        float x = Random.Range(teleportArea.min.x, teleportArea.max.x);
        float y = Random.Range(teleportArea.min.y, teleportArea.max.y);
        float z = Random.Range(teleportArea.min.z, teleportArea.max.z);
        Vector3 newPosition = new(x, y, z);
        transform.position = newPosition;
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.black;
        Gizmos.DrawWireCube(teleportArea.center, teleportArea.size);
    }

}
