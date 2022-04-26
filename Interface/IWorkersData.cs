using System;
using System.Collections.Generic;
using Todo_APP.Models;

namespace Todo_APP.Interface
{
   public interface IWorkersData
    {
        List<Workers> GetWorkers();

        Workers GetWorkers(Guid Id);

        Workers AddWorker(Workers workers);

        Workers EditWorker(Workers workers);

        void DeleteWorker(Workers workers);
    }
}
