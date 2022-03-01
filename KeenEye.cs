using System;

namespace mis321_pa2_gfmoncivais.Interfaces
{
    public class KeenEye: IDefend
    {
        //be able to defend distract 
        public void Defend()
        {
            Console.WriteLine("Nice Try, but I won't be fooled!");
        }
    }
}
