using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        int Speed = -1;
        int upSpeed = (score * -1) / 50;
        if(upSpeed < -5)
        {
            upSpeed = -5;
        }
        return Speed + upSpeed;
    }
}
