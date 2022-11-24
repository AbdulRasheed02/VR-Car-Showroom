using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript1 : MonoBehaviour
{

    public Renderer myobj;
    public float rft,bft,gft,aft;
    public Color mycol; 

    public GameObject test;

    void OnCollisionEnter(Collision col){
        if(col.gameObject.name=="KoeniggButton"){
            Debug.Log("Collision Detected");
            SceneManager.LoadScene("Interior1");
        }
        
        if(col.gameObject.name=="KoeniggColorChange"){
            Debug.Log("Color Changed");
            test = GameObject.Find("uploads_files_2792345_Koenigsegg");
            Transform[] ts = test.transform.GetComponentsInChildren<Transform>(true);
            Material newMat = Resources.Load("MyColor", typeof(Material)) as Material;
            foreach (Transform t in ts){
                if (t.gameObject.name == "Body"){
                    t.GetComponent<Renderer>().material = newMat;
                } 
            } 
            
        }
        if(col.gameObject.name=="KoeniggColorChange2"){
            Debug.Log("Color Changed");
            test = GameObject.Find("uploads_files_2792345_Koenigsegg");
            Transform[] ts = test.transform.GetComponentsInChildren<Transform>(true);
            Material newMat = Resources.Load("MyColor2", typeof(Material)) as Material;
            foreach (Transform t in ts){
                if (t.gameObject.name == "Body"){
                    t.GetComponent<Renderer>().material = newMat;
                } 
            } 
            
        }
    }
}

