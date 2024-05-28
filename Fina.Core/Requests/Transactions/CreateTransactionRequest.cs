using Fina.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Transactions
{
    public class CreateTransactionRequest : Request
    {
        [Required(ErrorMessage ="Titulo Invalido")]
        public string Title { get; set; } = string.Empty;
        [Required(ErrorMessage ="Tipo Invalido")]
        public ETransactionType Type { get; set; } = ETransactionType.Deposit;
        [Required(ErrorMessage ="Valor Invalido")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage ="Categoria Inválida")]
        public long CategoryId { get; set; }
        [Required(ErrorMessage ="Data Invalida")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}
