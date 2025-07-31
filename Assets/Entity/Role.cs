using UnityEngine;


public abstract class Role
{
        public EWinSide winSide;

        protected abstract void NightAction();

        protected abstract void DayAction();
}