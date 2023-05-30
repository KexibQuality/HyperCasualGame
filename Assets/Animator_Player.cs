using System;
using System.Collections;
using System.Collections.Generic;
using LessonEntities.Scripts.Mechanics.Move;
using UnityEngine;

public class Animator_Player : MonoBehaviour
{
   [SerializeField] private Animator animator;

   [SerializeField] private MoveMechanics controller;

   private void LateUpdate()
   {
      if (controller.IsMoving)
      {
         animator.SetBool("Run", true);
      }
      else
      {
         animator.SetBool("Run", false);
      }
   }
}
