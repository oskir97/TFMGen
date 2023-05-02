
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
public class Deporte_l10nRESTCAD : Deporte_l10nRepository
{
public Deporte_l10nRESTCAD()
        : base ()
{
}

public Deporte_l10nRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}
}
}
