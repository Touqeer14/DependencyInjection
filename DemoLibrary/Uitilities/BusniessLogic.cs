using System;


namespace DemoLibrary
{
    public class BusniessLogic : IBusniessLogic
    {
        ILogger _logger;
        IDataAccess _dataAccess;

        public BusniessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _logger = logger;
            _dataAccess = dataAccess;
        }
        public void ProcessData()
        {
            //Logger logger = new Logger();
            //DataAccess dataAccess = new DataAccess();

            _logger.Log("Strating the processing of data.");
             Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("ProcessedInfo");
            _logger.Log("Finished processing of the data.");
        }

    }
}
