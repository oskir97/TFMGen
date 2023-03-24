
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
public class PistaEstado_l10nRESTCAD : PistaEstado_l10nRepository
{
public PistaEstado_l10nRESTCAD()
        : base ()
{
}

public PistaEstado_l10nRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}
}
}
