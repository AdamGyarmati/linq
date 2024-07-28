using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linq
{
    public class ConfirmationToken
    {
        [Key]
        [Column("token_id")]
        public long TokenId { get; set; }

        [Column("confirmation_token")]
        public string ConfirmationTokenValue { get; set; }

        [Column("created_date")]
        public DateTime? CreatedDate { get; set; }

        [Column("user_id")]
        public long UserId { get; set; }

        public virtual Account Account { get; set; }

        public override string ToString()
        {
            return $"TokenId: {TokenId}, ConfirmationTokenValue: {ConfirmationTokenValue}, CreatedDate: {CreatedDate}, UserId: {UserId}";
        }
    }
}
