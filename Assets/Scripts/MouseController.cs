using UnityEngine;

public class MouseController : MonoBehaviour
{
    RaycastHit hit;
   
    private void Update()
    {
        Inputs();
    }
    private void Inputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Raycast();
        }
    }
    private void Raycast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit))
        {
            IClickable iclickable=hit.collider.gameObject.GetComponent<IClickable>();
            if (iclickable!=null)
            {
                iclickable.Click();
            }
        }
    }
}
