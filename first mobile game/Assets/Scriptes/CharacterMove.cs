

using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform Player;
    [SerializeField]
    private float speed = 10f;

    bool IsDirectionRight = true;
    void Update()
    {
        OnMouseDrag();
    }
    void OnMouseDrag()
    {
        if (!Character.lose)
        {
            if (Input.GetKey(KeyCode.D))
                if (IsDirectionRight == true)
                    Player.position = Vector2.MoveTowards(Player.position, new Vector2(8.2f, Player.position.y), speed * Time.deltaTime);
                else
                {
                    Player.rotation = Quaternion.Euler(0, 0, 0);
                    IsDirectionRight = true;
                }
            else if (Input.GetKey(KeyCode.A))
                if(IsDirectionRight == false)
                    Player.position = Vector2.MoveTowards(Player.position, new Vector2(-8.2f, Player.position.y), speed * Time.deltaTime);
                else
                {
                    Player.rotation = Quaternion.Euler(0,180,0);
                    IsDirectionRight = false;
                }


        }

    }

}


