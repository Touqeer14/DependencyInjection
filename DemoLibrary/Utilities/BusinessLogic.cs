﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary.Utilities;

namespace DemoLibrary.Utilities
{
    public class BusinessLogic : IBusinessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;
        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            _logger.Log("Starting the processing of data.");
            Console.WriteLine("processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processing");
            _logger.Log("Finished processing of the data.");
        }

    }
}
