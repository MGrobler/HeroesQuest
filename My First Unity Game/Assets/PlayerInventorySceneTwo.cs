using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventorySceneTwo : MonoBehaviour
{
  private int _score;
  public Text CurrentScore;
  // Start is called before the first frame update
  void Start()
  {
    _score = PlayerPrefs.GetInt("PreviousScore");
    UpdateScoreText(_score);
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void IncrementScore()
  {
    _score++;
    UpdateScoreText(_score); ;
  }


  private void UpdateScoreText(int score)
  {
    if (this.CurrentScore != null)
    {
      CurrentScore.text = string.Format("{0}\nScore", score.ToString());
    }
  }
}
