using UnityEngine;

public class FindTheClosest : MonoBehaviour
{
    [SerializeField] Transform[] objects;
    [SerializeField] Transform closest;

    void Update()
    {
        if (objects.Length == 0)
            return;

        Vector3 self = transform.position;

        float closestDistance = Vector3.Distance(objects[0].position, self);
        int closestIndex = 0;

        for (int i = 1; i < objects.Length; i++)
        {
            float distance = Vector3.Distance(objects[i].position, self);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestIndex = i;
            }
        }

        closest = objects[closestIndex];
    }


}
