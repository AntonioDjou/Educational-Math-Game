using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastar : MonoBehaviour {
    float distance = 10;

    private void OnMouseDrag() //Função para pegar a posição do mouse e copiá-la para mover o GameObject.
    {
        Vector3 MousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(MousePosition);
        transform.position = objPosition;
    }
}
