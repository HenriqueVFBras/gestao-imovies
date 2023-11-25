public partial class Program
{
    static void Main()
    {
        using (var contexto = new MeuContexto())
        {
            // Adicionar um senhorio
            var novoSenhorio = new Senhorio { Nome = "Novo Senhorio", Email = "email@dominio.com" };
            contexto.AdicionarSenhorio(novoSenhorio);

            // Consultar senhorios
            var senhorios = contexto.ConsultarSenhorios();
            foreach (var s in senhorios)
            {
                Console.WriteLine($"Senhorio: {s.Nome}, Email: {s.Email}");
            }

            // Atualizar um senhorio
            var senhorioParaAtualizar = senhorios.FirstOrDefault();
            if (senhorioParaAtualizar != null)
            {
                senhorioParaAtualizar.Nome = "Novo Nome do Senhorio";
                contexto.AtualizarSenhorio(senhorioParaAtualizar);
            }

            // Excluir um senhorio
            var senhorioParaExcluir = senhorios.LastOrDefault();
            if (senhorioParaExcluir != null)
            {
                contexto.ExcluirSenhorio(senhorioParaExcluir);
            }

            // Salvar as mudanças no banco de dados
            contexto.SaveChanges();
        }
    }
}


