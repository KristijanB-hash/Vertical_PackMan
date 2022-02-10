using UnityEngine;
using UnityEngine.UI;

public enum MouseClick
{
    LeftClick,
    RightClick,
    MiddleClick
}

public enum Direction
{
    Left, Right
}

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text scoreText;

    private int score = 0;


    private void Update()
    {
        /*UNITY_ANDROID
               if (Input.GetMouseButton((int)MouseClick.LeftClick))                      //dvizenje so mouse 
               {
                   float midScreenXPos = Screen.width / 2f;

                   if (Input.mousePosition.x < midScreenXPos)
                       MoveX(Direction.Left);
                   else
                       MoveX(Direction.Right);
               }
               */

        // sakame da proverime koga kje stisneme na left / right arrow

        Vector3 newPosition = transform.position;

        if (Input.GetKey(KeyCode.LeftArrow) && newPosition.x > -9.2f)     //nemoze da ja pomine newPosition.x povekje od 9.2.... na levo
            {
                newPosition.x -= speed * Time.deltaTime;
                transform.position = newPosition;

                //Debug.Log("Left arrow on keyboard was pressed");
            }
            else if (Input.GetKey(KeyCode.RightArrow) && newPosition.x < 9.2f)
            {
                newPosition.x += speed * Time.deltaTime;
                transform.position = newPosition;

                //Debug.Log("Right arrow on keyboard was pressed");
            }

    }

    private void MoveX(Direction direction)
    {
        Vector3 newPosition = transform.position;
        if (direction == Direction.Left)
            newPosition.x -= speed * Time.deltaTime;
        else
            newPosition.x += speed * Time.deltaTime;

        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);

        if (collision.gameObject.tag == "Cherry")
        {
            score--;
            scoreText.text = "Score: " + score;
        }

        else
        {
            score++;
            scoreText.text = "Score: " + score;
        }


    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    //Debug.Log("PlayerController::OnCollisionEnter2D");
    //    //collision.gameObject.SetActive(false);

    //    Destroy(collision.gameObject);

    //    // zgolemi ja vrednosta na score
    //    score++;
    //    scoreText.text = "Score: " + score;
    //}
}
