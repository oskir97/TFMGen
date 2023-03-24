
using System;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using System.Collections.Generic;

using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.ApplicationCore.CP.TFM;

namespace TFM_REST.CAD
{
public class PagoTipo_l10nRESTCAD : PagoTipo_l10nRepository
{
public PagoTipo_l10nRESTCAD()
        : base ()
{
}

public PagoTipo_l10nRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}
}
}
