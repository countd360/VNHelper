using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VNHelper
{
    public class VNHelperComponent : MonoBehaviour
    {
        // basic
        public object owner;
        public string id;

        public void ResetAllEvent()
        {
            // status and lifetime
            destroyEvent = null;
            enableEvent = null;
            disableEvent = null;
            becameVisibleEvent = null;
            becameInvisibleEvent = null;
            // GUI
            GUIEvent = null;
            updateEvent = null;
            fixedUpdateEvent = null;
            lateUpdateEvent = null;
            // collision
            collisionEnterEvent = null;
            collisionStayEvent = null;
            collisionExitEvent = null;
            // trigger
            triggerEnterEvent = null;
            triggerStayEvent = null;
            triggerExitEvent = null;
            // mouse
            mouseDownEvent = null;
            mouseDragEvent = null;
            mouseEnterEvent = null;
            mouseExitEvent = null;
            mouseOverEvent = null;
            mouseUpEvent = null;
            mouseUpAsButtonEvent = null;

            return;
        }

        // status and lifetime
        private void Start()
        {
            Console.WriteLine("VNHelperComponent Start");
        }

        public Action<object, string> destroyEvent = null;
        void OnDestroy()
        {
            if (destroyEvent != null)
            {
                destroyEvent(owner, id);
            }
        }

        public Action<object, string> enableEvent = null;
        void OnEnable()
        {
            if (enableEvent != null)
            {
                enableEvent(owner, id);
            }
        }

        public Action<object, string> disableEvent = null;
        void OnDisable()
        {
            if (disableEvent != null)
            {
                disableEvent(owner, id);
            }
        }

        public Action<object, string> becameVisibleEvent = null;
        void OnBecameVisible()
        {
            if (becameVisibleEvent != null)
            {
                becameVisibleEvent(owner, id);
            }
        }

        public Action<object, string> becameInvisibleEvent = null;
        void OnBecameInvisible()
        {
            if (becameInvisibleEvent != null)
            {
                becameInvisibleEvent(owner, id);
            }
        }

        // GUI
        public Action<object, string> GUIEvent = null;
        void OnGUI()
        {
            if (GUIEvent != null)
            {
                GUIEvent(owner, id);
            }
        }

        // update
        public Action<object, string> updateEvent = null;
        void Update()
        {
            if (updateEvent != null)
            {
                updateEvent(owner, id);
            }
        }

        public Action<object, string> fixedUpdateEvent = null;
        void FixedUpdate()
        {
            if (fixedUpdateEvent != null)
            {
                fixedUpdateEvent(owner, id);
            }
        }

        public Action<object, string> lateUpdateEvent = null;
        void LateUpdate()
        {
            if (lateUpdateEvent != null)
            {
                lateUpdateEvent(owner, id);
            }
        }

        // collision
        public Action<object, string, Collision> collisionEnterEvent = null;
        void OnCollisionEnter(Collision collisionInfo)
        {
            if (collisionEnterEvent != null)
            {
                collisionEnterEvent(owner, id, collisionInfo);
            }
        }

        public Action<object, string, Collision> collisionStayEvent = null;
        void OnCollisionStay(Collision collisionInfo)
        {
            if (collisionStayEvent != null)
            {
                collisionStayEvent(owner, id, collisionInfo);
            }
        }

        public Action<object, string, Collision> collisionExitEvent = null;
        void OnCollisionExit(Collision collisionInfo)
        {
            if (collisionExitEvent != null)
            {
                collisionExitEvent(owner, id, collisionInfo);
            }
        }

        // trigger
        public Action<object, string, Collider> triggerEnterEvent = null;
        void OnTriggerEnter(Collider other)
        {
            if (triggerEnterEvent != null)
            {
                triggerEnterEvent(owner, id, other);
            }
        }

        public Action<object, string, Collider> triggerStayEvent = null;
        void OnTriggerStay(Collider other)
        {
            if (triggerStayEvent != null)
            {
                triggerStayEvent(owner, id, other);
            }
        }

        public Action<object, string, Collider> triggerExitEvent = null;
        void OnTriggerExit(Collider other)
        {
            if (triggerExitEvent != null)
            {
                triggerExitEvent(owner, id, other);
            }
        }

        // mouse
        public Action<object, string> mouseDownEvent = null;
        void OnMouseDown()
        {
            if (mouseDownEvent != null)
            {
                mouseDownEvent(owner, id);
            }
        }

        public Action<object, string> mouseDragEvent = null;
        void OnMouseDrag()
        {
            if (mouseDragEvent != null)
            {
                mouseDragEvent(owner, id);
            }
        }

        public Action<object, string> mouseEnterEvent = null;
        void OnMouseEnter()
        {
            if (mouseEnterEvent != null)
            {
                mouseEnterEvent(owner, id);
            }
        }

        public Action<object, string> mouseExitEvent = null;
        void OnMouseExit()
        {
            if (mouseExitEvent != null)
            {
                mouseExitEvent(owner, id);
            }
        }

        public Action<object, string> mouseOverEvent = null;
        void OnMouseOver()
        {
            if (mouseOverEvent != null)
            {
                mouseOverEvent(owner, id);
            }
        }

        public Action<object, string> mouseUpEvent = null;
        void OnMouseUp()
        {
            if (mouseUpEvent != null)
            {
                mouseUpEvent(owner, id);
            }
        }

        public Action<object, string> mouseUpAsButtonEvent = null;
        void OnMouseUpAsButton()
        {
            if (mouseUpAsButtonEvent != null)
            {
                mouseUpAsButtonEvent(owner, id);
            }
        }

    }
}
