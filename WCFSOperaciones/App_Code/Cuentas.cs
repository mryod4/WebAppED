using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cuentas
/// </summary>
public class Cuentas
{
    public int IdCuentaWCF { get; set; }

    public string ReferenciaWCF { get; set; }

    public string NumeroCuentaWCF { get; set; }

    public float MontoWCF { get; set; }

    public int IdEmpresa { get; set; }
    [ForeignKey("IdEmpresa")]

    public virtual Empresa Empresa { get; set; }

}