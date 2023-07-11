using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public static int BlocksInMoment;
    public void onClick()
    {
        SceneManager.LoadScene(1);
        BlocksInMoment = Pool.BlocksCount - Pool.BombsCount;
    }
}
