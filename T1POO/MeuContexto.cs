using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using (SqlConnection connection = new SqlConnection("https://github.com/HenriqueVFBras/gestao-imovies.git"))
{
    connection.Open();
    // Perform database operations here
}

public class MeuContexto : DbContext
{
    public DbSet<Senhorio> Senhorios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("https://github.com/HenriqueVFBras/gestao-imovies.git");
    }
    // Método para adicionar um senhorio
    public void AdicionarSenhorio(Senhorio senhorio)
    {
        Senhorios.Add(senhorio);
        SaveChanges();
    }
    public List<Senhorio> ConsultarSenhorios()
    {
        return Senhorios.ToList();
    }
    public void AtualizarSenhorio(Senhorio senhorio)
    {
        // Lógica para atualizar o senhorio no contexto
        // Por exemplo: Senhorios.Update(senhorio);
        SaveChanges();
    }
    public void ExcluirSenhorio(Senhorio senhorio)
    {
        // Lógica para excluir o senhorio do contexto
        // Por exemplo: Senhorios.Remove(senhorio);
        SaveChanges();
    }
}

