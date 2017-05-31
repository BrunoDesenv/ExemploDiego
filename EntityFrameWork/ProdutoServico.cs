using Entidade;
using EntityFrameWork.Contexto;

namespace EntityFrameWork
{
   public class ProdutoServico
    {
        public void Cadastro(Produto produto)
        {
            
            var bancoDeDados = new ContextoPadrao();

            bancoDeDados.Produto.Add(produto);

            bancoDeDados.SaveChanges();

        }
    }
}
