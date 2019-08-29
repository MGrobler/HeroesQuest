using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
  private int score;
  public Text PlayerScoreTxtElem;
  // Start is called before the first frame update
  void Start()
  {
    score = 0;
    PlayerScoreTxtElem.text = string.Format("{0} \n Score", score.ToString());
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void IncrementScore()
  {
    score++;
    PlayerScoreTxtElem.text = string.Format("{0} \n Score", score.ToString());
  }

  public void ResetScore()
  {
    score = 0;
    PlayerScoreTxtElem.text = string.Format("{0} \n Score", score.ToString());
  }
}
