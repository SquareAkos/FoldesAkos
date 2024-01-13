using UnityEngine;

public class FindTheClosest : MonoBehaviour
{
    [SerializeField] Transform closest;

    void Update()
    {
        MeshRenderer[] allRenderers = FindObjectsOfType<MeshRenderer>();

        if (allRenderers.Length == 0)
            return;

        Vector3 self = transform.position;

        float closestDistance = Vector3.Distance(allRenderers[0].transform.position, self);
        int closestIndex = 0;

        for (int i = 1; i < allRenderers.Length; i++)
        {
            float distance = Vector3.Distance(allRenderers[i].transform.position, self);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestIndex = i;
            }
        }

        closest = allRenderers[closestIndex].transform;
    }

    void OnDrawGizmos()
    {
        if (closest != null)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(closest.position, transform.position);
        }
    }

}
