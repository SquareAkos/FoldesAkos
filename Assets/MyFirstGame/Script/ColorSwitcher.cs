
using UnityEngine;

class ColorSwitcher : MonoBehaviour
{
    [SerializeField] Gradient colors;
    //[SerializeField] Light light;
    [SerializeField] float frequence;

    private void Update()
    {
        float scaledTime = Time.time * frequence;
        float t = scaledTime % 1;
        if (((int)scaledTime) % 2 == 0)
            t = 1 - t;

        GetComponent<Light>().color = colors.Evaluate(t);
    }

}
