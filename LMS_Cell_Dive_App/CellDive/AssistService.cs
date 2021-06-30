using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS_Cell_Dive_App.CellDive
{
    public class AssistService
    {
        public CellDiveServices.AsistServiceClient asistServiceClient = new CellDiveServices.AsistServiceClient();

        public CellDiveServices.LogInResponse logInResponse;
        public CellDiveServices.LogInRequest logInRequest = new CellDiveServices.LogInRequest();
        public CellDiveServices.WorkListRequest workListRequest = new CellDiveServices.WorkListRequest();
        public CellDiveServices.WorkListResponse workListResponse = new CellDiveServices.WorkListResponse();
    }
}
