using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScript1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="KoeniggBackButton"){
            Debug.Log("Collision Detected");
            SceneManager.LoadScene("SampleScene");
        }
    }
}
