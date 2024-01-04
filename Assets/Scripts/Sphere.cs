using UnityEngine;

public class Sphere : MonoBehaviour,IClickable
{
 
    public void Click()
    {
        ScaleToHalf();
    }
    private void ScaleToHalf()
    {
        transform.position += Vector3.up;
    }
}
