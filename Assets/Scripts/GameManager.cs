using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject Ball;

    [Header("Player 1")]
    public GameObject Player1;
    public GameObject Player1Goal;

    [Header("Player 2")]
    public GameObject Player2;
    public GameObject Player2Goal;


    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        Ball.GetComponent<Ball>().Reset();
        Player1.GetComponent<PlayerController>().Reset();
        Player2.GetComponent<PlayerController>().Reset();
    }
}
