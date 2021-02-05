using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    void Update()
    {
        scoreText.text = (player.position.z + 498).ToString("0"); // z of player is -498, so the score will start from 000
    }
}
