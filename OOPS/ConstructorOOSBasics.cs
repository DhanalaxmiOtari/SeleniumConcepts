using System;

namespace OOPS
{
        class ConstructorOOSBasics
        {
            public int intensity;
            public string name;
        public ConstructorOOSBasics()
        {
            Console.WriteLine("I m in deafult contructor");
        }
            public ConstructorOOSBasics(int intensity, string name)
            {
                this.intensity = intensity;
                this.name = name;
                Console.WriteLine("I am in the parametrize constructor.{0} and {1}", intensity, name);
            }

            public static void Main(string[] args)
            {
            ConstructorOOSBasics motorbike2 = new ConstructorOOSBasics();
            ConstructorOOSBasics motorbike1 = new ConstructorOOSBasics(9, "dhanu");
                
                Console.WriteLine("Parametrize Contructor motorbike.intensity " + motorbike1.intensity +"Name -"+ motorbike1.name);
                Console.WriteLine("Deafualt Contructor motorbike.intensity = " + motorbike2.intensity+ " , motorbike.name = " + motorbike2.name);
            }

        }
    

}
