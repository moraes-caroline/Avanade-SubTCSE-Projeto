namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Entities
{
    public record EmployeeRole //Somente estado, record garante imutabilidade
    {
        public EmployeeRole(string id, string roleName) //Não garante imutabilidade
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; private set; }

        public string RoleName { get; init; }

    }
}

