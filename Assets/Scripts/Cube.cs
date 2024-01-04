using UnityEngine;

public class Cube : MonoBehaviour, IClickable
{
    private Color color;
    private void Start()
    {
        color = Color.blue;
    }
    public void Click()
    {
        ChangeColor();
    }
    private void ChangeColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = color;
    }
}
