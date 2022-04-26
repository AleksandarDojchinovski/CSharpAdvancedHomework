using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generic
{
    public class PetStore<T> where T: Pet
    {
        public List<T> PetsList = new List<T>();
		public void PrintPets()
		{
			Console.WriteLine("Pet list: ");
			foreach (T item in PetsList)
			{
				Console.WriteLine(item.Name);
			}
		}
		public void BuyPet(string input)
		{
			var firstMatch = PetsList.FirstOrDefault(s => s.Name == input);
			PetsList.Remove(firstMatch);
		}
	}
}
