using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de clase "ServiceBancos" en el código, en svc y en el archivo de configuración a la vez.
public class ServiceBancos : IServiceBancos
{
    public List<Cuentas> GetCuentas()
    {
        return new List<Cuentas>
        {
            new Cuentas()
            {
                ReferenciaWCF = "Banco de Credito del Peru",
                IdEmpresa = 01,
                IdCuentaWCF=001,
                NumeroCuentaWCF="111-2054200423",
                MontoWCF=8590000
            },
        };
    }
}
