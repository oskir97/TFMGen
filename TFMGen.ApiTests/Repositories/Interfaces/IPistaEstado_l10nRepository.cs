using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFMGen.ApiTests.Models;
using TFMGen.ApiTests.Models.DTOA;
using TFMGen.ApiTests.Services;

namespace TFMGen.ApiTests.Repositories.Interfaces
{
    public interface IPistaEstado_l10nRepository
    {
        public ResponseModel<List<PistaEstado_l10nDTOA>> Listar(int p_ididioma);

        public ResponseModel<List<PistaEstado_l10nDTOA>> Listartodos();

    }
}
