using System.Collections.Generic;

namespace ProjetoTeste
{
    public class listaAluno
    {
        private List<Aluno> Lista = new List<Aluno>();

        public void adicionar(Aluno aluno)
        {
            Lista.Add(aluno);
        }

        public double totalizar()
        {
            double total = 0;
            for(int i = 0; i < Lista.Count; i = i + 1)
            {
                total = total + Lista[i].nota;
            }

            return total;
        }
    }
}
