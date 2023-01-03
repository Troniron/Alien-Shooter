using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorarrow;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorarrow, Vector2.zero, CursorMode.ForceSoftware);
      // Cursor.visible = false;
        
    }
   /* public void// OnMouseEnter()
    {
        Cursor.SetCursor(Click, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void //OnMouseExit()
    {
        Cursor.SetCursor(cursorarrow, Vector2.zero, CursorMode.ForceSoftware);
    }*/

    // Update is called once per frame
    void Update()
    {
      //  Vector2 cursorpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      // transform.position = cursorpos;
    }
}
