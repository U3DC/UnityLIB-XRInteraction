﻿using System.Collections.Generic;
using Fjord.XRInteraction.XRInteractors;
using Fjord.XRInteraction.XRUser;
using UnityEngine;
using UnityEngine.Events;

namespace Fjord.XRInteraction.Attachables
{
    [System.Serializable]
    public class AttachableUnityEvent : UnityEvent<Attachable>
    { }
}