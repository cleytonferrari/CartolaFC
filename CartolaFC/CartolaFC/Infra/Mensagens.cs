namespace CartolaFC.Infra
{
    public class Mensagens
    {
        public struct Time
        {
            public const string NomeDeveSerpreenchido = "Preencha o nome do time.";
            public const string NomeDeveTerDe2A50Caracteres = "O Nome do time deve ter entre 2 a 50 caracteres.";
            public const string AnoDeFundacaoDeveSerPreenchido = "Preencha o ano de fundação do time.";
            public const string AnoDeFundacaoDeveTer4Caracteres = "O Ano de fundação deve ter 4 caracteres.";
        }

        public struct Tecnico
        {
            public const string NomeDeveSerpreenchido = "Preencha o nome do técnico.";
            public const string NomeDeveTerDe2A50Caracteres = "O Nome do técnico deve ter entre 2 a 50 caracteres.";
        }
    }
}