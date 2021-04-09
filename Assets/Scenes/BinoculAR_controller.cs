using System.Collections.Generic;
using GoogleARCore;
using GoogleARCore.Examples.Common;
using UnityEngine;
using UnityEngine.EventSystems;

public class BinoculAR_controller : MonoBehaviour{

    public InstantPlacementMenu InstantPlacementMenu;

    public Camera FirstPersonCamera;

    public GameObject sceneObjects;

    private const float _prefabRotation = 180.0f;

    public void Awake(){
        Application.targetFrameRate = 60;
    }

    public void Update(){
        // If the player has not touched the screen, we are done with this update.
/*        Touch touch;
        if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began){
            return;
        }

        // Should not handle input if the player is pointing on UI.
        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId)){
            return;
        }

        // Raycast against the location the player touched to search for planes.
        TrackableHit hit;
        bool foundHit = false;
        if (InstantPlacementMenu.IsInstantPlacementEnabled()){
            foundHit = Frame.RaycastInstantPlacement(
                touch.position.x, touch.position.y, 1.0f, out hit);
        }

        if (foundHit){
            var anchor = hit.Trackable.CreateAnchor(hit.Pose);

            var gameObject = sceneObjects;
            gameObject.transform.position = FirstPersonCamera.transform.position;
            // Make game object a child of the anchor.
            gameObject.transform.parent = anchor.transform;
        }*/
    }
}

/*
public class BinoculAR_controller : MonoBehaviour
{
    public InstantPlacementMenu InstantPlacementMenu;

    public Camera FirstPersonCamera;

    public GameObject BunnyObject;


    private const float _prefabRotation = 180.0f;
    // Start is called before the first frame update
    void Start()
    {
        // Instantiate prefab at the hit pose.
        var gameObject = Instantiate(BunnyObject, FirstPersonCamera.transform.position, Quaternion.identity);

        // Compensate for the hitPose rotation facing away from the raycast (i.e.
        // camera).
        //gameObject.transform.Rotate(0, _prefabRotation, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch;
        if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
        {
            return;
        }

        // Should not handle input if the player is pointing on UI.
        if (EventSystem.current.IsPointerOverGameObject(touch.fingerId))
        {
            return;
        }

        TrackableHit hit;
        bool foundHit = false;
        if (InstantPlacementMenu.IsInstantPlacementEnabled())
        {
            foundHit = Frame.RaycastInstantPlacement(
                touch.position.x, touch.position.y, 1.0f, out hit);
        }
        else
        {
            TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinPolygon |
                TrackableHitFlags.FeaturePointWithSurfaceNormal;
            foundHit = Frame.Raycast(
                touch.position.x, touch.position.y, raycastFilter, out hit);
        }

        if (foundHit)
        {
            // Use hit pose and camera pose to check if hittest is from the
            // back of the plane, if it is, no need to create the anchor.
            if ((hit.Trackable is DetectedPlane) &&
                Vector3.Dot(FirstPersonCamera.transform.position - hit.Pose.position,
                    hit.Pose.rotation * Vector3.up) < 0)
            {
                Debug.Log("Hit at back of the current DetectedPlane");
            }
            else
            {
             

                // Instantiate prefab at the hit pose.
                var gameObject = Instantiate(BunnyObject, FirstPersonCamera.transform.position, hit.Pose.rotation);

                // Compensate for the hitPose rotation facing away from the raycast (i.e.
                // camera).
                gameObject.transform.Rotate(0, _prefabRotation, 0, Space.Self);

                // Create an anchor to allow ARCore to track the hitpoint as understanding of
                // the physical world evolves.
                var anchor = hit.Trackable.CreateAnchor(hit.Pose);

                // Make game object a child of the anchor.
                gameObject.transform.parent = anchor.transform;

            }
        }
    }
}

*/