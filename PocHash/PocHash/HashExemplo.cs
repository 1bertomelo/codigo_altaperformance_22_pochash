using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocHash
{
	public class HashExemplo : IHash<int>
	{
		private int?[] Vetor { get; set; }
		public int N { get; private set; }

		public int QtdeInserida { get; private set; }

		public HashExemplo(int tamanho)
		{
			Vetor = new int?[tamanho];
			N = tamanho;
			QtdeInserida = 0;

		}

		public int Busca(int item)
		{
			return 1;
		}

		public void Inserir(int item)
		{
			//int posicao = FuncoHashModular(item);
			if(N == QtdeInserida)
				throw new NotImplementedException("Não é possível inserir, vetor sem espaço");
			else
			{
				int i = 0;
				bool inseriu=false;

				while (!inseriu)
				{
					int posicao = FuncoHashModular(item+i);
					if (PosicaoVazia(posicao))
					{
						Vetor[posicao] = item;
						inseriu = true;
						QtdeInserida++;
					}
					else
					{
						i++;
					}

				}
			}
		}

		private int FuncoHashModular(int x)
		{
			return x % N;
		}

		private bool PosicaoVazia(int posicao) => Vetor[posicao] == null ? true : false;


	}
}
