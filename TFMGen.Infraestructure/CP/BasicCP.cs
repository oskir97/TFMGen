

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.ApplicationCore.CP.TFM;
using TFMGen.Infraestructure.Repository;

namespace TFMGen.Infraestructure.CP
{
public class BasicCPNHibernate : GenericBasicCP
{
protected ISession session;

protected ITransaction tx;


protected BasicCPNHibernate(SessionCPNHibernate sessionCP, UnitOfWorkRepository unitRepo) : base (sessionCP, unitRepo)
{
        session = (ISession)sessionCP.CurrentSession;
}
}
}

