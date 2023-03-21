using Microsoft.AspNetCore.Mvc;
using TFMGen.Infraestructure.CP;
using TFMGen.Infraestructure.Repository;
using TFMGen.Infraestructure.Repository.TFM;
using TFMGen.ApplicationCore.CP.TFM;


namespace TFM_REST.Controllers
{
public class BasicController : ControllerBase
{
protected GenericSessionCP session;
protected UnitOfWorkRepository unitRepo;

protected BasicController()
{
        session = new SessionCPNHibernate ();
        unitRepo = new UnitOfWorkRepository ((SessionCPNHibernate)session);
}

#region Individual Security

protected bool IsLoginID (string id)
{
        return(User.Identity.Name == id);
}

protected void Security (string id)
{
        if (User.Identity.Name == id) StatusCode (403);
}

#endregion
}
}
