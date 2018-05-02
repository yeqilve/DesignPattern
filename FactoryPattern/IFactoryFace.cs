using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface IFactoryFace
    {
        Faco GetFaco();    
    }

    public class FactoryFace:IFactoryFace
    {
        public Faco GetFaco()
        {
            return new fac();
        }
    }

    public interface Faco
    {

    }

    public class fac : Faco
    {

    }
}
