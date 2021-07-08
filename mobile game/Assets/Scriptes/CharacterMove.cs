

using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public Transform Player;

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
                    Player.position = Vector2.MoveTowards(Player.position, new Vector2(7.8f, Player.position.y), Characteristics.speedChar * Time.deltaTime);
                else
                {
                    Player.rotation = Quaternion.Euler(0, 0, 0);
                    IsDirectionRight = true;
                }
            else if (Input.GetKey(KeyCode.A))
                if(IsDirectionRight == false)
                    Player.position = Vector2.MoveTowards(Player.position, new Vector2(-7.9f, Player.position.y), Characteristics.speedChar * Time.deltaTime);
                else
                {
                    Player.rotation = Quaternion.Euler(0,180,0);
                    IsDirectionRight = false;
                }


        }

    }

}


