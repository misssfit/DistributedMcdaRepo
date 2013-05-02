namespace CalculatingEngine
{
    public static class Configuration
    {
        public static int TasksCalculationTimeout { get; set; }
        public static int CalculatedTasksTimeout { get; set; }

        public static int TasksCalculationTimeoutCheckInterval { get; set; }
        public static int CalculatedTasksTimeoutCheckInterval { get; set; }

        public static int TasksQueueManagerCheckInterval { get; set; }
        public static int ActiveTasksCount { get; set; }


        static Configuration()
        {
            TasksCalculationTimeout = 3600000; //1h
            CalculatedTasksTimeout = 1800000; //0.5h

            TasksCalculationTimeoutCheckInterval = 900000; //15min
            CalculatedTasksTimeoutCheckInterval = 900000; //15min

            TasksQueueManagerCheckInterval = 1000;
            ActiveTasksCount = 5;
        }
    }
}
