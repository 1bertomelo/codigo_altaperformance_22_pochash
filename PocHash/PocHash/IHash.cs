using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocHash
{
	public interface IHash<T>
	{
		public void Inserir(T item);	
		public T Busca(T item);
	}
}
