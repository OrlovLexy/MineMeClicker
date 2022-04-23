using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickObj : MonoBehaviour
{
    private bool move;
    private Vector2 randomVector;
    private void Update()
    {
        if (!move) return;
        transform.Translate(randomVector * Time.deltaTime);
    }
    public void StartMotion(int scoreIncrease)
    {
        transform.localPosition = Vector2.zero;
        GetComponent<Text>().text = "+" + scoreIncrease;
        randomVector = new Vector2(Random.Range(-3, 3), Random.Range(-3, 3));
        move = true;
        GetComponent<Animation>().Play();
    }

    public void StopMotion()
    {
        move = false;
    }
}
