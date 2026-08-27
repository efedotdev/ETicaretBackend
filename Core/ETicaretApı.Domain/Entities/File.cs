using System.ComponentModel.DataAnnotations.Schema;
using ETicaretApı.Domain.Entities.Common;

namespace ETicaretApı.Domain.Entities;

public class File : BaseEntity
{
    [NotMapped] public override DateTime ModifiedDate { get; set; }

    public string FileName { get; set; }
    public string Storage { get; set; }
    public string Path { get; set; }
}