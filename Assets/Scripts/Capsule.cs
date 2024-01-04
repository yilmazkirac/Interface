using UnityEngine;

public class Capsule : MonoBehaviour, IClickable
{
    private Vector3 scale;
    private void Start()
    {
        scale = transform.localScale;
    }
    public void Click()
    {
        ScaleToHalf();
    }
    private void ScaleToHalf()
    {
        transform.localScale = scale/2;
    }
}
