using UnityEngine;
using System; // not used

namespace CompanyName.UEPT.Runtime
{
    public class LinterViolator
    {
        private int Foo;
        public string _Bar;

        private void MakeFoo()
        {
            Debug.Log("I do nothing");
        }

        public string BakeBar()
        {
            return this._Bar;
        }
        
    }
}