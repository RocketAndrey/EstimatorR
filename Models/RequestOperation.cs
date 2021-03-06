﻿namespace Estimator.Models
{
    /// <summary>
    /// Описсывает операциию в заявке (делать или не делать и сколько раз)
    /// </summary>
    public class RequestOperation
    {
        public int RequestOperationID { get; set; }
        public int RequestElementTypeID { get; set; }
        /// <summary>
        /// Заявка
        /// </summary>
        public RequestElementType RequestElementType { get; set; }

        public int? TestChainItemID { get; set; }
        /// <summary>
        /// Операция программы
        /// </summary>
        public TestChainItem TestChainItem { get; set; }
        /// <summary>
        /// Надо делать или не надо
        /// </summary>
        public bool IsExecute { get; set; }
        /// <summary>
        /// Сколько раз делать, например 2 давления
        /// </summary>
        public int ExecuteCount { get; set; }
        /// <summary>
        /// Выборка для испытаний , -1 - 100%, 0- не используется
        /// </summary>
        public int SampleCount { get; set; }
    }
}
