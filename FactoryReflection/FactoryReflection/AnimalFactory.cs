using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryReflection
{
    public static class AnimalFactory
    {
        public static Ianimal CreateAnimal(string selection) //method which create instance of the class and assigns to newAnimal

        {

            //gets correct class type and makes sure value is not null   
            var animalType = Assembly.GetCallingAssembly().GetTypes().Where(t => t.Name.Equals(selection, StringComparison.CurrentCulture)).FirstOrDefault();

            if (animalType == null) throw new Exception(string.Format("Type not found of selection: {0}", selection));
            //activiator to create new instance
            var newAnimal = (Ianimal)Activator.CreateInstance(animalType);

            return newAnimal;
        }

    }

}
