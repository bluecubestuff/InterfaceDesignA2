using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour {

    public float boundaryX;
    public float speed;
    public GameObject gameController;

    private bool move;
    private int ID;

    private void Start()
    {
        move = true;
    }

    private void Update()
    {
        Vector3 newPostion = gameObject.GetComponent<RectTransform>().position;
        if (newPostion.x <= boundaryX)
        {
            if (move)
            {
                newPostion.x += speed * Time.deltaTime;
                gameObject.GetComponent<RectTransform>().position = newPostion;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check if collision on the right
        if (gameObject.transform.position.x < collision.gameObject.transform.position.x)
            move = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //check if collision on the left
        if (gameObject.transform.position.x < collision.gameObject.transform.position.x)
            move = true;
    }

    public void Clicked()
    {
        Debug.Log("Clicked!");
        GameController.PopTiles(this.gameObject);
    }

    public int GetID() { return ID; }
    public void SetID(int _id) { ID = _id; }
}
