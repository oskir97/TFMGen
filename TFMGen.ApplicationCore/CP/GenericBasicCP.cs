

using System;
using System.Collections.Generic;
using TFMGen.ApplicationCore.IRepository.TFM;

namespace TFMGen.ApplicationCore.CP.TFM
{
public abstract class GenericBasicCP
{
protected GenericSessionCP CPSession;
protected GenericUnitOfWorkRepository unitRepo;
protected GenericBasicCP (GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
{
        this.CPSession = currentSession;
        this.unitRepo = unitRepo;
}
}
}

