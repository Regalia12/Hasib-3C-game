using System;
using UnityEngine;


public class InputManager : MonoBehaviour

{
   public Action<Vector2> OnMoveInput;
   public Action<bool> OnSprintInput;
   public Action OnJumpInput;
   public Action OnClimbInput;
   public Action OnCancelClimb;
   public Action OnGlide;
   public Action OnChangePOV;

   private void Update()
   {
    CheckMovementInput();
    CheckSprintInput();
    CheckJumpInput();
    CheckCrouchInput();
    CheckChangePOVInput();
    CheckClimbInput();
    CheckGlideInput();
    CheckCancelInput();
    CheckPunchInput();
    CheckMainMenuInput();
   }
   private void CheckMovementInput()
   {
    float verticalAxis = Input.GetAxis("Vertical");
    float horizontalAxis = Input.GetAxis("Horizontal");
    Vector2 inputAxis = new Vector2(horizontalAxis, verticalAxis);
    if (OnMoveInput != null)
    {
      OnMoveInput(inputAxis);
    }
   }
   private void CheckSprintInput()
   {
   bool isHoldSprintInput = Input.GetKey(KeyCode.LeftShift)||
                           Input.GetKey(KeyCode.RightShift);
      if (isHoldSprintInput)
      {
         OnSprintInput(true);
      }
      else
      {
         OnSprintInput(false);
      }
   }
   private void CheckJumpInput()
   {
      bool isPressJumpInput = Input.GetKeyDown(KeyCode.Space);
      if (isPressJumpInput)
      {
         OnJumpInput();
      }
   }
   private void CheckCrouchInput()
   {
      bool isPressCrouchInput = Input.GetKeyDown(KeyCode.LeftControl)||
                              Input.GetKeyDown(KeyCode.RightControl);
      if (isPressCrouchInput)
      {
         Debug.Log("Crouch");
      }
   }
   private void CheckChangePOVInput()
   {
      bool isPressChangePOVInput = Input.GetKeyDown(KeyCode.Q);
      if (isPressChangePOVInput)
      {
         if (OnChangePOV != null)
         {
            OnChangePOV();
         }
      }
   }
   private void CheckClimbInput()
   {
      bool isPressClimbInput = Input.GetKeyDown(KeyCode.E);
      if (isPressClimbInput)
      {
         OnClimbInput();
      }
   }
   private void CheckGlideInput()
   {
      bool isPressGlideInput = Input.GetKeyDown(KeyCode.G);
      if (isPressGlideInput)
      {
         OnGlide();
      }
   }
   private void CheckCancelInput()
   {
      bool isPressCancelInput = Input.GetKeyDown(KeyCode.C);
      if (isPressCancelInput)
      {
         if (OnCancelClimb != null)
         {
            OnCancelClimb();
         }
      }
   }
   private void CheckPunchInput()
   {
      bool isPressPunchInput = Input.GetKeyDown(KeyCode.Mouse0);
      if (isPressPunchInput)
      {
         Debug.Log("Punch");
      }
   }
   private void CheckMainMenuInput()
   {
      bool isPressMainMenuInput = Input.GetKeyDown(KeyCode.Escape);
      if (isPressMainMenuInput)
      {
         Debug.Log("Back to Main Menu");
      }
   }
}

