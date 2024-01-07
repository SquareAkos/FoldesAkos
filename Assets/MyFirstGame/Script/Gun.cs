
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] KeyCode shootButton = KeyCode.Space;
    [SerializeField] GameObject bulletPrototype;
    private void Update()
    {
        if (Input.GetKeyDown(shootButton))
        {
            GameObject newBullet = Instantiate(bulletPrototype);
            newBullet.transform.position = transform.position;
            newBullet.transform.rotation = transform.rotation;
        }
    }
}
