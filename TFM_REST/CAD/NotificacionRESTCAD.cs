
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
public class NotificacionRESTCAD : NotificacionRepository
{
public NotificacionRESTCAD()
        : base ()
{
}

public NotificacionRESTCAD(GenericSessionCP sessionAux)
        : base (sessionAux)
{
}
}
}
