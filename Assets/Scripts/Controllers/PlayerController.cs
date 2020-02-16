using UnityEngine.EventSystems;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    public LayerMask movementmask;

    public Interactable focus;

    Camera cam;
    PlayerMotor motor;
    
    void Start()
    {
        cam = Camera.main;
        motor = GetComponent<PlayerMotor>();
    }

    
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
            //this disables controll while hovering over ui
        }


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit clickpoint;

            if(Physics.Raycast(ray, out clickpoint, 100, movementmask))
            {
                //Move player to clickpoint position 
                motor.MoveToPoint(clickpoint.point);

                //Stop focusing any objects
                RemoveFocus();
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit clickpoint;

            if (Physics.Raycast(ray, out clickpoint, 100))
            {
                Interactable clickinteractable = clickpoint.collider.GetComponent<Interactable>();
                if (clickinteractable != null)
                {
                    SetFocus(clickinteractable);
                }
            }
        }
    }

    void SetFocus(Interactable newfocus)
    {
        if (newfocus != focus)
        {
            if (focus != null)
            {
                focus.OnDefocused();
            }
            focus = newfocus;
            motor.FollowTarget(newfocus);
        }

        newfocus.OnFocused(transform);
        
    }

    void RemoveFocus()
    {
        if (focus != null)
        {
            focus.OnDefocused();
        }
            
        focus = null;
        motor.StopFollowingTarget();
    }
}
