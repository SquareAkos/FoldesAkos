using UnityEngine;

class AirJumpRefill : MonoBehaviour
{
    [SerializeField] bool destroyOnCollect = true;
    [SerializeField] float disableTime = 2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Platformer2DController pc = collision.GetComponent<Platformer2DController>();
        if (pc != null)
        {
            pc.RefillAirJump();
            if (destroyOnCollect)
            { 
                Destroy(gameObject); 
            }
            else
            {
                SetEnable(false);
                Invoke(nameof(SetEnableTrue), disableTime); // késleltetett végrehajtás

                

            }            
           
        }
    }

    void SetEnableTrue() { SetEnable(true);  }
    void SetEnable(bool enable)
    {
        Renderer renderer = GetComponent<Renderer>();
        Collider2D collider = GetComponent<Collider2D>();

        if (renderer != null)
        {
            renderer.enabled = enable;
        }
        if (collider != null)
        {
            collider.enabled = enable;
        }
    }
}