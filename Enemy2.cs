using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int score;

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
        if(other.tag == gameObject.tag){
            Destroy(other.gameObject);
            Destroy(gameObject);
            score++;
        }
        else{
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
