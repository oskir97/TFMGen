
using System;
using System.Text;
using System.Collections.Generic;
using TFMGen.ApplicationCore.Exceptions;
using TFMGen.ApplicationCore.EN.TFM;
using TFMGen.ApplicationCore.IRepository.TFM;
using TFMGen.ApplicationCore.CEN.TFM;



namespace TFMGen.ApplicationCore.CP.TFM
{
public partial class PistaCP : GenericBasicCP
{
public PistaCP(GenericSessionCP currentSession, GenericUnitOfWorkRepository unitRepo)
        : base (currentSession, unitRepo)
{
}
}
}
