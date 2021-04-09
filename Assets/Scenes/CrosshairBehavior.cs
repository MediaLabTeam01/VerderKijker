using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CrosshairBehavior : MonoBehaviour {

    [SerializeField]
    private Image _crosshair;
    public Camera FirstPersonCamera;
    public GameObject tree;
    public GameObject rabbit;

    void FixedUpdate(){
        RaycastHit hitinfo;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        //Cast a ray into the gameworld from the center of the screen (where the crosshair is) and get back info on what you hit
        Transform cameraTransform = Camera.main.transform;

        if (Physics.Raycast(cameraTransform.transform.position, fwd, out hitinfo)) {
            //Null check to see if you actually hit something
            if (hitinfo.collider != null) {
                _crosshair.color = new Color32 (0,255,0,255);

                if(hitinfo.collider.tag == "rabbit"){
                    rabbit.SetActive(true);
                    var rabbitRenderer = rabbit.GetComponent<Renderer>();
                    rabbitRenderer.material.SetColor("_Color", new Color32(233, 110, 70, 1));
                }else if(hitinfo.collider.tag == "tree"){
                    tree.SetActive(true);
                    var treeRenderer = tree.GetComponent<Renderer>();
                    treeRenderer.material.SetColor("_Color", new Color32(233, 110, 70, 1));
                }
            }
            
        }
        else
        {
            rabbit.SetActive(false);
            tree.SetActive(false);
        }
    }
}