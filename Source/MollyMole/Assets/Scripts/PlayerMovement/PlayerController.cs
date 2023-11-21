using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScoreText();
    }
    [SerializeField] private float _speed = 1;
    // Update is called once per frame
    void Update()
    {
//  Vector3 = x,y,z position of an object
//  Underneath si the code to make the player move
        var dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(dir * _speed * Time.deltaTime);
    }

    void SetScoreText(){
        // displays on the ui as the score
       scoreText.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other) {

        SetScoreText();
    }
}
