namespace ProjetoContaApi.Models
{
 public class Conta
 {
 public long Id { get; set; }
 public string? Titular { get; set; }
 public string? email { get; set; }
 public int agencia { get; set; }
 public string? numero { get; set; }
 public string? tipoConta { get; set; }
 public double saldo { get; set; }
 }
}